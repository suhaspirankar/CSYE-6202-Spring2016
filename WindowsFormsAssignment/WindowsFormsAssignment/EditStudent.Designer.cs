﻿namespace WindowsFormsAssignment
{
    partial class EditStudent
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.partTimeRadio = new System.Windows.Forms.RadioButton();
            this.fullTimeRadio = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.studentIdTextField = new System.Windows.Forms.TextBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.deptComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(428, 298);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 28);
            this.button2.TabIndex = 54;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 28);
            this.button1.TabIndex = 46;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // partTimeRadio
            // 
            this.partTimeRadio.AutoSize = true;
            this.partTimeRadio.Location = new System.Drawing.Point(491, 259);
            this.partTimeRadio.Name = "partTimeRadio";
            this.partTimeRadio.Size = new System.Drawing.Size(70, 17);
            this.partTimeRadio.TabIndex = 65;
            this.partTimeRadio.TabStop = true;
            this.partTimeRadio.Text = "Part Time";
            this.partTimeRadio.UseVisualStyleBackColor = true;
            // 
            // fullTimeRadio
            // 
            this.fullTimeRadio.AutoSize = true;
            this.fullTimeRadio.Location = new System.Drawing.Point(367, 259);
            this.fullTimeRadio.Name = "fullTimeRadio";
            this.fullTimeRadio.Size = new System.Drawing.Size(67, 17);
            this.fullTimeRadio.TabIndex = 64;
            this.fullTimeRadio.TabStop = true;
            this.fullTimeRadio.Text = "Full Time";
            this.fullTimeRadio.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 63;
            this.label5.Text = "Enrollment Type";
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(367, 135);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(194, 20);
            this.firstNameText.TabIndex = 62;
            // 
            // studentIdTextField
            // 
            this.studentIdTextField.Location = new System.Drawing.Point(367, 95);
            this.studentIdTextField.Name = "studentIdTextField";
            this.studentIdTextField.Size = new System.Drawing.Size(194, 20);
            this.studentIdTextField.TabIndex = 61;
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(367, 172);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(194, 20);
            this.lastNameText.TabIndex = 60;
            // 
            // deptComboBox
            // 
            this.deptComboBox.FormattingEnabled = true;
            this.deptComboBox.Location = new System.Drawing.Point(367, 214);
            this.deptComboBox.Name = "deptComboBox";
            this.deptComboBox.Size = new System.Drawing.Size(194, 21);
            this.deptComboBox.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 58;
            this.label4.Text = "Department";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "LastName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "FirstName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Student Id";
            // 
            // EditStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 416);
            this.Controls.Add(this.partTimeRadio);
            this.Controls.Add(this.fullTimeRadio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.studentIdTextField);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.deptComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "EditStudent";
            this.Text = "EditStudent";
            this.Load += new System.EventHandler(this.EditStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton partTimeRadio;
        private System.Windows.Forms.RadioButton fullTimeRadio;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.TextBox studentIdTextField;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.ComboBox deptComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}