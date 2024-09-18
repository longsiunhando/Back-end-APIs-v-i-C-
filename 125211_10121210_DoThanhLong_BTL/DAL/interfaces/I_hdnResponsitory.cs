using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.interfaces
{
    public partial interface I_hdnResponsitory
    {
        public List<hdnModel> GetAllhdn();
        public hdnModel Gethdn(string str);
        public chiTiethdnModel GetCThdn(int idHDN);
        public bool CreateHDN(hdnModel hdnModel);
        public bool CreateCTHDN(chiTiethdnModel chiTiethdnModel);
        public bool UpdateHDN(hdnModel hdnModel);
        public bool UpdateCTHDN(chiTiethdnModel chiTiethdnModel);
        public bool DeleteHDN(int idHDN);
        public bool DeleteCTHDN(int idHDN);
    }
}
