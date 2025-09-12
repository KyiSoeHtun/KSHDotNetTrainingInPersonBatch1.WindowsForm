namespace KSHDotNetTrainingInPersonBatch1.WindowsForm
{
    public partial class FrmLogin : Form
    {

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //if (txtUsername.Text == "admin" && txtPassword.Text == "admin")
            //{
            //    //successful login
            //}
            //else
            //{
            //    MessageBox.Show("Invalid username or password", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}


            if (txtUsername.Text != "admin" || txtPassword.Text != "admin")
            {
                MessageBox.Show("Invalid username or password", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Console.ReadLine();
            //successful login

            //this.Hide();
            FrmMenu frmMenu = new FrmMenu();
            //frmMenu.Show();
            frmMenu.ShowDialog();
            this.Show();
            //MessageBox.Show("Test");
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
