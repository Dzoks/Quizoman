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
using Quizzy.Model;

namespace Quizzy.View
{
    public partial class AddQuestionForm : Form
    {
        private QuizzyDB database;
        public AddQuestionForm(QuizzyDB database)
        {
            this.database = database;
            InitializeComponent();
            enableButton();
        }
        private void enableButton()
        {
            btnAdd.Enabled = fldQuestion.Text.Length > 0 && fldAnswer.Text.Length > 0 && (fldYoutube.Text.Length == 0 || Utility.IsYoutubeLinkValid(fldYoutube.Text));
        }
        private void AddQuestionForm_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fldQuestion_TextChanged(object sender, EventArgs e)
        {
            enableButton();
        }

        private void fldAnswer_TextChanged(object sender, EventArgs e)
        {
            enableButton();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var question = new question
            {
                deleted = 0,
                question_text = fldQuestion.Text.Trim(),
                answer = fldAnswer.Text.Trim(),
                youtube_link = fldYoutube.Text // this needs converting
            };
            database.questions.Add(question);
            database.SaveChanges();
            Close();
        }

        private void fldYoutube_TextChanged(object sender, EventArgs e)
        {
            enableButton();
            if (fldYoutube.Text.Length > 0 && !Utility.IsYoutubeLinkValid(fldYoutube.Text))
            {
                errorPanel.BackColor = Color.Red;
            }
            else
            {
                errorPanel.BackColor = Color.Transparent;
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

        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Clicks == 1 && e.Button == MouseButtons.Left && WindowState == FormWindowState.Normal)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
