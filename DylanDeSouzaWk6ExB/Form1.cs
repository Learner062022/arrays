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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnFindPrice_Click(object sender, EventArgs e)
        {
            string[] strMagazines = { "Time", "Australian Geographic", "Gormet", "Dolly", "Wheels" };
            double[] dblPrices = { 4.00, 6.50, 5.00, 4.50, 3.95 };
            int counter;
            bool bool_magazine_found = false;
            for (counter = 0; counter < 4; counter++) 
            {
                if (strMagazines[counter] == txtMagazineName.Text)
                {
                    txtPrice.Text = dblPrices[counter].ToString("C");
                    bool_magazine_found = true;

                }    
            }
            if (!bool_magazine_found)
            {
                MessageBox.Show("No match for the entered name");
                txtMagazineName.Clear();
                txtMagazineName.Focus();
            }
        }
    }
}
