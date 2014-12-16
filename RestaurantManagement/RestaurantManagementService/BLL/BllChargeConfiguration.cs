using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Service.DAL;
using Service.DTO;
using System.Data;

namespace Service.BLL
{
    public class BllChargeConfiguration : BaseBll<DTO.ChargeConfiguration>
    {
        public BllChargeConfiguration()
		{
            Dal = new DalChargeConfiguration();
			
		}

        public override int InsertOrUpdate(ChargeConfiguration obj)
        {
            try
            {
                //new DalMenuCategory().InsertOrUpdate(obj);
                return 1;
            }
            catch (Exception)
            {

                return 0;
            }
        }

        public override ChargeConfiguration LoadFromReader(DataTableReader reader)
        {
            var temp = new ChargeConfiguration();
            if (reader != null && !reader.IsClosed)
            {
                temp.Id = reader.GetInt32(0);
                if (!reader.IsDBNull(1)) temp.DiscountPercent = reader.GetInt32(1);
                if (!reader.IsDBNull(2)) temp.ServiceChargePercent = reader.GetInt32(2);
                if (!reader.IsDBNull(3)) temp.VatPercent = reader.GetInt32(3);

            }

            return temp;
        }
    }
}
