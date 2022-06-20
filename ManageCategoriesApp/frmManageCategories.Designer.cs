namespace ManageCategoriesApp
{
    partial class frmManageCategories
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
            this.IbCategoryID = new System.Windows.Forms.Label();
            this.IbCategoryName = new System.Windows.Forms.Label();
            this.txtCategoryID = new System.Windows.Forms.TextBox();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.dgvCategories = new System.Windows.Forms.DataGridView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // IbCategoryID
            // 
            this.IbCategoryID.AutoSize = true;
            this.IbCategoryID.Location = new System.Drawing.Point(51, 30);
            this.IbCategoryID.Name = "IbCategoryID";
            this.IbCategoryID.Size = new System.Drawing.Size(69, 15);
            this.IbCategoryID.TabIndex = 0;
            this.IbCategoryID.Text = "Category ID";
            // 
            // IbCategoryName
            // 
            this.IbCategoryName.AutoSize = true;
            this.IbCategoryName.Location = new System.Drawing.Point(51, 59);
            this.IbCategoryName.Name = "IbCategoryName";
            this.IbCategoryName.Size = new System.Drawing.Size(90, 15);
            this.IbCategoryName.TabIndex = 0;
            this.IbCategoryName.Text = "Category Name";
            // 
            // txtCategoryID
            // 
            this.txtCategoryID.Location = new System.Drawing.Point(155, 27);
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.ReadOnly = true;
            this.txtCategoryID.Size = new System.Drawing.Size(231, 23);
            this.txtCategoryID.TabIndex = 1;
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(155, 56);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(231, 23);
            this.txtCategoryName.TabIndex = 1;
            // 
            // dgvCategories
            // 
            this.dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategories.Location = new System.Drawing.Point(51, 99);
            this.dgvCategories.Name = "dgvCategories";
            this.dgvCategories.ReadOnly = true;
            this.dgvCategories.RowTemplate.Height = 25;
            this.dgvCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategories.Size = new System.Drawing.Size(335, 153);
            this.dgvCategories.TabIndex = 2;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(51, 272);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 3;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(185, 272);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(311, 272);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmManageCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 307);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dgvCategories);
            this.Controls.Add(this.txtCategoryName);
            this.Controls.Add(this.txtCategoryID);
            this.Controls.Add(this.IbCategoryName);
            this.Controls.Add(this.IbCategoryID);
            this.Name = "frmManageCategories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Categories";
            this.Load += new System.EventHandler(this.frmManageCategories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label IbCategoryID;
        private Label IbCategoryName;
        private TextBox txtCategoryID;
        private TextBox txtCategoryName;
        private DataGridView dgvCategories;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
    }
}