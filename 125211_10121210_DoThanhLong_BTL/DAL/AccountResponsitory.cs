using DAL.interfaces;
using DataAccessLayer;
using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public partial class AccountResponsitory : I_AccountRespository
    {
        private IDatabaseHelper dtbHelper;
        public AccountResponsitory(IDatabaseHelper dbHelper)
        {
            dtbHelper = dbHelper;
        }
            
        public accountModel GetAccByUsername(string username)
        {
            string msgError = "";
            try
            {
                var dt = dtbHelper.ExecuteSProcedureReturnDataTable(out msgError, "proc_getaccbyusername",
                     "@username", username);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<accountModel>().FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public accountIn4Model GetTTTKByUsername(string username)
        {
            string msgError = "";
            try
            {
                var dt = dtbHelper.ExecuteSProcedureReturnDataTable(out msgError, "proc_gettttkbyusername",
                     "@uname", username);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<accountIn4Model>().FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public bool CreateAcc(accountModel AccModel)
        {
            string msgError = "";
            try
            {
                var result = dtbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "proc_Create_account",
                    "@username", AccModel.username,
                    "@pass", AccModel.pass);
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

        public bool CreateAccIn4(accountIn4Model AccIn4Model)
        {
            string msgError = "";
            try
            {
                var result = dtbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "proc_Create_accountIn4",
                    "@username", AccIn4Model.username,
                    "@displayname", AccIn4Model.displayname,
                    "@email", AccIn4Model.email,
                    "@sdt", AccIn4Model.sdt,
                    "@diaChi", AccIn4Model.diaChi,
                    "@type", AccIn4Model.type);
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
        public bool UpdateAcc(accountModel acc)
        {
            string msgError = "";
            try
            {
                var result = dtbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "proc_UpdateAcc",
                    "@username", acc.username,
                    "@pass", acc.pass);
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
        public bool UpdateAccIn4(accountIn4Model AccIn4Model)
        {
            string msgError = "";
            try
            {
                var result = dtbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "proc_UpdateAccIn4",
                    "@username", AccIn4Model.username,
                    "@displayname", AccIn4Model.displayname,
                    "@email", AccIn4Model.email,
                    "@sdt", AccIn4Model.sdt,
                    "@diaChi", AccIn4Model.diaChi,
                    "@type", AccIn4Model.type);
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



        public bool DeleteAcc(string username)
        {
            string msgError = "";
            try
            {
                var result = dtbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "proc_DeleteAcc",
                    "@username", username);
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
        public bool DeleteAccIn4(string username)
        {
            string msgError = "";
            try
            {
                var result = dtbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "proc_DeleteAccIn4",
                    "@username", username);
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


