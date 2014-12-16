using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.DAL
{
    internal class DalTableDetails : BaseDal
    {
        public DalTableDetails()
        {
            SelectAll = "sp_Select_TableDetails_All";
            //SelectById = "sp_Select_MenuCategory";
            //IdParam = "@menucategoryid";
            //DeleteSql = "sp_Delete_MenuCategory";
        }
    }
}
