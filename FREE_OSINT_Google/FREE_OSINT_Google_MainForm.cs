﻿using FREE_OSINT_Google;
using FREE_OSINT_Lib;
using Models;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Web;
using System.Windows.Forms;
using System.Xml;
using static Main.EngineInfo;

namespace Main
{
    public partial class FREE_OSINT_Google_MainForm : Form, IGeneral_module, IInteractable_module, ISearchable_module, IConfigurable_module
    {
        private int MillisecondsTimeout = 200;
        private int MAX_RESULTS;

        String description = Lang.Eng.description;
        String title = Lang.Eng.title;

        string google_api_key;
        Engine google_cx_engine;
        //private static readonly HttpClient client = new HttpClient();

        private EngineInfo engineInfo;
        private List<Result> results;

        public event EventHandler InteractEvent;

        public FREE_OSINT_Google_MainForm()
        {
            results = new List<Result>();
            //this.CenterToScreen();
        }

        public void invokeEvent(InteractEventArgs interactEventArgs)
        {
            InteractEvent?.Invoke(this, interactEventArgs);
        }

        private void initListView()
        {
            listViewResults.Columns.Add("Title", 300, HorizontalAlignment.Left);
            listViewResults.Columns.Add("Link", 250, HorizontalAlignment.Left);
        }

        private void populateEnginecmb()
        {
            engineInfo = Config.Instance.Apis[cmbAPIs.SelectedIndex];
            pupulatecmbEngine();
            cmbEngine.SelectedIndex = 0;
            google_api_key = engineInfo.Api_key;
        }

        private void populateAPIcmb()
        {
            cmbAPIs.Items.Clear();
            List<EngineInfo> apis = Config.Instance.Apis;
            foreach (EngineInfo info in Config.Instance.Apis)
            {
                cmbAPIs.Items.Add(info.Api_key);
            }
            cmbAPIs.SelectedIndex = 0;
        }

        private string request_api(string url)
        {
            string json = string.Empty;

            if (txtLogs != null)
            {
                /*
                txtLogs.AppendText(Environment.NewLine);
                txtLogs.AppendText(Environment.NewLine);
                txtLogs.AppendText(Lang.Eng.url);
                txtLogs.AppendText(url);
                */
            }

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

                request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
                request.Timeout = 10000;

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    json = reader.ReadToEnd();
                    response.Close();
                    reader.Close();
                    stream.Close();
                }
            }
            catch (WebException e)
            {
                if (txtLogs != null)
                {
                    txtLogs.AppendText(Environment.NewLine);
                    txtLogs.AppendText(e.Message);
                    txtLogs.AppendText(Environment.NewLine);
                }
                throw e;
                //MessageBox.Show(e.Message);
            }
            catch (Exception e)
            {
                txtLogs.AppendText(Environment.NewLine);
                txtLogs.AppendText(e.Message);
            }
            return json;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            this.results.Clear();
            listViewResults.Items.Clear();

