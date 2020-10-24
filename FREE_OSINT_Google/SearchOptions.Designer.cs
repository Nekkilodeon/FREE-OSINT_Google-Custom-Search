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
            this.cmbCountryCodes = new System.Windows.Forms.ComboBox();
            this.btnOkay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.chkSearchInURL = new System.Windows.Forms.CheckBox();
            this.txtINURL = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbCountryCodes
            // 
            this.cmbCountryCodes.FormattingEnabled = true;
            this.cmbCountryCodes.Location = new System.Drawing.Point(166, 70);
            this.cmbCountryCodes.Name = "cmbCountryCodes";
            this.cmbCountryCodes.Size = new System.Drawing.Size(246, 28);
            this.cmbCountryCodes.TabIndex = 0;
            this.cmbCountryCodes.SelectedIndexChanged += new System.EventHandler(this.cmbCountryCodes_SelectedIndexChanged);
            // 
            // btnOkay
            // 
            this.btnOkay.Location = new System.Drawing.Point(694, 409);
            this.btnOkay.Name = "btnOkay";
            this.btnOkay.Size = new System.Drawing.Size(94, 29);
            this.btnOkay.TabIndex = 2;
            this.btnOkay.Text = "OK";
            this.btnOkay.UseVisualStyleBackColor = true;
            this.btnOkay.Click += new System.EventHandler(this.btnOkay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(19, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Advanced Search Options";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(28, 70);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(82, 24);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Country";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chkSearchInURL
            // 
            this.chkSearchInURL.AutoSize = true;
            this.chkSearchInURL.Location = new System.Drawing.Point(28, 120);
            this.chkSearchInURL.Name = "chkSearchInURL";
            this.chkSearchInURL.Size = new System.Drawing.Size(121, 24);
            this.chkSearchInURL.TabIndex = 5;
            this.chkSearchInURL.Text = "Search in URL";
            this.chkSearchInURL.UseVisualStyleBackColor = true;
            // 
            // txtINURL
            // 
            this.txtINURL.Location = new System.Drawing.Point(166, 118);
            this.txtINURL.Name = "txtINURL";
            this.txtINURL.Size = new System.Drawing.Size(347, 27);
            this.txtINURL.TabIndex = 6;
            // 
            // SearchOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtINURL);
            this.Controls.Add(this.chkSearchInURL);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOkay);
            this.Controls.Add(this.cmbCountryCodes);
            this.Name = "SearchOptions";
            this.Text = "SearchOptions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCountryCodes;
        private System.Windows.Forms.Button btnOkay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox chkSearchInURL;
        private System.Windows.Forms.TextBox txtINURL;
    }
}