using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasirPBO.res.Model
{
    public enum UserLevel
    {
        Admin = 0,
        Kasir = 1,
    }

    public class UserModel
    {
       public int id { get; set; }
       public string username { get; set; }
       public string password { get; set; }
       public UserLevel level { get; set; }
       public string display_name { get; set; }
    }
}
