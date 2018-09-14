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
            this.Pitanja = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Pitanja
            // 
            this.Pitanja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Pitanja.AutoSize = true;
            this.Pitanja.Location = new System.Drawing.Point(51, 68);
            this.Pitanja.Name = "Pitanja";
            this.Pitanja.Size = new System.Drawing.Size(39, 13);
            this.Pitanja.TabIndex = 0;
            this.Pitanja.Text = "Pitanja";
            // 
            // QuestionsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.Controls.Add(this.Pitanja);
            this.Name = "QuestionsView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Pitanja;
    }
}
