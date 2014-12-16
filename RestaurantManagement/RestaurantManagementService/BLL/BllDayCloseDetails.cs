using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Service.DAL;
using Service.DTO;
using System.Data;

namespace Service.BLL
{
    public class BllDayCloseDetails : BaseBll<DTO.DayCloseDetails>
    {
        public BllDayCloseDetails()
		{
            Dal = new DalDayCloseDetails();
			
		}

        public override int InsertOrUpdate(DayCloseDetails obj)
		{
			try
			{
                new DalDayCloseDetails().InsertOrUpdate(obj);
				return 1;
			}
			catch (Exception)
			{

				return 0;
			}
		}

        public override DayCloseDetails LoadFromReader(DataTableReader reader)
		{
            var temp = new DayCloseDetails();
			if (reader != null && !reader.IsClosed)
			{
                //temp.MenuCategoryId = reader.GetInt32(0);
				//if (!reader.IsDBNull(1)) temp.MenuCategoryName = reader.GetString(1);
			
			}
			
			return temp;        
		}

        public DateTime GetSystemDate()
        {
            return new DalDayCloseDetails().GetSystemDate();
        }

        public void GetDbBackup(string path)
        {
            new DalDayCloseDetails().GetDbBackup(path);
        }

        public DateTime GetValidityDate()
        {
            return new DalDayCloseDetails().GetValidityDate();
        }
    }
}
