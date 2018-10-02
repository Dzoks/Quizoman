namespace Quizzy.View
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtQuestions = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.questionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.questiontextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.answerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YoutubeCln = new System.Windows.Forms.DataGridViewImageColumn();
            this.youtubelinkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteCln = new System.Windows.Forms.DataGridViewImageColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roundquestionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtQuestions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtQuestions
            // 
            this.dtQuestions.AllowUserToResizeColumns = false;
            this.dtQuestions.AllowUserToResizeRows = false;
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
            this.dtQuestions.ColumnHeadersHeight = 38;
            this.dtQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtQuestions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.questiontextDataGridViewTextBoxColumn,
            this.answerDataGridViewTextBoxColumn,
            this.YoutubeCln,
            this.youtubelinkDataGridViewTextBoxColumn,
            this.DeleteCln,
            this.idDataGridViewTextBoxColumn,
            this.deletedDataGridViewTextBoxColumn,
            this.roundquestionDataGridViewTextBoxColumn});
            this.dtQuestions.DataSource = this.questionBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtQuestions.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtQuestions.EnableHeadersVisualStyles = false;
            this.dtQuestions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(87)))));
            this.dtQuestions.Location = new System.Drawing.Point(12, 24);
            this.dtQuestions.MultiSelect = false;
            this.dtQuestions.Name = "dtQuestions";
            this.dtQuestions.RowHeadersVisible = false;
            this.dtQuestions.RowTemplate.Height = 38;
            this.dtQuestions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtQuestions.Size = new System.Drawing.Size(849, 506);
            this.dtQuestions.TabIndex = 3;
            this.dtQuestions.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dtQuestions_CellBeginEdit);
            this.dtQuestions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtQuestions_CellClick);
            this.dtQuestions.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtQuestions_CellEndEdit);
            this.dtQuestions.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtQuestions_CellMouseEnter);
            this.dtQuestions.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtQuestions_CellMouseLeave);
            this.dtQuestions.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dtQuestions_DataBindingComplete);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(67)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.Transparent;
            this.btnAdd.Image = global::Quizzy.Properties.Resources.add;
            this.btnAdd.Location = new System.Drawing.Point(774, 431);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(78, 77);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            this.btnAdd.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            // 
            // questionBindingSource
            // 
            this.questionBindingSource.DataSource = typeof(Quizzy.Model.question);
            // 
            // questiontextDataGridViewTextBoxColumn
            // 
            this.questiontextDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.questiontextDataGridViewTextBoxColumn.DataPropertyName = "question_text";
            this.questiontextDataGridViewTextBoxColumn.HeaderText = "Pitanje";
            this.questiontextDataGridViewTextBoxColumn.Name = "questiontextDataGridViewTextBoxColumn";
            // 
            // answerDataGridViewTextBoxColumn
            // 
            this.answerDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.answerDataGridViewTextBoxColumn.DataPropertyName = "answer";
            this.answerDataGridViewTextBoxColumn.FillWeight = 50F;
            this.answerDataGridViewTextBoxColumn.HeaderText = "Odgovor";
            this.answerDataGridViewTextBoxColumn.Name = "answerDataGridViewTextBoxColumn";
            // 
            // YoutubeCln
            // 
            this.YoutubeCln.FillWeight = 38F;
            this.YoutubeCln.HeaderText = "YT";
            this.YoutubeCln.MinimumWidth = 38;
            this.YoutubeCln.Name = "YoutubeCln";
            this.YoutubeCln.ReadOnly = true;
            this.YoutubeCln.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.YoutubeCln.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.YoutubeCln.Width = 38;
            // 
            // youtubelinkDataGridViewTextBoxColumn
            // 
            this.youtubelinkDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.youtubelinkDataGridViewTextBoxColumn.DataPropertyName = "youtube_link";
            this.youtubelinkDataGridViewTextBoxColumn.FillWeight = 50F;
            this.youtubelinkDataGridViewTextBoxColumn.HeaderText = "Youtube link";
            this.youtubelinkDataGridViewTextBoxColumn.Name = "youtubelinkDataGridViewTextBoxColumn";
            this.youtubelinkDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // DeleteCln
            // 
            this.DeleteCln.FillWeight = 38F;
            this.DeleteCln.HeaderText = "";
            this.DeleteCln.MinimumWidth = 38;
            this.DeleteCln.Name = "DeleteCln";
            this.DeleteCln.ReadOnly = true;
            this.DeleteCln.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DeleteCln.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DeleteCln.Width = 38;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // deletedDataGridViewTextBoxColumn
            // 
            this.deletedDataGridViewTextBoxColumn.DataPropertyName = "deleted";
            this.deletedDataGridViewTextBoxColumn.HeaderText = "deleted";
            this.deletedDataGridViewTextBoxColumn.Name = "deletedDataGridViewTextBoxColumn";
            this.deletedDataGridViewTextBoxColumn.Visible = false;
            // 
            // roundquestionDataGridViewTextBoxColumn
            // 
            this.roundquestionDataGridViewTextBoxColumn.DataPropertyName = "round_question";
            this.roundquestionDataGridViewTextBoxColumn.HeaderText = "round_question";
            this.roundquestionDataGridViewTextBoxColumn.Name = "roundquestionDataGridViewTextBoxColumn";
            this.roundquestionDataGridViewTextBoxColumn.Visible = false;
            // 
            // QuestionsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(61)))));
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtQuestions);
            this.Name = "QuestionsView";
            this.Size = new System.Drawing.Size(882, 558);
            ((System.ComponentModel.ISupportInitialize)(this.dtQuestions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtQuestions;
        private System.Windows.Forms.BindingSource questionBindingSource;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn questiontextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn answerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn YoutubeCln;
        private System.Windows.Forms.DataGridViewTextBoxColumn youtubelinkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn DeleteCln;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deletedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roundquestionDataGridViewTextBoxColumn;
    }
}
