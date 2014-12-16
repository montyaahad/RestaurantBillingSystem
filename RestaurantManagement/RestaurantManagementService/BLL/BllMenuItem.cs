using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Service.DAL;
using Service.DTO;
using System.Data;

namespace Service.BLL
{
    public class BllMenuItem : BaseBll<DTO.MenuItem>
    {
        public BllMenuItem()
		{
			Dal = new DalMenuItem();
			
		}

		public override int InsertOrUpdate(MenuItem obj)
		{
			try
			{
				new DalMenuItem().InsertOrUpdate(obj);
				return 1;
			}
			catch (Exception)
			{

				return 0;
			}
		}

		public override MenuItem LoadFromReader(DataTableReader reader)
		{
			var temp = new MenuItem();
			if (reader != null && !reader.IsClosed)
			{
                temp.MenuItemId = reader.GetInt32(0);
				if (!reader.IsDBNull(1)) temp.MenuItemName = reader.GetString(1);

                temp.Price = reader.GetDecimal(2);
                temp.MenuItemCode = reader.GetString(3);
                temp.MenuCategoryId = reader.GetInt32(4);
                if (!reader.IsDBNull(5)) temp.MenuCategoryName = reader.GetString(5);
                if (!reader.IsDBNull(6)) temp.Description = reader.GetString(6);
                if (!reader.IsDBNull(7)) temp.FoodOrBeverage = reader.GetString(7);
			
			}
			
			return temp;        
		}

        public int GetMinimumMenuItemId()
        {
            try
            {
                return new DalMenuItem().GetMinimumMenuItemId();
            }
            catch (Exception)
            {

                return 0;
            }
        }

        public int GetMenuItemIdByMenuCode(string menuItemCode)
        {
            try
            {
                return new DalMenuItem().GetMenuItemIdByMenuCode(menuItemCode);
            }
            catch (Exception)
            {

                return 0;
            }
        }
    }
}
