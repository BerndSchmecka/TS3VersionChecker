using System;
using System.Windows.Forms;

namespace TS3VersionChecker
{
    public partial class About : Form
    {

        string version, build;

        public About(string versionString, string versionBuild)
        {
            InitializeComponent();
            version = versionString;
            build = versionBuild;
        }

        private void SVGLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/vvvv/SVG");
        }

        private void About_Load(object sender, EventArgs e)
        {
            lblVersion.Text = version;
            lblBuild.Text = build;
            //addScrollBar();
        }

        private void CEFLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/cefsharp/CefSharp");
        }

        private void CEFredistLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/cefsharp/cef-binary");
        }

        private void NaClLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://labs.rebex.net/curves");
        }

        private void ProtoBufLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/protobuf-net/protobuf-net");
        }

        private void JsonLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.newtonsoft.com/json");
        }

        private void NancyLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://nancyfx.org");
        }

        void addScrollBar()
        {
            ScrollBar vScrollBar1 = new VScrollBar();
            vScrollBar1.Dock = DockStyle.Right;
            vScrollBar1.Scroll += (sender, e) => { libPanel.VerticalScroll.Value = vScrollBar1.Value; };
            libPanel.Controls.Add(vScrollBar1);
        }
    }
}
