
namespace KSHDotNetTrainingInPersonBatch1.WindowsForm
{
    partial class FrmLogin
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
            btnCancel = new Button();
            LblUsername = new Label();
            txtPassword = new TextBox();
            LblPassword = new Label();
            btnLogin = new Button();
            txtUsername = new TextBox();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(409, 358);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(145, 44);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // LblUsername
            // 
            LblUsername.AutoSize = true;
            LblUsername.Location = new Point(264, 241);
            LblUsername.Name = "LblUsername";
            LblUsername.Size = new Size(121, 32);
            LblUsername.TabIndex = 1;
            LblUsername.Text = "Username";
            // 
            // txtPassword
            // 
            txtPassword.AcceptsReturn = true;
            txtPassword.Location = new Point(409, 294);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(300, 39);
            txtPassword.TabIndex = 3;
            txtPassword.Text = "admin";
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // LblPassword
            // 
            LblPassword.AutoSize = true;
            LblPassword.Location = new Point(272, 298);
            LblPassword.Name = "LblPassword";
            LblPassword.Size = new Size(111, 32);
            LblPassword.TabIndex = 4;
            LblPassword.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(564, 358);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(145, 44);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "&Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtUsername
            // 
            txtUsername.AcceptsReturn = true;
            txtUsername.Location = new Point(409, 241);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(300, 39);
            txtUsername.TabIndex = 2;
            txtUsername.Text = "admin";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 731);
            Controls.Add(txtUsername);
            Controls.Add(btnLogin);
            Controls.Add(LblPassword);
            Controls.Add(txtPassword);
            Controls.Add(LblUsername);
            Controls.Add(btnCancel);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += FrmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button btnCancel;
        private Label LblUsername;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label LblPassword;
        private Button btnLogin;
        //private TextBox textUsername;
    }
}
