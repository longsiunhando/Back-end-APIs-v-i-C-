using BUS.interfaces;
using DAL.interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public partial class KHBUS : I_KHBUS
    {
        private I_KHResponsitory KHResponsitory;
        public KHBUS(I_KHResponsitory khRES)
        {
            KHResponsitory = khRES;
        }
        public List<KHModel> GetAllKH()
        {
            return KHResponsitory.GetAllKH();
        }
        public List<KHModel> GetKH(string str)
        {
            return KHResponsitory.GetKH(str);
        }
        public bool CreateKH(KHModel khModel)
        {
            return KHResponsitory.CreateKH(khModel);
        }
        public bool UpdateKH(KHModel khModel)
        {
            return KHResponsitory.UpdateKH(khModel);
        }
        public bool DeleteKH(int id)
        {
            return KHResponsitory.DeleteKH(id);
        }
    }


}
