using Quizzy.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizzy.View
{
    public partial class TeamsForm : Form
    {
        private bool success;
        private round round;
        private QuizzyDB database;
        public TeamsForm(round round,QuizzyDB database)
        {
            this.database = database;
            this.round = round;
            InitializeComponent();
            var autocompleteCollection=new AutoCompleteStringCollection();
            var roundTeams = database.team_round
                .Where(t => t.round_id == round.id && t.deleted == 0).Select(r => r.team).ToList();
            var allTeams = database.teams.Where(t => t.deleted == 0).ToList();
            var availableTeamsString= allTeams.Except(roundTeams).Select(t=>t.name).ToList();
            autocompleteCollection.AddRange(availableTeamsString.ToArray());
            fldTeam.AutoCompleteSource = AutoCompleteSource.CustomSource;
            fldTeam.AutoCompleteCustomSource = autocompleteCollection;
            fldTeam.AutoCompleteMode = AutoCompleteMode.Append;
            btnAddQuestion.Enabled = false;
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

        public bool Success { get => success; set => success = value; }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            team newTeam=database.teams.FirstOrDefault(r => r.name == fldTeam.Text);
            if (newTeam != null &&
                database.team_round.FirstOrDefault(t =>
                    t.round_id == round.id && t.deleted == 0 && t.team_id == newTeam.id) != null)
            {
                //TODO error
                new ErrorPopup("Tim već postoji").ShowDialog(this);
                return;
            }else if (newTeam == null)
            {
                newTeam=new team()
                {
                    name = fldTeam.Text,
                    deleted = 0,
                };
            }

            database.team_round.Add(new team_round()
            {
                round = round,
                total = 0,
                team = newTeam
            });

            if (database.season_has_team.FirstOrDefault(r =>
                    r.team_id == newTeam.id && r.deleted == 0 && r.season_id == round.season_id) == null)
            {
                database.season_has_team.Add(new season_has_team()
                {
                    season_id = round.season_id,
                    team_id = newTeam.id,
                    deleted = 0
                });
            }

            database.SaveChanges();
            success = true;
            Close();
        }

        private void fldTeam_TextChanged(object sender, EventArgs e)
        {
            btnAddQuestion.Enabled = fldTeam.Text.Length > 0;
        }
    }
}
