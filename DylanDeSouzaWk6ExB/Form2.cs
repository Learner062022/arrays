using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DylanDeSouzaWk6ExB
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string[] strMagazines = { "Time", "Australian Geographic", "Gormet", "Dolly", "Wheels" };
        double[] dblPrices = { 4.00, 6.50, 5.00, 4.50, 3.95 };
        int counter;
        bool bool_found = false;
        private void btnFindPrice_Click(object sender, EventArgs e)
        {
            for (counter = 0; counter < strMagazines.Length; counter++)
            {
                if (strMagazines[counter] == txtMagazineName.Text)
                {
                    txtPrice.Text = dblPrices[counter].ToString("C");
                    bool_found = true;
                }
            }
            if (!bool_found)
            {
                MessageBox.Show("No match for the entered name");
                txtMagazineName.Clear();
                txtMagazineName.Focus();
            }
        }

        private void btnPriceUnder_Click(object sender, EventArgs e)
        {
            lstNamePrice.Items.Add("Name\tPrice");
            for (counter = 0; counter < dblPrices.Length; counter++)
            {
                double dblAmount;
                dblAmount = double.Parse(txtAmount.Text);
                if (dblPrices[counter] <= dblAmount)
                {
                    lstNamePrice.Items.Add(strMagazines[counter] + "\t" + dblPrices[counter].ToString("C"));
                    bool_found = true;
                }
            }
            if (!bool_found)
            {
                MessageBox.Show("No match for the entered amount");
                txtAmount.Clear();
                txtAmount.Focus();
            }
                   
       
        }
    }
}
