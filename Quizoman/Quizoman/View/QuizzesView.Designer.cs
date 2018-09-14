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
            this.Kvizovi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Kvizovi
            // 
            this.Kvizovi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Kvizovi.AutoSize = true;
            this.Kvizovi.Location = new System.Drawing.Point(59, 53);
            this.Kvizovi.Name = "Kvizovi";
            this.Kvizovi.Size = new System.Drawing.Size(41, 13);
            this.Kvizovi.TabIndex = 0;
            this.Kvizovi.Text = "Kvizovi";
            // 
            // QuizzesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.Controls.Add(this.Kvizovi);
            this.Name = "QuizzesView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Kvizovi;
    }
}
