using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.DAL
{
    internal class DalServiceType : BaseDal
    {
        public DalServiceType()
        {
            SelectAll = "sp_Select_ServiceType_All";
            //SelectById = "sp_Select_MenuCategory";
            //IdParam = "@menucategoryid";
            //DeleteSql = "sp_Delete_MenuCategory";
        }
    }
}
