namespace Assignment_13
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtNumberdays = new System.Windows.Forms.TextBox();
            this.txtNumberkm = new System.Windows.Forms.TextBox();
            this.txtNumberliters = new System.Windows.Forms.TextBox();
            this.btnCalculateRentalPrice = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRentalPrice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(38, 139);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(156, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Refuel on account of renter";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtNumberdays
            // 
            this.txtNumberdays.Location = new System.Drawing.Point(200, 57);
            this.txtNumberdays.Name = "txtNumberdays";
            this.txtNumberdays.Size = new System.Drawing.Size(100, 20);
            this.txtNumberdays.TabIndex = 1;
            // 
            // txtNumberkm
            // 
            this.txtNumberkm.Location = new System.Drawing.Point(200, 101);
            this.txtNumberkm.Name = "txtNumberkm";
            this.txtNumberkm.Size = new System.Drawing.Size(100, 20);
            this.txtNumberkm.TabIndex = 2;
            // 
            // txtNumberliters
            // 
            this.txtNumberliters.Location = new System.Drawing.Point(200, 177);
            this.txtNumberliters.Name = "txtNumberliters";
            this.txtNumberliters.Size = new System.Drawing.Size(100, 20);
            this.txtNumberliters.TabIndex = 3;
            // 
            // btnCalculateRentalPrice
            // 
            this.btnCalculateRentalPrice.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnCalculateRentalPrice.FlatAppearance.BorderSize = 100;
            this.btnCalculateRentalPrice.Location = new System.Drawing.Point(38, 214);
            this.btnCalculateRentalPrice.Name = "btnCalculateRentalPrice";
            this.btnCalculateRentalPrice.Size = new System.Drawing.Size(262, 41);
            this.btnCalculateRentalPrice.TabIndex = 4;
            this.btnCalculateRentalPrice.Text = "&Calculate Rental Price";
            this.btnCalculateRentalPrice.UseVisualStyleBackColor = true;
            this.btnCalculateRentalPrice.Click += new System.EventHandler(this.btnCalculateRentalPrice_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Number of rental days";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Number of kms";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Numbers of liters tanked";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Rental price";
            // 
            // lblRentalPrice
            // 
            this.lblRentalPrice.AutoSize = true;
            this.lblRentalPrice.Location = new System.Drawing.Point(208, 272);
            this.lblRentalPrice.Name = "lblRentalPrice";
            this.lblRentalPrice.Size = new System.Drawing.Size(13, 13);
            this.lblRentalPrice.TabIndex = 9;
            this.lblRentalPrice.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(181, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "$";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 333);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblRentalPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalculateRentalPrice);
            this.Controls.Add(this.txtNumberliters);
            this.Controls.Add(this.txtNumberkm);
            this.Controls.Add(this.txtNumberdays);
            this.Controls.Add(this.checkBox1);
            this.Name = "Form1";
            this.Text = "Assignment 13";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtNumberdays;
        private System.Windows.Forms.TextBox txtNumberkm;
        private System.Windows.Forms.TextBox txtNumberliters;
        private System.Windows.Forms.Button btnCalculateRentalPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRentalPrice;
        private System.Windows.Forms.Label label7;
    }
}

