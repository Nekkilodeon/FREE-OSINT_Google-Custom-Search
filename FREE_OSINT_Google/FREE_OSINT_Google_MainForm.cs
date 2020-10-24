using FREE_OSINT_Google;
using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;
using System.Xml;
using static Main.EngineInfo;

namespace Main
{
    public partial class FREE_OSINT_Google_MainForm : Form
    {
        private int MillisecondsTimeout = 200;
        private int MAX_RESULTS;
        string google_api_key;
        Engine google_cx_engine;
        private static readonly HttpClient client = new HttpClient();

        private EngineInfo engineInfo;

        List<Result> facebook_results = null;
        List<Result> instagram_results = null;
        List<Result> linkedin_results = null;
        List<Result> other_results = null;

        public FREE_OSINT_Google_MainForm()
        {
            if (!Config.Instance.first_time && !Config.Instance.Apis.Count.Equals(0))
            {
                this.Show();
                InitializeComponent();
                populateAPIcmb();
                initListView();
                populateEnginecmb();
                google_api_key = engineInfo.api_key;
                Int16.Parse(txtResultLimit.Value.ToString());
            }
            else
            {
                this.Hide();
                SettingUp settingUp = new SettingUp();
                settingUp.Show();
                //
            }
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
                google_api_key = engineInfo.api_key;
        }

        private void populateAPIcmb()
        {
            List<EngineInfo> apis = Config.Instance.Apis;
            foreach(EngineInfo info in Config.Instance.Apis)
            {
                cmbAPIs.Items.Add(info.api_key);
            }
            cmbAPIs.SelectedIndex = 0;

        }

        private string request_api(string url)
        {
            string json = string.Empty;

            txtLogs.AppendText(Lang.Eng.searching_url);
            txtLogs.AppendText(Environment.NewLine);
            txtLogs.AppendText(Lang.Eng.url);
            txtLogs.AppendText(url);
            txtLogs.AppendText(Environment.NewLine);

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.AutomaticDecompression = DecompressionMethods.GZip;

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    json = reader.ReadToEnd();
                }
            }
            catch (WebException e)
            {
                txtLogs.AppendText(Environment.NewLine);
                txtLogs.AppendText(e.Message);
                txtLogs.AppendText(Environment.NewLine);

                //MessageBox.Show(e.Message);
            }
            return json;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            facebook_results = new List<Result>();
            instagram_results = new List<Result>();
            linkedin_results = new List<Result>();
            other_results = new List<Result>();
            listViewResults.Items.Clear();


            string query = textSearch.Text;

            string json = string.Empty;
            dynamic jsonData;
            var results = new List<Result>();
            int total_results = -1;
            int start_index = -1;
            int count = -1;

            string url = @"https://www.googleapis.com/customsearch/v1?" +
                "key=" + google_api_key + "&" +
                "cx=" + google_cx_engine.cx + "&" +
                "q=" + query;

