using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace Villegas_SEMIFINALACTIVITY1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetupValidation();
            SetupDateTimePicker();
        }

        private void SetupDateTimePicker()
        {
            dtpBirthday.Format = DateTimePickerFormat.Custom;
            dtpBirthday.CustomFormat = "MM/dd/yyyy";
            dtpBirthday.ShowUpDown = false;
            dtpBirthday.Value = DateTime.Today;
            dtpBirthday.MaxDate = DateTime.Today;
            dtpBirthday.MinDate = new DateTime(1900, 1, 1);
        }

        private void SetupValidation()
        {
            // ID Number - numbers only
            txtIdNumber.KeyPress += (sender, e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            };

            // First Name - allow letters and numbers
            txtFirstName.KeyPress += (sender, e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            };

            // Last Name - allow letters and numbers
            txtLastName.KeyPress += (sender, e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            };

            // Middle Name - allow letters and numbers
            txtMiddleName.KeyPress += (sender, e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            };

            // Year Level - numbers only
            txtYearLevel.KeyPress += (sender, e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            };

            // Save button click event
            btnSave.Click += BtnSave_Click;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                SaveStudentRecord();
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtIdNumber.Text))
            {
                MessageBox.Show("Please enter ID Number", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIdNumber.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("Please enter First Name", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirstName.Focus();
                return false;
            }

            if (!Regex.IsMatch(txtFirstName.Text, @"^[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("First Name should contain only letters and numbers", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirstName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Please enter Last Name", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLastName.Focus();
                return false;
            }

            if (!Regex.IsMatch(txtLastName.Text, @"^[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("Last Name should contain only letters and numbers", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLastName.Focus();
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtMiddleName.Text) && !Regex.IsMatch(txtMiddleName.Text, @"^[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("Middle Name should contain only letters and numbers", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMiddleName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCourse.Text))
            {
                MessageBox.Show("Please enter Course", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCourse.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtYearLevel.Text))
            {
                MessageBox.Show("Please enter Year Level", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtYearLevel.Focus();
                return false;
            }

            return true;
        }

        private void SaveStudentRecord()
        {
            try
            {
                StringBuilder record = new StringBuilder();
                record.AppendLine("ID Number: " + txtIdNumber.Text);
                record.AppendLine("First Name: " + txtFirstName.Text);
                record.AppendLine("Last Name: " + txtLastName.Text);
                record.AppendLine("Middle Name: " + (String.IsNullOrWhiteSpace(txtMiddleName.Text) ? "N/A" : txtMiddleName.Text));
                record.AppendLine("Course: " + txtCourse.Text);
                record.AppendLine("Year Level: " + txtYearLevel.Text);
                record.AppendLine("Birthday: " + dtpBirthday.Value.ToString("MM/dd/yyyy"));
                record.AppendLine("----------------------------------------");

                File.AppendAllText("student_record.txt", record.ToString());
                MessageBox.Show("Student record saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            txtIdNumber.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtMiddleName.Clear();
            txtCourse.Clear();
            txtYearLevel.Clear();
            dtpBirthday.Value = DateTime.Today;
            txtIdNumber.Focus();
        }
    }
}
