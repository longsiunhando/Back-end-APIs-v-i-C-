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
    public partial class loaiSPBUS : I_loaiSPBUS
    {
        private I_loaiSPResponsitory loaiSPRes;
        public loaiSPBUS(I_loaiSPResponsitory loaispRES)
        {
            loaiSPRes = loaispRES;
        }
        public List<loaiSPModel> GetAllloaiSP()
        {
            return loaiSPRes.GetAllloaiSP();
        }

        public List<loaiSPModel> GetloaiSP(string str)
        {
            return loaiSPRes.GetloaiSP(str);
        }

        public bool CreateloaiSP(loaiSPModel loaiSPModel)
        {
            return loaiSPRes.CreateloaiSP(loaiSPModel);
        }

        public bool UpdateloaiSP(loaiSPModel loaiSPModel)
        {
            return loaiSPRes.UpdateloaiSP(loaiSPModel);
        }

        public bool DeleteloaiSP(int idLoai)
        {
            return loaiSPRes.DeleteloaiSP(idLoai);
        }
    }
}
