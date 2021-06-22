using CefSharp;
using CefSharp.WinForms;
using Rebex.Security.Cryptography;
using System;
using System.Data;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TS3VersionChecker;

namespace TS3VersionChecker
{
    public partial class VersionList : Form
    {

        const int WM_NCPAINT = 0x85;

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr GetWindowDC(IntPtr hwnd);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern int ReleaseDC(IntPtr hwnd, IntPtr hdc);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern void DisableProcessWindowsGhosting();

        [DllImport("UxTheme.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr SetWindowTheme(IntPtr hwnd, string pszSubAppName, string pszSubIdList);


        private static readonly byte[] publicKey = Convert.FromBase64String("UrN1jX0dBE1vulTNLCoYwrVpfITyo+NBuq/twbf9hLw=");

        public CustomContextHandler cmhandler = new CustomContextHandler();
        internal ChromiumWebBrowser chromeBrowser;


        public VersionList()
        {
            StaticUtils.UseImmersiveDarkMode(this.Handle, true);
            InitializeComponent();
            InitializeChromium();
            chromeBrowser.JavascriptObjectRepository.ResolveObject += (sender, e) =>
            {
                var repo = e.ObjectRepository;
                if (e.ObjectName == "verList")
                {
                    repo.Register("verList", new VerListTable(this), isAsync: true);
                }
                if (e.ObjectName == "conMenu")
                {
                    repo.Register("conMenu", new ContextMenuObject(this), isAsync: true);
                }
            };
        }

        public void InitializeChromium()
        {
            String page = string.Format(@"{0}\html-resources\version.html", Application.StartupPath);
            chromeBrowser = new ChromiumWebBrowser(page);
            chromeBrowser.MenuHandler = cmhandler;
            this.Controls.Add(chromeBrowser);
            chromeBrowser.Dock = DockStyle.Fill;
        }

        private void VersionList_Load(object sender, EventArgs e)
        {
            Version version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            DateTime buildDate = new DateTime(2000, 1, 1)
                                    .AddDays(version.Build).AddSeconds(version.Revision * 2);
            string displayableVersion = $"{version} ({buildDate})";

            this.Text = this.Text + " " + displayableVersion;
        }

        internal string DownloadCSVFromGithub(string link)
        {
            HttpWebRequest request = HttpWebRequest.CreateHttp(link);
            request.UserAgent = "Mozilla/5.0";
            WebResponse response = request.GetResponse();
            using (Stream s = response.GetResponseStream())
            {
                using(StreamReader sr = new StreamReader(s))
                {
                    string[] tmp_headers = sr.ReadLine().Split(',');
                    string[] headers = AddToStringArray(tmp_headers, "Valid");
                    DataTable dt = new DataTable();
                    foreach (string header in headers)
                    {
                        dt.Columns.Add(header);
                    }
                    while (!sr.EndOfStream)
                    {
                        string[] tmp_rows = Regex.Split(sr.ReadLine(), ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");
                        string[] rows = AddToStringArray(tmp_rows, "{nottestedyet}");
                        DataRow dr = dt.NewRow();
                        for (int i = 0; i < headers.Length; i++)
                        {
                            dr[i] = rows[i];
                        }

                        dr["Valid"] = ValidateVersion(dr);

                        dt.Rows.Add(dr);
                    }
                    sr.Close();

                    StringBuilder sb = new StringBuilder();
                    StringWriter sw = new StringWriter(sb);
                    //headers    
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        sw.Write(dt.Columns[i]);
                        if (i < dt.Columns.Count - 1)
                        {
                            sw.Write(",");
                        }
                    }
                    sw.Write(sw.NewLine);
                    foreach (DataRow dr in dt.Rows)
                    {
                        for (int i = 0; i < dt.Columns.Count; i++)
                        {
                            if (!Convert.IsDBNull(dr[i]))
                            {
                                string value = dr[i].ToString();
                                if (value.Contains(','))
                                {
                                    value = String.Format("\"{0}\"", value);
                                    sw.Write(value);
                                }
                                else
                                {
                                    sw.Write(dr[i].ToString());
                                }
                            }
                            if (i < dt.Columns.Count - 1)
                            {
                                sw.Write(",");
                            }
                        }
                        sw.Write(sw.NewLine);
                    }
                    sw.Close();
                    return sb.ToString();
                }
            }
        }

        private void DgvVersions_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                chromeBrowser.Refresh();
            }
        }

        private char ValidateVersion(DataRow input)
        {
            string[] inputValues = new string[input.ItemArray.Length];
            Array.Copy(input.ItemArray, inputValues, input.ItemArray.Length);
            
            string name = inputValues[0], platform = inputValues[1], sign = inputValues[2];

            var ver = Encoding.ASCII.GetBytes(platform + name);
            Ed25519 ed = new Ed25519();
            ed.FromPublicKey(publicKey);
            if (!ed.VerifyMessage(ver, Convert.FromBase64String(sign)))
            {
                return '\u2718';
            }

            return '\u2714';
        }

    private string[] AddToStringArray(string[] input, string strToAdd)
        {
            string[] output = new string[input.Length + 1];
            for (int i = 0; i < input.Length; i++)
            {
                output[i] = input[i];
            }
            output[input.Length] = strToAdd;

            return output;
        }

        private void VersionList_FormClosing(object sender, FormClosingEventArgs e)
        {
            chromeBrowser.Delete();
            chromeBrowser.Dispose();
        }
    }
}


public class VerListTable
{

    VersionList form;
    public VerListTable(VersionList formRef)
    {
        form = formRef;
    }

    public string getdata()
    {
        string data;
        try
        {
            data = form.DownloadCSVFromGithub(Form1.verGitLink);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
            data = "version,platform,hash,Valid \n0.0.0 [Build: 0000000000],Unknown,00000000000000000000000000000000000000000000000000000000000000000000000000000000000000==,\u2718 ";
        }
        return data;
    }
}
