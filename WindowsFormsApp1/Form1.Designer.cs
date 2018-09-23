namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFee = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtMembership = new System.Windows.Forms.TextBox();
            this.rdBtnFootball = new System.Windows.Forms.RadioButton();
            this.rdBtnHandball = new System.Windows.Forms.RadioButton();
            this.btnCalculateFee = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sport";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Age";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Membership duration";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fee to be paid";
            // 
            // lblFee
            // 
            this.lblFee.AutoSize = true;
            this.lblFee.Location = new System.Drawing.Point(237, 247);
            this.lblFee.Name = "lblFee";
            this.lblFee.Size = new System.Drawing.Size(13, 13);
            this.lblFee.TabIndex = 4;
            this.lblFee.Text = "0";
            this.lblFee.Click += new System.EventHandler(this.lblFee_Click);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(156, 116);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(129, 20);
            this.txtAge.TabIndex = 5;
            // 
            // txtMembership
            // 
            this.txtMembership.Location = new System.Drawing.Point(156, 150);
            this.txtMembership.Name = "txtMembership";
            this.txtMembership.Size = new System.Drawing.Size(129, 20);
            this.txtMembership.TabIndex = 6;
            // 
            // rdBtnFootball
            // 
            this.rdBtnFootball.AutoSize = true;
            this.rdBtnFootball.Location = new System.Drawing.Point(156, 42);
            this.rdBtnFootball.Name = "rdBtnFootball";
            this.rdBtnFootball.Size = new System.Drawing.Size(62, 17);
            this.rdBtnFootball.TabIndex = 7;
            this.rdBtnFootball.TabStop = true;
            this.rdBtnFootball.Text = "Football";
            this.rdBtnFootball.UseVisualStyleBackColor = true;
            // 
            // rdBtnHandball
            // 
            this.rdBtnHandball.AutoSize = true;
            this.rdBtnHandball.Location = new System.Drawing.Point(156, 65);
            this.rdBtnHandball.Name = "rdBtnHandball";
            this.rdBtnHandball.Size = new System.Drawing.Size(67, 17);
            this.rdBtnHandball.TabIndex = 8;
            this.rdBtnHandball.TabStop = true;
            this.rdBtnHandball.Text = "Handball";
            this.rdBtnHandball.UseVisualStyleBackColor = true;
            // 
            // btnCalculateFee
            // 
            this.btnCalculateFee.Location = new System.Drawing.Point(25, 191);
            this.btnCalculateFee.Name = "btnCalculateFee";
            this.btnCalculateFee.Size = new System.Drawing.Size(260, 37);
            this.btnCalculateFee.TabIndex = 9;
            this.btnCalculateFee.Text = "&Calculate Fee";
            this.btnCalculateFee.UseVisualStyleBackColor = true;
            this.btnCalculateFee.Click += new System.EventHandler(this.btnCalculateFee_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(194, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "$";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 284);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCalculateFee);
            this.Controls.Add(this.rdBtnHandball);
            this.Controls.Add(this.rdBtnFootball);
            this.Controls.Add(this.txtMembership);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblFee);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Assignment 9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFee;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtMembership;
        private System.Windows.Forms.RadioButton rdBtnFootball;
        private System.Windows.Forms.RadioButton rdBtnHandball;
        private System.Windows.Forms.Button btnCalculateFee;
        private System.Windows.Forms.Label label6;
    }
}

