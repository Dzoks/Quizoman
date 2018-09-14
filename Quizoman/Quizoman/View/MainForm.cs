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
using Quizoman.Properties;
using Quizoman.View;

namespace Quizoman
{
    public partial class MainForm : Form
    {
       

        private Color menuBtnClickedColor = Color.FromArgb(127, 127, 127);
        private Color menuBtnColor = Color.FromArgb(33, 33, 33);
        public MainForm()
        {
              
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.FormBorderStyle = FormBorderStyle.None; // no borders
            btnTabQuiz_Click(null,null);

        }

        private void btnTabQuiz_Click(object sender, EventArgs e)
        {
            clearColors();
            btnTabQuiz.BackColor = menuBtnClickedColor;
            selectControl(new QuizzesView());
        }

        private void clearColors()
        {
            btnTabQuestion.BackColor = menuBtnColor;
            btnTabQuiz.BackColor = menuBtnColor;
            btnTabTeam.BackColor = menuBtnColor;
        }

        private void btnTabTeam_Click(object sender, EventArgs e)
        {
            clearColors();
            btnTabTeam.BackColor = menuBtnClickedColor;
            selectControl(new TeamsView());
        }

        private void btnTabQuestion_Click(object sender, EventArgs e)
        {
            clearColors();
            btnTabQuestion.BackColor = menuBtnClickedColor;
           selectControl(new QuestionsView());
        }

       

        private void selectControl(Control control)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(control);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                btnMaximize.BackgroundImage = Resources.maximized;
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                btnMaximize.BackgroundImage = Resources.maximize;
                WindowState = FormWindowState.Normal;
            }
        }

        //***********************************************************
        //This gives us the ability to resize the borderless from any borders instead of just the lower right corner
        protected override void WndProc(ref Message m)
        {
            const int wmNcHitTest = 0x84;
            const int htLeft = 10;
            const int htRight = 11;
            const int htTop = 12;
            const int htTopLeft = 13;
            const int htTopRight = 14;
            const int htBottom = 15;
            const int htBottomLeft = 16;
            const int htBottomRight = 17;
            if (m.Msg == wmNcHitTest && WindowState==FormWindowState.Normal)
            {
                int x = (int)(m.LParam.ToInt64() & 0xFFFF);
                int y = (int)((m.LParam.ToInt64() & 0xFFFF0000) >> 16);
                Point pt = PointToClient(new Point(x, y));
                Size clientSize = ClientSize;
                ///allow resize on the lower right corner
                if (pt.X >= clientSize.Width - 16 && pt.Y >= clientSize.Height - 16 && clientSize.Height >= 16)
                {
                    m.Result = (IntPtr)(IsMirrored ? htBottomLeft : htBottomRight);
                    return;
                }
                ///allow resize on the lower left corner
                if (pt.X <= 16 && pt.Y >= clientSize.Height - 16 && clientSize.Height >= 16)
                {
                    m.Result = (IntPtr)(IsMirrored ? htBottomRight : htBottomLeft);
                    return;
                }
                ///allow resize on the upper right corner
                if (pt.X <= 16 && pt.Y <= 16 && clientSize.Height >= 16)
                {
                    m.Result = (IntPtr)(IsMirrored ? htTopRight : htTopLeft);
                    return;
                }
                ///allow resize on the upper left corner
                if (pt.X >= clientSize.Width - 16 && pt.Y <= 16 && clientSize.Height >= 16)
                {
                    m.Result = (IntPtr)(IsMirrored ? htTopLeft : htTopRight);
                    return;
                }
                ///allow resize on the top border
                if (pt.Y <= 16 && clientSize.Height >= 16)
                {
                    m.Result = (IntPtr)(htTop);
                    return;
                }
                ///allow resize on the bottom border
                if (pt.Y >= clientSize.Height - 16 && clientSize.Height >= 16)
                {
                    m.Result = (IntPtr)(htBottom);
                    return;
                }
                ///allow resize on the left border
                if (pt.X <= 16 && clientSize.Height >= 16)
                {
                    m.Result = (IntPtr)(htLeft);
                    return;
                }
                ///allow resize on the right border
                if (pt.X >= clientSize.Width - 16 && clientSize.Height >= 16)
                {
                    m.Result = (IntPtr)(htRight);
                    return;
                }
            }
            base.WndProc(ref m);
        }
        //***********************************************************
        //***********************************************************
        //This gives us the ability to drag the borderless form to a new location
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void dragWindow(object sender, MouseEventArgs e)
        {
            //ctrl-leftclick anywhere on the control to drag the form to a new location 
            if (e.Clicks==1 && e.Button == MouseButtons.Left && WindowState==FormWindowState.Normal)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        //***********************************************************
        //***********************************************************
        //This gives us the drop shadow behind the borderless form
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

        private void topPanel_DoubleClick(object sender, EventArgs e)
        {
            btnMaximize_Click(null,null);
        }

      
    }
}
