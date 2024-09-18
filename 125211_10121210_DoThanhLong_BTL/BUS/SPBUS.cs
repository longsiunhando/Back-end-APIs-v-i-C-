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
    public partial class SPBUS : I_SPBUS
    {
        private I_SPResponsitory SPRes;
        public SPBUS(I_SPResponsitory spRes)
        {
            SPRes = spRes;
        }
        public List<SPModel> GetAllSP()
        {
            return SPRes.GetAllSP();
        }

        public List <SPModel> GetSP(string str)
        {
            return SPRes.GetSP(str);
        }

        public bool CreateSP(SPModel spModel)
        {
            return SPRes.CreateSP(spModel);
        }
        public bool UpdateSP(SPModel spModel)
        {
            return SPRes.UpdateSP(spModel);
        }
        public bool DeleteSP(int idSP)
        {
            return SPRes.DeleteSP(idSP);
        }
    }
}
