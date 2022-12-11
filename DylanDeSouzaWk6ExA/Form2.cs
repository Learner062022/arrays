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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            lstAustralianStates.Items.Add("Australian States:");
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            string[] str_states = { "WA", "NT", "QLD", "NSW", "SA", "VIC" };
            foreach (string str_state in str_states)
            {
                lstAustralianStates.Items.Add(str_state);
            }
        }
    }
}
