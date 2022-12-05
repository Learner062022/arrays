using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DylanDeSouzaWk6ExA
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        string[] strdogs = { "corgi", "boxer", "husky", "beagle", "collie" };
        private void btnClick_Click(object sender, EventArgs e)
        {
            lstDogNamesNumbers.Visible = true;
            lstDogNamesNumbers.Items.Add("Names\tNumbers");
            for(int ints = 0; ints < strdogs.Length; ints++)
            {
                lstDogNamesNumbers.Items.Add(strdogs[ints] + "\t" + ints.ToString());
            }
        }
    }
}
