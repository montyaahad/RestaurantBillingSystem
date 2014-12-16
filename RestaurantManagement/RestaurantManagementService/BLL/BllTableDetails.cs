using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Service.DAL;
using System.Data;
using Service.DTO;

namespace Service.BLL
{
    public class BllTableDetails : BaseBll<DTO.TableDetails>
    {
        public BllTableDetails()
		{
			Dal = new DalTableDetails();
			
		}

        public override int InsertOrUpdate(TableDetails obj)
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

        public override TableDetails LoadFromReader(DataTableReader reader)
        {
            var temp = new TableDetails();
            if (reader != null && !reader.IsClosed)
            {
                temp.TableId = reader.GetInt32(0);
                if (!reader.IsDBNull(1)) temp.TableCode = reader.GetString(1);

            }

            return temp;
        }
    }
}
