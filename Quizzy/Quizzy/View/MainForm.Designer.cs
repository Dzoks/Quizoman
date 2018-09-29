namespace Quizzy
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.topPanel = new System.Windows.Forms.Panel();
            this.btnQuestion = new System.Windows.Forms.Button();
            this.btnQuiz = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.seasonTreeView = new System.Windows.Forms.TreeView();
            this.btnTeams = new System.Windows.Forms.Button();
            this.btnQuestions = new System.Windows.Forms.Button();
            this.lblPlaces = new System.Windows.Forms.Label();
            this.dtTeams = new System.Windows.Forms.DataGridView();
            this.TeamCountCln = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeamDeleteCln = new System.Windows.Forms.DataGridViewImageColumn();
            this.dtQuestions = new System.Windows.Forms.DataGridView();
            this.dtSeasonTeams = new System.Windows.Forms.DataGridView();
            this.SeasonCountCln = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.roundquestionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roundidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletedDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roundDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamroundBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seasonidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seasonhasteamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.questionsView = new Quizzy.View.QuestionsView();
            this.UpCln = new System.Windows.Forms.DataGridViewImageColumn();
            this.questionnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DownCln = new System.Windows.Forms.DataGridViewImageColumn();
            this.questionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnswerCln = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YoutubeCln = new System.Windows.Forms.DataGridViewImageColumn();
            this.DeleteCln = new System.Windows.Forms.DataGridViewImageColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roundidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletedDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roundDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtTeams)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtQuestions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSeasonTeams)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundquestionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamroundBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seasonhasteamBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(47)))));
            this.topPanel.Controls.Add(this.btnQuestion);
            this.topPanel.Controls.Add(this.btnQuiz);
            this.topPanel.Controls.Add(this.btnClose);
            this.topPanel.Controls.Add(this.btnMaximize);
            this.topPanel.Controls.Add(this.btnMinimize);
            this.topPanel.Controls.Add(this.label);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(1, 1);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(882, 40);
            this.topPanel.TabIndex = 0;
            this.topPanel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDoubleClick);
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            // 
            // btnQuestion
            // 
            this.btnQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.btnQuestion.FlatAppearance.BorderSize = 0;
            this.btnQuestion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(61)))));
            this.btnQuestion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.btnQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuestion.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuestion.ForeColor = System.Drawing.Color.White;
            this.btnQuestion.Location = new System.Drawing.Point(634, 8);
            this.btnQuestion.Name = "btnQuestion";
            this.btnQuestion.Size = new System.Drawing.Size(112, 32);
            this.btnQuestion.TabIndex = 4;
            this.btnQuestion.Text = "Pitanja";
            this.btnQuestion.UseVisualStyleBackColor = false;
            this.btnQuestion.Click += new System.EventHandler(this.btnQuestion_Click);
            // 
            // btnQuiz
            // 
            this.btnQuiz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.btnQuiz.FlatAppearance.BorderSize = 0;
            this.btnQuiz.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(61)))));
            this.btnQuiz.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.btnQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuiz.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuiz.ForeColor = System.Drawing.Color.White;
            this.btnQuiz.Location = new System.Drawing.Point(525, 8);
            this.btnQuiz.Name = "btnQuiz";
            this.btnQuiz.Size = new System.Drawing.Size(112, 32);
            this.btnQuiz.TabIndex = 4;
            this.btnQuiz.Text = "Kvizovi";
            this.btnQuiz.UseVisualStyleBackColor = false;
            this.btnQuiz.Click += new System.EventHandler(this.btnQuiz_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::Quizzy.Properties.Resources.close;
            this.btnClose.Location = new System.Drawing.Point(845, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 36);
            this.btnClose.TabIndex = 3;
            this.btnClose.TabStop = false;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Image = global::Quizzy.Properties.Resources.maximize;
            this.btnMaximize.Location = new System.Drawing.Point(803, 4);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(36, 36);
            this.btnMaximize.TabIndex = 2;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::Quizzy.Properties.Resources.minimize;
            this.btnMinimize.Location = new System.Drawing.Point(761, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(36, 36);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI Black", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(3, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(95, 32);
            this.label.TabIndex = 0;
            this.label.Text = "Quizzy";
            this.label.Click += new System.EventHandler(this.label_Click);
            this.label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            // 
            // seasonTreeView
            // 
            this.seasonTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.seasonTreeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(64)))));
            this.seasonTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.seasonTreeView.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll;
            this.seasonTreeView.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seasonTreeView.ForeColor = System.Drawing.Color.White;
            this.seasonTreeView.LabelEdit = true;
            this.seasonTreeView.Location = new System.Drawing.Point(0, 41);
            this.seasonTreeView.Name = "seasonTreeView";
            this.seasonTreeView.Size = new System.Drawing.Size(240, 558);
            this.seasonTreeView.TabIndex = 1;
            this.seasonTreeView.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.seasonTreeView_AfterLabelEdit);
            this.seasonTreeView.DrawNode += new System.Windows.Forms.DrawTreeNodeEventHandler(this.seasonTreeView_DrawNode);
            this.seasonTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.seasonTreeView_NodeMouseClick);
            this.seasonTreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.seasonTreeView_NodeMouseDoubleClick);
            this.seasonTreeView.DoubleClick += new System.EventHandler(this.seasonTreeView_DoubleClick);
            // 
            // btnTeams
            // 
            this.btnTeams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(67)))));
            this.btnTeams.FlatAppearance.BorderSize = 0;
            this.btnTeams.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(67)))));
            this.btnTeams.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.btnTeams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeams.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeams.ForeColor = System.Drawing.Color.White;
            this.btnTeams.Location = new System.Drawing.Point(260, 47);
            this.btnTeams.Name = "btnTeams";
            this.btnTeams.Size = new System.Drawing.Size(112, 31);
            this.btnTeams.TabIndex = 3;
            this.btnTeams.Text = "Timovi";
            this.btnTeams.UseVisualStyleBackColor = false;
            this.btnTeams.Click += new System.EventHandler(this.btnTeams_Click);
            // 
            // btnQuestions
            // 
            this.btnQuestions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(67)))));
            this.btnQuestions.FlatAppearance.BorderSize = 0;
            this.btnQuestions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(67)))));
            this.btnQuestions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.btnQuestions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuestions.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuestions.ForeColor = System.Drawing.Color.White;
            this.btnQuestions.Location = new System.Drawing.Point(366, 47);
            this.btnQuestions.Name = "btnQuestions";
            this.btnQuestions.Size = new System.Drawing.Size(112, 31);
            this.btnQuestions.TabIndex = 3;
            this.btnQuestions.Text = "Pitanja";
            this.btnQuestions.UseVisualStyleBackColor = false;
            this.btnQuestions.Click += new System.EventHandler(this.btnQuestions_Click);
            // 
            // lblPlaces
            // 
            this.lblPlaces.AutoSize = true;
            this.lblPlaces.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaces.ForeColor = System.Drawing.Color.White;
            this.lblPlaces.Location = new System.Drawing.Point(265, 41);
            this.lblPlaces.Name = "lblPlaces";
            this.lblPlaces.Size = new System.Drawing.Size(150, 25);
            this.lblPlaces.TabIndex = 5;
            this.lblPlaces.Text = "Ukupni plasman";
            // 
            // dtTeams
            // 
            this.dtTeams.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtTeams.AutoGenerateColumns = false;
            this.dtTeams.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(67)))));
            this.dtTeams.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtTeams.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtTeams.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtTeams.ColumnHeadersHeight = 38;
            this.dtTeams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtTeams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TeamCountCln,
            this.teamDataGridViewTextBoxColumn1,
            this.totalDataGridViewTextBoxColumn1,
            this.TeamDeleteCln,
            this.teamidDataGridViewTextBoxColumn1,
            this.roundidDataGridViewTextBoxColumn,
            this.deletedDataGridViewTextBoxColumn1,
            this.roundDataGridViewTextBoxColumn});
            this.dtTeams.DataSource = this.teamroundBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtTeams.DefaultCellStyle = dataGridViewCellStyle8;
            this.dtTeams.EnableHeadersVisualStyles = false;
            this.dtTeams.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(87)))));
            this.dtTeams.Location = new System.Drawing.Point(260, 78);
            this.dtTeams.MultiSelect = false;
            this.dtTeams.Name = "dtTeams";
            this.dtTeams.RowHeadersVisible = false;
            this.dtTeams.RowTemplate.Height = 38;
            this.dtTeams.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtTeams.Size = new System.Drawing.Size(599, 506);
            this.dtTeams.TabIndex = 2;
            this.dtTeams.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dtTeams_CellBeginEdit);
            this.dtTeams.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtTeams_CellClick);
            this.dtTeams.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtTeams_CellEndEdit);
            this.dtTeams.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtTeams_CellMouseEnter);
            this.dtTeams.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtTeams_CellMouseLeave);
            this.dtTeams.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dtTeams_DataBindingComplete);
            // 
            // TeamCountCln
            // 
            this.TeamCountCln.FillWeight = 60F;
            this.TeamCountCln.HeaderText = "Mjesto";
            this.TeamCountCln.MinimumWidth = 60;
            this.TeamCountCln.Name = "TeamCountCln";
            this.TeamCountCln.ReadOnly = true;
            this.TeamCountCln.Width = 60;
            // 
            // TeamDeleteCln
            // 
            this.TeamDeleteCln.FillWeight = 38F;
            this.TeamDeleteCln.HeaderText = "";
            this.TeamDeleteCln.MinimumWidth = 38;
            this.TeamDeleteCln.Name = "TeamDeleteCln";
            this.TeamDeleteCln.Width = 38;
            // 
            // dtQuestions
            // 
            this.dtQuestions.AllowDrop = true;
            this.dtQuestions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtQuestions.AutoGenerateColumns = false;
            this.dtQuestions.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(67)))));
            this.dtQuestions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtQuestions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtQuestions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dtQuestions.ColumnHeadersHeight = 38;
            this.dtQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtQuestions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UpCln,
            this.questionnumberDataGridViewTextBoxColumn,
            this.DownCln,
            this.questionDataGridViewTextBoxColumn,
            this.AnswerCln,
            this.YoutubeCln,
            this.DeleteCln,
            this.idDataGridViewTextBoxColumn,
            this.questionidDataGridViewTextBoxColumn,
            this.roundidDataGridViewTextBoxColumn1,
            this.deletedDataGridViewTextBoxColumn2,
            this.roundDataGridViewTextBoxColumn1});
            this.dtQuestions.DataSource = this.roundquestionBindingSource;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtQuestions.DefaultCellStyle = dataGridViewCellStyle10;
            this.dtQuestions.EnableHeadersVisualStyles = false;
            this.dtQuestions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(87)))));
            this.dtQuestions.Location = new System.Drawing.Point(260, 78);
            this.dtQuestions.MultiSelect = false;
            this.dtQuestions.Name = "dtQuestions";
            this.dtQuestions.ReadOnly = true;
            this.dtQuestions.RowHeadersVisible = false;
            this.dtQuestions.RowTemplate.Height = 38;
            this.dtQuestions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtQuestions.Size = new System.Drawing.Size(599, 506);
            this.dtQuestions.TabIndex = 2;
            this.dtQuestions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtQuestions_CellClick);
            this.dtQuestions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.s);
            this.dtQuestions.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtQuestions_CellMouseEnter);
            this.dtQuestions.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtQuestions_CellMouseLeave);
            this.dtQuestions.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dtQuestions_DataBindingComplete);
            // 
            // dtSeasonTeams
            // 
            this.dtSeasonTeams.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtSeasonTeams.AutoGenerateColumns = false;
            this.dtSeasonTeams.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(67)))));
            this.dtSeasonTeams.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtSeasonTeams.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtSeasonTeams.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dtSeasonTeams.ColumnHeadersHeight = 38;
            this.dtSeasonTeams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtSeasonTeams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SeasonCountCln,
            this.teamDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.seasonidDataGridViewTextBoxColumn,
            this.teamidDataGridViewTextBoxColumn,
            this.deletedDataGridViewTextBoxColumn,
            this.seasonDataGridViewTextBoxColumn});
            this.dtSeasonTeams.DataSource = this.seasonhasteamBindingSource;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtSeasonTeams.DefaultCellStyle = dataGridViewCellStyle12;
            this.dtSeasonTeams.EnableHeadersVisualStyles = false;
            this.dtSeasonTeams.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(87)))));
            this.dtSeasonTeams.Location = new System.Drawing.Point(260, 78);
            this.dtSeasonTeams.MultiSelect = false;
            this.dtSeasonTeams.Name = "dtSeasonTeams";
            this.dtSeasonTeams.ReadOnly = true;
            this.dtSeasonTeams.RowHeadersVisible = false;
            this.dtSeasonTeams.RowTemplate.Height = 38;
            this.dtSeasonTeams.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtSeasonTeams.Size = new System.Drawing.Size(599, 506);
            this.dtSeasonTeams.TabIndex = 2;
            this.dtSeasonTeams.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dtSeasonTeams_DataBindingComplete);
            // 
            // SeasonCountCln
            // 
            this.SeasonCountCln.FillWeight = 60F;
            this.SeasonCountCln.HeaderText = "Mjesto";
            this.SeasonCountCln.MinimumWidth = 60;
            this.SeasonCountCln.Name = "SeasonCountCln";
            this.SeasonCountCln.ReadOnly = true;
            this.SeasonCountCln.Width = 60;
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddTeam.BackColor = System.Drawing.Color.Transparent;
            this.btnAddTeam.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(67)))));
            this.btnAddTeam.FlatAppearance.BorderSize = 0;
            this.btnAddTeam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddTeam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTeam.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddTeam.Image = global::Quizzy.Properties.Resources.add;
            this.btnAddTeam.Location = new System.Drawing.Point(526, 431);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(78, 77);
            this.btnAddTeam.TabIndex = 4;
            this.btnAddTeam.UseVisualStyleBackColor = false;
            this.btnAddTeam.Click += new System.EventHandler(this.btnAddTeam_Click);
            this.btnAddTeam.MouseEnter += new System.EventHandler(this.btnAddTeam_MouseEnter);
            this.btnAddTeam.MouseLeave += new System.EventHandler(this.btnAddTeam_MouseLeave);
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddQuestion.BackColor = System.Drawing.Color.Transparent;
            this.btnAddQuestion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(67)))));
            this.btnAddQuestion.FlatAppearance.BorderSize = 0;
            this.btnAddQuestion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddQuestion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddQuestion.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddQuestion.Image = global::Quizzy.Properties.Resources.add;
            this.btnAddQuestion.Location = new System.Drawing.Point(526, 431);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(78, 77);
            this.btnAddQuestion.TabIndex = 4;
            this.btnAddQuestion.UseVisualStyleBackColor = false;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            this.btnAddQuestion.MouseEnter += new System.EventHandler(this.btnAddQuestion_MouseEnter);
            this.btnAddQuestion.MouseLeave += new System.EventHandler(this.btnAddQuestion_MouseLeave);
            // 
            // roundquestionBindingSource
            // 
            this.roundquestionBindingSource.DataSource = typeof(Quizzy.Model.round_question);
            // 
            // teamDataGridViewTextBoxColumn1
            // 
            this.teamDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.teamDataGridViewTextBoxColumn1.DataPropertyName = "team";
            this.teamDataGridViewTextBoxColumn1.HeaderText = "Naziv tima";
            this.teamDataGridViewTextBoxColumn1.Name = "teamDataGridViewTextBoxColumn1";
            this.teamDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn1
            // 
            this.totalDataGridViewTextBoxColumn1.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn1.FillWeight = 60F;
            this.totalDataGridViewTextBoxColumn1.HeaderText = "Bodovi";
            this.totalDataGridViewTextBoxColumn1.MinimumWidth = 60;
            this.totalDataGridViewTextBoxColumn1.Name = "totalDataGridViewTextBoxColumn1";
            this.totalDataGridViewTextBoxColumn1.Width = 60;
            // 
            // teamidDataGridViewTextBoxColumn1
            // 
            this.teamidDataGridViewTextBoxColumn1.DataPropertyName = "team_id";
            this.teamidDataGridViewTextBoxColumn1.HeaderText = "team_id";
            this.teamidDataGridViewTextBoxColumn1.Name = "teamidDataGridViewTextBoxColumn1";
            this.teamidDataGridViewTextBoxColumn1.ReadOnly = true;
            this.teamidDataGridViewTextBoxColumn1.Visible = false;
            // 
            // roundidDataGridViewTextBoxColumn
            // 
            this.roundidDataGridViewTextBoxColumn.DataPropertyName = "round_id";
            this.roundidDataGridViewTextBoxColumn.HeaderText = "round_id";
            this.roundidDataGridViewTextBoxColumn.Name = "roundidDataGridViewTextBoxColumn";
            this.roundidDataGridViewTextBoxColumn.ReadOnly = true;
            this.roundidDataGridViewTextBoxColumn.Visible = false;
            // 
            // deletedDataGridViewTextBoxColumn1
            // 
            this.deletedDataGridViewTextBoxColumn1.DataPropertyName = "deleted";
            this.deletedDataGridViewTextBoxColumn1.HeaderText = "deleted";
            this.deletedDataGridViewTextBoxColumn1.Name = "deletedDataGridViewTextBoxColumn1";
            this.deletedDataGridViewTextBoxColumn1.ReadOnly = true;
            this.deletedDataGridViewTextBoxColumn1.Visible = false;
            // 
            // roundDataGridViewTextBoxColumn
            // 
            this.roundDataGridViewTextBoxColumn.DataPropertyName = "round";
            this.roundDataGridViewTextBoxColumn.HeaderText = "round";
            this.roundDataGridViewTextBoxColumn.Name = "roundDataGridViewTextBoxColumn";
            this.roundDataGridViewTextBoxColumn.ReadOnly = true;
            this.roundDataGridViewTextBoxColumn.Visible = false;
            // 
            // teamroundBindingSource
            // 
            this.teamroundBindingSource.DataSource = typeof(Quizzy.Model.team_round);
            // 
            // teamDataGridViewTextBoxColumn
            // 
            this.teamDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.teamDataGridViewTextBoxColumn.DataPropertyName = "team";
            this.teamDataGridViewTextBoxColumn.HeaderText = "Naziv tima";
            this.teamDataGridViewTextBoxColumn.Name = "teamDataGridViewTextBoxColumn";
            this.teamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.FillWeight = 69F;
            this.totalDataGridViewTextBoxColumn.HeaderText = "Bodovi";
            this.totalDataGridViewTextBoxColumn.MinimumWidth = 60;
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalDataGridViewTextBoxColumn.Width = 60;
            // 
            // seasonidDataGridViewTextBoxColumn
            // 
            this.seasonidDataGridViewTextBoxColumn.DataPropertyName = "season_id";
            this.seasonidDataGridViewTextBoxColumn.HeaderText = "season_id";
            this.seasonidDataGridViewTextBoxColumn.Name = "seasonidDataGridViewTextBoxColumn";
            this.seasonidDataGridViewTextBoxColumn.ReadOnly = true;
            this.seasonidDataGridViewTextBoxColumn.Visible = false;
            // 
            // teamidDataGridViewTextBoxColumn
            // 
            this.teamidDataGridViewTextBoxColumn.DataPropertyName = "team_id";
            this.teamidDataGridViewTextBoxColumn.HeaderText = "team_id";
            this.teamidDataGridViewTextBoxColumn.Name = "teamidDataGridViewTextBoxColumn";
            this.teamidDataGridViewTextBoxColumn.ReadOnly = true;
            this.teamidDataGridViewTextBoxColumn.Visible = false;
            // 
            // deletedDataGridViewTextBoxColumn
            // 
            this.deletedDataGridViewTextBoxColumn.DataPropertyName = "deleted";
            this.deletedDataGridViewTextBoxColumn.HeaderText = "deleted";
            this.deletedDataGridViewTextBoxColumn.Name = "deletedDataGridViewTextBoxColumn";
            this.deletedDataGridViewTextBoxColumn.ReadOnly = true;
            this.deletedDataGridViewTextBoxColumn.Visible = false;
            // 
            // seasonDataGridViewTextBoxColumn
            // 
            this.seasonDataGridViewTextBoxColumn.DataPropertyName = "season";
            this.seasonDataGridViewTextBoxColumn.HeaderText = "season";
            this.seasonDataGridViewTextBoxColumn.Name = "seasonDataGridViewTextBoxColumn";
            this.seasonDataGridViewTextBoxColumn.ReadOnly = true;
            this.seasonDataGridViewTextBoxColumn.Visible = false;
            // 
            // seasonhasteamBindingSource
            // 
            this.seasonhasteamBindingSource.DataSource = typeof(Quizzy.Model.season_has_team);
            // 
            // questionsView
            // 
            this.questionsView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.questionsView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(61)))));
            this.questionsView.Database = null;
            this.questionsView.Location = new System.Drawing.Point(0, 41);
            this.questionsView.Name = "questionsView";
            this.questionsView.Size = new System.Drawing.Size(882, 558);
            this.questionsView.TabIndex = 6;
            // 
            // UpCln
            // 
            this.UpCln.FillWeight = 38F;
            this.UpCln.HeaderText = "";
            this.UpCln.Image = global::Quizzy.Properties.Resources.plus;
            this.UpCln.MinimumWidth = 38;
            this.UpCln.Name = "UpCln";
            this.UpCln.ReadOnly = true;
            this.UpCln.Width = 38;
            // 
            // questionnumberDataGridViewTextBoxColumn
            // 
            this.questionnumberDataGridViewTextBoxColumn.DataPropertyName = "question_number";
            this.questionnumberDataGridViewTextBoxColumn.FillWeight = 60F;
            this.questionnumberDataGridViewTextBoxColumn.HeaderText = "Broj";
            this.questionnumberDataGridViewTextBoxColumn.MinimumWidth = 60;
            this.questionnumberDataGridViewTextBoxColumn.Name = "questionnumberDataGridViewTextBoxColumn";
            this.questionnumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.questionnumberDataGridViewTextBoxColumn.Width = 60;
            // 
            // DownCln
            // 
            this.DownCln.FillWeight = 38F;
            this.DownCln.HeaderText = "";
            this.DownCln.Image = global::Quizzy.Properties.Resources.minus;
            this.DownCln.MinimumWidth = 38;
            this.DownCln.Name = "DownCln";
            this.DownCln.ReadOnly = true;
            this.DownCln.Width = 38;
            // 
            // questionDataGridViewTextBoxColumn
            // 
            this.questionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.questionDataGridViewTextBoxColumn.DataPropertyName = "question";
            this.questionDataGridViewTextBoxColumn.HeaderText = "Pitanje";
            this.questionDataGridViewTextBoxColumn.Name = "questionDataGridViewTextBoxColumn";
            this.questionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // AnswerCln
            // 
            this.AnswerCln.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AnswerCln.HeaderText = "Odgovor";
            this.AnswerCln.Name = "AnswerCln";
            this.AnswerCln.ReadOnly = true;
            // 
            // YoutubeCln
            // 
            this.YoutubeCln.FillWeight = 38F;
            this.YoutubeCln.HeaderText = "YT";
            this.YoutubeCln.MinimumWidth = 38;
            this.YoutubeCln.Name = "YoutubeCln";
            this.YoutubeCln.ReadOnly = true;
            this.YoutubeCln.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.YoutubeCln.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.YoutubeCln.Width = 38;
            // 
            // DeleteCln
            // 
            this.DeleteCln.FillWeight = 38F;
            this.DeleteCln.HeaderText = "";
            this.DeleteCln.MinimumWidth = 38;
            this.DeleteCln.Name = "DeleteCln";
            this.DeleteCln.ReadOnly = true;
            this.DeleteCln.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DeleteCln.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DeleteCln.Width = 38;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // questionidDataGridViewTextBoxColumn
            // 
            this.questionidDataGridViewTextBoxColumn.DataPropertyName = "question_id";
            this.questionidDataGridViewTextBoxColumn.HeaderText = "question_id";
            this.questionidDataGridViewTextBoxColumn.Name = "questionidDataGridViewTextBoxColumn";
            this.questionidDataGridViewTextBoxColumn.ReadOnly = true;
            this.questionidDataGridViewTextBoxColumn.Visible = false;
            // 
            // roundidDataGridViewTextBoxColumn1
            // 
            this.roundidDataGridViewTextBoxColumn1.DataPropertyName = "round_id";
            this.roundidDataGridViewTextBoxColumn1.HeaderText = "round_id";
            this.roundidDataGridViewTextBoxColumn1.Name = "roundidDataGridViewTextBoxColumn1";
            this.roundidDataGridViewTextBoxColumn1.ReadOnly = true;
            this.roundidDataGridViewTextBoxColumn1.Visible = false;
            // 
            // deletedDataGridViewTextBoxColumn2
            // 
            this.deletedDataGridViewTextBoxColumn2.DataPropertyName = "deleted";
            this.deletedDataGridViewTextBoxColumn2.HeaderText = "deleted";
            this.deletedDataGridViewTextBoxColumn2.Name = "deletedDataGridViewTextBoxColumn2";
            this.deletedDataGridViewTextBoxColumn2.ReadOnly = true;
            this.deletedDataGridViewTextBoxColumn2.Visible = false;
            // 
            // roundDataGridViewTextBoxColumn1
            // 
            this.roundDataGridViewTextBoxColumn1.DataPropertyName = "round";
            this.roundDataGridViewTextBoxColumn1.HeaderText = "round";
            this.roundDataGridViewTextBoxColumn1.Name = "roundDataGridViewTextBoxColumn1";
            this.roundDataGridViewTextBoxColumn1.ReadOnly = true;
            this.roundDataGridViewTextBoxColumn1.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(884, 600);
            this.Controls.Add(this.lblPlaces);
            this.Controls.Add(this.btnAddTeam);
            this.Controls.Add(this.btnAddQuestion);
            this.Controls.Add(this.btnQuestions);
            this.Controls.Add(this.btnTeams);
            this.Controls.Add(this.dtQuestions);
            this.Controls.Add(this.dtTeams);
            this.Controls.Add(this.dtSeasonTeams);
            this.Controls.Add(this.seasonTreeView);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.questionsView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtTeams)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtQuestions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSeasonTeams)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundquestionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamroundBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seasonhasteamBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.TreeView seasonTreeView;
        private System.Windows.Forms.Button btnTeams;
        private System.Windows.Forms.Button btnQuestions;
        private System.Windows.Forms.BindingSource teamroundBindingSource;
        private System.Windows.Forms.BindingSource seasonhasteamBindingSource;
        private System.Windows.Forms.BindingSource roundquestionBindingSource;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.Button btnAddTeam;
        private System.Windows.Forms.Label lblPlaces;
        private System.Windows.Forms.Button btnQuiz;
        private System.Windows.Forms.Button btnQuestion;
        private System.Windows.Forms.DataGridView dtTeams;
        private System.Windows.Forms.DataGridView dtQuestions;
        private System.Windows.Forms.DataGridView dtSeasonTeams;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeasonCountCln;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seasonidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deletedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seasonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamCountCln;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewImageColumn TeamDeleteCln;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn roundidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deletedDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn roundDataGridViewTextBoxColumn;
        private View.QuestionsView questionsViewcs1;
        private View.QuestionsView questionsView;
        private System.Windows.Forms.DataGridViewImageColumn UpCln;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn DownCln;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnswerCln;
        private System.Windows.Forms.DataGridViewImageColumn YoutubeCln;
        private System.Windows.Forms.DataGridViewImageColumn DeleteCln;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roundidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn deletedDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn roundDataGridViewTextBoxColumn1;
    }
}

