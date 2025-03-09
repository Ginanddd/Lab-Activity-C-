using System.Windows.Forms;

namespace Activity2B
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.container = new System.Windows.Forms.Panel();
            this.inputField = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.textBoxContainer = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.container.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(24, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 53);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Activity 2B";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.container);
            this.panel2.Controls.Add(this.submitButton);
            this.panel2.Controls.Add(this.textBoxContainer);
            this.panel2.Location = new System.Drawing.Point(119, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(545, 278);
            this.panel2.TabIndex = 1;
            // 
            // container
            // 
            this.container.BackColor = System.Drawing.SystemColors.Window;
            this.container.Controls.Add(this.inputField);
            this.container.Location = new System.Drawing.Point(99, 90);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(340, 38);
            this.container.TabIndex = 3;
            // 
            // inputField
            // 
            this.inputField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputField.Location = new System.Drawing.Point(7, 11);
            this.inputField.Name = "inputField";
            this.inputField.Size = new System.Drawing.Size(330, 15);
            this.inputField.TabIndex = 0;
            this.inputField.TextChanged += new System.EventHandler(this.inputHandler);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(197, 151);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(114, 48);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.buttonHandler);
            // 
            // textBoxContainer
            // 
            this.textBoxContainer.AutoSize = true;
            this.textBoxContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContainer.Location = new System.Drawing.Point(193, 46);
            this.textBoxContainer.Name = "textBoxContainer";
            this.textBoxContainer.Size = new System.Drawing.Size(118, 29);
            this.textBoxContainer.TabIndex = 0;
            this.textBoxContainer.Text = "Question";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.container.ResumeLayout(false);
            this.container.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label textBoxContainer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private Button submitButton;
        private Panel container;
        private TextBox inputField;
    }
}

