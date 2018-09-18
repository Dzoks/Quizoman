namespace Quizoman.View
{
    partial class QuestionsView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionsView));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtQuestions = new System.Windows.Forms.DataGridView();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.clnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnQuestion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnAnswer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnYoutube = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clnDeleted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roundquestionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingQuestion = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtQuestions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingQuestion)).BeginInit();
            this.SuspendLayout();
            // 
            // dtQuestions
            // 
            this.dtQuestions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtQuestions.AutoGenerateColumns = false;
            this.dtQuestions.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.dtQuestions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtQuestions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtQuestions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtQuestions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnId,
            this.clnQuestion,
            this.clnAnswer,
            this.clnYoutube,
            this.clnDeleted,
            this.roundquestionDataGridViewTextBoxColumn});
            this.dtQuestions.DataSource = this.bindingQuestion;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtQuestions.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtQuestions.EnableHeadersVisualStyles = false;
            this.dtQuestions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(87)))));
            this.dtQuestions.Location = new System.Drawing.Point(17, 57);
            this.dtQuestions.Name = "dtQuestions";
            this.dtQuestions.RowHeadersVisible = false;
            this.dtQuestions.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.dtQuestions.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtQuestions.RowTemplate.Height = 46;
            this.dtQuestions.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtQuestions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtQuestions.Size = new System.Drawing.Size(771, 570);
            this.dtQuestions.TabIndex = 0;
            this.dtQuestions.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtQuestions_CellMouseEnter);
            this.dtQuestions.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtQuestions_CellMouseLeave);
            this.dtQuestions.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dtQuestions_CellPainting);
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddQuestion.BackColor = System.Drawing.Color.Transparent;
            this.btnAddQuestion.FlatAppearance.BorderSize = 0;
            this.btnAddQuestion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddQuestion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddQuestion.Image = ((System.Drawing.Image)(resources.GetObject("btnAddQuestion.Image")));
            this.btnAddQuestion.Location = new System.Drawing.Point(679, 484);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(81, 83);
            this.btnAddQuestion.TabIndex = 3;
            this.btnAddQuestion.UseVisualStyleBackColor = false;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            this.btnAddQuestion.MouseEnter += new System.EventHandler(this.btnAddQuestion_MouseEnter);
            this.btnAddQuestion.MouseLeave += new System.EventHandler(this.btnAddQuestion_MouseLeave);
            // 
            // clnId
            // 
            this.clnId.DataPropertyName = "id";
            this.clnId.HeaderText = "id";
            this.clnId.Name = "clnId";
            this.clnId.Visible = false;
            // 
            // clnQuestion
            // 
            this.clnQuestion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnQuestion.DataPropertyName = "question_text";
            this.clnQuestion.HeaderText = "Pitanje";
            this.clnQuestion.Name = "clnQuestion";
            // 
            // clnAnswer
            // 
            this.clnAnswer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnAnswer.DataPropertyName = "answer";
            this.clnAnswer.HeaderText = "Odgovor";
            this.clnAnswer.Name = "clnAnswer";
            // 
            // clnYoutube
            // 
            this.clnYoutube.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clnYoutube.DataPropertyName = "youtube_link";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Transparent;
            this.clnYoutube.DefaultCellStyle = dataGridViewCellStyle2;
            this.clnYoutube.HeaderText = "YT";
            this.clnYoutube.MinimumWidth = 46;
            this.clnYoutube.Name = "clnYoutube";
            this.clnYoutube.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clnYoutube.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clnYoutube.Width = 46;
            // 
            // clnDeleted
            // 
            this.clnDeleted.DataPropertyName = "deleted";
            this.clnDeleted.HeaderText = "deleted";
            this.clnDeleted.Name = "clnDeleted";
            this.clnDeleted.Visible = false;
            // 
            // roundquestionDataGridViewTextBoxColumn
            // 
            this.roundquestionDataGridViewTextBoxColumn.DataPropertyName = "round_question";
            this.roundquestionDataGridViewTextBoxColumn.HeaderText = "round_question";
            this.roundquestionDataGridViewTextBoxColumn.Name = "roundquestionDataGridViewTextBoxColumn";
            this.roundquestionDataGridViewTextBoxColumn.Visible = false;
            // 
            // bindingQuestion
            // 
            this.bindingQuestion.DataSource = typeof(Quizoman.Model.question);
            // 
            // QuestionsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.btnAddQuestion);
            this.Controls.Add(this.dtQuestions);
            this.Name = "QuestionsView";
            this.Size = new System.Drawing.Size(800, 640);
            this.Load += new System.EventHandler(this.QuestionsView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtQuestions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingQuestion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dtQuestions;
        private System.Windows.Forms.BindingSource bindingQuestion;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnQuestion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnAnswer;
        private System.Windows.Forms.DataGridViewButtonColumn clnYoutube;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDeleted;
        private System.Windows.Forms.DataGridViewTextBoxColumn roundquestionDataGridViewTextBoxColumn;
    }
}
