using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Service.DAL;
using System.Data;
using Service.DTO;

namespace Service.BLL
{
    public class BllWaiters : BaseBll<DTO.Waiters>
    {
        public BllWaiters()
		{
			Dal = new DalWaiters();
			
		}

        public override int InsertOrUpdate(Waiters obj)
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

        public override Waiters LoadFromReader(DataTableReader reader)
        {
            var temp = new Waiters();
            if (reader != null && !reader.IsClosed)
            {
                temp.WaiterId = reader.GetInt32(0);
                if (!reader.IsDBNull(1)) temp.WaiterName = reader.GetString(1);
                if (!reader.IsDBNull(2)) temp.WaiterCode = reader.GetString(2);

            }

            return temp;
        }
    }
}
