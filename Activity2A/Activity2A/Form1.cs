using Activity2A.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Activity2A
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int input))
            {
            }
            else
            {
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // Ensures the program fully terminates
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int input))
            {
                submitButton.Enabled = input >= 0 && input <= 12;
            }
            else
            {
                submitButton.Enabled = false;
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Input cannot be empty. Please enter a number between 0 and 12.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return; 
            }


            string[] rules = {
                    "1. Maintain silence, proper decorum, and discipline inside the laboratory. Mobile phones, walkmans, and other personal pieces of equipment must be switched off.",
                    "2. Games are not allowed inside the lab. This includes computer-related games, card games, and other games that may disturb the operation of the lab.",
                    "3. Surfing the Internet is allowed only with the permission of the instructor. Downloading and installing of software are strictly prohibited.",
                    "4. Getting access to other websites not related to the course (especially pornographic and illicit sites) is strictly prohibited.",
                    "5. Deleting computer files and changing the set-up of the computer is a major offense.",
                    "6. Observe computer time usage carefully. A fifteen-minute allowance is given for each use. Otherwise, the unit will be given to those who wish to 'sit-in'.",
                    $"7. Observe proper decorum while inside the laboratory.\r\na. Do not get inside the lab unless the instructor is present.\r\nb. All bags, knapsacks, and the likes must be deposited at the counter.\r\nc. Follow the seating arrangement of your instructor.\r\nd. At the end of class, all software programs must be closed.\r\ne. Return all chairs to their proper places after using.",
                    "8. Chewing gum, eating, drinking, smoking, and other forms of vandalism are prohibited inside the lab.",
                    "9. Anyone causing a continual disturbance will be asked to leave the lab. Acts or gestures offensive to the members of the community, including public display of physical intimacy, are not tolerated.",
                    "10. Persons exhibiting hostile or threatening behavior such as yelling, swearing, or disregarding requests made by lab personnel will be asked to leave the lab.",
                    "11. For serious offenses, the lab personnel may call the Civil Security Office (CSU) for assistance.",
                    "12. Any technical problem or difficulty must be addressed to the laboratory supervisor, student assistant, or instructor immediately."
                };
            Form2 resultForm = new Form2(this);
            int rule = int.Parse(textBox1.Text);
            resultForm.Show();
            
            if (rule != 7)
                resultForm.ruleLabel.Location = new System.Drawing.Point(8, 50);
            resultForm.ruleNumberLabel.Text = $"Rule {textBox1.Text}";
            resultForm.ruleLabel.Text = rules[rule - 1];


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
