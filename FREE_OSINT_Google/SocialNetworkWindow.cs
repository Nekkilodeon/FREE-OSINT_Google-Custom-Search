using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Main
{
    public partial class SocialNetworkWindow : Form
    {
        private List<Result> facebook_results;

        public SocialNetworkWindow()
        {
            InitializeComponent();
            listItems.Columns.Add("Title", 300, HorizontalAlignment.Left);
            listItems.Columns.Add("Link", -2, HorizontalAlignment.Left);
        }

        public SocialNetworkWindow(string v, List<Result> facebook_results)
        {

            InitializeComponent();
            listItems.Columns.Add("Title", 300, HorizontalAlignment.Left);
            listItems.Columns.Add("Link", -2, HorizontalAlignment.Left);
            this.facebook_results = facebook_results;
            if (facebook_results != null)
            {
                foreach (Result r in facebook_results)
                {
                    var list_item = new ListViewItem(new[] { r.Title, r.Link });
                    listItems.Items.Add(list_item);
                }
            }
        }


        private void btnDetails_Click(object sender, EventArgs e)
        {
            try
            {
                Result r = facebook_results[listItems.SelectedIndices[0]];
                DetailsPage page = new DetailsPage(r);
                page.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOpenBrowser_Click(object sender, EventArgs e)
        {
            try
            {
                Result r = facebook_results[listItems.SelectedIndices[0]];
                Config.Instance.OpenUrl(r.Link);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
