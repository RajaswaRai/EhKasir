using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace KasirPBO.res.Model
{

    public class TransactionModel
    {
       public int id { get; set; }
       public string items { get; set; }
       public string user_id { get; set; }
       public string user { get; set;  }
       public string timestamp { get; set; }

    }
}
