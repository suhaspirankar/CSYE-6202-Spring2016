namespace FinalProject.View
{
    partial class unBookFlight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(unBookFlight));
            this.label1 = new System.Windows.Forms.Label();
            this.flightTable = new System.Windows.Forms.DataGridView();
            this.unBookFlightButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.flightTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "List of your Book flights";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // flightTable
            // 
            this.flightTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flightTable.Location = new System.Drawing.Point(46, 55);
            this.flightTable.Name = "flightTable";
            this.flightTable.Size = new System.Drawing.Size(735, 150);
            this.flightTable.TabIndex = 4;
            this.flightTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.flightTable_CellContentClick);
            // 
            // unBookFlightButton
            // 
            this.unBookFlightButton.Location = new System.Drawing.Point(340, 252);
            this.unBookFlightButton.Name = "unBookFlightButton";
            this.unBookFlightButton.Size = new System.Drawing.Size(173, 32);
            this.unBookFlightButton.TabIndex = 5;
            this.unBookFlightButton.Text = "UnBook Flight";
            this.unBookFlightButton.UseVisualStyleBackColor = true;
            this.unBookFlightButton.Click += new System.EventHandler(this.unBookFlightButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 472);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // unBookFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(949, 609);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.unBookFlightButton);
            this.Controls.Add(this.flightTable);
            this.Controls.Add(this.label1);
            this.Name = "unBookFlight";
            this.Text = " ";
            this.Load += new System.EventHandler(this.unBookFlight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flightTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView flightTable;
        private System.Windows.Forms.Button unBookFlightButton;
        private System.Windows.Forms.Button button1;
    }
}