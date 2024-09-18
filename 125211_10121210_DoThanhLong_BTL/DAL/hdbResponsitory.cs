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
    public partial class hdbResponsitory : I_hdbResponsitory
    {
        private IDatabaseHelper dtbHelper;
        public hdbResponsitory(IDatabaseHelper dbHelper)
        {
            dtbHelper = dbHelper;
        }
        public List<hdbModel> GetAllhdb()
        {
            string msgError = "";
            try
            {
                var dt = dtbHelper.ExecuteSProcedureReturnDataTable(out msgError, "proc_GetAllhdb");
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<hdbModel>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public hdbModel Gethdb(string str)
        {
            string msgError = "";
            try
            {
                var dt = dtbHelper.ExecuteSProcedureReturnDataTable(out msgError, "proc_GetHDB",
                     "@str", str);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<hdbModel>().FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public chiTiethdbModel GetCThdb(int idHDB)
        {
            string msgError = "";
            try
            {
                var dt = dtbHelper.ExecuteSProcedureReturnDataTable(out msgError, "proc_GetCTHDB",
                     "@idHDB", idHDB);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<chiTiethdbModel>().FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public bool CreateHDB(hdbModel hdbModel)
        {
            string msgError = "";
            try
            {
                var result = dtbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "proc_CreateHDB",
                    "@idKH", hdbModel.idKH,
                    "@idNV", hdbModel.idNV,
                    "@tongTien", hdbModel.tongTien,
                    "@thoiGianB", hdbModel.thoiGianB);
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

        public bool CreateCTHDB(chiTiethdbModel chiTiethdbModel)
        {
            string msgError = "";
            try
            {
                var result = dtbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "proc_CreateCTHDB",
                    "@idChiTietHDB", chiTiethdbModel.idChiTietHDB,
                    "@idHDB", chiTiethdbModel.idHDB,
                    "@idSP", chiTiethdbModel.idSP,
                    "@soLuong", chiTiethdbModel.soLuong,
                    "@giaBan", chiTiethdbModel.giaBan,
                    "@thanhTien", chiTiethdbModel.thanhTien);
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
        public bool UpdateHDB(hdbModel hdbModel)
        {
            string msgError = "";
            try
            {
                var result = dtbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "proc_UpdateHDB",
                    "@idHDB", hdbModel.idHDB,
                    "@idKH", hdbModel.idKH,
                    "@idNV", hdbModel.idNV,
                    "@tongTien", hdbModel.tongTien,
                    "@thoiGianB", hdbModel.thoiGianB);
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
        public bool UpdateCTHDB(chiTiethdbModel chiTiethdbModel)
        {
            string msgError = "";
            try
            {
                var result = dtbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "proc_UpdateCTHDB",
                    "@idChiTietHDB", chiTiethdbModel.idChiTietHDB,
                    "@idHDB", chiTiethdbModel.idHDB,
                    "@idSP", chiTiethdbModel.idSP,
                    "@soLuong", chiTiethdbModel.soLuong,
                    "@giaBan", chiTiethdbModel.giaBan,
                    "@thanhTien", chiTiethdbModel.thanhTien);
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



        public bool DeleteHDB(int idHDB)
        {
            string msgError = "";
            try
            {
                var result = dtbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "proc_DeleteHDB",
                    "@idHDB", idHDB);
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
        public bool DeleteCTHDB(int idCTHDB)
        {
            string msgError = "";
            try
            {
                var result = dtbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "proc_DeleteCTHDB",
                    "@idCTHDB", idCTHDB);
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
