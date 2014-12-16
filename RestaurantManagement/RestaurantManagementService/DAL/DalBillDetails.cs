using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Service.DTO;

namespace Service.DAL
{
    internal class DalBillDetails : BaseDal
    {
        public DalBillDetails()
        {
            SelectAll = "";
            SelectById = "";
            IdParam = "@billid";
            DeleteSql = "";
        }

        public void InsertOrUpdate(BillDetails obj)
        {
            ClearParameter();


            AddParameter("@billdetailid", obj.BillDetailId);
            AddParameter("@billid", obj.BillId);
            AddParameter("@menuitemid", obj.MenuItemId);
            AddParameter("@quantity", obj.Quantity);
            AddParameter("@unitprice", obj.UnitPrice);
            AddParameter("@isdiscountavailable", obj.IsDiscountAvailable);
            AddParameter("@totalprice", obj.TotalPrice);
            AddParameter("@receivedby", 1);

            FetchData("sp_InsertUpdate_BillDetails");
        }
    }
}
