using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Service.DAL;
using Service.DTO;
using System.Data;

namespace Service.BLL
{
    public class BllBillInfo : BaseBll<DTO.BillInfo>
    {
        public BllBillInfo()
		{
			Dal = new DalBillInfo();
			
		}

        public override int InsertOrUpdate(BillInfo obj)
		{
			try
			{
				return new DalBillInfo().InsertOrUpdate(obj);
				//return 1;
			}
			catch (Exception)
			{

				return 0;
			}
		}

        public override BillInfo LoadFromReader(DataTableReader reader)
		{
            var temp = new BillInfo();
			if (reader != null && !reader.IsClosed)
			{
                temp.BillId = reader.GetInt32(0);
                if (!reader.IsDBNull(1)) temp.BillNo = reader.GetString(1);
                if (!reader.IsDBNull(2)) temp.SubTotal = reader.GetDecimal(2);
                if (!reader.IsDBNull(3)) temp.DiscountPercent = reader.GetInt32(3);
                if (!reader.IsDBNull(4)) temp.DiscountAmount = reader.GetDecimal(4);
                if (!reader.IsDBNull(5)) temp.VatPercent = reader.GetInt32(5);
                if (!reader.IsDBNull(6)) temp.VatAmount = reader.GetDecimal(6);
                if (!reader.IsDBNull(7)) temp.GrandTotal = reader.GetDecimal(7);
                if (!reader.IsDBNull(8)) temp.BillDate = reader.GetDateTime(8);
                if (!reader.IsDBNull(9)) temp.PaymentType = reader.GetInt32(9);
                if (!reader.IsDBNull(10)) temp.TableNo = reader.GetInt32(10);
                if (!reader.IsDBNull(11)) temp.BillStatus = reader.GetString(11);
                if (!reader.IsDBNull(12)) temp.EntryDatetime = reader.GetDateTime(12);
                if (!reader.IsDBNull(13)) temp.ReceivedBy = reader.GetInt32(13);
                if (!reader.IsDBNull(14)) temp.Remarks = reader.GetString(14);

                if (!reader.IsDBNull(15)) temp.IsClosed = reader.GetBoolean(15);
                if (!reader.IsDBNull(16)) temp.ServiceChargePercent = reader.GetInt32(16);
                if (!reader.IsDBNull(17)) temp.ServiceChargeAmount = reader.GetDecimal(17);
                if (!reader.IsDBNull(18)) temp.ServiceTypeId = reader.GetInt32(18);
                if (!reader.IsDBNull(19)) temp.PaymentTypeId = reader.GetInt32(19);
                if (!reader.IsDBNull(20)) temp.WaiterId = reader.GetInt32(20);
                if (!reader.IsDBNull(21)) temp.TableId = reader.GetInt32(21);
                if (!reader.IsDBNull(22)) temp.KotNo = reader.GetString(22);
			
			}
			
			return temp;        
		}

        public int GetOpenBillIdByTableId(int tableId)
        {
            try
            {
                return new DalBillInfo().GetOpenBillIdByTableId(tableId);
            }
            catch (Exception)
            {

                return 0;
            }
        }

    }
}
