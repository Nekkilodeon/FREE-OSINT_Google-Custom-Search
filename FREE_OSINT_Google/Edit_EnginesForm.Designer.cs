namespace FREE_OSINT_Google
{
    partial class Edit_EnginesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_EnginesForm));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEditAPI = new System.Windows.Forms.Button();
            this.btnAPIRemove = new System.Windows.Forms.Button();
            this.btnEngineRemove = new System.Windows.Forms.Button();
            this.btnEditEngine = new System.Windows.Forms.Button();
            this.btnAddAPI = new System.Windows.Forms.Button();
            this.btnAddEngine = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.listBoxAPIs = new System.Windows.Forms.ListBox();
            this.listBoxEngines = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "API Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Engine";
            // 
            // btnEditAPI
            // 
            this.btnEditAPI.Location = new System.Drawing.Point(417, 82);
            this.btnEditAPI.Name = "btnEditAPI";
            this.btnEditAPI.Size = new System.Drawing.Size(97, 39);
            this.btnEditAPI.TabIndex = 37;
            this.btnEditAPI.Text = "Edit";
            this.btnEditAPI.UseVisualStyleBackColor = true;
            this.btnEditAPI.Click += new System.EventHandler(this.btnEditAPI_Click);
            // 
            // btnAPIRemove
            // 
            this.btnAPIRemove.Location = new System.Drawing.Point(417, 127);
            this.btnAPIRemove.Name = "btnAPIRemove";
            this.btnAPIRemove.Size = new System.Drawing.Size(97, 42);
            this.btnAPIRemove.TabIndex = 38;
            this.btnAPIRemove.Text = "Remove";
            this.btnAPIRemove.UseVisualStyleBackColor = true;
            this.btnAPIRemove.Click += new System.EventHandler(this.btnAPIRemove_Click);
            // 
            // btnEngineRemove
            // 
            this.btnEngineRemove.Location = new System.Drawing.Point(417, 286);
            this.btnEngineRemove.Name = "btnEngineRemove";
            this.btnEngineRemove.Size = new System.Drawing.Size(97, 39);
            this.btnEngineRemove.TabIndex = 40;
            this.btnEngineRemove.Text = "Remove";
            this.btnEngineRemove.UseVisualStyleBackColor = true;
            this.btnEngineRemove.Click += new System.EventHandler(this.btnEngineRemove_Click);
            // 
            // btnEditEngine
            // 
            this.btnEditEngine.Location = new System.Drawing.Point(417, 238);
            this.btnEditEngine.Name = "btnEditEngine";
            this.btnEditEngine.Size = new System.Drawing.Size(97, 42);
            this.btnEditEngine.TabIndex = 39;
            this.btnEditEngine.Text = "Edit";
            this.btnEditEngine.UseVisualStyleBackColor = true;
            this.btnEditEngine.Click += new System.EventHandler(this.btnEditEngine_Click);
            // 
            // btnAddAPI
            // 
            this.btnAddAPI.Location = new System.Drawing.Point(417, 37);
            this.btnAddAPI.Name = "btnAddAPI";
            this.btnAddAPI.Size = new System.Drawing.Size(97, 39);
            this.btnAddAPI.TabIndex = 43;
            this.btnAddAPI.Text = "Add";
            this.btnAddAPI.UseVisualStyleBackColor = true;
            this.btnAddAPI.Click += new System.EventHandler(this.btnAddAPI_Click);
            // 
            // btnAddEngine
            // 
            this.btnAddEngine.Location = new System.Drawing.Point(417, 193);
            this.btnAddEngine.Name = "btnAddEngine";
            this.btnAddEngine.Size = new System.Drawing.Size(97, 39);
            this.btnAddEngine.TabIndex = 44;
            this.btnAddEngine.Text = "Add";
            this.btnAddEngine.UseVisualStyleBackColor = true;
            this.btnAddEngine.Click += new System.EventHandler(this.btnAddEngine_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(144, 340);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 46);
            this.btnCancel.TabIndex = 45;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(261, 340);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(111, 46);
            this.btnOK.TabIndex = 46;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // listBoxAPIs
            // 
            this.listBoxAPIs.FormattingEnabled = true;
            this.listBoxAPIs.ItemHeight = 16;
            this.listBoxAPIs.Location = new System.Drawing.Point(12, 37);
            this.listBoxAPIs.Name = "listBoxAPIs";
            this.listBoxAPIs.Size = new System.Drawing.Size(395, 132);
            this.listBoxAPIs.TabIndex = 47;
            this.listBoxAPIs.SelectedIndexChanged += new System.EventHandler(this.listBoxAPISelectedIndexChanged);
            // 
            // listBoxEngines
            // 
            this.listBoxEngines.FormattingEnabled = true;
            this.listBoxEngines.ItemHeight = 16;
            this.listBoxEngines.Location = new System.Drawing.Point(12, 193);
            this.listBoxEngines.Name = "listBoxEngines";
            this.listBoxEngines.Size = new System.Drawing.Size(395, 132);
            this.listBoxEngines.TabIndex = 48;
            // 
            // Edit_EnginesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 399);
            this.Controls.Add(this.listBoxEngines);
            this.Controls.Add(this.listBoxAPIs);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddEngine);
            this.Controls.Add(this.btnAddAPI);
            this.Controls.Add(this.btnEngineRemove);
            this.Controls.Add(this.btnEditEngine);
            this.Controls.Add(this.btnAPIRemove);
            this.Controls.Add(this.btnEditAPI);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Edit_EnginesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configure Keys";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEditAPI;
        private System.Windows.Forms.Button btnAPIRemove;
        private System.Windows.Forms.Button btnEngineRemove;
        private System.Windows.Forms.Button btnEditEngine;
        private System.Windows.Forms.Button btnAddAPI;
        private System.Windows.Forms.Button btnAddEngine;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ListBox listBoxAPIs;
        private System.Windows.Forms.ListBox listBoxEngines;
    }
}