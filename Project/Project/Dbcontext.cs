using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Dbcontext
    {
        public SqlConnection con;
        public SqlCommand cmd;
        public Dbcontext()
        {
            con = new SqlConnection("Server=DESKTOP-JFM5B8D\\SQLEXPRESS;Database=ProjectDB;User Id=sa;Password=123");
            cmd = new SqlCommand();
        }
    }
}
