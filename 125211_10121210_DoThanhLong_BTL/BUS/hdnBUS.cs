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
    public class hdnBUS : I_hdnBUS
    {
        private I_hdnResponsitory hdnRES;
        public hdnBUS(I_hdnResponsitory _hdnress)
        {
            hdnRES = _hdnress;
        }

        public List<hdnModel> GetAllhdn()
        {
            return hdnRES.GetAllhdn();
        }
        public hdnModel Gethdn(string str)
        {
            return hdnRES.Gethdn(str);
        }
        public chiTiethdnModel GetCThdn(int idHDN)
        {
            return hdnRES.GetCThdn(idHDN);
        }
        public bool CreateHDN(hdnModel hdnModel)
        {
            return hdnRES.CreateHDN(hdnModel);
        }
        public bool CreateCTHDN(chiTiethdnModel chiTiethdnModel)
        {
            return hdnRES.CreateCTHDN(chiTiethdnModel);
        }
        public bool UpdateHDN(hdnModel hdnModel)
        {
            return hdnRES.UpdateHDN(hdnModel);
        }
        public bool UpdateCTHDN(chiTiethdnModel chiTiethdnModel)
        {
            return hdnRES.UpdateCTHDN(chiTiethdnModel);
        }
        public bool DeleteHDN(int idHDN)
        {
            return hdnRES.DeleteHDN(idHDN);
        }
        public bool DeleteCTHDN(int idHDN)
        {
            return hdnRES.DeleteCTHDN(idHDN);
        }
    }
}
