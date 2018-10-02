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
    public partial class AddSeasonForm : Form
    {
        private QuizzyDB database;
        public AddSeasonForm(Model.QuizzyDB database)
        {
            this.database = database;
            InitializeComponent();
            btnAdd.Enabled = fldSeason.Text.Length > 0;

        }

        public bool Success { get; set; }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
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

        private void fldSeason_TextChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = fldSeason.Text.Length > 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (database.seasons.FirstOrDefault(s => s.deleted == 0 && s.name == fldSeason.Text) != null)
            {
                new ErrorPopup("Naziv sezone mora biti jedinstven!").ShowDialog(this);
            }
            else
            {
                Season = new season()
                {
                    name = fldSeason.Text,
                    deleted = 0
                };
                database.seasons.Add(Season);
                database.SaveChanges();
                Success = true;
                Close();
            }
           
        }

        public season Season { get; set; }
    }
}
