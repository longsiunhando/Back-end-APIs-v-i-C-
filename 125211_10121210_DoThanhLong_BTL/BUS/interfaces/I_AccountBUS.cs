using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.interfaces
{
    public partial interface I_AccountBUS
    {
        public accountModel GetAccByUsername(string username);
        public accountIn4Model GetTTTKByUsername(string username);
        public bool CreateAcc(accountModel account);
        public bool CreateAccIn4(accountIn4Model accountIn4);
        public bool UpdateAcc(accountModel account);
        public bool UpdateAccIn4(accountIn4Model accountIn4);
        public bool DeleteAcc(string username);
        public bool DeleteAccIn4(string username);

    }
}
