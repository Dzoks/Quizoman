using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quizoman.Model;
using Quizoman.Properties;
using Console = System.Console;

namespace Quizoman.View
{
    public partial class QuestionsView : UserControl
    {
        private QuizomanDB db;
        public QuestionsView()
        {
            InitializeComponent();
            db = new QuizomanDB();
            dtQuestions.AutoGenerateColumns = false;
            Dock = DockStyle.Fill;
            btnAddQuestion.Parent = dtQuestions;
            dtQuestions.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            clnYoutube.FlatStyle = FlatStyle.Flat;
            clnYoutube.DefaultCellStyle.SelectionBackColor = Color.FromArgb(38, 40, 47);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void QuestionsView_Load(object sender, EventArgs e)
        {
            foreach (var VARIABLE in db.questions)
            {
                Console.WriteLine(VARIABLE.answer);
            }
            dtQuestions.DataSource = db.questions.Local.ToBindingList();
        }

        private void btnAddQuestion_MouseEnter(object sender, EventArgs e)
        {
            btnAddQuestion.Image = Resources.add_fade;
        }

        private void btnAddQuestion_MouseLeave(object sender, EventArgs e)
        {
            btnAddQuestion.Image = Resources.add;
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            btnAddQuestion.Image = Resources.add;
            MessageBox.Show("Mac mac", "Hello");
        }

        private void dtQuestions_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if(e.RowIndex < 0)
            return;

            //I supposed your button column is at index 0
            if (e.ColumnIndex == 3)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.play.Width;
                var h = Properties.Resources.play.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;
                if (hovered&&e.RowIndex==rowIndex)
                    e.Graphics.DrawImage(Properties.Resources.play_fade, new Rectangle(x, y, w, h));
                else
                    e.Graphics.DrawImage(Properties.Resources.play, new Rectangle(x, y, w, h));

                e.Handled = true;
            }
        }

        private int rowIndex=-1;
        private bool hovered = false;
        private void dtQuestions_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {

            rowIndex = e.RowIndex;
            //I supposed your button column is at index 0
            if (e.ColumnIndex == 3)
            {
                hovered = true;
               dtQuestions.Refresh();
               
            }
        }

        private void dtQuestions_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==3 && e.RowIndex==rowIndex&&hovered)
            {
                hovered = false;
                rowIndex = -1;
                dtQuestions.Refresh();
            }
        }
    }
}
