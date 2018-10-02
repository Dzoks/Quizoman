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

namespace Quizzy.View
{
    public partial class QuestionsForm : Form
    {

        private QuizzyDB database;
        private round round;
        private int YoutubeClnIndex=2;


        public QuestionsForm(QuizzyDB database,round round)
        {
            this.round = round;
            InitializeComponent();
            this.database = database;
            loadTable();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
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

        private void checkAudio_CheckedChanged(object sender, EventArgs e)
        {
            loadTable();
        }

        private void loadTable()
        {
            var currentQuestions = database.round_question.Where(q => q.round_id == round.id && q.deleted == 0).Select(q=>q.question).ToList();
            var allQuestions = database.questions.Where(q => q.deleted == 0).ToList();
            allQuestions = allQuestions.Except(currentQuestions).ToList();
            if (checkUntold.Checked)
            {
                allQuestions=allQuestions.Except(database.round_question.Where(q => q.deleted == 0).Select(q => q.question)).ToList();
            }

            if (checkAudio.Checked)
            {
                allQuestions.RemoveAll(q => String.IsNullOrEmpty(q.youtube_link));
            }

            allQuestions.Reverse();
            dtQuestions.DataSource = allQuestions;
            dtQuestions.ClearSelection();
            enableButton();

        }

        private void enableButton()
        {
            btnAddQuestion.Enabled = dtQuestions.SelectedRows.Count == 1 && Double.TryParse(fldPoints.Text,out var value) && value>0;
        }

        private void checkUntold_CheckedChanged(object sender, EventArgs e)
        {
            loadTable();
        }

        private void dtQuestions_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dtQuestions.Rows)
            {
                var rowQuestion = row.DataBoundItem as question;
                if (rowQuestion != null)
                {
                    if (String.IsNullOrEmpty(rowQuestion.youtube_link))
                    {
                        row.Cells["YoutubeCln"].Value = Resources.empty;
                    }
                    else
                    {
                        row.Cells["YoutubeCln"].Value = Resources.play;
                    }
                }

            }
        }

        private void dtQuestions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == YoutubeClnIndex && e.RowIndex > 0)
            {
                var question = dtQuestions.Rows[e.RowIndex].DataBoundItem as question;
                if (!String.IsNullOrEmpty(question.youtube_link))
                {
                    var form = new YoutubeForm(question.youtube_link);
                    form.ShowDialog(this);
                }
            }
        }

        private void dtQuestions_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == YoutubeClnIndex && e.RowIndex > 0)
            {
                var question = dtQuestions.Rows[e.RowIndex].DataBoundItem as question;
                if (!String.IsNullOrEmpty(question.youtube_link))
                {
                    dtQuestions.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Resources.play_red;
                }
            }
        }

        private void dtQuestions_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == YoutubeClnIndex && e.RowIndex > 0)
            {
                var question = dtQuestions.Rows[e.RowIndex].DataBoundItem as question;
                if (!String.IsNullOrEmpty(question.youtube_link))
                {
                    dtQuestions.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Resources.play;
                }
            }
        }

        private void btnNewQuestion_Click(object sender, EventArgs e)
        {
            var form=new AddQuestionForm(database);
            form.ShowDialog(this);
            loadTable();
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            var newQuestion=new round_question()
            {
                question = dtQuestions.SelectedRows[0].DataBoundItem as question,
                round=round,
                points = Double.Parse(fldPoints.Text),
                deleted = 0,
                question_number = round.round_question.Where(r => r.deleted == 0).ToList().Count+1
            };
            
            round.round_question.Add(newQuestion);
            database.SaveChanges();
            Close();

        }

        private void dtQuestions_SelectionChanged(object sender, EventArgs e)
        {
            enableButton();
        }


        private void fldPoints_TextChanged(object sender, EventArgs e)
        {
            enableButton();
        }
    }
}
