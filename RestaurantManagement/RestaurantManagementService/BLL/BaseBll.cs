using System.Collections.Generic;
using System.Data;
using Service.DAL;

namespace Service.BLL
{
    public abstract class BaseBll<T>
    {
        internal BaseDal Dal { get; set; }
        public virtual List<T> GetAll()
        {
            DataTable dt = Dal.GetAll();

            return LoadLists(dt.CreateDataReader());
        }
        public virtual T GetById(int id)
        {
            T t = default(T);
            DataTable dt = Dal.GetById(id);
            var reader = dt.CreateDataReader();
            try
            {
                if (reader.Read())
                {
                    t = LoadFromReader(reader);
                    reader.Close();
                }
                return t;
            }
            finally
            {
                if (!reader.IsClosed) 
                        reader.Close();
            }
        }

        public virtual List<T> Get(int refid)
        {
            DataTable dt = Dal.GetById(refid);

            return LoadLists(dt.CreateDataReader());
        }

        public abstract int InsertOrUpdate(T obj);
        public virtual void Delete(int id)
        {
            Dal.Delete(id);
        }

        public abstract T LoadFromReader(DataTableReader reader);

        protected virtual List<T> LoadLists(DataTableReader reader)
        {
            var list = new List<T>();

            try
            {
                while (reader.Read())
                {
                    list.Add(LoadFromReader(reader));
                }
                return list;
            }
            finally
            {
                if (!reader.IsClosed)
                    reader.Close();
            }
        }
         
    }
}