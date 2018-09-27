using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizzy.View
{
    public partial class AreYouSurePopup : Form
    {
        public bool Success { get; set; }
        private string message;
        public AreYouSurePopup(string message)
        {
            this.message = message;
            InitializeComponent();
            label1.Text = message;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            Success = true;
            Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
