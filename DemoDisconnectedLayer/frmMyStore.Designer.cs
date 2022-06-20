namespace DemoDisconnectedLayer
{
    partial class frmMyStore
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
            this.btnViewProducts = new System.Windows.Forms.Button();
            this.btnViewCategories = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnViewProducts
            // 
            this.btnViewProducts.Location = new System.Drawing.Point(82, 24);
            this.btnViewProducts.Name = "btnViewProducts";
            this.btnViewProducts.Size = new System.Drawing.Size(111, 37);
            this.btnViewProducts.TabIndex = 0;
            this.btnViewProducts.Text = "View Products";
            this.btnViewProducts.UseVisualStyleBackColor = true;
            this.btnViewProducts.Click += new System.EventHandler(this.btnViewProducts_Click);
            // 
            // btnViewCategories
            // 
            this.btnViewCategories.Location = new System.Drawing.Point(396, 24);
            this.btnViewCategories.Name = "btnViewCategories";
            this.btnViewCategories.Size = new System.Drawing.Size(111, 37);
            this.btnViewCategories.TabIndex = 0;
            this.btnViewCategories.Text = "View Categories";
            this.btnViewCategories.UseVisualStyleBackColor = true;
            this.btnViewCategories.Click += new System.EventHandler(this.btnViewCategories_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(245, 401);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(111, 37);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(12, 77);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowTemplate.Height = 25;
            this.dgvData.Size = new System.Drawing.Size(557, 318);
            this.dgvData.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 450);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnViewCategories);
            this.Controls.Add(this.btnViewProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnViewProducts;
        private Button btnViewCategories;
        private Button btnClose;
        private DataGridView dgvData;
    }
}