using CefSharp;
using CefSharp.WinForms;
using Nancy.Json;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace TS3VersionChecker
{
    public partial class Form1 : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
        int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public string[] Gguid;
        public string[] Gname;
        public string[] Gurl;
        public string[] Gdesc;

        public const string verLink = "http://versions.teamspeak.com/ts3-client-2";
        public const string badgeLink = "https://badges-content.teamspeak.com/list";
        public const string ua = "teamspeak.downloader/1.0";
        public const string key = "Basic dGVhbXNwZWFrNTpMRlo2Wl5rdkdyblh+YW4sJEwjNGd4TDMnYTcvYVtbJl83PmF0fUEzQVJSR1k=\r\n";
        public const string verGitLink = "https://raw.githubusercontent.com/ReSpeak/tsdeclarations/master/Versions.csv";

        public CustomContextHandler cmhandler = new CustomContextHandler();

        internal ChromiumWebBrowser chromeBrowser;

        public Form1()
        {
            InitializeComponent();

            if(DateTime.Now.Day==1&&DateTime.Now.Month==4){this.RightToLeft=RightToLeft.Yes;this.RightToLeftLayout=true;}

            StaticUtils.UseImmersiveDarkMode(this.Handle, true);

            InitializeChromium();

            chromeBrowser.JavascriptObjectRepository.ResolveObject += (sender, e) =>
            {
                var repo = e.ObjectRepository;
                if (e.ObjectName == "versionListObj")
                {
                    repo.Register("versionListObj", new JSVerList(this), isAsync: true);
                }
                if (e.ObjectName == "requestBtnObj")
                {
                    repo.Register("requestBtnObj", new JSInteraction(this), isAsync: true);
                }
                if (e.ObjectName == "feedbackBtnObj")
                {
                    repo.Register("feedbackBtnObj", new FeedbackInteraction(this), isAsync: true);
                }
                if (e.ObjectName == "nickResolveObj")
                {
                    repo.Register("nickResolveObj", new NickResolver(this), isAsync: true);
                }
                if (e.ObjectName == "matrixResolveObj")
                {
                    repo.Register("matrixResolveObj", new MatrixResolver(this), isAsync: true);
                }
                if (e.ObjectName == "contextMenuObj")
                {
                    repo.Register("contextMenuObj", new ContextMenuObject(this), isAsync: true);
                }
            };
        }

        public void InitializeChromium()
        {
            String page = string.Format(@"{0}\html-resources\dashboard.html", Application.StartupPath);
            CefSettings settings = new CefSettings();
            Cef.Initialize(settings);
            chromeBrowser = new ChromiumWebBrowser(page);
            chromeBrowser.MenuHandler = cmhandler;
            this.Controls.Add(chromeBrowser);
            chromeBrowser.Dock = DockStyle.Fill;
        }

        public string dispVer1 = "N/A";
        public string dispVer2 = "N/A";

        private void Form1_Load(object sender, EventArgs e)
        {
            Version version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            DateTime buildDate = new DateTime(2000, 1, 1)
                                    .AddDays(version.Build).AddSeconds(version.Revision * 2);
            Int64 buildNumber = (Int64)(buildDate.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            string buildName = "2.0.0-exp.6";
            string displayableVersion = buildName + " [Build: " + buildNumber + "]";
            string displayableVersion2 = $"{version} ({buildDate})";

            dispVer1 = displayableVersion;
            dispVer2 = displayableVersion2;

            this.Text = this.Text + " " + displayableVersion;

            tsslblVersionAddress.Text = verLink;
            tsslblBadgeAddress.Text = badgeLink;
            tsslblGitAddress.Text = verGitLink;

            if (!CultureInfo.InstalledUICulture.Name.Contains("DE"))
            {
                vtsslblGitAddress.Text = "Version List:";
            }
        }

        public static string TranslatedLocalDayOfWeek(DateTime input)
        {
            string englishDayOfWeek = input.ToLocalTime().DayOfWeek.ToString();
            string germanDayOfWeek = "";
            switch (englishDayOfWeek)
            {
                case "Monday":
                    germanDayOfWeek = "Montag";
                    break;
                case "Tuesday":
                    germanDayOfWeek = "Dienstag";
                    break;
                case "Wednesday":
                    germanDayOfWeek = "Mittwoch";
                    break;
                case "Thursday":
                    germanDayOfWeek = "Donnerstag";
                    break;
                case "Friday":
                    germanDayOfWeek = "Freitag";
                    break;
                case "Saturday":
                    germanDayOfWeek = "Samstag";
                    break;
                case "Sunday":
                    germanDayOfWeek = "Sonntag";
                    break;
                default:
                    germanDayOfWeek = "ErrorYouShouldNotSeeThisPleaseReport";
                    break;
            }

            if (!CultureInfo.InstalledUICulture.Name.Contains("DE"))
            {
                return englishDayOfWeek;
            }

            return germanDayOfWeek;
        }

        private void ToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TsslblVersionAddress_Click(object sender, EventArgs e)
        {
            if (!tsslblVersionAddress.Text.Equals("N/A"))
            {
                System.Diagnostics.Process.Start(tsslblVersionAddress.Text);
            }
        }

        private void TsslblBadgeAddress_Click(object sender, EventArgs e)
        {
            if (!tsslblBadgeAddress.Text.Equals("N/A"))
            {
                System.Diagnostics.Process.Start(tsslblBadgeAddress.Text);
            }
        }

        private void TsslblGitAddress_Click(object sender, EventArgs e)
        {
            if (!tsslblGitAddress.Text.Equals("N/A"))
            {
                System.Diagnostics.Process.Start(tsslblGitAddress.Text);
            }
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            About ab = new About(dispVer1, dispVer2);
            ab.Show();
        }

        public static string getIPfromNickname(string nickname)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://named.myteamspeak.com/lookup?name=" + nickname);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }

        public static string getMatrixIDfromUsertag(string usertag)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://35.195.56.213:8008/lookup");
            request.Method = "POST";
            request.ContentType = "application/json";

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                string json = "{\"tsChatId\":\"" + usertag + "\"}";

                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)request.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();

                dynamic de_ser_obj = JsonConvert.DeserializeObject(result);

                return de_ser_obj.matrixId;
            }
        }
    }

    public class JSInteraction
    {
        Form1 form;
        public JSInteraction(Form1 formRef)
        {
            form = formRef;
        }

        string[] alpha, beta, server, stable; string udbhttp, udblocal, udbunix, nowhttp, nowlocal, nowunix;
        public void uvd3()
        {
            HttpWebRequest webRequest = HttpWebRequest.CreateHttp(Form1.verLink);

            webRequest.UserAgent = "Mozilla/5.0";

            using (HttpWebResponse webResponse = (HttpWebResponse)webRequest.GetResponse())
            {

                VersionMessage version = ProtoBuf.Serializer.Deserialize<VersionMessage>(webResponse.GetResponseStream());
                VersionData[] v = version.SubElement;

                foreach(VersionData vers in v)
                {
                    if(vers.Channel == "server")
                    {
                        server = new string[]{ (vers.Version + " (" + UnixToLocalTime(vers.Timestamp) + ")"), (vers.Version + " [Build: " + vers.Timestamp + "]")};
                    }
                    else if (vers.Channel == "stable")
                    {
                        stable = new string[] { (vers.Version + " (" + UnixToLocalTime(vers.Timestamp) + ")"), (vers.Version + " [Build: " + vers.Timestamp + "]") };
                    }
                    else if (vers.Channel == "beta")
                    {
                        beta = new string[] { (vers.Version + " (" + UnixToLocalTime(vers.Timestamp) + ")"), (vers.Version + " [Build: " + vers.Timestamp + "]") };
                    }
                    else if (vers.Channel == "alpha")
                    {
                        alpha = new string[] { (vers.Version + " (" + UnixToLocalTime(vers.Timestamp) + ")"), (vers.Version + " [Build: " + vers.Timestamp + "]") };
                    }
                }

                DateTime lastModified = DateTime.ParseExact(webResponse.GetResponseHeader("Last-Modified"), "r", null);
                DateTime currDate = DateTime.ParseExact(webResponse.GetResponseHeader("Date"), "r", null);
                Int32 lastUNIX = (Int32)(lastModified.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
                Int32 currUNIX = (Int32)(currDate.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;

                TimeZoneInfo localZone = TimeZoneInfo.Local;

                //lblAvailVers.Text = getStatusCode(webResponse);

                nowhttp = webResponse.GetResponseHeader("Date");
                nowlocal = Form1.TranslatedLocalDayOfWeek(currDate) + ", " + currDate.ToLocalTime().ToString() + " " + (localZone.IsDaylightSavingTime(currDate) ? localZone.DaylightName : localZone.StandardName);
                nowunix = currUNIX.ToString();

                udbhttp = webResponse.GetResponseHeader("Last-Modified");
                udblocal = Form1.TranslatedLocalDayOfWeek(lastModified) + ", " + lastModified.ToLocalTime().ToString() + " " + (localZone.IsDaylightSavingTime(lastModified) ? localZone.DaylightName : localZone.StandardName);
                udbunix = lastUNIX.ToString();
            }
        }

        public string UnixToLocalTime(long input)
        {
            DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, System.DateTimeKind.Utc);
            string output = epoch.AddSeconds(input).ToLocalTime().ToString();
            return output;
        }

        string fiveunix, fiveversion, udbfhttp, udbflocal, udbfunix;
        public void uvd5()
        {

            HttpWebRequest request = HttpWebRequest.CreateHttp("http://update.teamspeak.com/windows/x64/latest/info.json");
            request.Method = "GET";
            request.UserAgent = Form1.ua;
            request.Headers.Add("Authorization", Form1.key);
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                String responseString = reader.ReadToEnd();

                DateTime last5Modified = DateTime.ParseExact(response.GetResponseHeader("Last-Modified"), "r", null);
                Int32 last5UNIX = (Int32)(last5Modified.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;

                TimeZoneInfo localZone = TimeZoneInfo.Local;

                udbfhttp = response.GetResponseHeader("Last-Modified");
                udbflocal = Form1.TranslatedLocalDayOfWeek(last5Modified) + ", " + last5Modified.ToLocalTime().ToString() + " " + (localZone.IsDaylightSavingTime(last5Modified) ? localZone.DaylightName : localZone.StandardName);
                udbfunix = last5UNIX.ToString();

                JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
                dynamic dobj = jsonSerializer.Deserialize<dynamic>(responseString);

                string jtimestamp = dobj["timestamp"].ToString();
                string jversion = dobj["version"].ToString();

                fiveversion = jversion;
                fiveunix = jtimestamp;
            }
        }

        string bdbhttp, bdblocal, bdbunix;
        BadgeData[] badgedata;
        long badge_timestamp;
        public void ubd()
        {
            HttpWebRequest webRequest = HttpWebRequest.CreateHttp(Form1.badgeLink);

            webRequest.UserAgent = "Mozilla/5.0";

            using (HttpWebResponse webResponse = (HttpWebResponse)webRequest.GetResponse())
            {


                BadgeMessage badge = ProtoBuf.Serializer.Deserialize<BadgeMessage>(webResponse.GetResponseStream());
                badge_timestamp = badge.Timestamp;
                badgedata = badge.SubElement;

                DateTime lastBModified = DateTime.ParseExact(webResponse.GetResponseHeader("Last-Modified"), "r", null);
                Int32 badgeUNIX = (Int32)(lastBModified.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;

                TimeZoneInfo localZone = TimeZoneInfo.Local;

                bdbhttp = webResponse.GetResponseHeader("Last-Modified");
                bdblocal = Form1.TranslatedLocalDayOfWeek(lastBModified) + ", " + lastBModified.ToLocalTime().ToString() + " " + (localZone.IsDaylightSavingTime(lastBModified) ? localZone.DaylightName : localZone.StandardName);
                bdbunix = badgeUNIX.ToString();
            }
        }

        public long getbadgetimestamp()
        {
            return badge_timestamp;
        }
        public BadgeData[] getbadgedata()
        {
            return badgedata;
        }
        public string[] getalpha()
        {
            return alpha;
        }
        public string[] getbeta()
        {
            return beta;
        }
        public string[] getserver()
        {
            return server;
        }
        public string[] getstable()
        {
            return stable;
        }
        public string getfversion()
        {
            return fiveversion;
        }
        public string getfunix()
        {
            return fiveunix;
        }
        public string getudbhttp()
        {
            return udbhttp;
        }
        public string getudblocal()
        {
            return udblocal;
        }
        public string getudbunix()
        {
            return udbunix;
        }
        public string getnowhttp()
        {
            return nowhttp;
        }
        public string getnowlocal()
        {
            return nowlocal;
        }
        public string getnowunix()
        {
            return nowunix;
        }
        public string getudbfhttp()
        {
            return udbfhttp;
        }
        public string getudbflocal()
        {
            return udbflocal;
        }
        public string getudbfunix()
        {
            return udbfunix;
        }

        public void requestsrv()
        {

                form.Invoke((MethodInvoker)delegate
                {
                    try
                    {
                        uvd3();
                        uvd5();
                        ubd();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace);
                    }
                });
        }

        public string getbdbhttp()
        {
            return bdbhttp;
        }
        public string getbdblocal()
        {
            return bdblocal;
        }
        public string getbdbunix()
        {
            return bdbunix;
        }
    }

    public class FeedbackInteraction
    {

        Form1 form;
        public FeedbackInteraction(Form1 formRef)
        {
            form = formRef;
        }

        public void openform()
        {
            form.Invoke((MethodInvoker)delegate
            {
                Process.Start("mailto:business@dunkelmann.eu");
            });
        }
    }

    public class NickResolver
    {
        Form1 form;
        public NickResolver(Form1 formRef)
        {
            form = formRef;
        }

        public string resolvenick(string ntext)
        {
            try
            {
                return Form1.getIPfromNickname(ntext);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ein Fehler ist aufgetreten!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }
    }

    public class MatrixResolver
    {
        Form1 form;
        public MatrixResolver(Form1 formRef)
        {
            form = formRef;
        }

        public string resolvematrix(string mtext)
        {
            try
            {
                return Form1.getMatrixIDfromUsertag(mtext);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ein Fehler ist aufgetreten!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }
    }

    public class ContextMenuObject
    {

        private ChromiumWebBrowser cwb;
        public ContextMenuObject(Form1 formRef)
        {
            this.cwb = formRef.chromeBrowser;
        }

        public ContextMenuObject(VersionList formRef)
        {
            this.cwb = formRef.chromeBrowser;
        }

        public void handlecontextmenu(string id)
        {
            if (id.Equals("cut"))
            {
                cwb.Cut();
            }
            if (id.Equals("copy"))
            {
                cwb.Copy();
            }
            if (id.Equals("paste"))
            {
                cwb.Paste();
            }
            if (id.Equals("select_all"))
            {
                cwb.SelectAll();
            }
        }
    }

    public class CustomContextHandler : IContextMenuHandler
    {
        public void OnBeforeContextMenu(IWebBrowser browserControl, CefSharp.IBrowser browser, IFrame frame, IContextMenuParams parameters,
            IMenuModel model)
        {
            model.Clear();
            model.AddItem(CefMenuCommand.Cut, "Ausschneiden");
            model.AddItem(CefMenuCommand.Copy, "Kopieren");
            model.AddItem(CefMenuCommand.Paste, "Einfügen");
            model.AddItem(CefMenuCommand.SelectAll, "Alles Auswählen");
            model.SetEnabledAt(0, !string.IsNullOrWhiteSpace(parameters.SelectionText));
        }

        public bool OnContextMenuCommand(IWebBrowser browserControl, CefSharp.IBrowser browser, IFrame frame, IContextMenuParams parameters,
            CefMenuCommand commandId, CefEventFlags eventFlags)
        {
            return false;
        }

        public void OnContextMenuDismissed(IWebBrowser browserControl, CefSharp.IBrowser browser, IFrame frame)
        {
        }

        public bool RunContextMenu(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IContextMenuParams parameters, IMenuModel model, IRunContextMenuCallback callback)
        {
            return false;
        }
    }

}
