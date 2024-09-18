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
    public partial class SPResponsitory:I_SPResponsitory
    {
        private IDatabaseHelper dtbHelper;
        public SPResponsitory(IDatabaseHelper dbHelper)
        {
            dtbHelper = dbHelper;
        }

        public List<SPModel> GetAllSP()
        {
            string msgError = "";
            try
            {
                var dt = dtbHelper.ExecuteSProcedureReturnDataTable(out msgError, "proc_GetAllSP");
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<SPModel>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<SPModel> GetSP(string str)
        {
            string msgError = "";
            try
            {
                var dt = dtbHelper.ExecuteSProcedureReturnDataTable(out msgError, "proc_GetSP",
                    "@str",str);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<SPModel>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool CreateSP(SPModel SPModel)
        {
            string msgError = "";
            try
            {
                var result = dtbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "proc_CreateSP",
                "@tenSP", SPModel.tenSP,
                "@soLuong", SPModel.soLuong,
                "@giaNhap", SPModel.giaNhap,
                "@giaBan", SPModel.giaBan,
                "@idLoai", SPModel.idLoai);
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

        public bool UpdateSP(SPModel SPModel)
        {
            string msgError = "";
            try
            {
                var result = dtbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "proc_UpdateSP",
                "@idSP",SPModel.idSP,
                "@tenSP", SPModel.tenSP,
                "@soLuong", SPModel.soLuong,
                "@giaNhap", SPModel.giaNhap,
                "@giaBan", SPModel.giaBan,
                "@idLoai", SPModel.idLoai);
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

        public bool DeleteSP(int idSP)
        {
            string msgError = "";
            try
            {
                var result = dtbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "proc_DeleteSP",
                "@idSP", idSP);
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
