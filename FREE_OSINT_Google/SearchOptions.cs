using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static Main.Config;

namespace Main
{
    public partial class SearchOptions : Form
    {
        private List<Country_Codes> codes;
        public SearchOptions()
        {
            InitializeComponent();
            populateCountryCodes();
        }

        private void populateCountryCodes()
        {
            codes = Config.Instance.load_country_code_xml();
            foreach (Country_Codes code in codes)
            {
                cmbCountryCodes.Items.Add(code.Name);
            }
            cmbCountryCodes.SelectedIndex = 171;
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {

        }

        private void cmbCountryCodes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
