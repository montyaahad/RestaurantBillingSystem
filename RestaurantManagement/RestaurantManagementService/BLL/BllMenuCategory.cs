using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Service.DAL;
using Service.DTO;
using System.Data;

namespace Service.BLL
{
    public class BllMenuCategory : BaseBll<DTO.MenuCategory>
    {
        public BllMenuCategory()
		{
			Dal = new DalMenuCategory();
			
		}

		public override int InsertOrUpdate(MenuCategory obj)
		{
			try
			{
				new DalMenuCategory().InsertOrUpdate(obj);
				return 1;
			}
			catch (Exception)
			{

				return 0;
			}
		}

		public override MenuCategory LoadFromReader(DataTableReader reader)
		{
			var temp = new MenuCategory();
			if (reader != null && !reader.IsClosed)
			{
                temp.MenuCategoryId = reader.GetInt32(0);
				if (!reader.IsDBNull(1)) temp.MenuCategoryName = reader.GetString(1);
			
			}
			
			return temp;        
		}
    }
}
