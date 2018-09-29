using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quizzy.Model;
using Quizzy.Properties;
using Quizzy.View;

namespace Quizzy
{
    public partial class MainForm : Form
    {
        private QuizzyDB database;

        public static Color ButtonColor = Color.FromArgb(54, 54, 64);
        public static  Color BackgroundColor=Color.FromArgb(50,51,61);
        public static Color PrimaryColor = Color.FromArgb(55, 55, 64);
        public static Color TreeNodeColor = Color.FromArgb(51,51,61);
        public static Color TreeNodeColorSub = Color.FromArgb(53, 53, 63);
        public static Color SelectedColor = Color.FromArgb(38, 40, 47);
        public static Color TableColor = Color.FromArgb(57, 57, 67);
        private season selectedSeason;
        private round selectedRound;
        private object oldValue;

        public MainForm()
        {
            database = new QuizzyDB();

            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            btnQuiz.BackColor = BackgroundColor;
            btnQuestion.BackColor = PrimaryColor;
            questionsView.Hide();

            loadMainForm();

           
        }

        private void loadMainForm()
        {

            seasonTreeView.Nodes.Clear();
            foreach (var season in database.seasons.Include("rounds"))
            {
                TreeNode node = new TreeNode()
                {
                    Text = season.name,
                    Name = season.name,
                    Tag = season
                };
                foreach (var round in season.rounds)
                {
                    node.Nodes.Add(new TreeNode()
                    {
                        Text = round.name,
                        Name = round.name,
                        Tag = round
                    });
                }
                seasonTreeView.Nodes.Add(node);
            }

            btnTeams.Hide();
            btnAddTeam.Parent = dtTeams;
            btnQuestions.Hide();
            btnAddQuestion.Parent = dtQuestions;
            dtSeasonTeams.Hide();
            dtTeams.Hide();
            lblPlaces.Hide();

            dtQuestions.Hide();
        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
            if (m.Msg == wmNcHitTest && WindowState == FormWindowState.Normal)
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

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                btnMaximize.Image = Resources.maximized;
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                btnMaximize.Image = Resources.maximize;
                WindowState = FormWindowState.Normal;
            }
        }

