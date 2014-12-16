using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.DAL
{
    internal class DalPaymentType : BaseDal
    {
        public DalPaymentType()
        {
            SelectAll = "sp_Select_PaymentType_All";
            //SelectById = "sp_Select_MenuCategory";
            //IdParam = "@menucategoryid";
            //DeleteSql = "sp_Delete_MenuCategory";
        }
    }
}
