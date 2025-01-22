namespace RecapProject1
{
    partial class Form1
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
            gbxCategory = new GroupBox();
            cbxCategory = new ComboBox();
            lblCategory = new Label();
            gbxSearch = new GroupBox();
            lblSearch = new Label();
            txtSearch = new TextBox();
            dgwProduct = new DataGridView();
            gbxCategory.SuspendLayout();
            gbxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwProduct).BeginInit();
            SuspendLayout();
            // 
            // gbxCategory
            // 
            gbxCategory.Controls.Add(lblCategory);
            gbxCategory.Controls.Add(cbxCategory);
            gbxCategory.Location = new Point(12, 12);
            gbxCategory.Name = "gbxCategory";
            gbxCategory.Size = new Size(1110, 84);
            gbxCategory.TabIndex = 0;
            gbxCategory.TabStop = false;
            gbxCategory.Text = "Kategoriye Göre Listele";
            // 
            // cbxCategory
            // 
            cbxCategory.FormattingEnabled = true;
            cbxCategory.Location = new Point(97, 34);
            cbxCategory.Name = "cbxCategory";
            cbxCategory.Size = new Size(303, 28);
            cbxCategory.TabIndex = 0;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(18, 37);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(73, 20);
            lblCategory.TabIndex = 1;
            lblCategory.Text = "Kategori :";
            // 
            // gbxSearch
            // 
            gbxSearch.Controls.Add(txtSearch);
            gbxSearch.Controls.Add(lblSearch);
            gbxSearch.Location = new Point(12, 102);
            gbxSearch.Name = "gbxSearch";
            gbxSearch.Size = new Size(1110, 78);
            gbxSearch.TabIndex = 1;
            gbxSearch.TabStop = false;
            gbxSearch.Text = "Ürün İsmine Göre Ara";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(48, 38);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(39, 20);
            lblSearch.TabIndex = 2;
            lblSearch.Text = "Ara :";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(93, 31);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(303, 27);
            txtSearch.TabIndex = 3;
            // 
            // dgwProduct
            // 
            dgwProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwProduct.Location = new Point(15, 186);
            dgwProduct.Name = "dgwProduct";
            dgwProduct.RowHeadersWidth = 51;
            dgwProduct.Size = new Size(1110, 357);
            dgwProduct.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1137, 677);
            Controls.Add(dgwProduct);
            Controls.Add(gbxSearch);
            Controls.Add(gbxCategory);
            Name = "Form1";
            Text = "Form1";
            gbxCategory.ResumeLayout(false);
            gbxCategory.PerformLayout();
            gbxSearch.ResumeLayout(false);
            gbxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxCategory;
        private Label lblCategory;
        private ComboBox cbxCategory;
        private GroupBox gbxSearch;
        private TextBox txtSearch;
        private Label lblSearch;
        private DataGridView dgwProduct;
    }
}