            textURI.Text = url;
            json = request_api(url);
            if (!json.Equals(String.Empty))
            {
                jsonData = JsonConvert.DeserializeObject(json);
                results = new List<Result>();
                if (jsonData.queries.request[0].totalResults != null)
                {
                    total_results = jsonData.queries.request[0].totalResults;

                }
                if (total_results > MAX_RESULTS)
                {
                    total_results = MAX_RESULTS;
                }
                start_index = jsonData.queries.request[0].startIndex;
                count = jsonData.queries.request[0].count;

                foreach (var item in jsonData.items)
                {
                    Result result = new Result
                    {
                        Title = item.title,
                        Link = item.link,
                        Snippet = item.snippet,
                    };
                    results.Add(result);
                    var list_item = new ListViewItem(new[] { result.Title, result.Link });
                    listViewResults.Items.Add(list_item);

                    if (results.Last().Link.Contains("facebook"))
                    {
                        facebook_results.Add(results.Last());

                    }
                    else if (results.Last().Link.Contains("instagram"))
                    {
                        instagram_results.Add(results.Last());
                    }
                    else if (results.Last().Link.Contains("linkedin"))
                    {
                        linkedin_results.Add(results.Last());
                    }
                    else
                    {
                        other_results.Add(results.Last());
                    }

                }
                start_index += count;
            }
            else
            {
                return;
            }
            do
            {
                System.Threading.Thread.Sleep(MillisecondsTimeout);
                string newurl = url + "&start=" + start_index;
                json = request_api(newurl);
                if (!json.Equals(String.Empty))
                {
                    jsonData = JsonConvert.DeserializeObject(json);
                    results = new List<Result>();
                    start_index = jsonData.queries.request[0].startIndex;
                    count = jsonData.queries.request[0].count;
                    if (jsonData.items != null) {
                        foreach (var item in jsonData.items)
                        {
                            Result result = new Result
                            {
                                Title = item.title,
                                Link = item.link,
                                Snippet = item.snippet,
                            };
                            results.Add(result);
                            var list_item = new ListViewItem(new[] { result.Title, result.Link });
                            listViewResults.Items.Add(list_item);

                            if (results.Last().Link.Contains("facebook"))
                            {
                                facebook_results.Add(results.Last());

                            }
                            else if (results.Last().Link.Contains("instagram"))
                            {
                                instagram_results.Add(results.Last());
                            }
                            else if (results.Last().Link.Contains("linkedin"))
                            {
                                linkedin_results.Add(results.Last());
                            }
                            else
                            {
                                other_results.Add(results.Last());
                            }
                        }
                }
                    if(jsonData.searchInformation.totalResults != null && jsonData.searchInformation.totalResults == 0)
                    {
                        string extra = "";
                        if(jsonData.spelling != null)
                        {
                            extra = "Suggested correction - " + jsonData.spelling.correctedQuery;
                        }
                        var list_item = new ListViewItem(new[] { "End of Results", extra });
                        listViewResults.Items.Add(list_item);
                    }
                    btnFaceBook.Text = "Facebook " + facebook_results.Count;
                    btnIG.Text = "Instagram " + instagram_results.Count;
                    btnLinkedIn.Text = "LinkedIn " + linkedin_results.Count;
                    btnOtherResults.Text = "Other " + other_results.Count;

                    start_index += count;
                }

                else
                {
                    return;
                }
            } while (start_index + count < total_results);

            //Console.WriteLine(html);
        }

        private void btnFaceBook_Click(object sender, EventArgs e)
        {
            SocialNetworkWindow window = new SocialNetworkWindow("Facebook", facebook_results);
            window.Text = "Facebook";
            window.Show();
        }

        private void cmbEngine_SelectedIndexChanged(object sender, EventArgs e)
        {
            google_cx_engine = engineInfo.engines[cmbEngine.SelectedIndex];
        }

        private void cmbAPIs_SelectedIndexChanged(object sender, EventArgs e)
        {
            engineInfo = Config.Instance.Apis[cmbAPIs.SelectedIndex];
            labelLimitReached.Visible = engineInfo.expired;
            pupulatecmbEngine();
            cmbEngine.SelectedIndex = 0;
            google_api_key = engineInfo.api_key;
        }

        private void pupulatecmbEngine()
        {
            cmbEngine.Items.Clear();
            foreach (Engine engine in engineInfo.engines)
            {
                cmbEngine.Items.Add(engine.title);
            }
        }

        private void btnIG_Click(object sender, EventArgs e)
        {
            SocialNetworkWindow window = new SocialNetworkWindow("Instagram", instagram_results);
            window.Text = "Instagram";
            window.Show();
        }

        private void btnLinkedIn_Click(object sender, EventArgs e)
        {
            SocialNetworkWindow window = new SocialNetworkWindow("LinkedIn", linkedin_results);
            window.Text = "LinkedIn";
            window.Show();
        }

        private void btnOtherResults_Click(object sender, EventArgs e)
        {
            SocialNetworkWindow window = new SocialNetworkWindow("Other Results", other_results);
            window.Text = "Other Results";
            window.Show();
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            SearchOptions window = new SearchOptions();
            window.Show();
        }

        private void txtResultLimit_ValueChanged(object sender, EventArgs e)
        {
            MAX_RESULTS = Int16.Parse(txtResultLimit.Value.ToString());
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            MillisecondsTimeout = Int16.Parse(numericUpDown1.Value.ToString());
        }
    }
}
