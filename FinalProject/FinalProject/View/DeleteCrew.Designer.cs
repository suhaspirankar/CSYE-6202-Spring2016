﻿namespace FinalProject.View
{
    partial class DeleteCrew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteCrew));
            this.button1 = new System.Windows.Forms.Button();
            this.deleteFlightButton = new System.Windows.Forms.Button();
            this.crewIdTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 460);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // deleteFlightButton
            // 
            this.deleteFlightButton.Location = new System.Drawing.Point(454, 251);
            this.deleteFlightButton.Name = "deleteFlightButton";
            this.deleteFlightButton.Size = new System.Drawing.Size(75, 23);
            this.deleteFlightButton.TabIndex = 7;
            this.deleteFlightButton.Text = "Submit";
            this.deleteFlightButton.UseVisualStyleBackColor = true;
            this.deleteFlightButton.Click += new System.EventHandler(this.deleteFlightButton_Click);
            // 
            // crewIdTextBox
            // 
            this.crewIdTextBox.Location = new System.Drawing.Point(484, 153);
            this.crewIdTextBox.Name = "crewIdTextBox";
            this.crewIdTextBox.Size = new System.Drawing.Size(245, 20);
            this.crewIdTextBox.TabIndex = 6;
            this.crewIdTextBox.TextChanged += new System.EventHandler(this.deleteTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter Crew Id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(436, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Delete Crew";
            // 
            // DeleteCrew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(887, 522);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deleteFlightButton);
            this.Controls.Add(this.crewIdTextBox);
            this.Controls.Add(this.label1);
            this.Name = "DeleteCrew";
            this.Text = "DeleteCrew";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button deleteFlightButton;
        private System.Windows.Forms.TextBox crewIdTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}