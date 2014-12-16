using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Service.DTO;

namespace Service.DAL
{
    internal class DalBillInfo : BaseDal
    {
        public DalBillInfo()
        {
            SelectAll = "sp_Select_BillInfo_All";
            SelectById = "sp_Select_BillInfo";
            IdParam = "@billid";
            DeleteSql = "sp_Delete_BillInfo";
        }

        public int InsertOrUpdate(BillInfo obj)
        {
            ClearParameter();
            

            AddParameter("@billid", obj.BillId);
            AddParameter("@billno", obj.BillNo);
            AddParameter("@subtotal", obj.SubTotal);
            AddParameter("@discountpercent", obj.DiscountPercent);
            AddParameter("@discountamount", obj.DiscountAmount);
            AddParameter("@vatpercent", obj.VatPercent);
            AddParameter("@vatamount", obj.VatAmount);
            AddParameter("@grandtotal", obj.GrandTotal);
            AddParameter("@billdate", obj.BillDate);
            AddParameter("@paymenttype", obj.PaymentType);
            AddParameter("@tableno", obj.TableNo);

            AddParameter("@billstatus", obj.BillStatus);
            AddParameter("@entrydatetime", obj.EntryDatetime);
            AddParameter("@receivedby", obj.ReceivedBy);
            AddParameter("@remarks", obj.Remarks);

            AddParameter("@isclosed", obj.IsClosed);
            AddParameter("@servicechargepercent", obj.ServiceChargePercent);
            AddParameter("@servicechargeamount", obj.ServiceChargeAmount);
            AddParameter("@servicetypeid", obj.ServiceTypeId);
            AddParameter("@paymenttypeid", obj.PaymentTypeId);
            AddParameter("@waiterid", obj.WaiterId);
            AddParameter("@tableid", obj.TableId);
            AddParameter("@kotno", obj.KotNo);

            AddParameter("@pax", obj.Pax);
            AddParameter("@customername", obj.CustomerName);

            //FetchData("sp_InsertUpdate_BillInfo");

            
            int id = 0;
            id = InsertOrUpdateData("sp_InsertUpdate_BillInfo");

            return id;
        }

        public int GetOpenBillIdByTableId(int tableId)
        {
            ClearParameter();

            AddParameter("@tableid", tableId);

            int id = 0;
            id = FetchDataNonQuery("sp_Select_Open_BillId_By_TableId");

            return id;
        }
    }
}