        private void topPanel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnMaximize_Click(null,null);
        }

        private void btnTeams_Click(object sender, EventArgs e)
        {
            btnTeams.BackColor = TableColor;
            btnQuestions.BackColor = ButtonColor;
            dtQuestions.Hide();
            dtTeams.Show();
            dtTeams.DataSource = database.team_round.Where(r => r.deleted == 0 && r.round_id == selectedRound.id)
                .OrderByDescending(r => r.total).ToList();
        }

        private void btnQuestions_Click(object sender, EventArgs e)
        {
            btnQuestions.BackColor = TableColor;
            btnTeams.BackColor = ButtonColor;
            dtTeams.Hide();
            dtQuestions.Show();
            btnAddQuestion.Show();
            dtQuestions.DataSource = database.round_question
                    .Where(q => q.round_id == selectedRound.id && q.deleted == 0).Include("question").OrderBy(q => q.question_number).ToList(); ;
            dtQuestions.ClearSelection();
        }

        private void seasonTreeView_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            Rectangle nodeRect = e.Node.Bounds;
            /*--------- 1. draw expand/collapse icon ---------*/
            Point ptExpand = new Point(nodeRect.Location.X - 20, nodeRect.Location.Y + 2);
            Rectangle b = e.Node.Bounds;
            b.X -= 20;
            b.Width = seasonTreeView.Width;
            if ((e.State & TreeNodeStates.Focused) != 0)
            {
                if (e.Node.Level == 1)
                {
                    b.X -= 20;
                    b.Width += 20;
                    e.Graphics.FillRectangle(new SolidBrush(SelectedColor), b);

                }
                else
                {
                    e.Graphics.FillRectangle(new SolidBrush(SelectedColor), b);

                }

            }
            else
            {
                if (e.Node.Level == 1)
                {

                    b.X -= 20;
                    b.Width += 20;
                    e.Graphics.FillRectangle(new SolidBrush(TreeNodeColorSub), b);

                }
                else
                {
                    e.Graphics.FillRectangle(new SolidBrush(TreeNodeColor), b);

                }

            }

            bool selected = e.Node == seasonTreeView.SelectedNode;
            Image expandImg = null;
            if (e.Node.Parent == null && e.Node.Nodes.Count > 0)
            {
                if (e.Node.IsExpanded || e.Node.Nodes.Count < 1)
                {
                    if (selected)
                    {
                        expandImg = Resources.minus_fade;
                    }
                    else
                    {
                        expandImg = Resources.minus;
                    }
                }
                else
                {
                    if (selected)
                    {
                        expandImg = Resources.plus_fade;
                    }
                    else
                    {
                        expandImg = Resources.plus;
                    }
                }
                Graphics g = Graphics.FromImage(expandImg);
                IntPtr imgPtr = g.GetHdc();
                g.ReleaseHdc();
                e.Graphics.DrawImage(expandImg, ptExpand);
            }


            /*--------- 3. draw node text ---------*/
            Font nodeFont = e.Node.NodeFont;
            if (nodeFont == null)
                nodeFont = ((TreeView)sender).Font;
            Brush textBrush = new SolidBrush(Color.White);
            //to highlight the text when selected
            if ((e.State & TreeNodeStates.Focused) != 0)
            {

                textBrush = new SolidBrush(Color.WhiteSmoke);
            }

            //Inflate to not be cut
            Rectangle textRect = nodeRect;
            textRect.Width = seasonTreeView.Width;
            //need to extend node rect
            //textRect.Width += 40;
            e.Graphics.DrawString(e.Node.Text, nodeFont, textBrush, Rectangle.Inflate(textRect, -12, 0));
        }

        private void seasonTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            seasonTreeView.SelectedNode = e.Node;

            if (e.X <= 20)
                return;
            if (e.Node.IsExpanded)
            {
                e.Node.Collapse();
            }
            else
            {
                e.Node.Expand();
            }

            if (e.Node.Level == 1)
            {
                selectedRound=e.Node.Tag as round;
                lblPlaces.Hide();
                ShowRound();
            }
            else
            {
                selectedSeason=e.Node.Tag as season;
                lblPlaces.Show();
                ShowSeason();
            }
        }

        private void ShowRound()
        {
            dtSeasonTeams.Hide();
            btnTeams.Show();
            btnQuestions.Show();
            btnTeams_Click(null,null);
        }

        private void ShowSeason()
        {
            btnTeams.Hide();
            btnQuestions.Hide();
            dtQuestions.Hide();
            dtTeams.Hide();
            dtSeasonTeams.Show();
            selectedRound = null;
            dtSeasonTeams.DataSource = database.season_has_team.Where(s => s.season.id == selectedSeason.id && s.deleted == 0)
                .OrderByDescending(t => t.total).ToList();
        }

        #region dtTeams

        private void dtTeams_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < dtTeams.RowCount; i++)
            {
                dtTeams.Rows[i].Cells[0].Value = i + 1;
                dtTeams.Rows[i].Cells["TeamDeleteCln"].Value = Resources.remove;
            }
        }

        private void dtSeasonTeams_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < dtSeasonTeams.RowCount; i++)
            {
                dtSeasonTeams.Rows[i].Cells[0].Value = i + 1;
            }
        }

        #endregion

        #region dtQuestions

        private void dtQuestions_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dtQuestions.Rows)
            {
                var rowQuestion = (row.DataBoundItem as round_question)?.question;
                if (rowQuestion != null)
                {
                    row.Cells["AnswerCln"].Value = rowQuestion?.answer;
                    if (String.IsNullOrEmpty(rowQuestion.youtube_link))
                    {
                        row.Cells["YoutubeCln"].Value = Resources.empty;
                    }
                    else
                    {
                        row.Cells["YoutubeCln"].Value = Resources.play;
                    }

                    row.Cells["DeleteCln"].Value = Resources.remove;
                }
                
            }
        }

        private void dtQuestions_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == YoutubeClnIndex && e.RowIndex >= 0)
            {
                var roundQuestion = dtQuestions.Rows[e.RowIndex].DataBoundItem as round_question;
                if (!String.IsNullOrEmpty(roundQuestion.question.youtube_link))
                {
                    dtQuestions.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Resources.play_red;
                }
            }
            else if (e.ColumnIndex == DeleteQuestionClnIndex && e.RowIndex >= 0)
            {
                dtQuestions.Rows[e.RowIndex].Cells["DeleteCln"].Value = Resources.remove_fade;
            }
        }

        private void dtQuestions_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == YoutubeClnIndex && e.RowIndex>=0)
            {
                var roundQuestion =dtQuestions.Rows[e.RowIndex].DataBoundItem as round_question;
                if (!String.IsNullOrEmpty(roundQuestion.question.youtube_link))
                {
                    dtQuestions.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Resources.play;
                }
            }
            else if (e.ColumnIndex == DeleteQuestionClnIndex && e.RowIndex >= 0)
            {
                dtQuestions.Rows[e.RowIndex].Cells["DeleteCln"].Value = Resources.remove;
            }
        }

        private const int YoutubeClnIndex = 5;
        private const int DeleteQuestionClnIndex = 6;
        private const int UpClnIndex = 0;
        private const int DownClnIndex = 2;

        private void dtQuestions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == YoutubeClnIndex)
            {
                var roundQuestion = dtQuestions.Rows[e.RowIndex].DataBoundItem as round_question;
                if (!String.IsNullOrEmpty(roundQuestion.question.youtube_link))
                {
                    var form = new YoutubeForm(roundQuestion.question.youtube_link);
                    form.ShowDialog(this);
                }
            }else if (e.ColumnIndex == DeleteQuestionClnIndex)
            {
                var dialog=new AreYouSurePopup("Da li ste sigurni da želite da obrišete pitanje?");
                dialog.ShowDialog(this);
                if (dialog.Success)
                {
                    var roundQuestion = dtQuestions.Rows[e.RowIndex].DataBoundItem as round_question;
                    roundQuestion.deleted = 1;
                    foreach (DataGridViewRow row in dtQuestions.Rows)
                    {
                        var question=row.DataBoundItem as round_question;
                        if (question.question_number > roundQuestion.question_number)
                        {
                            question.question_number--;
                        }
                    }
                    database.SaveChanges();
                    btnQuestions_Click(null, null);
                }
               
            }else if (e.ColumnIndex == UpClnIndex && e.RowIndex>0)
            {
                var roundQuestion = dtQuestions.Rows[e.RowIndex].DataBoundItem as round_question;
                var nextQuestion = dtQuestions.Rows[e.RowIndex - 1].DataBoundItem as round_question;
                var oldNumber = roundQuestion.question_number;
                roundQuestion.question_number = nextQuestion.question_number;
                nextQuestion.question_number = oldNumber;
                database.SaveChanges();
                btnQuestions_Click(null, null);
                                dtQuestions.Rows[e.RowIndex - 1].Selected = true;

            }
            else if (e.ColumnIndex == DownClnIndex && e.RowIndex+1<dtQuestions.RowCount)
            {
                var roundQuestion = dtQuestions.Rows[e.RowIndex].DataBoundItem as round_question;
                var nextQuestion = dtQuestions.Rows[e.RowIndex+1].DataBoundItem as round_question;
                var oldNumber=roundQuestion.question_number;
                roundQuestion.question_number = nextQuestion.question_number;
                nextQuestion.question_number = oldNumber;
                database.SaveChanges();
                btnQuestions_Click(null,null);
                dtQuestions.Rows[e.RowIndex + 1].Selected = true;
            }
        }

        #endregion

        #region btnAddTeam

        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            var form = new TeamsForm(selectedRound, database);
            form.ShowDialog(this);
            if (form.Success)
            {
                btnTeams_Click(null, null);
            }


        }

        private void btnAddTeam_MouseLeave(object sender, EventArgs e)
        {
            btnAddTeam.Image = Resources.add;
        }


        private void btnAddTeam_MouseEnter(object sender, EventArgs e)
        {
            btnAddTeam.Image = Resources.add_fade;

        }

        #endregion

        #region btnAddQuestion

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            var form = new QuestionsForm(database, selectedRound);
            form.ShowDialog(this);
            btnQuestions_Click(null,null);
        }

        private void btnAddQuestion_MouseLeave(object sender, EventArgs e)
        {
            btnAddQuestion.Image = Resources.add;

        }

        private void btnAddQuestion_MouseEnter(object sender, EventArgs e)
        {
            btnAddQuestion.Image = Resources.add_fade;
        }

        #endregion

        #region dtTeam

        

        private void dtTeams_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            oldValue = dtTeams.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

        }

        private void dtTeams_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
           var newValue = dtTeams.Rows[e.RowIndex].Cells[e.ColumnIndex].Value as double?;
            if (newValue < 0)
            {
                dtTeams.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = oldValue;
            }
            else
            {
                database.SaveChanges();
                btnTeams_Click(null,null);
            }
        }

        #endregion


        
        
        private const int DeleteTeamClnIndex = 3;

        private void dtTeams_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DeleteTeamClnIndex && e.RowIndex >= 0)
            {
                var dialog = new AreYouSurePopup("Da li ste sigurni da želite da obrišete tim?");
                dialog.ShowDialog(this);
                if (dialog.Success)
                {
                    var teamToDelete = dtTeams.Rows[e.RowIndex].DataBoundItem as team_round;
                    teamToDelete.deleted = 1;
                    database.SaveChanges();
                    if (database.team_round.FirstOrDefault(t => t.team_id == teamToDelete.team_id && t.deleted == 0) ==
                        null)
                    {
                        database.season_has_team.First(t => t.team_id == teamToDelete.team_id).deleted = 1;
                        database.SaveChanges();
                    };
                    btnTeams_Click(null, null);
                }

            }
        }

        private void dtTeams_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DeleteTeamClnIndex && e.RowIndex >= 0)
            {
                dtTeams.Rows[e.RowIndex].Cells["TeamDeleteCln"].Value = Resources.remove_fade;
            }
        }

        private void dtTeams_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DeleteTeamClnIndex && e.RowIndex >= 0)
            {
                dtTeams.Rows[e.RowIndex].Cells["TeamDeleteCln"].Value = Resources.remove;
            }
        }

        private void btnQuiz_Click(object sender, EventArgs e)
        {
            btnQuiz.BackColor = BackgroundColor;
            btnQuestion.BackColor = PrimaryColor;
            //loadMainForm();
            questionsView.SendToBack();
            questionsView.Hide();
        }

        private void btnQuestion_Click(object sender, EventArgs e)
        {
            btnQuiz.BackColor = PrimaryColor;
            btnQuestion.BackColor = BackgroundColor;
            questionsView.Database = database;
            questionsView.loadDB();
            questionsView.BringToFront();
            questionsView.Show();
        }

        private void seasonTreeView_DoubleClick(object sender, EventArgs e)
        {

        }

        private void seasonTreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            e.Node.BeginEdit();
        }

        private void seasonTreeView_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (String.IsNullOrEmpty(e.Label))
            {
                e.CancelEdit = true;
               // new ErrorPopup("Naziv mora da postoji!").ShowDialog(this);
                return;
            }
            else
            {
                if (e.Node.Level == 0 &&
                    seasonTreeView.Nodes.OfType<TreeNode>().FirstOrDefault(t => t.Text == e.Label && t.Tag != e.Node.Tag) == null)
                {
                    var season = e.Node.Tag as season;
                    season.name = e.Label;

                }
                else if (e.Node.Parent.Nodes.OfType<TreeNode>().FirstOrDefault(t => t.Text == e.Label && t.Tag!=e.Node.Tag) == null)
                {
                    var round = e.Node.Tag as round;
                    round.name = e.Label;
                }
                else
                {
                    new ErrorPopup("Naziv mora biti jedinstven!").ShowDialog(this);
                    e.CancelEdit = true;
                    return;
                }

                database.SaveChanges();
            }
        }

        private void s(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
