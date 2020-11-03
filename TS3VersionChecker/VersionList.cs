using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

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


        public static readonly byte[] publicKey = Convert.FromBase64String("UrN1jX0dBE1vulTNLCoYwrVpfITyo+NBuq/twbf9hLw=");


        public VersionList()
        {
            //DisableProcessWindowsGhosting();
            
            InitializeComponent();
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            //SetWindowTheme(this.Handle, "", "");
            base.OnHandleCreated(e);
        }

        private void VersionList_Load(object sender, EventArgs e)
        {
            Version version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            DateTime buildDate = new DateTime(2000, 1, 1)
                                    .AddDays(version.Build).AddSeconds(version.Revision * 2);
            string displayableVersion = $"{version} ({buildDate})";

            this.Text = this.Text + " " + displayableVersion;

            try
            {
                DataTable verListTable = DownloadCSVFromGitHub(Form1.verGitLink);
                dgvVersions.DataSource = verListTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private DataTable DownloadCSVFromGitHub(string link)
        {
            HttpWebRequest request = HttpWebRequest.CreateHttp(link);
            request.UserAgent = "Mozilla/5.0";
            WebResponse response = request.GetResponse();
            FileStream fs = File.Create(Path.GetTempPath() + "ver.csv");
            Stream s = response.GetResponseStream();
            //s.Seek(0, SeekOrigin.Begin);
            s.CopyTo(fs);
            s.Close();
            fs.Close();
            DataTable dt = ConvertCSVtoDataTable(Path.GetTempPath() + "ver.csv");
            File.Delete(Path.GetTempPath() + "ver.csv");
            return dt;
        }

        private DataTable ConvertCSVtoDataTable(string strFilePath)
        {
            StreamReader sr = new StreamReader(strFilePath);
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
            return dt;
        }

        private void DgvVersions_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                try
                {
                    DataTable verListTable = DownloadCSVFromGitHub(Form1.verGitLink);
                    dgvVersions.DataSource = verListTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private char ValidateVersion(DataRow input)
        {
            string[] inputValues = new string[input.ItemArray.Length];
            Array.Copy(input.ItemArray, inputValues, input.ItemArray.Length);
            
            string name = inputValues[0], platform = inputValues[1], sign = inputValues[2];

            var ver = Encoding.ASCII.GetBytes(platform + name);
            
            if (!Sodium.PublicKeyAuth.VerifyDetached(Convert.FromBase64String(sign), ver, publicKey))
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

        private void dgvVersions_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvVersions.Rows)
            {
                if (Convert.ToString(row.Cells["Valid"].Value) == "\u2714")
                {
                    row.Cells["Valid"].Style.BackColor = Color.Green;
                }
                else if (Convert.ToString(row.Cells["Valid"].Value) == "\u2718")
                {
                    row.Cells["Valid"].Style.BackColor = Color.Red;
                }
                else
                {
                    row.Cells["Valid"].Style.BackColor = Color.Yellow;
                }
            }
        }
    }
}
