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
    public partial class Search_engine_form : Form
    {
        public string cx = "";
        public string title = "";
        public List<string> filters = new List<string>();
        public int index = -1;
        public Search_engine_form()
        {
            InitializeComponent();
        }

        public Search_engine_form(int index ,string title, string search_engine_id)
        {
            this.index = index;
            this.title = title;
            this.cx = search_engine_id;
            InitializeComponent();
            txtTitle.Text = title;
            txtSearch_engine_id.Text = search_engine_id;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.title = txtTitle.Text;
            this.cx = txtSearch_engine_id.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnInsertFilters_Click(object sender, EventArgs e)
        {
            filters.Add(txtFilter.Text);
            txtFilter.Text = "";
            refreshCheckList();
        }

        private void btnEditFilter_Click(object sender, EventArgs e)
        {

            txtFilter.Text = filters[listFilters.SelectedIndex];
            filters.RemoveAt(listFilters.SelectedIndex);
            refreshCheckList();

        }

        private void btnRemoveFilter_Click(object sender, EventArgs e)
        {
            foreach (string filter in listFilters.CheckedItems)
            {
                filters.Remove(filter);
            }
            refreshCheckList();
        }

        private void refreshCheckList()
        {
            listFilters.Items.Clear();
            foreach (string filter in filters)
            {
                listFilters.Items.Add(filter);
            }
        }
    }
}
