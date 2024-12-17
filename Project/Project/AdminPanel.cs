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

namespace Project
{
    public partial class AdminPanel : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        public AdminPanel()
        {
            InitializeComponent();
            con = new SqlConnection("Server=DESKTOP-JFM5B8D\\SQLEXPRESS;Database=ProjectDB;User Id=sa;Password=123");
            KullanıcıDoldur();
        }
        private void KullanıcıDoldur()
        {
            List<User> users = new List<User>();
            cmd = new SqlCommand("Select * From Users", con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                User user = new User();
                user.Id = reader.GetInt32(0);
                user.UserName = reader.GetString(1);
                user.Password = reader.GetInt32(2);
                users.Add(user);
                lst_users.Items.Add(user);
            }
            dtgridusers.DataSource = users;
            con.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            UserPanel userPanel = new UserPanel();
            this.Hide();
            userPanel.Show();
        }
    }
}
