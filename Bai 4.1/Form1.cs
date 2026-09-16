namespace Bai_4._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Mặc định ẩn mật khẩu
            txtPassword.UseSystemPasswordChar = true;

            // Enter = Đăng nhập
            this.AcceptButton = btnLogin;

            // Esc = Thoát
            this.CancelButton = btnExit;
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            bool valid = true;

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                errorProvider1.SetError(
                    txtUsername,
                    "Tên đăng nhập không được để trống!"
                );

                valid = false;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errorProvider1.SetError(
                    txtPassword,
                    "Mật khẩu không được để trống!"
                );

                valid = false;
            }

            if (!valid)
                return;

            MessageBox.Show("Đăng nhập thành công!");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}