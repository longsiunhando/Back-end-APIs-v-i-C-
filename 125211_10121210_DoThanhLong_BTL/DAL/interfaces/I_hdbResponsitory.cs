using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.interfaces
{
    public partial interface I_hdbResponsitory
    {
        public List<hdbModel> GetAllhdb();
        public hdbModel Gethdb(string str);
        public chiTiethdbModel GetCThdb(int idHDB);
        public bool CreateHDB(hdbModel hdbModel);
        public bool CreateCTHDB(chiTiethdbModel chiTiethdbModel);
        public bool UpdateHDB(hdbModel hdbModel);
        public bool UpdateCTHDB(chiTiethdbModel chiTiethdbModel);
        public bool DeleteHDB(int idHDB);
        public bool DeleteCTHDB(int idHDB);
    }
}
