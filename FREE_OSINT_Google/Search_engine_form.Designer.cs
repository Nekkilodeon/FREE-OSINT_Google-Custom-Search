namespace FREE_OSINT_Google
{
    partial class Search_engine_form
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtSearch_engine_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEditFilter = new System.Windows.Forms.Button();
            this.btnRemoveFilter = new System.Windows.Forms.Button();
            this.btnInsertFilters = new System.Windows.Forms.Button();
            this.listFilters = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(16, 44);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(432, 22);
            this.txtTitle.TabIndex = 1;
            // 
            // txtSearch_engine_id
            // 
            this.txtSearch_engine_id.Location = new System.Drawing.Point(16, 110);
            this.txtSearch_engine_id.Name = "txtSearch_engine_id";
            this.txtSearch_engine_id.Size = new System.Drawing.Size(432, 22);
            this.txtSearch_engine_id.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search Engine ID (CX)";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(234, 326);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(85, 45);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(137, 326);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 45);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEditFilter
            // 
            this.btnEditFilter.Location = new System.Drawing.Point(364, 231);
            this.btnEditFilter.Name = "btnEditFilter";
            this.btnEditFilter.Size = new System.Drawing.Size(84, 27);
            this.btnEditFilter.TabIndex = 17;
            this.btnEditFilter.Text = "Edit";
            this.btnEditFilter.UseVisualStyleBackColor = true;
            this.btnEditFilter.Click += new System.EventHandler(this.btnEditFilter_Click);
            // 
            // btnRemoveFilter
            // 
            this.btnRemoveFilter.Location = new System.Drawing.Point(364, 264);
            this.btnRemoveFilter.Name = "btnRemoveFilter";
            this.btnRemoveFilter.Size = new System.Drawing.Size(83, 26);
            this.btnRemoveFilter.TabIndex = 16;
            this.btnRemoveFilter.Text = "Remove";
            this.btnRemoveFilter.UseVisualStyleBackColor = true;
            this.btnRemoveFilter.Click += new System.EventHandler(this.btnRemoveFilter_Click);
            // 
            // btnInsertFilters
            // 
            this.btnInsertFilters.Location = new System.Drawing.Point(364, 198);
            this.btnInsertFilters.Name = "btnInsertFilters";
            this.btnInsertFilters.Size = new System.Drawing.Size(84, 27);
            this.btnInsertFilters.TabIndex = 15;
            this.btnInsertFilters.Text = "Insert";
            this.btnInsertFilters.UseVisualStyleBackColor = true;
            this.btnInsertFilters.Click += new System.EventHandler(this.btnInsertFilters_Click);
            // 
            // listFilters
            // 
            this.listFilters.FormattingEnabled = true;
            this.listFilters.Location = new System.Drawing.Point(16, 231);
            this.listFilters.Name = "listFilters";
            this.listFilters.Size = new System.Drawing.Size(342, 89);
            this.listFilters.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Sites to search (Optional)";
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(16, 198);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(342, 22);
            this.txtFilter.TabIndex = 19;
            // 
            // Search_engine_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 383);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEditFilter);
            this.Controls.Add(this.btnRemoveFilter);
            this.Controls.Add(this.btnInsertFilters);
            this.Controls.Add(this.listFilters);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtSearch_engine_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label1);
            this.Name = "Search_engine_form";
            this.Text = "Search Engine Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtSearch_engine_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEditFilter;
        private System.Windows.Forms.Button btnRemoveFilter;
        private System.Windows.Forms.Button btnInsertFilters;
        private System.Windows.Forms.CheckedListBox listFilters;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFilter;
    }
}