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
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            string[] strStates = { "WA", "NT", "QLD", "NSW", "SA", "VIC" };
            for (uint uintmembers = 0U; uintmembers < strStates.Length; uintmembers++)
            {
                lstAustralianStates.Items.Add(strStates[uintmembers]);
            }
        }
    }
}
