using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Service.DAL;
using System.Data;
using Service.DTO;

namespace Service.BLL
{
    public class BllServiceType : BaseBll<DTO.ServiceType>
    {
        public BllServiceType()
		{
			Dal = new DalServiceType();
			
		}

        public override int InsertOrUpdate(ServiceType obj)
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

        public override ServiceType LoadFromReader(DataTableReader reader)
        {
            var temp = new ServiceType();
            if (reader != null && !reader.IsClosed)
            {
                temp.ServiceTypeId = reader.GetInt32(0);
                if (!reader.IsDBNull(1)) temp.ServiceTypeName = reader.GetString(1);

            }

            return temp;
        }
    }
}
