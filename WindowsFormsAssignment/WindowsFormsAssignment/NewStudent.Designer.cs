namespace WindowsFormsAssignment
{
    partial class NewStudent
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
            this.partTimeRadio = new System.Windows.Forms.RadioButton();
            this.fullTimeRadio = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.studentIdTextField = new System.Windows.Forms.TextBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.deptComboBox = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // partTimeRadio
            // 
            this.partTimeRadio.AutoSize = true;
            this.partTimeRadio.Location = new System.Drawing.Point(459, 233);
            this.partTimeRadio.Name = "partTimeRadio";
            this.partTimeRadio.Size = new System.Drawing.Size(70, 17);
            this.partTimeRadio.TabIndex = 27;
            this.partTimeRadio.TabStop = true;
            this.partTimeRadio.Text = "Part Time";
            this.partTimeRadio.UseVisualStyleBackColor = true;
            // 
            // fullTimeRadio
            // 
            this.fullTimeRadio.AutoSize = true;
            this.fullTimeRadio.Location = new System.Drawing.Point(335, 233);
            this.fullTimeRadio.Name = "fullTimeRadio";
            this.fullTimeRadio.Size = new System.Drawing.Size(67, 17);
            this.fullTimeRadio.TabIndex = 26;
            this.fullTimeRadio.TabStop = true;
            this.fullTimeRadio.Text = "Full Time";
            this.fullTimeRadio.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Enrollment Type";
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(335, 109);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(194, 20);
            this.firstNameText.TabIndex = 24;
            this.firstNameText.TextChanged += new System.EventHandler(this.firstNameText_TextChanged);
            // 
            // studentIdTextField
            // 
            this.studentIdTextField.Location = new System.Drawing.Point(335, 69);
            this.studentIdTextField.Name = "studentIdTextField";
            this.studentIdTextField.Size = new System.Drawing.Size(194, 20);
            this.studentIdTextField.TabIndex = 23;
            this.studentIdTextField.TextChanged += new System.EventHandler(this.studentIdTextField_TextChanged);
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(335, 146);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(194, 20);
            this.lastNameText.TabIndex = 22;
            this.lastNameText.TextChanged += new System.EventHandler(this.lastNameText_TextChanged);
            // 
            // deptComboBox
            // 
            this.deptComboBox.FormattingEnabled = true;
            this.deptComboBox.Location = new System.Drawing.Point(335, 188);
            this.deptComboBox.Name = "deptComboBox";
            this.deptComboBox.Size = new System.Drawing.Size(194, 21);
            this.deptComboBox.TabIndex = 21;
            this.deptComboBox.SelectedIndexChanged += new System.EventHandler(this.deptComboBox_SelectedIndexChanged);
            // 
            // addButton
            // 
            this.addButton.Enabled = false;
            this.addButton.Location = new System.Drawing.Point(221, 276);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(121, 28);
            this.addButton.TabIndex = 18;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Department";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "LastName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "FirstName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Student Id";
            // 
            // resetButton
            // 
            this.resetButton.Enabled = false;
            this.resetButton.Location = new System.Drawing.Point(408, 276);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(121, 28);
            this.resetButton.TabIndex = 28;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // NewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 442);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.partTimeRadio);
            this.Controls.Add(this.fullTimeRadio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.studentIdTextField);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.deptComboBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewStudent";
            this.Text = "NewStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton partTimeRadio;
        private System.Windows.Forms.RadioButton fullTimeRadio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.TextBox studentIdTextField;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.ComboBox deptComboBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button resetButton;
    }
}