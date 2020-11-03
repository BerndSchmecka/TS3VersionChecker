using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TS3VersionChecker
{
    public partial class FirstRun : Form
    {

        string cpuid;

        public FirstRun(string CPUID)
        {
            InitializeComponent();
            cpuid = CPUID;
        }

        private void FirstRun_Load(object sender, EventArgs e)
        {
            tbCPUID.Text = cpuid;
        }
    }
}
