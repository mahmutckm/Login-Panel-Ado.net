using Microsoft.VisualBasic.ApplicationServices;
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
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project
{
    public partial class Register : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        public Register()
        {
            InitializeComponent();
            con = new SqlConnection("Server=DESKTOP-JFM5B8D\\SQLEXPRESS;Database=ProjectDB;User Id=sa;Password=123");
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbox_registerpass.Text) || string.IsNullOrEmpty(txtbox_registerpass1.Text) || string.IsNullOrEmpty(txtbox_registerusername.Text))
            {
                MessageBox.Show("Alanları Doldurunuz");
                return;
            }
            User user = new User();
            user.UserName = txtbox_registerusername.Text;
            user.Password = Convert.ToInt32(txtbox_registerpass.Text);
            int pass = Convert.ToInt32(txtbox_registerpass1.Text);
            con.Open();
            cmd = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Username = @Username", con);
            cmd.Parameters.AddWithValue("@Username", user.UserName);
            int userExists = (int)cmd.ExecuteScalar();
            con.Close();
            if (userExists > 0)
            {
                MessageBox.Show("Bu kullanıcı adı zaten mevcut. Lütfen farklı bir kullanıcı adı seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (user.Password == pass)
            {
                cmd = new SqlCommand($"insert into Users values('{user.UserName}','{user.Password}')", con);
                con.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Kayıt Yapıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Thread.Sleep(1000);
                    txtbox_registerusername.Clear();
                    txtbox_registerpass.Clear();
                    txtbox_registerpass1.Clear();
                    chkbox_registerpassshow.Checked = false;
                    UserPanel panel = new UserPanel();
                    this.Hide();
                    panel.Show();
                }
                else
                {
                    MessageBox.Show("Kayıt Yapılamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtbox_registerusername.Clear();
                    txtbox_registerpass.Clear();
                    txtbox_registerpass1.Clear();
                    chkbox_registerpassshow.Checked=false;
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Şifreler uyuşmuyor", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void chkbox_registerpassshow_Click(object sender, EventArgs e)
        {
            if (chkbox_registerpassshow.Checked)
            {
                txtbox_registerpass.PasswordChar = '\0';
                txtbox_registerpass1.PasswordChar = '\0';
            }
            else
            {
                txtbox_registerpass.PasswordChar = '*';
                txtbox_registerpass1.PasswordChar = '*';
            }
        }
    }
}
