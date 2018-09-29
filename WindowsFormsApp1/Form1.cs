using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblFee_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculateFee_Click(object sender, EventArgs e)
        {
            const double FMEMEBERSHIP = 175;
            const double HMEMBERSHIP = 225;

            string inputA = txtAge.Text;
            double age = double.Parse(inputA);

            string inputM = txtMembership.Text;
            double membership = double.Parse(inputM);

            //..discounted price for people above 40
            double overfortypriceF = 150;
            double overfortypriceH = 200;

            //..discounted price for people above 10 years of membership and under forty
            double tenyearsmemberF = 155;
            double tenyearsmemberH = 205;

            //..price if above 40 and above 10 years membership
            double tenyearsFortymemberF = 130;
            double tenyearsFortymemberH = 180;

            //..CASE FOOTBALL CHECKED

            //..if the member checked football and is above forty and membership below ten
            if (rdBtnFootball.Checked && age > 40 && membership < 10)
            {
                lblFee.Text = overfortypriceF.ToString("0.00");
                

            }
            //..if the member checked football and is above forty and membership above ten
            else if (rdBtnFootball.Checked && age > 40 && membership > 10)
            {
                lblFee.Text = tenyearsFortymemberF.ToString("0.00");
                
            }

            //..if the member checked football and is under forty and membership below ten
            else if (rdBtnFootball.Checked && age <= 40 && membership < 10)
            {
                lblFee.Text = FMEMEBERSHIP.ToString("0.00");
                
            }
            //..if the member checked football and is under forty and membership above ten
            else if (rdBtnFootball.Checked && age <= 40 && membership > 10)
            {
                lblFee.Text = tenyearsmemberF.ToString("0.00");
                
            }

            //..CASE HANDBALL CHECKED

            //..if the member checked handball and is above forty and membership below ten
            else if (rdBtnHandball.Checked && age > 40 && membership <= 10)
            {
                lblFee.Text = overfortypriceH.ToString("0.00");
                
            }
            //..if the member checked hanball and is above forty and membership above ten
            else if (rdBtnHandball.Checked && age > 40 && membership > 10)
            {
                lblFee.Text = tenyearsFortymemberH.ToString("0.00");
                
            }

            //..if the member checked hanball and is under forty and membership below ten
            else if (rdBtnHandball.Checked && age <= 40 && membership <= 10)
            {
                lblFee.Text = HMEMBERSHIP.ToString("0.00");
                
            }
            //..if the member checked hanball and is under forty and membership above ten
            else if (rdBtnHandball.Checked && age <= 40 && membership > 10)
            {
                lblFee.Text = tenyearsmemberH.ToString("0.00");
               
            }

        }
    }
}
