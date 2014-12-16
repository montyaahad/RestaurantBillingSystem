using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Service.DAL;
using Service.DTO;
using System.Data;

namespace Service.BLL
{
    public class BllPaymentType : BaseBll<DTO.PaymentType>
    {
        public BllPaymentType()
		{
			Dal = new DalPaymentType();
			
		}

        public override int InsertOrUpdate(PaymentType obj)
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

        public override PaymentType LoadFromReader(DataTableReader reader)
        {
            var temp = new PaymentType();
            if (reader != null && !reader.IsClosed)
            {
                temp.PaymentTypeId = reader.GetInt32(0);
                if (!reader.IsDBNull(1)) temp.PaymentTypeName = reader.GetString(1);

            }

            return temp;
        }
    }
}
