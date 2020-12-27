using FREE_OSINT_Lib;
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
        private List<Result> results;
        private FREE_OSINT_Google_MainForm mainForm;

        public SocialNetworkWindow()
        {
            InitializeComponent();
            listItems.Columns.Add("Title", 300, HorizontalAlignment.Left);
            listItems.Columns.Add("Link", -2, HorizontalAlignment.Left);
        }

        public SocialNetworkWindow(string v, List<Result> results, FREE_OSINT_Google_MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            listItems.Columns.Add("Title", 300, HorizontalAlignment.Left);
            listItems.Columns.Add("Link", -2, HorizontalAlignment.Left);
            this.results = results;
            if (results != null)
            {
                foreach (Result r in results)
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
                Result r = results[listItems.SelectedIndices[0]];
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
                Result r = results[listItems.SelectedIndices[0]];
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

        private void button1_Click(object sender, EventArgs e)
        {
            InteractEventArgs args = new InteractEventArgs();
            args.Operation = InteractEventArgs.Operation_Type.Insert;
            args.SelectedObjects = new HashSet<TreeNode>();
            foreach (ListViewItem item in listItems.Items)
            {
                if (item.Checked)
                {
                    List<TreeNode> treeNodes = new List<TreeNode>();
                    String title = item.SubItems[0].Text;
                    String link = item.SubItems[1].Text;
                    treeNodes.Add(new TreeNode(link));
                    String date = DateTime.Now.ToString();
                    treeNodes.Add(new TreeNode(date));
                    TreeNode treeNode = new TreeNode(title, treeNodes.ToArray());
                    args.SelectedObjects.Add(treeNode);
                }
            }
            mainForm.invokeEvent(args);
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listItems.Items)
            {
                item.Checked = true;
            }
        }

        private void btnDeselectAll_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listItems.Items)
            {
                item.Checked = false;
            }
        }
    }
}
