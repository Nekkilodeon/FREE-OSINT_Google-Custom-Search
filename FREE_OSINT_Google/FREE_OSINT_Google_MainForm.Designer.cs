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
            this.btnFaceBook = new System.Windows.Forms.Button();
            this.btnIG = new System.Windows.Forms.Button();
            this.btnLinkedIn = new System.Windows.Forms.Button();
            this.btnOtherResults = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.txtResultLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(12, 70);
            this.textSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(332, 22);
            this.textSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(13, 105);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(331, 46);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Google Custom Search";
            // 
            // textURI
            // 
            this.textURI.Location = new System.Drawing.Point(557, 70);
            this.textURI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textURI.Name = "textURI";
            this.textURI.Size = new System.Drawing.Size(600, 22);
            this.textURI.TabIndex = 4;
            // 
            // btnFaceBook
            // 
            this.btnFaceBook.Image = ((System.Drawing.Image)(resources.GetObject("btnFaceBook.Image")));
            this.btnFaceBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFaceBook.Location = new System.Drawing.Point(12, 217);
            this.btnFaceBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFaceBook.Name = "btnFaceBook";
            this.btnFaceBook.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnFaceBook.Size = new System.Drawing.Size(332, 46);
            this.btnFaceBook.TabIndex = 5;
            this.btnFaceBook.Text = "Facebook";
            this.btnFaceBook.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnFaceBook.UseVisualStyleBackColor = true;
            this.btnFaceBook.Click += new System.EventHandler(this.btnFaceBook_Click);
            // 
            // btnIG
            // 
            this.btnIG.Image = ((System.Drawing.Image)(resources.GetObject("btnIG.Image")));
            this.btnIG.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIG.Location = new System.Drawing.Point(12, 267);
            this.btnIG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIG.Name = "btnIG";
            this.btnIG.Size = new System.Drawing.Size(332, 46);
            this.btnIG.TabIndex = 6;
            this.btnIG.Text = "Instagram";
            this.btnIG.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnIG.UseVisualStyleBackColor = true;
            this.btnIG.Click += new System.EventHandler(this.btnIG_Click);
            // 
            // btnLinkedIn
            // 
            this.btnLinkedIn.Image = ((System.Drawing.Image)(resources.GetObject("btnLinkedIn.Image")));
            this.btnLinkedIn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLinkedIn.Location = new System.Drawing.Point(12, 317);
            this.btnLinkedIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLinkedIn.Name = "btnLinkedIn";
            this.btnLinkedIn.Size = new System.Drawing.Size(332, 43);
            this.btnLinkedIn.TabIndex = 7;
            this.btnLinkedIn.Text = "LinkedIn";
            this.btnLinkedIn.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnLinkedIn.UseVisualStyleBackColor = true;
            this.btnLinkedIn.Click += new System.EventHandler(this.btnLinkedIn_Click);
            // 
            // btnOtherResults
            // 
            this.btnOtherResults.Location = new System.Drawing.Point(12, 364);
            this.btnOtherResults.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOtherResults.Name = "btnOtherResults";
            this.btnOtherResults.Size = new System.Drawing.Size(332, 44);
            this.btnOtherResults.TabIndex = 8;
            this.btnOtherResults.Text = "Other";
            this.btnOtherResults.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnOtherResults.UseVisualStyleBackColor = true;
            this.btnOtherResults.Click += new System.EventHandler(this.btnOtherResults_Click);
            // 
            // cmbEngine
            // 
            this.cmbEngine.FormattingEnabled = true;
            this.cmbEngine.Location = new System.Drawing.Point(778, 25);
            this.cmbEngine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbEngine.Name = "cmbEngine";
            this.cmbEngine.Size = new System.Drawing.Size(271, 24);
            this.cmbEngine.TabIndex = 9;
            this.cmbEngine.SelectedIndexChanged += new System.EventHandler(this.cmbEngine_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(778, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Engine";
            // 
            // cmbAPIs
            // 
            this.cmbAPIs.FormattingEnabled = true;
            this.cmbAPIs.Location = new System.Drawing.Point(351, 25);
            this.cmbAPIs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbAPIs.Name = "cmbAPIs";
            this.cmbAPIs.Size = new System.Drawing.Size(421, 24);
            this.cmbAPIs.TabIndex = 11;
            this.cmbAPIs.SelectedIndexChanged += new System.EventHandler(this.cmbAPIs_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "API Key";
            // 
            // btnOptions
            // 
            this.btnOptions.Location = new System.Drawing.Point(304, 28);
            this.btnOptions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(40, 23);
            this.btnOptions.TabIndex = 13;
            this.btnOptions.Text = "...";
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
            this.txtResultLimit.Location = new System.Drawing.Point(1061, 25);
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
            this.label4.Location = new System.Drawing.Point(1057, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Result Nº Limit";
            // 
            // labelLimitReached
            // 
            this.labelLimitReached.AutoSize = true;
            this.labelLimitReached.ForeColor = System.Drawing.Color.DarkRed;
            this.labelLimitReached.Location = new System.Drawing.Point(679, 5);
            this.labelLimitReached.Name = "labelLimitReached";
            this.labelLimitReached.Size = new System.Drawing.Size(93, 17);
            this.labelLimitReached.TabIndex = 16;
            this.labelLimitReached.Text = "Limit reached";
            this.labelLimitReached.Visible = false;
            // 
            // listViewResults
            // 
            this.listViewResults.FullRowSelect = true;
            this.listViewResults.GridLines = true;
            this.listViewResults.HideSelection = false;
            this.listViewResults.Location = new System.Drawing.Point(351, 105);
            this.listViewResults.Name = "listViewResults";
            this.listViewResults.Size = new System.Drawing.Size(806, 303);
            this.listViewResults.TabIndex = 17;
            this.listViewResults.UseCompatibleStateImageBehavior = false;
            this.listViewResults.View = System.Windows.Forms.View.Details;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(554, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Generated URL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(350, 51);
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
            this.numericUpDown1.Location = new System.Drawing.Point(353, 70);
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
            200,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // txtLogs
            // 
            this.txtLogs.AcceptsTab = true;
            this.txtLogs.Location = new System.Drawing.Point(13, 426);
            this.txtLogs.Multiline = true;
            this.txtLogs.Name = "txtLogs";
            this.txtLogs.ReadOnly = true;
            this.txtLogs.Size = new System.Drawing.Size(1144, 105);
            this.txtLogs.TabIndex = 21;
            // 
            // FREE_OSINT_Google_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 543);
            this.Controls.Add(this.txtLogs);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listViewResults);
            this.Controls.Add(this.labelLimitReached);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtResultLimit);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbAPIs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbEngine);
            this.Controls.Add(this.btnOtherResults);
            this.Controls.Add(this.btnLinkedIn);
            this.Controls.Add(this.btnIG);
            this.Controls.Add(this.btnFaceBook);
            this.Controls.Add(this.textURI);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textSearch);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FREE_OSINT_Google_MainForm";
            this.Text = "FREE-OSINT Google Custom Search";
            ((System.ComponentModel.ISupportInitialize)(this.txtResultLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textURI;
        private System.Windows.Forms.Button btnFaceBook;
        private System.Windows.Forms.Button btnIG;
        private System.Windows.Forms.Button btnLinkedIn;
        private System.Windows.Forms.Button btnOtherResults;
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
    }
}

