namespace Quizzy.View
{
    partial class QuestionsForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.topPanel = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.dtQuestions = new System.Windows.Forms.DataGridView();
            this.YoutubeCln = new System.Windows.Forms.DataGridViewImageColumn();
            this.checkUntold = new System.Windows.Forms.CheckBox();
            this.checkAudio = new System.Windows.Forms.CheckBox();
            this.questiontextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.answerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.youtubelinkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roundquestionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtQuestions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(47)))));
            this.topPanel.Controls.Add(this.btnClose);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(890, 40);
            this.topPanel.TabIndex = 1;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::Quizzy.Properties.Resources.close;
            this.btnClose.Location = new System.Drawing.Point(853, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 36);
            this.btnClose.TabIndex = 3;
            this.btnClose.TabStop = false;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnAddQuestion.FlatAppearance.BorderSize = 0;
            this.btnAddQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddQuestion.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddQuestion.ForeColor = System.Drawing.Color.White;
            this.btnAddQuestion.Location = new System.Drawing.Point(738, 488);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(140, 41);
            this.btnAddQuestion.TabIndex = 2;
            this.btnAddQuestion.Text = "Dodavanje";
            this.btnAddQuestion.UseVisualStyleBackColor = false;
            // 
            // dtQuestions
            // 
            this.dtQuestions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtQuestions.AutoGenerateColumns = false;
            this.dtQuestions.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(67)))));
            this.dtQuestions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtQuestions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtQuestions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtQuestions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.questiontextDataGridViewTextBoxColumn,
            this.answerDataGridViewTextBoxColumn,
            this.YoutubeCln,
            this.youtubelinkDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.deletedDataGridViewTextBoxColumn,
            this.roundquestionDataGridViewTextBoxColumn});
            this.dtQuestions.DataSource = this.questionBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtQuestions.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtQuestions.EnableHeadersVisualStyles = false;
            this.dtQuestions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(87)))));
            this.dtQuestions.Location = new System.Drawing.Point(12, 86);
            this.dtQuestions.MultiSelect = false;
            this.dtQuestions.Name = "dtQuestions";
            this.dtQuestions.ReadOnly = true;
            this.dtQuestions.RowHeadersVisible = false;
            this.dtQuestions.RowTemplate.Height = 32;
            this.dtQuestions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtQuestions.Size = new System.Drawing.Size(866, 382);
            this.dtQuestions.TabIndex = 3;
            this.dtQuestions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtQuestions_CellClick);
            this.dtQuestions.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtQuestions_CellMouseEnter);
            this.dtQuestions.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtQuestions_CellMouseLeave);
            this.dtQuestions.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dtQuestions_DataBindingComplete);
            // 
            // YoutubeCln
            // 
            this.YoutubeCln.FillWeight = 34F;
            this.YoutubeCln.HeaderText = "YT";
            this.YoutubeCln.MinimumWidth = 34;
            this.YoutubeCln.Name = "YoutubeCln";
            this.YoutubeCln.ReadOnly = true;
            this.YoutubeCln.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.YoutubeCln.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.YoutubeCln.Width = 34;
            // 
            // checkUntold
            // 
            this.checkUntold.AutoSize = true;
            this.checkUntold.FlatAppearance.BorderSize = 0;
            this.checkUntold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkUntold.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkUntold.ForeColor = System.Drawing.Color.White;
            this.checkUntold.Location = new System.Drawing.Point(86, 497);
            this.checkUntold.Name = "checkUntold";
            this.checkUntold.Size = new System.Drawing.Size(126, 17);
            this.checkUntold.TabIndex = 4;
            this.checkUntold.Text = "Samo nepostavljena";
            this.checkUntold.UseVisualStyleBackColor = true;
            this.checkUntold.CheckedChanged += new System.EventHandler(this.checkUntold_CheckedChanged);
            // 
            // checkAudio
            // 
            this.checkAudio.AutoSize = true;
            this.checkAudio.FlatAppearance.BorderSize = 0;
            this.checkAudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkAudio.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkAudio.ForeColor = System.Drawing.Color.White;
            this.checkAudio.Location = new System.Drawing.Point(262, 497);
            this.checkAudio.Name = "checkAudio";
            this.checkAudio.Size = new System.Drawing.Size(84, 17);
            this.checkAudio.TabIndex = 4;
            this.checkAudio.Text = "Samo audio";
            this.checkAudio.UseVisualStyleBackColor = true;
            this.checkAudio.CheckedChanged += new System.EventHandler(this.checkAudio_CheckedChanged);
            // 
            // questiontextDataGridViewTextBoxColumn
            // 
            this.questiontextDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.questiontextDataGridViewTextBoxColumn.DataPropertyName = "question_text";
            this.questiontextDataGridViewTextBoxColumn.HeaderText = "Pitanje";
            this.questiontextDataGridViewTextBoxColumn.Name = "questiontextDataGridViewTextBoxColumn";
            this.questiontextDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // answerDataGridViewTextBoxColumn
            // 
            this.answerDataGridViewTextBoxColumn.DataPropertyName = "answer";
            this.answerDataGridViewTextBoxColumn.HeaderText = "Odgovor";
            this.answerDataGridViewTextBoxColumn.Name = "answerDataGridViewTextBoxColumn";
            this.answerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // youtubelinkDataGridViewTextBoxColumn
            // 
            this.youtubelinkDataGridViewTextBoxColumn.DataPropertyName = "youtube_link";
            this.youtubelinkDataGridViewTextBoxColumn.HeaderText = "youtube_link";
            this.youtubelinkDataGridViewTextBoxColumn.Name = "youtubelinkDataGridViewTextBoxColumn";
            this.youtubelinkDataGridViewTextBoxColumn.ReadOnly = true;
            this.youtubelinkDataGridViewTextBoxColumn.Visible = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // deletedDataGridViewTextBoxColumn
            // 
            this.deletedDataGridViewTextBoxColumn.DataPropertyName = "deleted";
            this.deletedDataGridViewTextBoxColumn.HeaderText = "deleted";
            this.deletedDataGridViewTextBoxColumn.Name = "deletedDataGridViewTextBoxColumn";
            this.deletedDataGridViewTextBoxColumn.ReadOnly = true;
            this.deletedDataGridViewTextBoxColumn.Visible = false;
            // 
            // roundquestionDataGridViewTextBoxColumn
            // 
            this.roundquestionDataGridViewTextBoxColumn.DataPropertyName = "round_question";
            this.roundquestionDataGridViewTextBoxColumn.HeaderText = "round_question";
            this.roundquestionDataGridViewTextBoxColumn.Name = "roundquestionDataGridViewTextBoxColumn";
            this.roundquestionDataGridViewTextBoxColumn.ReadOnly = true;
            this.roundquestionDataGridViewTextBoxColumn.Visible = false;
            // 
            // questionBindingSource
            // 
            this.questionBindingSource.DataSource = typeof(Quizzy.Model.question);
            // 
            // QuestionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(890, 541);
            this.Controls.Add(this.checkAudio);
            this.Controls.Add(this.checkUntold);
            this.Controls.Add(this.dtQuestions);
            this.Controls.Add(this.btnAddQuestion);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuestionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuestionsForm";
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtQuestions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.DataGridView dtQuestions;
        private System.Windows.Forms.DataGridViewTextBoxColumn questiontextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn answerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn YoutubeCln;
        private System.Windows.Forms.DataGridViewTextBoxColumn youtubelinkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deletedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roundquestionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource questionBindingSource;
        private System.Windows.Forms.CheckBox checkUntold;
        private System.Windows.Forms.CheckBox checkAudio;
    }
}