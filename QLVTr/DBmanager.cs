using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVTr
{
    class DBmanager
    {
        public static string user, pass, cn, sql,userLink="htkn",passLink="123456";
        public static SqlConnection connection;
        public static BindingSource bindingCN;
        public static BindingSource bindingMACN;
        public static User userDangNhap;

    }

    class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
    }
}
