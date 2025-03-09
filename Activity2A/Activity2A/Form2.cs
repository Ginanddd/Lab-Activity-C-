using System;
using System.Windows.Forms;

namespace Activity2A
{
    public partial class Form2 : Form
    {
        private Form1 form1Reference;

        public Form2(Form1 form1)
        {
            InitializeComponent();
            form1Reference = form1;  // Store the reference to Form1
            this.FormClosing += Form2_FormClosing;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            form1Reference.Show(); // Ensure Form1 is visible when Form2 closes
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ruleNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void ruleLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
