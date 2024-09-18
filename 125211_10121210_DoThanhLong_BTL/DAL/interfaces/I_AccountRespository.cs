using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.interfaces
{
    public partial interface I_AccountRespository
    {
        public accountModel GetAccByUsername(string username);
        public accountIn4Model GetTTTKByUsername(string username);
        public bool CreateAcc(accountModel AccModel);
        public bool CreateAccIn4(accountIn4Model AccIn4Model);
        public bool UpdateAcc(accountModel model);
        public bool UpdateAccIn4(accountIn4Model model);
        public bool DeleteAcc(string username);
        public bool DeleteAccIn4(string username);


    }
}
