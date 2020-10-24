using FREE_OSINT_Lib;
using Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FREE_OSINT_Google
{
    public partial class SettingUp : Form, ISearchable_module, IInteractable_module
    {
        String description = "Google Custom Search API module developed for FREE_OSINT";
        String title = "FREE-OSINT Google Custom Search API";
        static string first_step = "https://developers.google.com/custom-search/v1/overview";
        static string third_step = "https://cse.google.com/cse/all";
        List<EngineInfo.Engine> engines;
        String google_api_key;


        public SettingUp()
        {
            //
            InitializeComponent();
            engines = new List<EngineInfo.Engine>();

            //
        }

        public string Description()
        {
            return description;
        }

        public void Interact()
        {
            FREE_OSINT_Google_MainForm main = new FREE_OSINT_Google_MainForm();
            //main.Show();
            //this.Close();
        }


        public List<Intel> Search(string query, List<object> extras)
        {
            throw new NotImplementedException();
        }

        public string Title()
        {
            return title;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Config.Instance.OpenUrl(first_step);
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FREE_OSINT_Google_MainForm mainform = new FREE_OSINT_Google_MainForm();
            mainform.Show();
        }

        private void btnSearchEngines_Click(object sender, EventArgs e)
        {
            Config.Instance.OpenUrl(third_step);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnInsertSearchEngine_Click(object sender, EventArgs e)
        {
            Search_engine_form search_Engine_Form = new Search_engine_form();
            //search_Engine_Form.Show();
            var result = search_Engine_Form.ShowDialog();
            if (result == DialogResult.OK)
            {
                string title = search_Engine_Form.title;            //values preserved after close
                string cx = search_Engine_Form.cx;          //values preserved after close

                EngineInfo.Engine engine = new EngineInfo.Engine(title, cx);
                engines.Add(engine);
                refreshCheckList();
                //Do something here with these values
            }
            if(result == DialogResult.Cancel)
            {
                search_Engine_Form.Close();
            }
        }

        private void refreshCheckList()
        {
            listCheckedSearchEngines.Items.Clear();
            foreach(EngineInfo.Engine engine in engines)
            {
                listCheckedSearchEngines.Items.Add(engine);
            }
        }

        private void btnEditSearchEngine_Click(object sender, EventArgs e)
        {
            EngineInfo.Engine engine = (EngineInfo.Engine)listCheckedSearchEngines.Items[listCheckedSearchEngines.SelectedIndex];
            Search_engine_form search_Engine_Form = new Search_engine_form(listCheckedSearchEngines.SelectedIndex, engine.title,engine.cx);
            var result = search_Engine_Form.ShowDialog();
            if (result == DialogResult.OK)
            {
                string title = search_Engine_Form.title;            //values preserved after close
                string cx = search_Engine_Form.cx;          //values preserved after close
                int index = search_Engine_Form.index;
                engine = new EngineInfo.Engine(title, cx);
                engines[index] = engine;
                refreshCheckList();
                //Do something here with these values
            }
            if (result == DialogResult.Cancel)
            {
                search_Engine_Form.Close();
            }
        }

        private void btnRemoveSearchEngine_Click(object sender, EventArgs e)
        {
            foreach(Object engine in listCheckedSearchEngines.CheckedItems)
            {
                engines.Remove((EngineInfo.Engine)engine);
            }
            refreshCheckList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            google_api_key = txtGoogle_API_key.Text;
            EngineInfo info = new EngineInfo(google_api_key, engines);
            List<EngineInfo> infos = new List<EngineInfo>();
            infos.Add(info);
            if (!google_api_key.Equals(String.Empty) && !engines.Count.Equals(0))
            {
                Config.Instance.GenerateEnginesXML(infos);
                Config.Instance.Apis = infos;
                Config.Instance.first_time = false;
                btnContinue.Enabled = true;

            }
            else
            {
                MessageBox.Show(Lang.Eng.first_steps_save_error);
            }
        }
    }
}
