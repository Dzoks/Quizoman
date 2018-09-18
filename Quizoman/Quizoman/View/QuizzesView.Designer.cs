namespace Quizoman.View
{
    partial class QuizzesView
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
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node2");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Harroo", new System.Windows.Forms.TreeNode[] {
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Howdy");
            this.treeViewSeasons = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // treeViewSeasons
            // 
            this.treeViewSeasons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeViewSeasons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.treeViewSeasons.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeViewSeasons.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewSeasons.ForeColor = System.Drawing.Color.White;
            this.treeViewSeasons.Indent = 20;
            this.treeViewSeasons.ItemHeight = 60;
            this.treeViewSeasons.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(87)))));
            this.treeViewSeasons.Location = new System.Drawing.Point(20, 40);
            this.treeViewSeasons.Name = "treeViewSeasons";
            treeNode4.Name = "Mac";
            treeNode4.Text = "Node2";
            treeNode5.Name = "Hello";
            treeNode5.Text = "Harroo";
            treeNode6.Name = "Node1";
            treeNode6.Text = "Howdy";
            this.treeViewSeasons.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
            this.treeViewSeasons.Size = new System.Drawing.Size(280, 577);
            this.treeViewSeasons.TabIndex = 1;
            this.treeViewSeasons.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeViewSeasons_BeforeExpand);
            this.treeViewSeasons.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewSeasons_NodeMouseClick);
            this.treeViewSeasons.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewSeasons_NodeMouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(69)))));
            this.panel1.Location = new System.Drawing.Point(304, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 577);
            this.panel1.TabIndex = 2;
            // 
            // QuizzesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.treeViewSeasons);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "QuizzesView";
            this.Size = new System.Drawing.Size(800, 640);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView treeViewSeasons;
        private System.Windows.Forms.Panel panel1;
    }
}
