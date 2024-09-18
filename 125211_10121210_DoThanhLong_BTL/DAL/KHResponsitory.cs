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
    public partial class KHResponsitory : I_KHResponsitory
    {
        private IDatabaseHelper dtbHelper;
        public KHResponsitory(IDatabaseHelper dbHelper)
        {
            dtbHelper = dbHelper;
        }

        public List<KHModel> GetAllKH()
        {
            string msgError = "";

            try
            {
                var dt = dtbHelper.ExecuteSProcedureReturnDataTable(out msgError, "proc_getallkh");
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<KHModel>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<KHModel> GetKH(string str)
        {
            string msgError = "";

            try
            {
                var dt = dtbHelper.ExecuteSProcedureReturnDataTable(out msgError, "proc_getkh",
                    "@str",str);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<KHModel>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool CreateKH(KHModel KHmodel)
        {
            string msgError = "";
            try
            {
                var result = dtbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "proc_CreateKH",
                    "@tenKH", KHmodel.tenKH,
                    "@diachi", KHmodel.diachi,
                    "@sdt", KHmodel.sdt);
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

        public bool UpdateKH(KHModel KHmodel)
        {
            string msgError = "";
            try
            {
                var result = dtbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "proc_UpdateKH",
                    "@idKH", KHmodel.idKH,
                    "@tenKH", KHmodel.tenKH,
                    "@diachi", KHmodel.diachi,
                    "@sdt", KHmodel.sdt);
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

        public bool DeleteKH(int id)
        {
            string msgError = "";
            try
            {
                var result = dtbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "proc_DeleteKH",
                    "@idKH", id);
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
