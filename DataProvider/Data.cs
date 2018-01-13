﻿
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DataProvider
{
    public class Data
    {
        SqlConnection conn = null;
        SqlCommand comm = null;
        SqlDataAdapter da = null;
         string ConnStr = @"Data Source=ADMIN\CU;Initial Catalog=CUAHANG_BANXE;Persist Security Info=True;User ID=sa;Password=cac";//string.Format("Data Source = '{0}';Integrated Security = SSPI; Database = '{1}'", @"(localdb)\v11.0", @"NORTHWND");

        public Data()
        {
           
            conn = new SqlConnection(ConnStr);
            comm = conn.CreateCommand();
            conn.Open();
            conn.Close();
        }

        /// <summary>
        /// Kết nối tới SQL
        /// </summary>
        /// <param name="Server">(localdb)\v11.0</param>
        /// <param name="Database">NORTHWND</param>
        public Data(string Server, string Database)
        {
           
            conn = new SqlConnection(ConnStr);
            comm = conn.CreateCommand();
            conn.Open();
            conn.Close();
        }

        public Data(string Server, string Database, string UserName, string Password)
        {
            conn = new SqlConnection(ConnStr);
            comm = conn.CreateCommand();
            conn.Open();
            conn.Close();
        }
        /// <summary>
        /// Gọi 1 StoredPorcedure
        /// </summary>
        /// <param name="StoredProcedureName">Tên StoredProcedure</param>
        /// <param name="param">dạng new{ id="my id", name="my name" }</param>
        public void RunStoredProcedure(string StoredProcedureName, object param)
        {
            List<SqlParameter> paramList = new List<SqlParameter>();
            foreach (var pro in param.GetType().GetProperties())
            {
                var value = pro.GetValue(param);
                value = value == null ? DBNull.Value : value;
                if (pro.PropertyType.Equals(typeof(DateTime)))
                {
                    if (((DateTime)value).Year < 1753)
                        paramList.Add(new SqlParameter("@" + pro.Name, DBNull.Value));
                    else
                        paramList.Add(new SqlParameter("@" + pro.Name, value));
                }
                else
                    paramList.Add(new SqlParameter("@" + pro.Name, value));
            }
            ExecuteNonQuery(StoredProcedureName, CommandType.StoredProcedure, paramList.ToArray());
        }

        /// <summary>
        /// Gọi 1 StoredPorcedure
        /// </summary>
        /// <param name="StoredProcedureName">Tên StoredProcedure</param>
        /// <param name="param">dạng new{ id="my id", name="my name" }</param>
        /// <returns>Dữ liệu</returns>
        public DataSet RunReturnStoredProcedure(string StoredProcedureName, object param)
        {
            List<SqlParameter> paramList = new List<SqlParameter>();
            foreach (var pro in param.GetType().GetProperties())
            {
                var value = pro.GetValue(param);
                value = value == null ? DBNull.Value : value;
                if (pro.PropertyType.Equals(typeof(DateTime)))
                {
                    if (((DateTime)value).Year < 1753)
                        paramList.Add(new SqlParameter("@" + pro.Name, DBNull.Value));
                    else
                        paramList.Add(new SqlParameter("@" + pro.Name, value));
                }
                else
                    paramList.Add(new SqlParameter("@" + pro.Name, value));
            }
            return ExecuteQueryDataSet(StoredProcedureName, CommandType.StoredProcedure, paramList.ToArray());
        }

        public DataSet ExecuteQueryDataSet(string strSQL, CommandType ct, params SqlParameter[] param)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.Parameters.Clear();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            foreach (SqlParameter p in param ?? (new SqlParameter[] { })) 
                comm.Parameters.Add(p);
            da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        
        public void ExecuteNonQuery(string strSQL, CommandType ct, params SqlParameter[] param)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.Parameters.Clear();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            foreach (SqlParameter p in param ?? (new SqlParameter[] { }))
                comm.Parameters.Add(p);
            comm.ExecuteNonQuery();
            conn.Close();
        }

    }
}
