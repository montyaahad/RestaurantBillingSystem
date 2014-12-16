using System.Collections.Generic;

namespace Service.BLL
{
    public interface IBll<T>
    {
        List<T> GetAll();
        T GetById(int id);

        int InsertOrUpdate(T obj);
        void Delete(int id);


    }
}