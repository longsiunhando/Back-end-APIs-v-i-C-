using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.interfaces
{
    public partial interface I_NVBUS
    {
        List<NVModel> GetAllNV();
        List<NVModel> GetNV(string str);
        bool CreateNV(NVModel nvModel);
        bool UpdateNV(NVModel nvModel);

        bool DeleteNV(int id );
    }
}
