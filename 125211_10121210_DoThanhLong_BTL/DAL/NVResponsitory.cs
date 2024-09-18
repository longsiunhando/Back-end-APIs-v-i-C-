using DAL.interfaces;
using DataAccessLayer;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public partial class NVResponsitory : I_NVResponsitory
    {
        private IDatabaseHelper dtbHelper;
        public NVResponsitory(IDatabaseHelper dbHelper)
        {
            dtbHelper = dbHelper;
        }

        public List<NVModel> GetAllNV() 
        {
            string msgError = "";
            try
            {
                var dt = dtbHelper.ExecuteSProcedureReturnDataTable(out msgError, "proc_GetAllNV");
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<NVModel>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List <NVModel> GetNV(string str) 
        {
            string msgError = "";
            try
            {
                var dt = dtbHelper.ExecuteSProcedureReturnDataTable(out msgError, "proc_GetNV",
                    "@str",str);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<NVModel>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public bool CreateNV(NVModel NVModel)
        {
            string msgError = "";
            try
            {
                var result = dtbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "proc_CreateNV",
                    "@tenNV", NVModel.tenNV,
                    "@diaChi", NVModel.diaChi,
                    "@sdt", NVModel.sdt);
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


        public bool UpdateNV(NVModel NVModel)
        {
            string msgError = "";
            try
            {
                var result = dtbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "proc_UpdateNV",
                "@idNV", NVModel.idNV,
                "@tenNV", NVModel.tenNV,
                "@diaChi", NVModel.diaChi,
                "@sdt", NVModel.sdt);
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


        public bool DeleteNV(int id)
        {
            string msgError = "";
            try
            {
                var result = dtbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "proc_DeleteNV",
                "@idNV", id);
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
