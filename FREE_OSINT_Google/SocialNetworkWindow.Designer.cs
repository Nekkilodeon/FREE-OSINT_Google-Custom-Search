namespace Main
{
    partial class SocialNetworkWindow
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
            this.listItems = new System.Windows.Forms.ListView();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnOpenBrowser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listItems
            // 
            this.listItems.FullRowSelect = true;
            this.listItems.GridLines = true;
            this.listItems.HideSelection = false;
            this.listItems.Location = new System.Drawing.Point(13, 29);
            this.listItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listItems.MultiSelect = false;
            this.listItems.Name = "listItems";
            this.listItems.Size = new System.Drawing.Size(565, 322);
            this.listItems.TabIndex = 1;
            this.listItems.UseCompatibleStateImageBehavior = false;
            this.listItems.View = System.Windows.Forms.View.Details;
            this.listItems.SelectedIndexChanged += new System.EventHandler(this.listItems_SelectedIndexChanged);
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(585, 29);
            this.btnDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(203, 36);
            this.btnDetails.TabIndex = 2;
            this.btnDetails.Text = "Details";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnOpenBrowser
            // 
            this.btnOpenBrowser.Location = new System.Drawing.Point(585, 69);
            this.btnOpenBrowser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpenBrowser.Name = "btnOpenBrowser";
            this.btnOpenBrowser.Size = new System.Drawing.Size(203, 34);
            this.btnOpenBrowser.TabIndex = 3;
            this.btnOpenBrowser.Text = "Open in Browser";
            this.btnOpenBrowser.UseVisualStyleBackColor = true;
            this.btnOpenBrowser.Click += new System.EventHandler(this.btnOpenBrowser_Click);
            // 
            // SocialNetworkWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 360);
            this.Controls.Add(this.btnOpenBrowser);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.listItems);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SocialNetworkWindow";
            this.Text = "SocialNetworkWindow";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listItems;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Button btnOpenBrowser;
    }
}