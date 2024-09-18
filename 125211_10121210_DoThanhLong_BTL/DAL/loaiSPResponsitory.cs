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
    public partial class loaiSPResponsitory:I_loaiSPResponsitory
    {
        private IDatabaseHelper dtbHelper;
        public loaiSPResponsitory(IDatabaseHelper dbHelper)
        {
            dtbHelper = dbHelper;
        }
        public List<loaiSPModel> GetAllloaiSP()
        {
            string msgError = "";
            try
            {
                var dt = dtbHelper.ExecuteSProcedureReturnDataTable(out msgError, "proc_getallloaisp");
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<loaiSPModel>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<loaiSPModel> GetloaiSP(string str)
        {
            string msgError = "";
            try
            {
                var dt = dtbHelper.ExecuteSProcedureReturnDataTable(out msgError, "proc_getloaisp",
                    "@str",str);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<loaiSPModel>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool CreateloaiSP(loaiSPModel loaiSPModel)
        {
            string msgError = "";
            try
            {
                var result = dtbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "proc_CreateloaiSP",
                    "@tenLoai", loaiSPModel.tenLoai,
                    "@moTa", loaiSPModel.moTa);
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

        public bool UpdateloaiSP(loaiSPModel loaiSPModel)
        {
            string msgError = "";
            try
            {
                var result = dtbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "proc_UpdateloaiSP",
                    "@idLoai",loaiSPModel.idLoai,
                    "@tenLoai", loaiSPModel.tenLoai,
                    "@moTa", loaiSPModel.moTa);
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

        public bool DeleteloaiSP(int idLoai)
        {
            string msgError = "";
            try
            {
                var result = dtbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "proc_DeleteloaiSP",
                    "@idLoai", idLoai);
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
