namespace FinalProject.View
{
    partial class BookFlight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookFlight));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.bookFlightButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.idNumberTextBox = new System.Windows.Forms.TextBox();
            this.IdcomboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.classComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.calculatePrice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(354, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book FLight";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(56, 36);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(735, 150);
            this.dataGridView.TabIndex = 1;
            // 
            // bookFlightButton
            // 
            this.bookFlightButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bookFlightButton.Location = new System.Drawing.Point(357, 489);
            this.bookFlightButton.Name = "bookFlightButton";
            this.bookFlightButton.Size = new System.Drawing.Size(157, 38);
            this.bookFlightButton.TabIndex = 2;
            this.bookFlightButton.Text = "Book Flight";
            this.bookFlightButton.UseVisualStyleBackColor = true;
            this.bookFlightButton.Click += new System.EventHandler(this.bookFlightButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Customer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valid ID Type";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(340, 252);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(211, 20);
            this.customerNameTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Id Number";
            // 
            // idNumberTextBox
            // 
            this.idNumberTextBox.Location = new System.Drawing.Point(340, 350);
            this.idNumberTextBox.Name = "idNumberTextBox";
            this.idNumberTextBox.Size = new System.Drawing.Size(211, 20);
            this.idNumberTextBox.TabIndex = 8;
            // 
            // IdcomboBox
            // 
            this.IdcomboBox.FormattingEnabled = true;
            this.IdcomboBox.Location = new System.Drawing.Point(340, 298);
            this.IdcomboBox.Name = "IdcomboBox";
            this.IdcomboBox.Size = new System.Drawing.Size(211, 21);
            this.IdcomboBox.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 504);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // classComboBox
            // 
            this.classComboBox.FormattingEnabled = true;
            this.classComboBox.Location = new System.Drawing.Point(340, 395);
            this.classComboBox.Name = "classComboBox";
            this.classComboBox.Size = new System.Drawing.Size(211, 21);
            this.classComboBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(221, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Seat Class";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Enabled = false;
            this.priceTextBox.Location = new System.Drawing.Point(340, 441);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(211, 20);
            this.priceTextBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(224, 447);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Price";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // calculatePrice
            // 
            this.calculatePrice.Location = new System.Drawing.Point(610, 439);
            this.calculatePrice.Name = "calculatePrice";
            this.calculatePrice.Size = new System.Drawing.Size(137, 23);
            this.calculatePrice.TabIndex = 15;
            this.calculatePrice.Text = "Click to Calculate";
            this.calculatePrice.UseVisualStyleBackColor = true;
            this.calculatePrice.Click += new System.EventHandler(this.calculatePrice_Click);
            // 
            // BookFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(856, 567);
            this.Controls.Add(this.calculatePrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.classComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.IdcomboBox);
            this.Controls.Add(this.idNumberTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bookFlightButton);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label1);
            this.Name = "BookFlight";
            this.Text = "BookFlight";
            this.Load += new System.EventHandler(this.BookFlight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button bookFlightButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox idNumberTextBox;
        private System.Windows.Forms.ComboBox IdcomboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox classComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button calculatePrice;
    }
}