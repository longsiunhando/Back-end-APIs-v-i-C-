using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.interfaces
{
    public partial interface I_NVResponsitory
    {
        List<NVModel> GetAllNV();
        List<NVModel> GetNV(string str);
        bool CreateNV(NVModel NVmodel);
        bool UpdateNV(NVModel nVModel);
        bool DeleteNV(int id);


    }
}
