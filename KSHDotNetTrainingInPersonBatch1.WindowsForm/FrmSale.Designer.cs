namespace KSHDotNetTrainingInPersonBatch1.WindowsForm
{
    partial class FrmSale
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
            cboProduct = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            txtPrice = new TextBox();
            label3 = new Label();
            txtQuantity = new TextBox();
            btnAdd = new Button();
            btnCancel = new Button();
            dgvData = new DataGridView();
            colProductId = new DataGridViewTextBoxColumn();
            colProductName = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            label4 = new Label();
            txtTotalAmount = new TextBox();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // cboProduct
            // 
            cboProduct.FormattingEnabled = true;
            cboProduct.Location = new Point(142, 122);
            cboProduct.Name = "cboProduct";
            cboProduct.Size = new Size(318, 40);
            cboProduct.TabIndex = 0;
            cboProduct.SelectedIndexChanged += cboProduct_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(142, 78);
            label1.Name = "label1";
            label1.Size = new Size(167, 32);
            label1.TabIndex = 1;
            label1.Text = "Product Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(142, 174);
            label2.Name = "label2";
            label2.Size = new Size(65, 32);
            label2.TabIndex = 2;
            label2.Text = "Price";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(142, 219);
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = true;
            txtPrice.Size = new Size(318, 39);
            txtPrice.TabIndex = 3;
            txtPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(142, 281);
            label3.Name = "label3";
            label3.Size = new Size(106, 32);
            label3.TabIndex = 2;
            label3.Text = "Quantity";
            label3.Click += label3_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(142, 326);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(318, 39);
            txtQuantity.TabIndex = 3;
            txtQuantity.TextAlign = HorizontalAlignment.Right;
            txtQuantity.KeyPress += txtQuantity_KeyPress;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(310, 385);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 46);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "&Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(142, 385);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 46);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // dgvData
            // 
            dgvData.AllowUserToAddRows = false;
            dgvData.AllowUserToDeleteRows = false;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Columns.AddRange(new DataGridViewColumn[] { colProductId, colProductName, colPrice, colQuantity });
            dgvData.Location = new Point(485, 78);
            dgvData.Name = "dgvData";
            dgvData.ReadOnly = true;
            dgvData.RowHeadersWidth = 82;
            dgvData.Size = new Size(676, 422);
            dgvData.TabIndex = 6;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1003, 535);
            label4.Name = "label4";
            label4.Size = new Size(158, 32);
            label4.TabIndex = 2;
            label4.Text = "Total Amount";
            label4.Click += label3_Click;
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Location = new Point(485, 579);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.ReadOnly = true;
            txtTotalAmount.Size = new Size(676, 39);
            txtTotalAmount.TabIndex = 3;
            txtTotalAmount.TextAlign = HorizontalAlignment.Right;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(1011, 639);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 46);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // FrmSale
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1198, 715);
            Controls.Add(btnSave);
            Controls.Add(dgvData);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(txtTotalAmount);
            Controls.Add(txtQuantity);
            Controls.Add(txtPrice);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cboProduct);
            Name = "FrmSale";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sale";
            Load += FrmSale_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboProduct;
        private Label label1;
        private Label label2;
        private TextBox txtPrice;
        private Label label3;
        private TextBox txtQuantity;
        private Button btnAdd;
        private Button btnCancel;
        private DataGridView dgvData;
        private Label label4;
        private TextBox txtTotalAmount;
        private Button btnSave;
        private DataGridViewTextBoxColumn colProductId;
        private DataGridViewTextBoxColumn colProductName;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn colQuantity;
    }
}