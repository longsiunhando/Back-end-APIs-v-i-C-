﻿using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.interfaces
{
    public partial interface I_SPBUS
    {
        public List<SPModel> GetAllSP();

        public List<SPModel> GetSP(string str);

        public bool CreateSP(SPModel spModel);

        public bool UpdateSP(SPModel spModel);

        public bool DeleteSP(int idSP);
    }
}
