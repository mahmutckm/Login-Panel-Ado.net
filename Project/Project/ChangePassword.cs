using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project
{
    public partial class ChangePassword : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        public ChangePassword()
        {
            InitializeComponent();
            con = new SqlConnection("Server=DESKTOP-JFM5B8D\\SQLEXPRESS;Database=ProjectDB;User Id=sa;Password=123");
        }

        private void chkbox_changepassshow_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbox_changepassshow.Checked)
            {
                txtbox_changepass.PasswordChar = '\0';
                txtbox_changepass1.PasswordChar = '\0';
            }
            else
            {
                txtbox_changepass.PasswordChar = '*';
                txtbox_changepass1.PasswordChar = '*';
            }
        }

        private void btn_changepass_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbox_changepass.Text) || string.IsNullOrEmpty(txtbox_changepass1.Text) || string.IsNullOrEmpty(txtbox_changeusername.Text))
            {
                MessageBox.Show("Alanları Doldurunuz");
                return;
            }
            User user = new User();
            user.UserName = txtbox_changeusername.Text;
            user.Password = Convert.ToInt32(txtbox_changepass.Text);
            int pass = Convert.ToInt32(txtbox_changepass1.Text);
            if (user.Password == pass)
            {
                cmd = new SqlCommand("UPDATE Users SET Password = @Password WHERE Username = @Username", con);
                con.Open();
                cmd.Parameters.AddWithValue("@Username", user.UserName);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show($"{user.UserName} Hesabın parolası başarıyla değiştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UserPanel userPanel = new UserPanel();
                    this.Hide();
                    userPanel.Show();
                }
                else
                {
                    MessageBox.Show("Kullanıcı bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Şifreler uyuşmuyor");
                return;
            }
        }
    }
}

