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
    public partial class DetailsPage : Form
    {
        private Result r;

        public DetailsPage()
        {
            InitializeComponent();
        }

        public DetailsPage(Result r)
        {
            InitializeComponent();
            this.r = r;

            WebBrowser browser = new WebBrowser();
            browser.Navigate(r.Link);
            browser.Size = new System.Drawing.Size(1600, 800);
            this.Controls.Add(browser);
            browser.Show();
        }



        private void DetailsPage_Load(object sender, EventArgs e)
        {

        }
    }
}
