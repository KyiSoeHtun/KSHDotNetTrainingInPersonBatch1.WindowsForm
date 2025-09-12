namespace KSHDotNetTrainingInPersonBatch1.WindowsForm
{
    partial class FrmProduct
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
            txtCode = new TextBox();
            txtName = new TextBox();
            txtPrice = new TextBox();
            txtQty = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label1 = new Label();
            dgvData = new DataGridView();
            colEdit = new DataGridViewButtonColumn();
            colDelete = new DataGridViewButtonColumn();
            colProductId = new DataGridViewTextBoxColumn();
            colProductCode = new DataGridViewTextBoxColumn();
            colProductName = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            btnRefresh = new Button();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // txtCode
            // 
            txtCode.Location = new Point(322, 59);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(653, 39);
            txtCode.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Location = new Point(322, 104);
            txtName.Name = "txtName";
            txtName.Size = new Size(653, 39);
            txtName.TabIndex = 5;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(322, 149);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(653, 39);
            txtPrice.TabIndex = 6;
            // 
            // txtQty
            // 
            txtQty.Location = new Point(322, 194);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(653, 39);
            txtQty.TabIndex = 7;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(358, 248);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 46);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(578, 248);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 46);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(229, 156);
            label3.Name = "label3";
            label3.Size = new Size(70, 32);
            label3.TabIndex = 2;
            label3.Text = "Price:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(127, 111);
            label2.Name = "label2";
            label2.Size = new Size(172, 32);
            label2.TabIndex = 1;
            label2.Text = "Product Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(188, 197);
            label4.Name = "label4";
            label4.Size = new Size(111, 32);
            label4.TabIndex = 3;
            label4.Text = "Quantity:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(135, 66);
            label1.Name = "label1";
            label1.Size = new Size(164, 32);
            label1.TabIndex = 0;
            label1.Text = "Product Code:";
            // 
            // dgvData
            // 
            dgvData.AllowUserToAddRows = false;
            dgvData.AllowUserToDeleteRows = false;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Columns.AddRange(new DataGridViewColumn[] { colEdit, colDelete, colProductId, colProductCode, colProductName, colPrice, colQuantity });
            dgvData.Location = new Point(12, 317);
            dgvData.Name = "dgvData";
            dgvData.ReadOnly = true;
            dgvData.RowHeadersWidth = 82;
            dgvData.Size = new Size(1175, 628);
            dgvData.TabIndex = 10;
            dgvData.CellContentClick += dgvData_CellContentClick;
            // 
            // colEdit
            // 
            colEdit.HeaderText = "Edit";
            colEdit.MinimumWidth = 10;
            colEdit.Name = "colEdit";
            colEdit.ReadOnly = true;
            colEdit.Text = "Edit";
            colEdit.UseColumnTextForButtonValue = true;
            colEdit.Width = 200;
            // 
            // colDelete
            // 
            colDelete.HeaderText = "Delete";
            colDelete.MinimumWidth = 10;
            colDelete.Name = "colDelete";
            colDelete.ReadOnly = true;
            colDelete.Text = "Delete";
            colDelete.UseColumnTextForButtonValue = true;
            colDelete.Width = 200;
            // 
            // colProductId
            // 
            colProductId.DataPropertyName = "ProductID";
            colProductId.HeaderText = "Product Id";
            colProductId.MinimumWidth = 10;
            colProductId.Name = "colProductId";
            colProductId.ReadOnly = true;
            colProductId.Width = 200;
            // 
            // colProductCode
            // 
            colProductCode.DataPropertyName = "ProductCode";
            colProductCode.HeaderText = "Product Code";
            colProductCode.MinimumWidth = 10;
            colProductCode.Name = "colProductCode";
            colProductCode.ReadOnly = true;
            colProductCode.Width = 200;
            // 
            // colProductName
            // 
            colProductName.DataPropertyName = "ProductName";
            colProductName.HeaderText = "Product Name";
            colProductName.MinimumWidth = 10;
            colProductName.Name = "colProductName";
            colProductName.ReadOnly = true;
            colProductName.Width = 200;
            // 
            // colPrice
            // 
            colPrice.DataPropertyName = "Price";
            colPrice.HeaderText = "Price";
            colPrice.MinimumWidth = 10;
            colPrice.Name = "colPrice";
            colPrice.ReadOnly = true;
            colPrice.Width = 200;
            // 
            // colQuantity
            // 
            colQuantity.DataPropertyName = "Quantity";
            colQuantity.HeaderText = "Quantity";
            colQuantity.MinimumWidth = 10;
            colQuantity.Name = "colQuantity";
            colQuantity.ReadOnly = true;
            colQuantity.Width = 200;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(790, 248);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(150, 46);
            btnRefresh.TabIndex = 11;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(578, 248);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(150, 46);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Visible = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // FrmProduct
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1197, 957);
            Controls.Add(btnUpdate);
            Controls.Add(btnRefresh);
            Controls.Add(dgvData);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(txtQty);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Controls.Add(txtCode);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product";
            Load += FrmProduct_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtCode;
        private TextBox txtName;
        private TextBox txtPrice;
        private TextBox txtQty;
        private Button btnCancel;
        private Button btnSave;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label1;
        private DataGridView dgvData;
        private Button btnRefresh;
        private Button btnUpdate;
        private DataGridViewButtonColumn colEdit;
        private DataGridViewButtonColumn colDelete;
        private DataGridViewTextBoxColumn colProductId;
        private DataGridViewTextBoxColumn colProductCode;
        private DataGridViewTextBoxColumn colProductName;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn colQuantity;
    }
}