using DAL.interfaces;
using DataAccessLayer;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public partial class NCCResponsitory:I_NCCResponsitory
    {
        private IDatabaseHelper dtbHelper;
        public NCCResponsitory(IDatabaseHelper dbHelper)
        {
            dtbHelper = dbHelper;
        }

        public List<NCCModel> GetAllNCC()
        {
            string msgError = "";

            try
            {
                var dt = dtbHelper.ExecuteSProcedureReturnDataTable(out msgError, "proc_getallncc");
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<NCCModel>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<NCCModel> GetNCC(string str)
        {
            string msgError = "";

            try
            {
                var dt = dtbHelper.ExecuteSProcedureReturnDataTable(out msgError, "proc_getncc",
                    "@str", str);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<NCCModel>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool CreateNCC(NCCModel NCCmodel)
        {
            string msgError = "";
            try
            {
                var result = dtbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "proc_CreateNCC",
                    "@tenNCC", NCCmodel.tenNCC,
                    "@diaChi", NCCmodel.diaChi,
                    "@sdt", NCCmodel.sdt);
                if ((result != null && !string.IsNullOrEmpty(result.ToString())) || !string.IsNullOrEmpty(msgError))
                {
                    throw new Exception(Convert.ToString(result) + msgError);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdateNCC(NCCModel NCCmodel)
        {
            string msgError = "";
            try
            {
                var result = dtbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "proc_UpdateNCC",
                    "@idNCC", NCCmodel.idNCC,
                    "@tenNCC", NCCmodel.tenNCC,
                    "@diaChi", NCCmodel.diaChi,
                    "@sdt", NCCmodel.sdt);
                if ((result != null && !string.IsNullOrEmpty(result.ToString())) || !string.IsNullOrEmpty(msgError))
                {
                    throw new Exception(Convert.ToString(result) + msgError);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DeleteNCC(int id)
        {
            string msgError = "";
            try
            {
                var result = dtbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "proc_DeleteNCC",
                    "@idNCC", id);
                if ((result != null && !string.IsNullOrEmpty(result.ToString())) || !string.IsNullOrEmpty(msgError))
                {
                    throw new Exception(Convert.ToString(result) + msgError);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
