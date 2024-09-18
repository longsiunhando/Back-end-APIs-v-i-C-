using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.interfaces
{
    public partial interface I_NCCResponsitory
    {
        List<NCCModel> GetAllNCC();
        List<NCCModel> GetNCC(string str);
        bool CreateNCC(NCCModel model);
        bool UpdateNCC(NCCModel model);
        bool DeleteNCC(int id);
    }
}
