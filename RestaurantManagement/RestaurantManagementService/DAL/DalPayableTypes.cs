using System.Data;

namespace Service.DAL
{
    public class DalPayableTypes : Base
    {
        public DataTable GetAll()
        {
            ClearParameter();
            return FetchData("");

        }
        public DataTable GetById(int id)
        {
            ClearParameter();
            return FetchData("");

        }

        public void InsertOrUpdate()
        {
            ClearParameter();
            FetchData("");

        }

        public void Delete(int id)
        {
            ClearParameter();
            FetchData("");

        }
    }
}
