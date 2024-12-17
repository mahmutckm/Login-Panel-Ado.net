using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;
using System.Xml.Linq;

namespace Project
{
    internal class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public int Password { get; set; }
        public override string ToString()
        {;
            return "Id:" + Id + " " + "Kullanıcı Adı:" + UserName + " " + "Şifre:" + " " + Password;
        }
    }
}
