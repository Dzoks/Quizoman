namespace Quizoman
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
            this.sidePanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTabQuestion = new System.Windows.Forms.Button();
            this.btnTabTeam = new System.Windows.Forms.Button();
            this.btnTabQuiz = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.sidePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(61)))));
            this.sidePanel.Controls.Add(this.panel1);
            this.sidePanel.Controls.Add(this.btnTabQuestion);
            this.sidePanel.Controls.Add(this.btnTabTeam);
            this.sidePanel.Controls.Add(this.btnTabQuiz);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(1, 1);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(200, 640);
            this.sidePanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 41);
            this.panel1.TabIndex = 3;
            this.panel1.DoubleClick += new System.EventHandler(this.topPanel_DoubleClick);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragWindow);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(45, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quizzy";
            this.label1.DoubleClick += new System.EventHandler(this.topPanel_DoubleClick);
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragWindow);
            // 
            // btnTabQuestion
            // 
            this.btnTabQuestion.FlatAppearance.BorderSize = 0;
            this.btnTabQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabQuestion.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTabQuestion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnTabQuestion.Location = new System.Drawing.Point(0, 238);
            this.btnTabQuestion.Name = "btnTabQuestion";
            this.btnTabQuestion.Size = new System.Drawing.Size(200, 100);
            this.btnTabQuestion.TabIndex = 2;
            this.btnTabQuestion.Text = "Pitanja";
            this.btnTabQuestion.UseVisualStyleBackColor = true;
            this.btnTabQuestion.Click += new System.EventHandler(this.btnTabQuestion_Click);
            // 
            // btnTabTeam
            // 
            this.btnTabTeam.FlatAppearance.BorderSize = 0;
            this.btnTabTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabTeam.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTabTeam.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnTabTeam.Location = new System.Drawing.Point(0, 138);
            this.btnTabTeam.Name = "btnTabTeam";
            this.btnTabTeam.Size = new System.Drawing.Size(200, 100);
            this.btnTabTeam.TabIndex = 1;
            this.btnTabTeam.Text = "Timovi";
            this.btnTabTeam.UseVisualStyleBackColor = true;
            this.btnTabTeam.Click += new System.EventHandler(this.btnTabTeam_Click);
            // 
            // btnTabQuiz
            // 
            this.btnTabQuiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.btnTabQuiz.FlatAppearance.BorderSize = 0;
            this.btnTabQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabQuiz.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTabQuiz.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnTabQuiz.Location = new System.Drawing.Point(0, 38);
            this.btnTabQuiz.Name = "btnTabQuiz";
            this.btnTabQuiz.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnTabQuiz.Size = new System.Drawing.Size(200, 100);
            this.btnTabQuiz.TabIndex = 0;
            this.btnTabQuiz.Text = "Kvizovi";
            this.btnTabQuiz.UseVisualStyleBackColor = false;
            this.btnTabQuiz.Click += new System.EventHandler(this.btnTabQuiz_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(201, 1);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(798, 640);
            this.mainPanel.TabIndex = 1;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(64)))));
            this.topPanel.Controls.Add(this.btnMinimize);
            this.topPanel.Controls.Add(this.btnMaximize);
            this.topPanel.Controls.Add(this.btnClose);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(201, 1);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(798, 42);
            this.topPanel.TabIndex = 2;
            this.topPanel.DoubleClick += new System.EventHandler(this.topPanel_DoubleClick);
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragWindow);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BackgroundImage = global::Quizoman.Properties.Resources.minimize;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(700, 0);
            this.btnMinimize.MaximumSize = new System.Drawing.Size(36, 36);
            this.btnMinimize.MinimumSize = new System.Drawing.Size(36, 36);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(36, 36);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.BackgroundImage = global::Quizoman.Properties.Resources.maximize;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Location = new System.Drawing.Point(733, 4);
            this.btnMaximize.MaximumSize = new System.Drawing.Size(36, 36);
            this.btnMaximize.MinimumSize = new System.Drawing.Size(36, 36);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(36, 36);
            this.btnMaximize.TabIndex = 1;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::Quizoman.Properties.Resources.close;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(766, 3);
            this.btnClose.MaximumSize = new System.Drawing.Size(36, 36);
            this.btnClose.MinimumSize = new System.Drawing.Size(36, 36);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 36);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(1000, 642);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.sidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.sidePanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button btnTabQuestion;
        private System.Windows.Forms.Button btnTabTeam;
        private System.Windows.Forms.Button btnTabQuiz;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}

