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
    public partial class hdnResponsitory : I_hdnResponsitory
    {
        private IDatabaseHelper dtbHelper;
        public hdnResponsitory(IDatabaseHelper dbHelper)
        {
            dtbHelper = dbHelper;
        }

        public List<hdnModel> GetAllhdn()
        {
            string msgError = "";
            try
            {
                var dt = dtbHelper.ExecuteSProcedureReturnDataTable(out msgError, "proc_GetAllhdn");
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<hdnModel>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public hdnModel Gethdn(string str)
        {
            string msgError = "";
            try
            {
                var dt = dtbHelper.ExecuteSProcedureReturnDataTable(out msgError, "proc_GetHDN",
                     "@str", str);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<hdnModel>().FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public chiTiethdnModel GetCThdn(int idHDN)
        {
            string msgError = "";
            try
            {
                var dt = dtbHelper.ExecuteSProcedureReturnDataTable(out msgError, "proc_GetCTHDN",
                     "@idHDN", idHDN);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<chiTiethdnModel>().FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool CreateHDN(hdnModel hdnModel)
        {
            string msgError = "";
            try
            {
                var result = dtbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "proc_CreateHDN",
                    "@idNCC", hdnModel.idNCC,
                    "@idNV", hdnModel.idNV,
                    "@tongTien", hdnModel.tongTien,
                    "@thoiGianN", hdnModel.thoiGianN);
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
        public bool CreateCTHDN(chiTiethdnModel chiTiethdnModel)
        {
            string msgError = "";
            try
            {
                var result = dtbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "proc_CreateCTHDN",
                    "@idChiTietHDN", chiTiethdnModel.idChiTietHDN,
                    "@idHDN", chiTiethdnModel.idHDN,
                    "@idSP", chiTiethdnModel.idSP,
                    "@soLuong", chiTiethdnModel.soLuong,
                    "@giaNhap", chiTiethdnModel.giaNhap,
                    "@thanhTien", chiTiethdnModel.thanhTien);
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
        public bool UpdateHDN(hdnModel hdnModel)
        {
            string msgError = "";
            try
            {
                var result = dtbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "proc_UpdateHDN",
                    "@idHDN", hdnModel.idHDN,
                    "@idNCC", hdnModel.idNCC,
                    "@idNV", hdnModel.idNV,
                    "@tongTien", hdnModel.tongTien,
                    "@thoiGianN", hdnModel.thoiGianN);
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
        public bool UpdateCTHDN(chiTiethdnModel chiTiethdnModel)
        {
            string msgError = "";
            try
            {
                var result = dtbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "proc_UpdateCTHDN",
                    "@idChiTietHDN", chiTiethdnModel.idChiTietHDN,
                    "@idHDN", chiTiethdnModel.idHDN,
                    "@idSP", chiTiethdnModel.idSP,
                    "@soLuong", chiTiethdnModel.soLuong,
                    "@giaNhap", chiTiethdnModel.giaNhap,
                    "@thanhTien", chiTiethdnModel.thanhTien);
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
        public bool DeleteHDN(int idHDN)
        {
            string msgError = "";
            try
            {
                var result = dtbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "proc_DeleteHDN",
                    "@idHDN", idHDN);
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
        public bool DeleteCTHDN(int idCTHDN)
        {
            string msgError = "";
            try
            {
                var result = dtbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "proc_DeleteCTHDN",
                    "@idCTHDN", idCTHDN);
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
