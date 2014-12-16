using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.DAL
{
    internal class DalWaiters : BaseDal
    {
        public DalWaiters()
        {
            SelectAll = "sp_Select_Waiters_All";
            //SelectById = "sp_Select_MenuCategory";
            //IdParam = "@menucategoryid";
            //DeleteSql = "sp_Delete_MenuCategory";
        }
    }
}
