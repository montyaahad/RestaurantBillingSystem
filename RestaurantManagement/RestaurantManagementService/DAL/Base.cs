using System;
using System.Data.SqlClient;
using System.Collections;
using System.Data;
using VIT.DataLogicLayer;

namespace Service.DAL
{
    public abstract class Base
    {
        public string SelectById { get; set; }
        public string SelectAll { get; set; }
        public string DeleteSql { get; set; }
        public string IdParam { get; set; }

        protected ArrayList Parameter = new ArrayList();

        public DatabaseManager db = DatabaseManager.GetInstance();

        public DataTable FetchData(string spName)
        {
            //var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //string connectionString = ConfigurationManager.AppSettings["ConnectionString"];
            //return ConnectToSql(connectionString, spName);
            return db.ExecuteStoredProcedureDataTable(spName, Parameter);

        }
        protected void ClearParameter()
        {
            Parameter.Clear();
        }
        protected void AddParameter(string parameterName, object value)
        {
            Parameter.Add(new SqlParameter(parameterName, value));
        }

        private DataTable ConnectToSql(string connection, string spName)
        {
            System.Data.SqlClient.SqlConnection conn;
            conn = new System.Data.SqlClient.SqlConnection();
            conn.ConnectionString = connection;
            try
            {
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand(spName, conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddRange(Parameter.ToArray());
                SqlDataAdapter dataAdaptor = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable();
                dataAdaptor.Fill(dt);
                conn.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        internal virtual DataTable GetAll()
        {
            ClearParameter();
            return FetchData(SelectAll);
        }
        internal virtual DataTable GetById(int id)
        {
            ClearParameter();
            AddParameter(IdParam, id);

            return FetchData(SelectById);
        }
        internal virtual void Delete(int id)
        {
            ClearParameter();
            AddParameter(IdParam, id);
            FetchData(DeleteSql);
        }

    }
}