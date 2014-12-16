using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.DAL
{
    internal class DalChargeConfiguration : BaseDal
    {
        public DalChargeConfiguration()
        {
            SelectAll = "sp_Select_ChargeConfiguration_All";
            //SelectById = "sp_Select_MenuCategory";
            //IdParam = "@menucategoryid";
            //DeleteSql = "sp_Delete_MenuCategory";
        }
    }
}
