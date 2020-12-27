namespace Main
{
    partial class SearchOptions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchOptions));
            this.cmbCRCountryCodes = new System.Windows.Forms.ComboBox();
            this.btnOkay = new System.Windows.Forms.Button();
            this.cr = new System.Windows.Forms.CheckBox();
            this.linkSite = new System.Windows.Forms.CheckBox();
            this.txtLinkSite = new System.Windows.Forms.TextBox();
            this.btnEngines = new System.Windows.Forms.Button();
            this.btnAllParams = new System.Windows.Forms.Button();
            this.dateRestrict = new System.Windows.Forms.CheckBox();
            this.dateRestrictValue = new System.Windows.Forms.NumericUpDown();
            this.cmbdateRestrictType = new System.Windows.Forms.ComboBox();
            this.exactTerms = new System.Windows.Forms.CheckBox();
            this.exactTermsValue = new System.Windows.Forms.TextBox();
            this.excludeTermsValue = new System.Windows.Forms.TextBox();
            this.excludeTerms = new System.Windows.Forms.CheckBox();
            this.fileTypeValue = new System.Windows.Forms.TextBox();
            this.fileType = new System.Windows.Forms.CheckBox();
            this.btnSupportedTypes = new System.Windows.Forms.Button();
            this.filter = new System.Windows.Forms.CheckBox();
            this.gl = new System.Windows.Forms.CheckBox();
            this.cmbGeoLocation = new System.Windows.Forms.ComboBox();
            this.lr = new System.Windows.Forms.CheckBox();
            this.cmbLR = new System.Windows.Forms.ComboBox();
            this.relatedSiteValue = new System.Windows.Forms.TextBox();
            this.relatedSite = new System.Windows.Forms.CheckBox();
            this.extraParamsValue = new System.Windows.Forms.TextBox();
            this.extraParams = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbAPIs = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEngine = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResultLimit = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dateRestrictValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtResultLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCRCountryCodes
            // 
            this.cmbCRCountryCodes.FormattingEnabled = true;
            this.cmbCRCountryCodes.Location = new System.Drawing.Point(160, 78);
            this.cmbCRCountryCodes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCRCountryCodes.Name = "cmbCRCountryCodes";
            this.cmbCRCountryCodes.Size = new System.Drawing.Size(246, 24);
            this.cmbCRCountryCodes.TabIndex = 0;
            this.cmbCRCountryCodes.SelectedIndexChanged += new System.EventHandler(this.cmbCountryCodes_SelectedIndexChanged);
            // 
            // btnOkay
            // 
            this.btnOkay.Location = new System.Drawing.Point(682, 328);
            this.btnOkay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOkay.Name = "btnOkay";
            this.btnOkay.Size = new System.Drawing.Size(101, 24);
            this.btnOkay.TabIndex = 2;
            this.btnOkay.Text = "OK";
            this.btnOkay.UseVisualStyleBackColor = true;
            this.btnOkay.Click += new System.EventHandler(this.btnOkay_Click);
            // 
            // cr
            // 
            this.cr.AutoSize = true;
            this.cr.Location = new System.Drawing.Point(13, 79);
            this.cr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cr.Name = "cr";
            this.cr.Size = new System.Drawing.Size(137, 21);
            this.cr.TabIndex = 4;
            this.cr.Text = "Documents From";
            this.cr.UseVisualStyleBackColor = true;
            this.cr.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // linkSite
            // 
            this.linkSite.AutoSize = true;
            this.linkSite.Location = new System.Drawing.Point(13, 120);
            this.linkSite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.linkSite.Name = "linkSite";
            this.linkSite.Size = new System.Drawing.Size(142, 21);
            this.linkSite.TabIndex = 5;
            this.linkSite.Text = "Must contain URL";
            this.linkSite.UseVisualStyleBackColor = true;
            // 
            // txtLinkSite
            // 
            this.txtLinkSite.Location = new System.Drawing.Point(160, 119);
            this.txtLinkSite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLinkSite.Name = "txtLinkSite";
            this.txtLinkSite.Size = new System.Drawing.Size(246, 22);
            this.txtLinkSite.TabIndex = 6;
            this.txtLinkSite.Text = "www.example.com";
            // 
            // btnEngines
            // 
            this.btnEngines.Image = ((System.Drawing.Image)(resources.GetObject("btnEngines.Image")));
            this.btnEngines.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEngines.Location = new System.Drawing.Point(682, 74);
            this.btnEngines.Name = "btnEngines";
            this.btnEngines.Size = new System.Drawing.Size(101, 30);
            this.btnEngines.TabIndex = 7;
            this.btnEngines.Text = "Engines";
            this.btnEngines.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEngines.UseVisualStyleBackColor = true;
            this.btnEngines.Click += new System.EventHandler(this.btnEngines_Click);
            // 
            // btnAllParams
            // 
            this.btnAllParams.Image = ((System.Drawing.Image)(resources.GetObject("btnAllParams.Image")));
            this.btnAllParams.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllParams.Location = new System.Drawing.Point(542, 74);
            this.btnAllParams.Name = "btnAllParams";
            this.btnAllParams.Size = new System.Drawing.Size(134, 30);
            this.btnAllParams.TabIndex = 8;
            this.btnAllParams.Text = "All Parameters";
            this.btnAllParams.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAllParams.UseVisualStyleBackColor = true;
            this.btnAllParams.Click += new System.EventHandler(this.btnAllParams_Click);
            // 
            // dateRestrict
            // 
            this.dateRestrict.AutoSize = true;
            this.dateRestrict.Location = new System.Drawing.Point(13, 161);
            this.dateRestrict.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateRestrict.Name = "dateRestrict";
            this.dateRestrict.Size = new System.Drawing.Size(57, 21);
            this.dateRestrict.TabIndex = 9;
            this.dateRestrict.Text = "Last";
            this.dateRestrict.UseVisualStyleBackColor = true;
            // 
            // dateRestrictValue
            // 
            this.dateRestrictValue.Location = new System.Drawing.Point(160, 162);
            this.dateRestrictValue.Name = "dateRestrictValue";
            this.dateRestrictValue.Size = new System.Drawing.Size(71, 22);
            this.dateRestrictValue.TabIndex = 10;
            // 
            // cmbdateRestrictType
            // 
            this.cmbdateRestrictType.FormattingEnabled = true;
            this.cmbdateRestrictType.Items.AddRange(new object[] {
            "Days",
            "Weeks",
            "Months",
            "Years"});
            this.cmbdateRestrictType.Location = new System.Drawing.Point(238, 162);
            this.cmbdateRestrictType.Name = "cmbdateRestrictType";
            this.cmbdateRestrictType.Size = new System.Drawing.Size(168, 24);
            this.cmbdateRestrictType.TabIndex = 11;
            // 
            // exactTerms
            // 
            this.exactTerms.AutoSize = true;
            this.exactTerms.Location = new System.Drawing.Point(13, 204);
            this.exactTerms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exactTerms.Name = "exactTerms";
            this.exactTerms.Size = new System.Drawing.Size(110, 21);
            this.exactTerms.TabIndex = 12;
            this.exactTerms.Text = "Must contain";
            this.exactTerms.UseVisualStyleBackColor = true;
            // 
            // exactTermsValue
            // 
            this.exactTermsValue.Location = new System.Drawing.Point(160, 203);
            this.exactTermsValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exactTermsValue.Name = "exactTermsValue";
            this.exactTermsValue.Size = new System.Drawing.Size(246, 22);
            this.exactTermsValue.TabIndex = 13;
            this.exactTermsValue.Text = "keyword";
            // 
            // excludeTermsValue
            // 
            this.excludeTermsValue.Location = new System.Drawing.Point(160, 244);
            this.excludeTermsValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.excludeTermsValue.Name = "excludeTermsValue";
            this.excludeTermsValue.Size = new System.Drawing.Size(246, 22);
            this.excludeTermsValue.TabIndex = 15;
            this.excludeTermsValue.Text = "keyword";
            // 
            // excludeTerms
            // 
            this.excludeTerms.AutoSize = true;
            this.excludeTerms.Location = new System.Drawing.Point(13, 245);
            this.excludeTerms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.excludeTerms.Name = "excludeTerms";
            this.excludeTerms.Size = new System.Drawing.Size(130, 21);
            this.excludeTerms.TabIndex = 14;
            this.excludeTerms.Text = "Doesn\'t Contain";
            this.excludeTerms.UseVisualStyleBackColor = true;
            // 
            // fileTypeValue
            // 
            this.fileTypeValue.Location = new System.Drawing.Point(160, 287);
            this.fileTypeValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fileTypeValue.Name = "fileTypeValue";
            this.fileTypeValue.Size = new System.Drawing.Size(198, 22);
            this.fileTypeValue.TabIndex = 17;
            this.fileTypeValue.Text = "pdf";
            // 
            // fileType
            // 
            this.fileType.AutoSize = true;
            this.fileType.Location = new System.Drawing.Point(13, 288);
            this.fileType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fileType.Name = "fileType";
            this.fileType.Size = new System.Drawing.Size(83, 21);
            this.fileType.TabIndex = 16;
            this.fileType.Text = "File type";
            this.fileType.UseVisualStyleBackColor = true;
            // 
            // btnSupportedTypes
            // 
            this.btnSupportedTypes.Location = new System.Drawing.Point(364, 286);
            this.btnSupportedTypes.Name = "btnSupportedTypes";
            this.btnSupportedTypes.Size = new System.Drawing.Size(42, 23);
            this.btnSupportedTypes.TabIndex = 18;
            this.btnSupportedTypes.Text = "?";
            this.btnSupportedTypes.UseVisualStyleBackColor = true;
            this.btnSupportedTypes.Click += new System.EventHandler(this.btnSupportedTypes_Click);
            // 
            // filter
            // 
            this.filter.AutoSize = true;
            this.filter.Location = new System.Drawing.Point(418, 119);
            this.filter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(234, 21);
            this.filter.TabIndex = 19;
            this.filter.Text = "Turn OFF duplicate content filter";
            this.filter.UseVisualStyleBackColor = true;
            // 
            // gl
            // 
            this.gl.AutoSize = true;
            this.gl.Location = new System.Drawing.Point(13, 330);
            this.gl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gl.Name = "gl";
            this.gl.Size = new System.Drawing.Size(106, 21);
            this.gl.TabIndex = 21;
            this.gl.Text = "Geolocation";
            this.gl.UseVisualStyleBackColor = true;
            // 
            // cmbGeoLocation
            // 
            this.cmbGeoLocation.FormattingEnabled = true;
            this.cmbGeoLocation.Location = new System.Drawing.Point(160, 329);
            this.cmbGeoLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbGeoLocation.Name = "cmbGeoLocation";
            this.cmbGeoLocation.Size = new System.Drawing.Size(246, 24);
            this.cmbGeoLocation.TabIndex = 20;
            // 
            // lr
            // 
            this.lr.AutoSize = true;
            this.lr.Location = new System.Drawing.Point(418, 164);
            this.lr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lr.Name = "lr";
            this.lr.Size = new System.Drawing.Size(157, 21);
            this.lr.TabIndex = 23;
            this.lr.Text = "Document language";
            this.lr.UseVisualStyleBackColor = true;
            // 
            // cmbLR
            // 
            this.cmbLR.FormattingEnabled = true;
            this.cmbLR.Location = new System.Drawing.Point(581, 162);
            this.cmbLR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbLR.Name = "cmbLR";
            this.cmbLR.Size = new System.Drawing.Size(202, 24);
            this.cmbLR.TabIndex = 22;
            // 
            // relatedSiteValue
            // 
            this.relatedSiteValue.Location = new System.Drawing.Point(581, 202);
            this.relatedSiteValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.relatedSiteValue.Name = "relatedSiteValue";
            this.relatedSiteValue.Size = new System.Drawing.Size(202, 22);
            this.relatedSiteValue.TabIndex = 25;
            this.relatedSiteValue.Text = "www.example.com";
            // 
            // relatedSite
            // 
            this.relatedSite.AutoSize = true;
            this.relatedSite.Location = new System.Drawing.Point(418, 204);
            this.relatedSite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.relatedSite.Name = "relatedSite";
            this.relatedSite.Size = new System.Drawing.Size(127, 21);
            this.relatedSite.TabIndex = 24;
            this.relatedSite.Text = "Related to URL";
            this.relatedSite.UseVisualStyleBackColor = true;
            // 
            // extraParamsValue
            // 
            this.extraParamsValue.Location = new System.Drawing.Point(581, 242);
            this.extraParamsValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.extraParamsValue.Name = "extraParamsValue";
            this.extraParamsValue.Size = new System.Drawing.Size(202, 22);
            this.extraParamsValue.TabIndex = 27;
            this.extraParamsValue.Text = "sort=date";
            // 
            // extraParams
            // 
            this.extraParams.AutoSize = true;
            this.extraParams.Location = new System.Drawing.Point(418, 244);
            this.extraParams.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.extraParams.Name = "extraParams";
            this.extraParams.Size = new System.Drawing.Size(139, 21);
            this.extraParams.TabIndex = 26;
            this.extraParams.Text = "Extra Parameters";
            this.extraParams.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(542, 327);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(134, 24);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "API Key";
            // 
            // cmbAPIs
            // 
            this.cmbAPIs.FormattingEnabled = true;
            this.cmbAPIs.Location = new System.Drawing.Point(11, 26);
            this.cmbAPIs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbAPIs.Name = "cmbAPIs";
            this.cmbAPIs.Size = new System.Drawing.Size(395, 24);
            this.cmbAPIs.TabIndex = 31;
            this.cmbAPIs.SelectedIndexChanged += new System.EventHandler(this.cmbAPIs_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(415, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Engine";
            // 
            // cmbEngine
            // 
            this.cmbEngine.FormattingEnabled = true;
            this.cmbEngine.Location = new System.Drawing.Point(418, 25);
            this.cmbEngine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbEngine.Name = "cmbEngine";
            this.cmbEngine.Size = new System.Drawing.Size(258, 24);
            this.cmbEngine.TabIndex = 29;
            this.cmbEngine.SelectedIndexChanged += new System.EventHandler(this.cmbEngine_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(678, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Result Nº Limit";
            // 
            // txtResultLimit
            // 
            this.txtResultLimit.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtResultLimit.Location = new System.Drawing.Point(682, 27);
            this.txtResultLimit.Name = "txtResultLimit";
            this.txtResultLimit.Size = new System.Drawing.Size(96, 22);
            this.txtResultLimit.TabIndex = 33;
            this.txtResultLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtResultLimit.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // SearchOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 376);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtResultLimit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbAPIs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbEngine);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.extraParamsValue);
            this.Controls.Add(this.extraParams);
            this.Controls.Add(this.relatedSiteValue);
            this.Controls.Add(this.relatedSite);
            this.Controls.Add(this.lr);
            this.Controls.Add(this.cmbLR);
            this.Controls.Add(this.gl);
            this.Controls.Add(this.cmbGeoLocation);
            this.Controls.Add(this.filter);
            this.Controls.Add(this.btnSupportedTypes);
            this.Controls.Add(this.fileTypeValue);
            this.Controls.Add(this.fileType);
            this.Controls.Add(this.excludeTermsValue);
            this.Controls.Add(this.excludeTerms);
            this.Controls.Add(this.exactTermsValue);
            this.Controls.Add(this.exactTerms);
            this.Controls.Add(this.cmbdateRestrictType);
            this.Controls.Add(this.dateRestrictValue);
            this.Controls.Add(this.dateRestrict);
            this.Controls.Add(this.btnAllParams);
            this.Controls.Add(this.btnEngines);
            this.Controls.Add(this.txtLinkSite);
            this.Controls.Add(this.linkSite);
            this.Controls.Add(this.cr);
            this.Controls.Add(this.btnOkay);
            this.Controls.Add(this.cmbCRCountryCodes);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SearchOptions";
            this.Text = "Search Options";
            this.Load += new System.EventHandler(this.SearchOptions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dateRestrictValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtResultLimit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCRCountryCodes;
        private System.Windows.Forms.Button btnOkay;
        private System.Windows.Forms.CheckBox cr;
        private System.Windows.Forms.CheckBox linkSite;
        private System.Windows.Forms.TextBox txtLinkSite;
        private System.Windows.Forms.Button btnEngines;
        private System.Windows.Forms.Button btnAllParams;
        private System.Windows.Forms.CheckBox dateRestrict;
        private System.Windows.Forms.NumericUpDown dateRestrictValue;
        private System.Windows.Forms.ComboBox cmbdateRestrictType;
        private System.Windows.Forms.CheckBox exactTerms;
        private System.Windows.Forms.TextBox exactTermsValue;
        private System.Windows.Forms.TextBox excludeTermsValue;
        private System.Windows.Forms.CheckBox excludeTerms;
        private System.Windows.Forms.TextBox fileTypeValue;
        private System.Windows.Forms.CheckBox fileType;
        private System.Windows.Forms.Button btnSupportedTypes;
        private System.Windows.Forms.CheckBox filter;
        private System.Windows.Forms.CheckBox gl;
        private System.Windows.Forms.ComboBox cmbGeoLocation;
        private System.Windows.Forms.CheckBox lr;
        private System.Windows.Forms.ComboBox cmbLR;
        private System.Windows.Forms.TextBox relatedSiteValue;
        private System.Windows.Forms.CheckBox relatedSite;
        private System.Windows.Forms.TextBox extraParamsValue;
        private System.Windows.Forms.CheckBox extraParams;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbAPIs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbEngine;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtResultLimit;
    }
}