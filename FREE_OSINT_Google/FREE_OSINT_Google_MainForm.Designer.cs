namespace Main
{
    partial class FREE_OSINT_Google_MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FREE_OSINT_Google_MainForm));
            this.textSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textURI = new System.Windows.Forms.TextBox();
            this.cmbEngine = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAPIs = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOptions = new System.Windows.Forms.Button();
            this.txtResultLimit = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.labelLimitReached = new System.Windows.Forms.Label();
            this.listViewResults = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.txtLogs = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panelFilters = new System.Windows.Forms.FlowLayoutPanel();
            this.exactTermChk = new System.Windows.Forms.CheckBox();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelCenter = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.txtResultLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panelLeft.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(3, 41);
            this.textSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(329, 22);
            this.textSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(1, 97);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(331, 41);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Google Custom Search";
            // 
            // textURI
            // 
            this.textURI.Location = new System.Drawing.Point(212, 65);
            this.textURI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textURI.Name = "textURI";
            this.textURI.Size = new System.Drawing.Size(591, 22);
            this.textURI.TabIndex = 4;
            // 
            // cmbEngine
            // 
            this.cmbEngine.FormattingEnabled = true;
            this.cmbEngine.Location = new System.Drawing.Point(435, 22);
            this.cmbEngine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbEngine.Name = "cmbEngine";
            this.cmbEngine.Size = new System.Drawing.Size(271, 24);
            this.cmbEngine.TabIndex = 9;
            this.cmbEngine.SelectedIndexChanged += new System.EventHandler(this.cmbEngine_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(435, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Engine";
            // 
            // cmbAPIs
            // 
            this.cmbAPIs.FormattingEnabled = true;
            this.cmbAPIs.Location = new System.Drawing.Point(8, 22);
            this.cmbAPIs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbAPIs.Name = "cmbAPIs";
            this.cmbAPIs.Size = new System.Drawing.Size(421, 24);
            this.cmbAPIs.TabIndex = 11;
            this.cmbAPIs.SelectedIndexChanged += new System.EventHandler(this.cmbAPIs_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "API Key";
            // 
            // btnOptions
            // 
            this.btnOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOptions.Image")));
            this.btnOptions.Location = new System.Drawing.Point(292, 13);
            this.btnOptions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(40, 26);
            this.btnOptions.TabIndex = 13;
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // txtResultLimit
            // 
            this.txtResultLimit.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtResultLimit.Location = new System.Drawing.Point(710, 22);
            this.txtResultLimit.Name = "txtResultLimit";
            this.txtResultLimit.Size = new System.Drawing.Size(96, 22);
            this.txtResultLimit.TabIndex = 14;
            this.txtResultLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtResultLimit.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.txtResultLimit.ValueChanged += new System.EventHandler(this.txtResultLimit_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(707, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Result Nº Limit";
            // 
            // labelLimitReached
            // 
            this.labelLimitReached.AutoSize = true;
            this.labelLimitReached.ForeColor = System.Drawing.Color.DarkRed;
            this.labelLimitReached.Location = new System.Drawing.Point(336, 3);
            this.labelLimitReached.Name = "labelLimitReached";
            this.labelLimitReached.Size = new System.Drawing.Size(93, 17);
            this.labelLimitReached.TabIndex = 16;
            this.labelLimitReached.Text = "Limit reached";
            this.labelLimitReached.Visible = false;
            // 
            // listViewResults
            // 
            this.listViewResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewResults.FullRowSelect = true;
            this.listViewResults.GridLines = true;
            this.listViewResults.HideSelection = false;
            this.listViewResults.Location = new System.Drawing.Point(0, 0);
            this.listViewResults.Name = "listViewResults";
            this.listViewResults.Size = new System.Drawing.Size(834, 341);
            this.listViewResults.TabIndex = 17;
            this.listViewResults.UseCompatibleStateImageBehavior = false;
            this.listViewResults.View = System.Windows.Forms.View.Details;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Generated URL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Request Interval (ms)";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(8, 66);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(198, 22);
            this.numericUpDown1.TabIndex = 20;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // txtLogs
            // 
            this.txtLogs.AcceptsTab = true;
            this.txtLogs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtLogs.Location = new System.Drawing.Point(0, 438);
            this.txtLogs.Multiline = true;
            this.txtLogs.Name = "txtLogs";
            this.txtLogs.ReadOnly = true;
            this.txtLogs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLogs.Size = new System.Drawing.Size(1169, 105);
            this.txtLogs.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(834, 37);
            this.button1.TabIndex = 22;
            this.button1.Text = "Display All Results";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Engine filters";
            // 
            // panelFilters
            // 
            this.panelFilters.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelFilters.AutoScroll = true;
            this.panelFilters.Location = new System.Drawing.Point(0, 163);
            this.panelFilters.Name = "panelFilters";
            this.panelFilters.Size = new System.Drawing.Size(335, 225);
            this.panelFilters.TabIndex = 24;
            // 
            // exactTermChk
            // 
            this.exactTermChk.AutoSize = true;
            this.exactTermChk.Checked = true;
            this.exactTermChk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.exactTermChk.Location = new System.Drawing.Point(3, 67);
            this.exactTermChk.Name = "exactTermChk";
            this.exactTermChk.Size = new System.Drawing.Size(101, 21);
            this.exactTermChk.TabIndex = 25;
            this.exactTermChk.Text = "Exact Term";
            this.exactTermChk.UseVisualStyleBackColor = true;
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.label1);
            this.panelLeft.Controls.Add(this.panelFilters);
            this.panelLeft.Controls.Add(this.exactTermChk);
            this.panelLeft.Controls.Add(this.label7);
            this.panelLeft.Controls.Add(this.btnOptions);
            this.panelLeft.Controls.Add(this.textSearch);
            this.panelLeft.Controls.Add(this.btnSearch);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(335, 438);
            this.panelLeft.TabIndex = 26;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.textURI);
            this.panelTop.Controls.Add(this.label3);
            this.panelTop.Controls.Add(this.labelLimitReached);
            this.panelTop.Controls.Add(this.label6);
            this.panelTop.Controls.Add(this.label4);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Controls.Add(this.numericUpDown1);
            this.panelTop.Controls.Add(this.txtResultLimit);
            this.panelTop.Controls.Add(this.label5);
            this.panelTop.Controls.Add(this.cmbAPIs);
            this.panelTop.Controls.Add(this.cmbEngine);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(335, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(834, 97);
            this.panelTop.TabIndex = 27;
            // 
            // panelCenter
            // 
            this.panelCenter.Controls.Add(this.button1);
            this.panelCenter.Controls.Add(this.listViewResults);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(335, 97);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(834, 341);
            this.panelCenter.TabIndex = 28;
            // 
            // FREE_OSINT_Google_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 543);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.txtLogs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FREE_OSINT_Google_MainForm";
            this.Text = "FREE-OSINT Google Custom Search";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.closingForm);
            ((System.ComponentModel.ISupportInitialize)(this.txtResultLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelCenter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textURI;
        private System.Windows.Forms.ComboBox cmbEngine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAPIs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.NumericUpDown txtResultLimit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelLimitReached;
        private System.Windows.Forms.ListView listViewResults;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox txtLogs;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FlowLayoutPanel panelFilters;
        private System.Windows.Forms.CheckBox exactTermChk;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelCenter;
    }
}

