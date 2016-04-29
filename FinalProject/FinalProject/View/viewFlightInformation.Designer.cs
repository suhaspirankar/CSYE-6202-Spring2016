namespace FinalProject.View
{
    partial class ViewFlightInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewFlightInformation));
            this.label1 = new System.Windows.Forms.Label();
            this.flight_IdTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listOfPassengers = new System.Windows.Forms.DataGridView();
            this.PassengersLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.carrierInformationTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listOfFlightCrew = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listOfPassengers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listOfFlightCrew)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter FLight ID";
            // 
            // flight_IdTextBox
            // 
            this.flight_IdTextBox.Location = new System.Drawing.Point(178, 86);
            this.flight_IdTextBox.Multiline = true;
            this.flight_IdTextBox.Name = "flight_IdTextBox";
            this.flight_IdTextBox.Size = new System.Drawing.Size(200, 25);
            this.flight_IdTextBox.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(484, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 53);
            this.button1.TabIndex = 3;
            this.button1.Text = "Get Flight Info";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listOfPassengers
            // 
            this.listOfPassengers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listOfPassengers.Location = new System.Drawing.Point(12, 410);
            this.listOfPassengers.Name = "listOfPassengers";
            this.listOfPassengers.Size = new System.Drawing.Size(834, 125);
            this.listOfPassengers.TabIndex = 4;
            this.listOfPassengers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listOfPassengers_CellContentClick);
            // 
            // PassengersLabel
            // 
            this.PassengersLabel.AutoSize = true;
            this.PassengersLabel.Location = new System.Drawing.Point(65, 381);
            this.PassengersLabel.Name = "PassengersLabel";
            this.PassengersLabel.Size = new System.Drawing.Size(93, 13);
            this.PassengersLabel.TabIndex = 5;
            this.PassengersLabel.Text = "List of Passengers";
            this.PassengersLabel.Click += new System.EventHandler(this.PassengersLabel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Flight Carrier";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // carrierInformationTextBox
            // 
            this.carrierInformationTextBox.Location = new System.Drawing.Point(178, 133);
            this.carrierInformationTextBox.Multiline = true;
            this.carrierInformationTextBox.Name = "carrierInformationTextBox";
            this.carrierInformationTextBox.Size = new System.Drawing.Size(200, 26);
            this.carrierInformationTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Flight Crew";
            // 
            // listOfFlightCrew
            // 
            this.listOfFlightCrew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listOfFlightCrew.Location = new System.Drawing.Point(12, 207);
            this.listOfFlightCrew.Name = "listOfFlightCrew";
            this.listOfFlightCrew.Size = new System.Drawing.Size(834, 150);
            this.listOfFlightCrew.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(338, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Flight Details";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(36, 605);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ViewFlightInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(910, 634);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listOfFlightCrew);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.carrierInformationTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PassengersLabel);
            this.Controls.Add(this.listOfPassengers);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flight_IdTextBox);
            this.Controls.Add(this.label1);
            this.Name = "ViewFlightInformation";
            this.Text = "viewFlightInformation";
            ((System.ComponentModel.ISupportInitialize)(this.listOfPassengers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listOfFlightCrew)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox flight_IdTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView listOfPassengers;
        private System.Windows.Forms.Label PassengersLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox carrierInformationTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView listOfFlightCrew;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
    }
}