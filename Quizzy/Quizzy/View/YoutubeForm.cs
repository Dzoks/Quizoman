using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizzy.View
{
    public partial class YoutubeForm : Form
    {
        private string url;
        public YoutubeForm(string youtubeLink)
        {
            this.url = Utility.getYoutubeEmbedLink(youtubeLink);
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            var embed = "<html><head>" +
                        "<meta http-equiv='X-UA-Compatible' content='IE=Edge'/>" +
                        "</head><body bgcolor='#373740'>" +
                        "<iframe width='780' height='430'  src='{0}'" +
                        " allow='autoplay; encrypted-media' allowfullscreen></iframe>" +
                        "</body></html>";
            youtubeBrowser.ScrollBarsEnabled = false;
            youtubeBrowser.DocumentText = string.Format(embed, url);
        }

        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Clicks == 1 && e.Button == MouseButtons.Left && WindowState == FormWindowState.Normal)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        //***********************************************************
        //***********************************************************
        //This gives us the ability to drag the borderless form to a new location
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private const int CS_DROPSHADOW = 0x20000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
