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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        string[] strStates = { "WA", "NT", "QLD", "NSW", "SA", "VIC" };

        private void btnArrayMemberOrder_Click(object sender, EventArgs e)
        {
            lstAustralianStates.Items.Clear();
            for (int intmembers = 0; intmembers < strStates.Length; intmembers++)
            {
                lstAustralianStates.Items.Add(strStates[intmembers]);
            }
        }

        private void btnReverseOrder_Click(object sender, EventArgs e)
        {
            lstAustralianStates.Items.Clear();
            for (int intmembers = strStates.Length - 1; intmembers >= 0; intmembers--)
            {
                lstAustralianStates.Items.Add(strStates[intmembers]);
            }
        }

        private void lstAustralianStates_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
