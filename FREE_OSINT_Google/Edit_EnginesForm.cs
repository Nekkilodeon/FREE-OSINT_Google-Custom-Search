using Main;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Main.EngineInfo;

namespace FREE_OSINT_Google
{
    public partial class Edit_EnginesForm : Form
    {
        public List<EngineInfo> engineInfos;
        public Edit_EnginesForm()
        {
            InitializeComponent();
            this.CenterToScreen();
            engineInfos = new List<EngineInfo>();
            foreach (EngineInfo engineInfo in Config.Instance.Apis)
            {
                engineInfos.Add((EngineInfo)engineInfo.Clone());
            }
            populateLists();
        }

        private void populateLists()
        {
            listBoxAPIs.Items.Clear();
            foreach (EngineInfo engineInfo in engineInfos)
            {
                listBoxAPIs.Items.Add(engineInfo.Api_key);
            }
            if (listBoxAPIs.Items.Count > 0)
            {
                listBoxAPIs.SelectedIndex = 0;
            }
            else
            {
                listBoxEngines.Items.Clear();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Config.Instance.Apis = this.engineInfos;
            Config.Instance.GenerateEnginesXML(engineInfos);
            this.DialogResult = DialogResult.OK;
        }

        private void listBoxAPISelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxEngines.Items.Clear();
            Engine[] engines = engineInfos[((ListBox)sender).SelectedIndex].Engines;
            foreach (Engine engine in engines)
            {
                listBoxEngines.Items.Add(engine.Title);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAddAPI_Click(object sender, EventArgs e)
        {
            string api_key = Interaction.InputBox("Add new API key to configuration", "Insert API key", "");
            if (api_key.Length > 0)
            {
                engineInfos.Add(new EngineInfo()
                {
                    Api_key = api_key,
                    Engines = new Engine[0]
                });
            }
            populateLists();
        }

        private void btnEditAPI_Click(object sender, EventArgs e)
        {
            string api_key = Interaction.InputBox("Change an existing configuration", "Edit API key", engineInfos[listBoxAPIs.SelectedIndex].Api_key);
            engineInfos[listBoxAPIs.SelectedIndex].Api_key = api_key;
            populateLists();
        }

        private void btnAPIRemove_Click(object sender, EventArgs e)
        {
            engineInfos.RemoveAt(listBoxAPIs.SelectedIndex);
            populateLists();

        }

        private void btnAddEngine_Click(object sender, EventArgs e)
        {
            Search_engine_form search_Engine_Form = new Search_engine_form();
            //search_Engine_Form.Show();
            var result = search_Engine_Form.ShowDialog();
            if (result == DialogResult.OK)
            {
                string title = search_Engine_Form.title;            //values preserved after close
                string cx = search_Engine_Form.cx;          //values preserved after close
                List<string> filters = search_Engine_Form.filters;
                EngineInfo.Engine engine = new EngineInfo.Engine(title, cx, filters);
                List<Engine> engines = new List<Engine>(engineInfos[listBoxAPIs.SelectedIndex].Engines);
                engines.Add(engine);
                engineInfos[listBoxAPIs.SelectedIndex].Engines = engines.ToArray();
                listBoxAPISelectedIndexChanged(listBoxAPIs, EventArgs.Empty);
                //Do something here with these values
            }
        }

        private void btnEditEngine_Click(object sender, EventArgs e)
        {
            //
            EngineInfo.Engine engine = engineInfos[listBoxAPIs.SelectedIndex].Engines[listBoxEngines.SelectedIndex];
            Search_engine_form search_Engine_Form = new Search_engine_form(listBoxEngines.SelectedIndex, engine.Title, engine.Cx, engine.Filters);
            var result = search_Engine_Form.ShowDialog();
            if (result == DialogResult.OK)
            {
                string title = search_Engine_Form.title;            //values preserved after close
                string cx = search_Engine_Form.cx;          //values preserved after close
                List<string> filters = search_Engine_Form.filters;
                engine = new EngineInfo.Engine(title, cx, filters);
                engineInfos[listBoxAPIs.SelectedIndex].Engines[listBoxEngines.SelectedIndex] = engine;
                //Do something here with these values
            }
        }

        private void btnEngineRemove_Click(object sender, EventArgs e)
        {
            Engine[] engines_array = engineInfos[listBoxAPIs.SelectedIndex].Engines;
            List<Engine> engines = new List<Engine>(engines_array);
            engines.RemoveAt(listBoxEngines.SelectedIndex);
            engineInfos[listBoxAPIs.SelectedIndex].Engines = engines.ToArray();
            listBoxAPISelectedIndexChanged(listBoxAPIs, EventArgs.Empty);
        }
    }
}
