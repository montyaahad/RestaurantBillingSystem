using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Service.DTO;
using System.Data;

namespace Service.DAL
{
    internal class DalTempBillDetails : BaseDal
    {
        public DalTempBillDetails()
        {
            SelectAll = "";
            SelectById = "sp_Select_TempBillDetail_By_BillId";
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
            AddParameter("@isdeleted", obj.IsDeleted);

            FetchData("sp_InsertUpdate_TempBillDetails");
        }

        public void Delete(BillDetails obj)
        {
            ClearParameter();


            AddParameter("@billid", obj.BillId);
            AddParameter("@menuitemid", obj.MenuItemId);

            FetchData("sp_Delete_TempBillDetails");
        }

        public DataTable GetBillDetailsByBillId(int billId)
        {
            ClearParameter();
            AddParameter("@billid", billId);

            return FetchData("sp_Select_TempBillDetail_By_BillId");
 
        }
    }
}
