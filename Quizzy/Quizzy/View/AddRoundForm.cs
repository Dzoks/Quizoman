using Quizzy.Model;
using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Quizzy.View
{
    public partial class AddRoundForm : Form
    {
        private QuizzyDB database;


        public AddRoundForm(Model.QuizzyDB database)
        {
            this.database = database;
            InitializeComponent();
            comboSeason.Items.AddRange(database.seasons.Where(q=>q.deleted==0).ToArray());
            enableButton();
        }

        public bool Success { get; set; }

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboSeason_TextChanged(object sender, EventArgs e)
        {
            enableButton();
        }

        private void enableButton()
        {
            btnAdd.Enabled = comboSeason.SelectedItem != null && fldRound.Text.Length > 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var season = comboSeason.SelectedItem as season;
            if (season.rounds.FirstOrDefault(r => r.deleted == 0 && r.name == fldRound.Text) != null)
            {
                new ErrorPopup("Naziv kviza mora biti jedinstven").ShowDialog(this);
            }
            else
            {
                season.rounds.Add(new round()
                {
                    name = fldRound.Text,
                    deleted = 0,
                });
                database.SaveChanges();
                Success = true;
                Close();
            }
        }
    }
}
