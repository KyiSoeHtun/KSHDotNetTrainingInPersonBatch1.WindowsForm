using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KSHDotNetTrainingInPersonBatch1.WindowsForm
{
    public partial class FrmProduct : Form
    {
        public FrmProduct()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
         
            var result = CheckRequiredFields();
            if (result == false) return;
            // insert into product table
            SaveProduct();

        }
        private void SaveProduct()
        {
            string id = Guid.NewGuid().ToString();
            ProductDto dto = new ProductDto()
            {
                DeleteFlag = false,
                Price = Convert.ToDecimal(txtPrice.Text.Trim()),
                ProductCode = txtCode.Text.Trim(),
                ProductID = id,
                ProductName = txtName.Text.Trim(),
                Quantity = Convert.ToInt64

            };

        }
        private bool CheckRequiredFields()
        {
            //trim is cutting the spaces before and after the text
            if (string.IsNullOrEmpty(txtCode.Text.Trim()))
            {
                MessageBox.Show("Product Code is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCode.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                MessageBox.Show("Product Name is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtPrice.Text.Trim()))
            {
                MessageBox.Show("Price is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrice.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtQty.Text.Trim()))
            {
                MessageBox.Show("Product Quantity is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQty.Focus();
                return false;
            }
            return true;
        }
    }
}
