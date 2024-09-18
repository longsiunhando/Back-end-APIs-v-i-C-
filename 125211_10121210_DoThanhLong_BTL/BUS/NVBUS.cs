using BUS.interfaces;
using DAL.interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NVBUS : I_NVBUS
    {
        private I_NVResponsitory NVRes;
        public NVBUS(I_NVResponsitory nvRes)
        {
            NVRes = nvRes;
        }
        public List<NVModel> GetAllNV()
        {
            return NVRes.GetAllNV();
        }

        public List<NVModel> GetNV(string str)
        {
            return NVRes.GetNV(str);
        }

        public bool CreateNV(NVModel nvModel)
        {
            return NVRes.CreateNV(nvModel);
        }


        public bool UpdateNV(NVModel nvModel)
        {
            return NVRes.UpdateNV(nvModel);
        }

        public bool DeleteNV(int idNV)
        {
            return NVRes.DeleteNV(idNV);
        }
    }
}
