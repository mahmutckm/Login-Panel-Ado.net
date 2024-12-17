using Microsoft.Win32;
using System.Data.SqlClient;

namespace Project
{
    public partial class UserPanel : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        public UserPanel()
        {
            InitializeComponent();
            con = new SqlConnection("Server=DESKTOP-JFM5B8D\\SQLEXPRESS;Database=ProjectDB;User Id=sa;Password=123");
        }

        private void btn_entry_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbox_username.Text) || string.IsNullOrEmpty(txtbox_password.Text))
            {
                MessageBox.Show("Alanlarý Doldurunuz");
                return;
            }
            User user = new User();
            user.UserName = txtbox_username.Text;
            user.Password = Convert.ToInt32(txtbox_password.Text);
            cmd = new SqlCommand($"Select * From Users where Username='{user.UserName}' and Password='{user.Password}'", con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("Giriþ Baþarýlý", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Hoþgeldin " + user.UserName, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Thread.Sleep(1000);
                txtbox_username.Clear();
                txtbox_password.Clear();
                AdminPanel adminPanel = new AdminPanel();
                this.Hide();
                adminPanel.Show();
            }
            else
            {
                MessageBox.Show("Giriþ bilgileri hatalý.");
            }
            con.Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_clean_Click(object sender, EventArgs e)
        {
            txtbox_username.Clear();
            txtbox_password.Clear();
            chkbox1.Checked = false;
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.Show();
        }

        private void chkbox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbox1.Checked)
            {
                txtbox_password.PasswordChar = '\0';
            }
            else
            {
                txtbox_password.PasswordChar = '*';
            }
        }
        private void lbl_changepass_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword();
            this.Hide();
            changePassword.Show();
        }
    }
}
