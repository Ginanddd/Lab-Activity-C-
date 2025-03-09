using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Activity2B
{
    public partial class Form1 : Form
    {
        private Data data = new Data();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            submitButton.Enabled = false; 
        }

        private void inputHandler(object sender, EventArgs e)
        {
            string input = GetInput(); 

            submitButton.Enabled = !string.IsNullOrEmpty(input);
        }

        private void buttonHandler(object sender, EventArgs e)
        {
            string key = GetInput();

            string output = data.GetData(key);

            MessageBox.Show((output ?? "Invalid Input"),  "Answer");
        }

        private string GetInput()
        {
            return inputField.Text.Trim().ToLower();
        }
    }
}
