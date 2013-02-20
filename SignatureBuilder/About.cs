using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignatureBuilder
{
    public partial class About : TemplateForm
    {
        public About()
        {
            InitializeComponent();
            this.title.Text = "关于我们";

        }

        void Author_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://bbs.ngacn.cc/nuke.php?func=ucp&uid=589455");
        }

        void Site_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://bbs.ngacn.cc");
        }

        void Gank_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://bbs.ngacn.cc/thread.php?fid=-152678");
        }

        void tqq_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://t.qq.com/susnow");
        }
    }
}
