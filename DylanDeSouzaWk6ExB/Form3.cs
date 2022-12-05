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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        string[] strMagazines = { "Time", "Australian Geographic", "Gormet", "Dolly", "Wheels" };
        double[] dblPrices = { 4.00, 6.50, 5.00, 4.50, 3.95 };
        bool bool_found = false;
        int counter;
        private void btnFindPrice_Click(object sender, EventArgs e)
        {
            for (counter = 0; counter < strMagazines.Length; counter++)
            {
                if (strMagazines[counter] == txtMagazineName.Text)
                {
                    txtPrice.Text = dblPrices[counter].ToString("C");
                    bool_found = true;
                }
                else if (!bool_found)
                {
                    MessageBox.Show("No match for the entered name");
                    txtMagazineName.Clear();
                    txtMagazineName.Focus();
                }
            }

        }

        private void btnPriceUnder_Click(object sender, EventArgs e)
        {
            double dblAmount;
            if (!double.TryParse(txtAmount.Text, out dblAmount))
            {
                MessageBox.Show("Please include a number");
                txtAmount.Clear();
                txtAmount.Focus();
            }
            else if (!bool_found)
            {
                MessageBox.Show("No match for the entered amount");
                txtAmount.Clear();
                txtAmount.Focus();
            }
            else
            {
                for (counter = 0; counter < dblPrices.Length; counter++)
                {
                    dblAmount = double.Parse(txtAmount.Text);
                    if (dblPrices[counter] <= dblAmount)
                    {
                        lstNamePrice.Items.Add(strMagazines[counter] + "\t" + dblPrices[counter].ToString("C"));
                        bool_found = true;
                    }

                }

            }
        }

        private void lstNamePrice_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
