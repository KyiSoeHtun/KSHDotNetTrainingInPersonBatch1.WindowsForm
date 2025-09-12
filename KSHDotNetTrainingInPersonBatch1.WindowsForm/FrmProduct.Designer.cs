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
            SuspendLayout();
            // 
            // txtCode
            // 
            txtCode.Location = new Point(322, 59);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(462, 39);
            txtCode.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Location = new Point(322, 104);
            txtName.Name = "txtName";
            txtName.Size = new Size(462, 39);
            txtName.TabIndex = 5;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(322, 149);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(462, 39);
            txtPrice.TabIndex = 6;
            // 
            // txtQty
            // 
            txtQty.Location = new Point(322, 194);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(462, 39);
            txtQty.TabIndex = 7;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(322, 248);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 46);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(478, 248);
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
            // FrmProduct
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(981, 933);
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
    }
}