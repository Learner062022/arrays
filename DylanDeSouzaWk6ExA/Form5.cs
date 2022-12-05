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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        string[] strdogs = { "corgi", "boxer", "husky", "beagle", "collie" };

        private void btnClick_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < strdogs.Length; i++)
            {
                if (strdogs[i] != txtDogName.Text)
                {
                    MessageBox.Show("The dog's breed wasn't in the list - please enter another breed");
                    txtDogName.Clear();
                    txtDogName.Focus();
                    return;
                }
                else if (strdogs[i] == txtDogName.Text)
                {
                    MessageBox.Show("Congradulations, the dog's breed was in the list");
                    return;
                }
            }
        }
    }
}
