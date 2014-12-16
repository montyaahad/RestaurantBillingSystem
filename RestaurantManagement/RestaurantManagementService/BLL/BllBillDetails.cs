using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Service.DAL;
using Service.DTO;
using System.Data;

namespace Service.BLL
{
    public class BllBillDetails : BaseBll<DTO.BillDetails>
    {
        public BllBillDetails()
		{
			Dal = new DalBillDetails();
			
		}

        public override int InsertOrUpdate(BillDetails obj)
		{
			try
			{
                new DalBillDetails().InsertOrUpdate(obj);
				return 1;
			}
			catch (Exception)
			{

				return 0;
			}
		}

        public override BillDetails LoadFromReader(DataTableReader reader)
		{
            var temp = new BillDetails();
			
            if (reader != null && !reader.IsClosed)
			{
                temp.BillDetailId = reader.GetInt32(0);
				if (!reader.IsDBNull(1)) temp.BillId = reader.GetInt32(1);
                if (!reader.IsDBNull(2)) temp.MenuItemId = reader.GetInt32(2);
                if (!reader.IsDBNull(3)) temp.Quantity = reader.GetInt32(3);
                if (!reader.IsDBNull(4)) temp.UnitPrice = reader.GetDecimal(4);
                if (!reader.IsDBNull(5)) temp.IsDiscountAvailable = reader.GetBoolean(5);
                if (!reader.IsDBNull(6)) temp.TotalPrice = reader.GetDecimal(6);
                if (!reader.IsDBNull(7)) temp.ReceivedBy = reader.GetInt32(7);
                if (!reader.IsDBNull(9)) temp.MenuItemName = reader.GetString(9);

			
			}
			
			return temp;        
		}
    }
}
