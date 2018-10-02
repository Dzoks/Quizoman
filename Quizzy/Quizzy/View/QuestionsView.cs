using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quizzy.Model;
using Quizzy.Properties;

namespace Quizzy.View
{
    public partial class QuestionsView : UserControl
    {
        public QuizzyDB Database { get; set; }
        private const int YoutubeLinkColumnNumber = 3;
        private const int YoutubeVideoColumnNumber = 2;
        private const int DeleteColumnNumber = 4;
        private object oldValue;

        public QuestionsView()
        {
            InitializeComponent();
            btnAdd.Parent = dtQuestions;
        }



        public void loadDB()
        {
            Database.SaveChanges();
            var list= Database.questions.Where(q => q.deleted == 0).ToList();
            list.Reverse();
            dtQuestions.DataSource = list;
        }

        private void dtQuestions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            var questionObject = dtQuestions.Rows[e.RowIndex]?.DataBoundItem as question;

            if (e.ColumnIndex == DeleteColumnNumber)
            {
                var dialog=new AreYouSurePopup("Da li ste sigurni da želite da obrišete pitanje?");
                dialog.ShowDialog(this);
                if (dialog.Success)
                {
                    questionObject.deleted = 1;
                    loadDB();

                }
            }
            else if (e.ColumnIndex == YoutubeVideoColumnNumber && !string.IsNullOrEmpty(questionObject?.youtube_link))
            {
                Form yt = new YoutubeForm(questionObject.youtube_link);
                yt.ShowDialog(this);
            }
        }

        private void dtQuestions_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            int j = e.ColumnIndex;
            if (i >= 0 && j >= 0)
            {
                var cell = dtQuestions.Rows[i].Cells[j];
                var questionObject = dtQuestions.Rows[i].DataBoundItem as question;
                if (cell.ColumnIndex == YoutubeVideoColumnNumber && !string.IsNullOrEmpty(questionObject?.youtube_link))
                {
                    cell.Value = Resources.play_red;
                }
                else if (cell.ColumnIndex == DeleteColumnNumber)
                {
                    cell.Value = Resources.remove_fade;

                }
            }
        }

        private void dtQuestions_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            int j = e.ColumnIndex;
            if (i >= 0 && j >= 0)
            {
                var cell = dtQuestions.Rows[i].Cells[j];
                if (dtQuestions.Rows[i].DataBoundItem is question questionObject && cell.ColumnIndex == YoutubeVideoColumnNumber &&
                    !string.IsNullOrEmpty(questionObject.youtube_link))
                {
                    cell.Value = Resources.play;

                }
                else if (cell.ColumnIndex == DeleteColumnNumber)
                {
                    cell.Value = Resources.remove;

                }
            }
        }

        private void dtQuestions_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            oldValue = dtQuestions.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
        }

        private void dtQuestions_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (!((question)dtQuestions.Rows[e.RowIndex].DataBoundItem).CheckValidity())
            {
                oldValue = dtQuestions.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = oldValue;
            }
            else
            {
                Database.SaveChanges();
                if (e.ColumnIndex == YoutubeLinkColumnNumber)
                {
                    dtQuestions.Rows[e.RowIndex].Cells[YoutubeVideoColumnNumber].Value = String.IsNullOrEmpty((dtQuestions.Rows[e.RowIndex].DataBoundItem as question)?.youtube_link) ? Resources.empty : Resources.play;
                }
            }
        }

        private void dtQuestions_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dtQuestions.Rows)
            {
                var questionObject = row.DataBoundItem as question;
                if (!string.IsNullOrEmpty(questionObject?.youtube_link))
                {
                    row.Cells["YoutubeCln"].Value = Resources.play;
                }
                else
                {
                    row.Cells["YoutubeCln"].Value = Resources.empty;
                }

                row.Cells["DeleteCln"].Value = Resources.remove;
                    
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Image = Resources.add;
            AddQuestionForm addForm = new AddQuestionForm(Database);
            addForm.ShowDialog(this);
            loadDB();
        }

        private void btnAdd_MouseEnter(object sender, EventArgs e)
        {
            btnAdd.Image = Resources.add_fade;

        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.Image = Resources.add;

        }
    }
    
}
