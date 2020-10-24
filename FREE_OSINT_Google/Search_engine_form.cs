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
    }
}
