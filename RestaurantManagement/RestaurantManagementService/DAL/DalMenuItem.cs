using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Service.DTO;

namespace Service.DAL
{
    internal class DalMenuItem : BaseDal
    {
        public DalMenuItem()
        {
            SelectAll = "sp_Select_MenuItem_All";
            SelectById = "sp_Select_MenuItem";
            IdParam = "@menuitemid";
            DeleteSql = "sp_Delete_MenuItem";
        }

        public void InsertOrUpdate(MenuItem obj)
        {
            ClearParameter();


            AddParameter("@menuitemid", obj.MenuItemId);
            AddParameter("@menuitemname", obj.MenuItemName);

            AddParameter("@price", obj.Price);
            AddParameter("@menuitemcode", obj.MenuItemCode);
            AddParameter("@menucategoryid", obj.MenuCategoryId);
            AddParameter("@description", obj.Description);
            AddParameter("@foodorbeverage", obj.FoodOrBeverage);

            FetchData("sp_InsertUpdate_MenuItem");
        }

        public int GetMinimumMenuItemId()
        {
            ClearParameter();


            int id = 0;
            id = FetchDataNonQuery("sp_Get_Minimum_MenuItemId");

            return id;
        }

        public int GetMenuItemIdByMenuCode(string menuItemCode)
        {
            ClearParameter();

            AddParameter("@menuitemcode", menuItemCode);

            int id = 0;
            id = FetchDataNonQuery("sp_Get_MenuItemId_By_MenuCode");

            return id;
        }
    }
}
