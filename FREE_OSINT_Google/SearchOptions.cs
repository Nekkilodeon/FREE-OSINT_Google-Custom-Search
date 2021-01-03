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
        private List<Country_Codes> lang_codes;
        private List<Country_Codes> cr_codes;

        private string config_engine_url = "https://programmablesearchengine.google.com/cse/all";
        private string all_params_url = "https://developers.google.com/custom-search/v1/reference/rest/v1/cse/list";
        private string supported_file_types = "https://support.google.com/webmasters/answer/35287";
        public string extra_params = "";

        string google_api_key;
        private EngineInfo engineInfo;
        private EngineInfo.Engine google_cx_engine;

        public SearchOptions()
        {
            InitializeComponent();
            populateAPIcmb();
            populateEnginecmb();
            google_api_key = engineInfo.api_key;
            populateCountryCodes();
        }
        public SearchOptions(string google_api_key, string google_cx_engine)
        {
            InitializeComponent();
            populateCountryCodes();

            cmbAPIs.Enabled = false;
            cmbEngine.Enabled = false;
            txtResultLimit.Enabled = false;
            cmbAPIs.Items.Add(google_api_key);
            cmbAPIs.SelectedIndex = 0;
            cmbEngine.Items.Add(google_cx_engine);
            cmbEngine.SelectedIndex = 0;

        }

        private void populateCountryCodes()
        {
            try
            {
                codes = Config.Instance.load_geolocation_code_xml();
                foreach (Country_Codes code in codes)
                {
                    cmbGeoLocation.Items.Add(code.Name);
                }
                cmbGeoLocation.SelectedIndex = 171;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            try
            {
                cr_codes = Config.Instance.load_cr_codes_xml();

                foreach (Country_Codes code in cr_codes)
                {
                    cmbCRCountryCodes.Items.Add(code.Name);
                }
                cmbCRCountryCodes.SelectedIndex = 174;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            try
            {
                lang_codes = Config.Instance.load_lang_codes_xml();
                foreach (Country_Codes code in lang_codes)
                {
                    cmbLR.Items.Add(code.Name);
                }
                cmbLR.SelectedIndex = 25;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void pupulatecmbEngine()
        {
            cmbEngine.Items.Clear();
            foreach (EngineInfo.Engine engine in engineInfo.engines)
            {
                cmbEngine.Items.Add(engine.title);
            }
        }
        private void populateEnginecmb()
        {
            engineInfo = Config.Instance.Apis[cmbAPIs.SelectedIndex];
            pupulatecmbEngine();
            cmbEngine.SelectedIndex = 0;
            google_api_key = engineInfo.api_key;
        }
        private void populateAPIcmb()
        {
            List<EngineInfo> apis = Config.Instance.Apis;
            foreach (EngineInfo info in Config.Instance.Apis)
            {
                cmbAPIs.Items.Add(info.api_key);
            }
            cmbAPIs.SelectedIndex = 0;
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            extra_params = "";
            try
            {
                if (cr.Checked)
                {
                    extra_params += "&cr=" + cr_codes[cmbCRCountryCodes.SelectedIndex].Code;
                }
                if (linkSite.Checked)
                {
                    extra_params += "&linkSite=" + txtLinkSite.Text;
                }
                if (dateRestrict.Checked)
                {
                    string dateRestrict_type = cmbdateRestrictType.SelectedItem.ToString().ToLower().ToString().Substring(0, 1);
                    extra_params += "&dateRestrict=" + dateRestrict_type + dateRestrictValue.Value;
                }
                if (exactTerms.Checked)
                {
                    extra_params += "&exactTerms=" + exactTermsValue.Text;
                }
                if (excludeTerms.Checked)
                {
                    extra_params += "&excludeTerms=" + excludeTermsValue.Text;
                }
                if (fileType.Checked)
                {
                    extra_params += "&fileType=" + fileTypeValue.Text;
                }
                if (gl.Checked)
                {
                    extra_params += "&gl=" + codes[cmbGeoLocation.SelectedIndex].Code;
                }
                if (filter.Checked)
                {
                    extra_params += "&filter=0";
                }
                if (lr.Checked)
                {
                    extra_params += "&lr=" + lang_codes[cmbLR.SelectedIndex].Code;
                }
                if (relatedSite.Checked)
                {
                    extra_params += "&relatedSite=" + relatedSiteValue.Text;
                }
                if (extraParams.Checked)
                {
                    extra_params += "&" + extraParamsValue.Text;
                }
                Config.Instance.Max_results = (int)txtResultLimit.Value;
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbCountryCodes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnEngines_Click(object sender, EventArgs e)
        {
            Config.Instance.OpenUrl(config_engine_url);
        }

        private void btnAllParams_Click(object sender, EventArgs e)
        {
            Config.Instance.OpenUrl(all_params_url);
        }

        private void SearchOptions_Load(object sender, EventArgs e)
        {
            cmbdateRestrictType.SelectedIndex = 0;
        }

        private void btnSupportedTypes_Click(object sender, EventArgs e)
        {
            Config.Instance.OpenUrl(supported_file_types);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void cmbAPIs_SelectedIndexChanged(object sender, EventArgs e)
        {
            engineInfo = Config.Instance.Apis[cmbAPIs.SelectedIndex];
            pupulatecmbEngine();
            cmbEngine.SelectedIndex = 0;
            google_api_key = engineInfo.api_key;
        }

        private void cmbEngine_SelectedIndexChanged(object sender, EventArgs e)
        {
            google_cx_engine = engineInfo.engines[cmbEngine.SelectedIndex];
        }
    }
}
