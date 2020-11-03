using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TS3VersionChecker
{
    public class JSVerList
    {

        Form form;
        public JSVerList(Form formRef)
        {
            form = formRef;
        }

        public void openform()
        {
            form.Invoke((MethodInvoker)delegate
            {
                VersionList vl = new VersionList();
                vl.Show();
            });
        }
    }
}
