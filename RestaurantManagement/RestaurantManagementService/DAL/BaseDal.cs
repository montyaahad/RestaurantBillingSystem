using System;
using System.Data.SqlClient;
using System.Collections;
using System.Data;
using VIT.DataLogicLayer;

namespace Service.DAL
{
    internal class BaseDal
    {

        public void Init(string selectAll, string selectId, string del, string idparam, dynamic child)
        {
            SelectAll = selectAll;
            SelectById = selectId;
            DeleteSql = del;
            IdParam = idparam;
            Child = child;
        }
        public string SelectById { get; set; }
        public string SelectAll { get; set; }
        public string DeleteSql { get; set; }
        public string IdParam { get; set; }
        public dynamic Child { get; set; }

        protected ArrayList Parameter = new ArrayList();

        public DatabaseManager db = DatabaseManager.GetInstance();

        public DataTable FetchData(string spName)
        {
            return db.ExecuteStoredProcedureDataTable(spName, Parameter);
        }

        public int FetchDataNonQuery(string spName)
        {
            var i = db.ExecuteStoredProcedureScalar(spName, Parameter);
            return Convert.ToInt32(i);
        }
        public int InsertOrUpdateData(string sp)
        {
            return FetchDataNonQuery(sp);
        }
        protected void ClearParameter()
        {
            Parameter.Clear();
        }
        protected void AddParameter(string parameterName, object value)
        {
            Parameter.Add(new SqlParameter(parameterName, value));
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