using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class accountModel
    {
        public string username { get; set; }
        public string pass { get; set; }
        public List<accountIn4Model> list_json_accountIn4 { get; set; }

    }

    public class accountIn4Model
    {
        public int idAccount { get; set; }
        public string username { get; set; }
        public string displayname { get; set; }
        public string email { get; set; }
        public string sdt { get; set; }
        public string diaChi { get; set; }
        public int type { get; set; }
    }
}