            string query = textSearch.Text;
            results = search_custom(query);
            //Console.WriteLine(html);
        }

        private void logMessage(string message)
        {
            if(txtLogs != null)
            {
                txtLogs.AppendText(Environment.NewLine);
                txtLogs.AppendText(message);
                txtLogs.AppendText(Environment.NewLine);
            }
        }

        private void cmbEngine_SelectedIndexChanged(object sender, EventArgs e)
        {
            google_cx_engine = engineInfo.Engines[cmbEngine.SelectedIndex];
            populateFilters();
        }

        private void populateFilters()
        {
            panelFilters.Controls.Clear();
            foreach (string filter in google_cx_engine.Filters)
            {
                Button dynamicbutton = new Button();
                dynamicbutton.Click += new System.EventHandler(menu_filters_Click);
                dynamicbutton.Text = filter;
                dynamicbutton.Visible = true;
                dynamicbutton.Height = 35;
                dynamicbutton.Width = 245;
                panelFilters.Controls.Add(dynamicbutton);
            }

        }

        private void menu_filters_Click(object sender, EventArgs e)
        {
            List<Result> filtered = new List<Result>();
            foreach (Result result in results)
            {
                if (result.Link.Contains(((Button)sender).Text.ToLower()))
                {
                    filtered.Add(result);
                }
            }
            SocialNetworkWindow window = new SocialNetworkWindow(((Button)sender).Text, filtered, this);
            window.Text = ((Button)sender).Text + " Results " + filtered.Count;
            window.Show();
            //throw new NotImplementedException();
        }

        private void cmbAPIs_SelectedIndexChanged(object sender, EventArgs e)
        {
            engineInfo = Config.Instance.Apis[cmbAPIs.SelectedIndex];
            labelLimitReached.Visible = engineInfo.Expired;
            pupulatecmbEngine();
            cmbEngine.SelectedIndex = 0;
            google_api_key = engineInfo.Api_key;
        }

        private void pupulatecmbEngine()
        {
            cmbEngine.Items.Clear();
            foreach (Engine engine in engineInfo.Engines)
            {
                cmbEngine.Items.Add(engine.Title);
            }
        }



        private void btnOptions_Click(object sender, EventArgs e)
        {
            SearchOptions window = new SearchOptions(google_api_key, (string)cmbEngine.Items[cmbEngine.SelectedIndex]);
            var result = window.ShowDialog();
            if (result == DialogResult.OK)
            {
                populateAPIcmb();

            }
            else
            {
                window.Close();
            }
        }

        private void txtResultLimit_ValueChanged(object sender, EventArgs e)
        {
            MAX_RESULTS = Int16.Parse(txtResultLimit.Value.ToString());
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            MillisecondsTimeout = Int16.Parse(numericUpDown1.Value.ToString());
        }

        public bool isInteractable()
        {
            return typeof(IInteractable_module).IsInstanceOfType(this);
        }

        public bool isSearchable()
        {
            return typeof(ISearchable_module).IsInstanceOfType(this);
        }

        public string Title()
        {
            return title;
        }

        public string Description()
        {
            return description;
        }

        public void Interact(string query)
        {
            //this.CenterToScreen();
            if (!Config.Instance.first_time && !Config.Instance.Apis.Count.Equals(0))
            {
                this.Show();
                if (textSearch == null)
                {
                    InitializeComponent();
                    populateAPIcmb();
                    initListView();
                    populateEnginecmb();
                    google_api_key = engineInfo.Api_key;
                    MAX_RESULTS = Int16.Parse(txtResultLimit.Value.ToString());
                    initFilters();
                    textSearch.Text = query;
                }
                else
                {
                    textSearch.Text = query;
                }
            }
            else
            {
                this.Hide();
                SettingUp settingUp = new SettingUp();
                var result = settingUp.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.Show();
                    InitializeComponent();
                    populateAPIcmb();
                    initListView();
                    populateEnginecmb();
                    google_api_key = engineInfo.Api_key;
                    MAX_RESULTS = Int16.Parse(txtResultLimit.Value.ToString());
                    initFilters();
                }
                //
            }
        }

        private void initFilters()
        {
            /*
            vScrollBar1.Scroll += (sender, e) => { panelFilters.VerticalScroll.Value = vScrollBar1.Value; };
            panelFilters.Controls.Add(vScrollBar1);*/
        }

        public SearchResult Search(string query, List<object> extras)
        {
            if (Config.Instance.Selected_API != null)
            {
                engineInfo = Config.Instance.Selected_API;
            }
            else
            {
                engineInfo = Config.Instance.Apis[0];
            }
            google_api_key = engineInfo.Api_key;
            if (Config.Instance.Selected_Engine != null)
            {
                google_cx_engine = Config.Instance.Selected_Engine;
            }
            else
            {
                google_cx_engine = engineInfo.Engines[0];

            }
            MAX_RESULTS = Config.Instance.Max_results;
            MillisecondsTimeout = Config.Instance.MillisecondsTimeout;
            //System.Threading.Thread.Sleep(5000);
            string json = string.Empty;
            dynamic jsonData;
            int total_results = -1;
            int start_index = -1;
            int count = -1;
            List<Intel> intels = new List<Intel>();
            SearchResult searchResult;
            string message = "Searching...";
            Dictionary<string, List<Intel>> filtered_intel = new Dictionary<string, List<Intel>>();
            List<TreeNode> intel_nodes = new List<TreeNode>();
            foreach (string filter in google_cx_engine.Filters)
            {
                filtered_intel.Add(filter, new List<Intel>());
            }
            do
            {
                string url = @"https://www.googleapis.com/customsearch/v1?" +
                "key=" + google_api_key + "&" +
                "cx=" + google_cx_engine.Cx + "&" +
                "q=" + HttpUtility.UrlEncode(query) + Config.Instance.ExtraParams;
                System.Threading.Thread.Sleep(MillisecondsTimeout);
                try
                {
                    if (start_index == -1)
                    {
                        json = request_api(url);
                    }
                    else
                    {
                        string newurl = url + "&start=" + start_index;

                        json = request_api(newurl);
                    }
                }
                catch (WebException e)
                {
                    message += Environment.NewLine;
                    message += e.Message;
                    message += Environment.NewLine;
                    message += Lang.Eng.attemping_different_api;
                    message += Environment.NewLine;
                    if (e.Message.Contains("(429) Too Many Requests.") && Config.Instance.Apis.Count > 1)
                    {
                        Config.Instance.Apis.Remove(engineInfo);
                        engineInfo = Config.Instance.Apis[0];
                        google_api_key = engineInfo.Api_key;
                        google_cx_engine = engineInfo.Engines[0];
                        url = @"https://www.googleapis.com/customsearch/v1?" +
                        "key=" + google_api_key + "&" +
                        "cx=" + google_cx_engine.Cx + "&" +
                        "q=" + HttpUtility.UrlEncode(query) + Config.Instance.ExtraParams;
                        try
                        {
                            json = request_api(url);
                        }
                        catch (WebException e2)
                        {
                            searchResult = new SearchResult(intels, DateTime.Now, intels.Count, Lang.Eng.title, Status_Code.ERROR, e2.Message);
                            return searchResult;
                        }
                    }
                }
                if (!json.Equals(String.Empty))
                {
                    jsonData = JsonConvert.DeserializeObject(json);
                    start_index = jsonData.queries.request[0].startIndex;
                    count = jsonData.queries.request[0].count;
                    total_results = jsonData.searchInformation.totalResults;

                    if (total_results > MAX_RESULTS)
                    {
                        total_results = MAX_RESULTS;
                    }
                    if (jsonData.items != null)
                    {
                        foreach (var item in jsonData.items)
                        {
                            Result result = new Result
                            {
                                Title = item.title,
                                Link = item.link,
                                Snippet = item.snippet,
                            };
                            Intel intel = new Intel()
                            {
                                Title = item.title,
                                Description = item.snippet,
                                Uri = item.link,
                                Extras = new ArrayList(),
                                From_module = Lang.Eng.title,
                                Timestamp = DateTime.Now,
                            };
                            intel.Fix_Characters();
                            if (google_cx_engine.Filters.Count > 0)
                                foreach (string filter in google_cx_engine.Filters)
                                {
                                    if (intel.Uri.ToString().Contains(filter.ToLower()))
                                    {
                                        filtered_intel[filter].Add(intel);
                                        break;
                                    }
                                }
                            if (Config.Instance.Metadata)
                            {
                                try
                                {
                                    dynamic metadata = item.pagemap.metatags[0];
                                    List<TreeNode> metadata_node = new List<TreeNode>();
                                    foreach (var meta_item in metadata)
                                    {
                                        String value = Convert.ToString(meta_item);
                                        metadata_node.Add(new TreeNode(value));
                                    }
                                    result.Metadata = new TreeNode("Metadata", metadata_node.ToArray());
                                    intel.Extras.Add(result.Metadata);
                                }
                                catch (Exception e)
                                {
                                    logMessage("No Metadata for " + intel.Title);
                                }

                            }
                            intels.Add(intel);
                            result.Fix_characters();
                            results.Add(result);
                        }
                    }
                    start_index += count;
                }
                else
                {
                    //logMessage(Lang.Eng.empty_response);
                    message += Environment.NewLine;
                    message += Lang.Eng.empty_response;
                    message += Environment.NewLine;
                    message += Lang.Eng.completed;
                    searchResult = new SearchResult(intels, DateTime.Now, intels.Count, Lang.Eng.title, Status_Code.ERROR, message);
                    return searchResult;
                }
            } while (start_index < total_results);
            message += Environment.NewLine;
            message += Lang.Eng.completed;
            List<TreeNode> filtered_Tree_nodes = new List<TreeNode>();
            foreach (KeyValuePair<string, List<Intel>> kvp in filtered_intel)
            {
                List<TreeNode> single_filter_tree_nodes = new List<TreeNode>();
                foreach (Intel intel in kvp.Value)
                {
                    TreeNode meta = new TreeNode("Metadata");
                    if (typeof(ArrayList).IsInstanceOfType(intel.Extras))
                    {
                        if (((ArrayList)intel.Extras).Count > 0)
                            meta = (TreeNode)intel.Extras[0];
                    }
                    TreeNode[] intel_node_array = new TreeNode[] {
                                new TreeNode(intel.Description),
                                new TreeNode(intel.Uri.ToString()),
                                new TreeNode(intel.Timestamp.ToString()),
                               meta,

                            };
                    TreeNode intel_node = new TreeNode(intel.Title, intel_node_array);
                    single_filter_tree_nodes.Add(intel_node);
                }
                filtered_Tree_nodes.Add(new TreeNode(kvp.Key, single_filter_tree_nodes.ToArray()));
                /*
                Console.WriteLine("Key = {0}, Value = {1}",
                    kvp.Key, kvp.Value);*/
            }
            if(filtered_Tree_nodes.Count > 0)
            {
                TreeNode module_node = new TreeNode(Lang.Eng.title, filtered_Tree_nodes.ToArray());
                searchResult = new SearchResult(module_node, DateTime.Now, null, module_node.GetNodeCount(true), Lang.Eng.title, Status_Code.DONE, message);
            }
            else
            {
                searchResult = new SearchResult(intels, DateTime.Now, intels.Count, Lang.Eng.title, Status_Code.DONE, message);
            }

            return searchResult;
        }

        private List<Result> search_custom(string query)
        {
            string json = string.Empty;
            dynamic jsonData;
            var results = new List<Result>();
            int total_results = -1;
            int start_index = -1;
            int count = -1;

            txtLogs.AppendText(Environment.NewLine);
            txtLogs.AppendText(Lang.Eng.searching_url);

            string url = @"https://www.googleapis.com/customsearch/v1?" +
                "key=" + google_api_key + "&" +
                "cx=" + google_cx_engine.Cx + "&" +
                "q=" + HttpUtility.UrlEncode(query) + Config.Instance.ExtraParams;
            if (exactTermChk.Checked)
            {
                url += "&exactTerms=" + HttpUtility.UrlEncode(query);
            }
            textURI.Text = url;
            try
            {
                json = request_api(url);

            }
            catch (WebException e)
            {
                logMessage(e.Message);
            }
            if (!json.Equals(String.Empty))
            {
                jsonData = JsonConvert.DeserializeObject(json);
                if (jsonData.queries.request[0].totalResults != null)
                {
                    total_results = jsonData.queries.request[0].totalResults;
                    logMessage(Lang.Eng.searching_for + MAX_RESULTS + Lang.Eng.in_total_of + total_results + Lang.Eng.results);
                }
                if (total_results > MAX_RESULTS)
                {
                    total_results = MAX_RESULTS;
                }
                start_index = jsonData.queries.request[0].startIndex;
                count = jsonData.queries.request[0].count;
                if (jsonData.items != null)
                {
                    foreach (var item in jsonData.items)
                    {
                        Result result = new Result
                        {
                            Title = item.title,
                            Link = item.link,
                            Snippet = item.snippet,
                        };
                        if (Config.Instance.Metadata)
                        {
                            try
                            {
                                dynamic metadata = item.pagemap.metatags[0];
                                List<TreeNode> metadata_node = new List<TreeNode>();
                                foreach (var meta_item in metadata)
                                {
                                    String value = Convert.ToString(meta_item);
                                    metadata_node.Add(new TreeNode(value));
                                }
                                result.Metadata = new TreeNode("Metadata", metadata_node.ToArray());
                            }
                            catch (Exception e)
                            {
                                logMessage("No Metadata for " + result.Title);
                            }
                        }
                        result.Fix_characters();
                        results.Add(result);
                        var list_item = new ListViewItem(new[] { result.Title, result.Link });
                        listViewResults.Items.Add(list_item);

                    }
                    start_index += count;
                }
                else
                {
                    logMessage(Lang.Eng.empty_response);
                }
            }
            else
            {
                logMessage(Lang.Eng.empty_response);
            }
            if (total_results > 10)
            {
                do
                {
                    System.Threading.Thread.Sleep(MillisecondsTimeout);
                    string newurl = url + "&start=" + start_index;
                    try
                    {
                        json = request_api(newurl);

                    }
                    catch (WebException e)
                    {

                    }
                    if (!json.Equals(String.Empty))
                    {
                        jsonData = JsonConvert.DeserializeObject(json);
                        start_index = jsonData.queries.request[0].startIndex;
                        count = jsonData.queries.request[0].count;
                        if (jsonData.items != null)
                        {
                            foreach (var item in jsonData.items)
                            {
                                Result result = new Result
                                {
                                    Title = item.title,
                                    Link = item.link,
                                    Snippet = item.snippet,
                                };
                                if (Config.Instance.Metadata)
                                {
                                    try
                                    {
                                        dynamic metadata = item.pagemap.metatags[0];
                                        List<TreeNode> metadata_node = new List<TreeNode>();
                                        foreach (var meta_item in metadata)
                                        {
                                            String value = Convert.ToString(meta_item);
                                            metadata_node.Add(new TreeNode(value));
                                        }
                                        result.Metadata = new TreeNode("Metadata", metadata_node.ToArray());
                                    }
                                    catch (Exception e)
                                    {
                                        logMessage("No Metadata for " + result.Title);
                                    }
                                }
                                result.Fix_characters();
                                results.Add(result);

                                var list_item = new ListViewItem(new[] { result.Title, result.Link });
                                listViewResults.Items.Add(list_item);
                            }
                        }
                        if (jsonData.searchInformation.totalResults != null && jsonData.searchInformation.totalResults == 0)
                        {
                            string extra = "";
                            if (jsonData.spelling != null)
                            {
                                extra = "Suggested correction - " + jsonData.spelling.correctedQuery;
                            }
                            var list_item = new ListViewItem(new[] { "End of Results", extra });
                            listViewResults.Items.Add(list_item);
                        }
                        start_index += count;
                    }
                    else
                    {
                        logMessage(Lang.Eng.empty_response);
                    }
                } while (start_index < total_results);
            }
            this.results = results;
            return results;
        }

        public bool isConfigurable()
        {
            return typeof(IConfigurable_module).IsInstanceOfType(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SocialNetworkWindow window = new SocialNetworkWindow("All results", results, this);
            window.Text = "All results";
            window.Show();
        }

        private void closingForm(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        public void Configure()
        {
            SearchOptions window = new SearchOptions();
            var result = window.ShowDialog();
            if (result == DialogResult.OK)
            {
                Config.Instance.ExtraParams = window.extra_params;
            }
            else
            {
                window.Close();
            }
        }
    }
}
