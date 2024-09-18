using BUS.interfaces;
using DAL.interfaces;
using DataAccessLayer;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class AccountBUS : I_AccountBUS
    {
        private I_AccountRespository AccRES;
        public AccountBUS(I_AccountRespository accRES)
        {
            AccRES = accRES;
        }

        public accountModel GetAccByUsername(string username)
        {
            return AccRES.GetAccByUsername(username);
        }

        public accountIn4Model GetTTTKByUsername(string username)
        {
            return AccRES.GetTTTKByUsername(username);
        }
        public bool CreateAcc(accountModel accountmodel) 
        {
            return AccRES.CreateAcc(accountmodel);
        }
        public bool CreateAccIn4(accountIn4Model accountIn4Model)
        {
            return AccRES.CreateAccIn4(accountIn4Model);
        }
        public bool UpdateAcc(accountModel accountmodel)
        {
            return AccRES.UpdateAcc(accountmodel);
        }
        public bool UpdateAccIn4(accountIn4Model accountIn4Model)
        {
            return AccRES.UpdateAccIn4(accountIn4Model);
        }

        public bool DeleteAcc(string username)
        {
            return AccRES.DeleteAcc(username);
        }
        public bool DeleteAccIn4(string username)
        {
            return AccRES.DeleteAccIn4(username);
        }
    }
}
