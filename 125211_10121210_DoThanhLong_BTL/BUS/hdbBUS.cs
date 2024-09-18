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
    public class hdbBUS : I_hdbBUS
    {
        private I_hdbResponsitory hdbRES;
        public hdbBUS(I_hdbResponsitory _hdbress)
        {
            hdbRES = _hdbress;
        }
        public List<hdbModel> GetAllhdb()
        {
            return hdbRES.GetAllhdb();
        }
        public hdbModel Gethdb(string str)
        {
            return hdbRES.Gethdb(str);
        }
        public chiTiethdbModel GetCThdb(int idHDB)
        {
            return hdbRES.GetCThdb(idHDB);
        }
        public bool CreateHDB(hdbModel hdbModel)
        {
            return hdbRES.CreateHDB(hdbModel);
        }
        public bool CreateCTHDB(chiTiethdbModel chiTiethdbModel)
        {
            return hdbRES.CreateCTHDB(chiTiethdbModel);
        }
        public bool UpdateHDB(hdbModel hdbModel)
        {
            return hdbRES.UpdateHDB(hdbModel);
        }
        public bool UpdateCTHDB(chiTiethdbModel chiTiethdbModel)
        {
            return hdbRES.UpdateCTHDB(chiTiethdbModel);
        }
        public bool DeleteHDB(int idHDB)
        {
            return hdbRES.DeleteHDB(idHDB);
        }
        public bool DeleteCTHDB(int idHDB)
        {
            return hdbRES.DeleteCTHDB(idHDB);
        }
    }
}
