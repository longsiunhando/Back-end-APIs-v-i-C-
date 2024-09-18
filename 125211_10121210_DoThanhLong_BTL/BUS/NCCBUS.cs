using BUS.interfaces;
using DAL;
using DAL.interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public partial class NCCBUS:I_NCCBUS
    {
        private I_NCCResponsitory nccRES;
        public NCCBUS(I_NCCResponsitory NCCRES)
        {
            nccRES = NCCRES;
        }

        public List<NCCModel> GetAllNCC()
        {
            return nccRES.GetAllNCC();
        }
        public List<NCCModel> GetNCC(string str)
        {
            return nccRES.GetNCC(str);
        }
        public bool CreateNCC(NCCModel ncc)
        {
            return nccRES.CreateNCC(ncc);
        }
        public bool UpdateNCC(NCCModel ncc)
        {
            return nccRES.UpdateNCC(ncc);
        }
        public bool DeleteNCC(int id)
        {
            return nccRES.DeleteNCC(id);
        }
    }
}
