using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculateRentalPrice_Click(object sender, EventArgs e)
        {
            

            string inputdays = txtNumberdays.Text;
            double days = double.Parse(inputdays);

            string inputkm = txtNumberkm.Text;
            double km = double.Parse(inputkm);

            string inputliters = txtNumberliters.Text;
            double liters = double.Parse(inputliters);

            double kmincl = 100 * days;
            
            double kmafterincl = km - kmincl;
            double priceforalldays = days * 55;
            
            double kmpriceOne = kmafterincl * 0.25;
            
            double priceliters = liters * 2.20;

            double finaltotalprice = kmpriceOne + priceforalldays + priceliters;
            double finaltotalpriceTWO = priceforalldays + priceliters;
            double finaltotalpriceThree = kmpriceOne + priceforalldays;
            


            //..if user checks the refuel on account of renter box, and enters an amount of kms more than kmincl 
            if (checkBox1.Checked && kmincl < km )

            {
                lblRentalPrice.Text = finaltotalprice.ToString("0.00");
            }

            else if (checkBox1.Checked && kmincl > km )
            {
                lblRentalPrice.Text = finaltotalpriceTWO.ToString("0.00");

            }

            else if (kmincl < km)
                {

                lblRentalPrice.Text = finaltotalpriceThree.ToString("0.00");
            }

            else if (kmincl > km)

            {
                
                    lblRentalPrice.Text = priceforalldays.ToString("0.00");
            }





        }
    }
}
