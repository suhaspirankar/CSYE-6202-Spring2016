namespace FinalProject.View
{
    partial class AddFlight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFlight));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.flightNameTextBox = new System.Windows.Forms.TextBox();
            this.carrierTextBox = new System.Windows.Forms.TextBox();
            this.addFlightButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.departureTextBox = new System.Windows.Forms.TextBox();
            this.destinationTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TimeCombo1 = new System.Windows.Forms.ComboBox();
            this.TimeCombo2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FLight Name";
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Departure Date";
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Arrival Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(407, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Carrier";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.AllowDrop = true;
            this.dateTimePicker1.Location = new System.Drawing.Point(114, 213);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(180, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.AllowDrop = true;
            this.dateTimePicker2.Location = new System.Drawing.Point(114, 287);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(180, 20);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // flightNameTextBox
            // 
            this.flightNameTextBox.AllowDrop = true;
            this.flightNameTextBox.Location = new System.Drawing.Point(114, 163);
            this.flightNameTextBox.Name = "flightNameTextBox";
            this.flightNameTextBox.Size = new System.Drawing.Size(180, 20);
            this.flightNameTextBox.TabIndex = 8;
            // 
            // carrierTextBox
            // 
            this.carrierTextBox.Location = new System.Drawing.Point(502, 251);
            this.carrierTextBox.Name = "carrierTextBox";
            this.carrierTextBox.Size = new System.Drawing.Size(200, 20);
            this.carrierTextBox.TabIndex = 9;
            // 
            // addFlightButton
            // 
            this.addFlightButton.Location = new System.Drawing.Point(469, 409);
            this.addFlightButton.Name = "addFlightButton";
            this.addFlightButton.Size = new System.Drawing.Size(161, 34);
            this.addFlightButton.TabIndex = 10;
            this.addFlightButton.Text = "Submit";
            this.addFlightButton.UseVisualStyleBackColor = true;
            this.addFlightButton.Click += new System.EventHandler(this.addFlightButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(350, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Add FLight";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(77, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(407, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Departure ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(407, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Destination";
            // 
            // departureTextBox
            // 
            this.departureTextBox.Location = new System.Drawing.Point(502, 170);
            this.departureTextBox.Name = "departureTextBox";
            this.departureTextBox.Size = new System.Drawing.Size(200, 20);
            this.departureTextBox.TabIndex = 15;
            // 
            // destinationTextBox
            // 
            this.destinationTextBox.Location = new System.Drawing.Point(502, 207);
            this.destinationTextBox.Name = "destinationTextBox";
            this.destinationTextBox.Size = new System.Drawing.Size(200, 20);
            this.destinationTextBox.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AllowDrop = true;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Departure Time";
            // 
            // label9
            // 
            this.label9.AllowDrop = true;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 337);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Arrival Time";
            // 
            // TimeCombo1
            // 
            this.TimeCombo1.AllowDrop = true;
            this.TimeCombo1.FormattingEnabled = true;
            this.TimeCombo1.Location = new System.Drawing.Point(114, 249);
            this.TimeCombo1.Name = "TimeCombo1";
            this.TimeCombo1.Size = new System.Drawing.Size(180, 21);
            this.TimeCombo1.TabIndex = 19;
            // 
            // TimeCombo2
            // 
            this.TimeCombo2.AllowDrop = true;
            this.TimeCombo2.FormattingEnabled = true;
            this.TimeCombo2.Location = new System.Drawing.Point(114, 329);
            this.TimeCombo2.Name = "TimeCombo2";
            this.TimeCombo2.Size = new System.Drawing.Size(180, 21);
            this.TimeCombo2.TabIndex = 20;
            // 
            // AddFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(778, 516);
            this.Controls.Add(this.TimeCombo2);
            this.Controls.Add(this.TimeCombo1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.destinationTextBox);
            this.Controls.Add(this.departureTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addFlightButton);
            this.Controls.Add(this.carrierTextBox);
            this.Controls.Add(this.flightNameTextBox);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddFlight";
            this.Text = "AddFlight";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox flightNameTextBox;
        private System.Windows.Forms.TextBox carrierTextBox;
        private System.Windows.Forms.Button addFlightButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox departureTextBox;
        private System.Windows.Forms.TextBox destinationTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox TimeCombo1;
        private System.Windows.Forms.ComboBox TimeCombo2;
    }
}