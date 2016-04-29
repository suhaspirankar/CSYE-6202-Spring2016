namespace FinalProject
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.viewFlightButton = new System.Windows.Forms.Button();
            this.bookFlight = new System.Windows.Forms.Button();
            this.unBookFlight = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.addFlightButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // viewFlightButton
            // 
            this.viewFlightButton.Location = new System.Drawing.Point(335, 98);
            this.viewFlightButton.Name = "viewFlightButton";
            this.viewFlightButton.Size = new System.Drawing.Size(291, 38);
            this.viewFlightButton.TabIndex = 0;
            this.viewFlightButton.Text = "View All Flights";
            this.viewFlightButton.UseVisualStyleBackColor = true;
            this.viewFlightButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // bookFlight
            // 
            this.bookFlight.Location = new System.Drawing.Point(335, 155);
            this.bookFlight.Name = "bookFlight";
            this.bookFlight.Size = new System.Drawing.Size(291, 36);
            this.bookFlight.TabIndex = 1;
            this.bookFlight.Text = "Book Flights";
            this.bookFlight.UseVisualStyleBackColor = true;
            this.bookFlight.Click += new System.EventHandler(this.bookFlight_Click);
            // 
            // unBookFlight
            // 
            this.unBookFlight.Location = new System.Drawing.Point(335, 209);
            this.unBookFlight.Name = "unBookFlight";
            this.unBookFlight.Size = new System.Drawing.Size(291, 34);
            this.unBookFlight.TabIndex = 2;
            this.unBookFlight.Text = "UnBook Flight";
            this.unBookFlight.UseVisualStyleBackColor = true;
            this.unBookFlight.Click += new System.EventHandler(this.unBookFlight_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(422, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Main Menu";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(291, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "View Flight Information";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // addFlightButton
            // 
            this.addFlightButton.Location = new System.Drawing.Point(335, 324);
            this.addFlightButton.Name = "addFlightButton";
            this.addFlightButton.Size = new System.Drawing.Size(291, 31);
            this.addFlightButton.TabIndex = 5;
            this.addFlightButton.Text = "Admin Menu";
            this.addFlightButton.UseVisualStyleBackColor = true;
            this.addFlightButton.Click += new System.EventHandler(this.addFlightButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(892, 618);
            this.Controls.Add(this.addFlightButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.unBookFlight);
            this.Controls.Add(this.bookFlight);
            this.Controls.Add(this.viewFlightButton);
            this.Name = "MainMenu";
            this.Text = " ";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button viewFlightButton;
        private System.Windows.Forms.Button bookFlight;
        private System.Windows.Forms.Button unBookFlight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button addFlightButton;
    }
}