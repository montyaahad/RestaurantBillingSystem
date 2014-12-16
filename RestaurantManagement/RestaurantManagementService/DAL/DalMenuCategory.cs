using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Service.DTO;

namespace Service.DAL
{
    internal class DalMenuCategory : BaseDal
    {
        public DalMenuCategory()
        {
            SelectAll = "sp_Select_MenuCategory_All";
            SelectById = "sp_Select_MenuCategory";
            IdParam = "@menucategoryid";
            DeleteSql = "sp_Delete_MenuCategory";
        }

        public void InsertOrUpdate(MenuCategory obj)
        {
            ClearParameter();


            AddParameter("@menucategoryid", obj.MenuCategoryId);
            AddParameter("@menucategoryname", obj.MenuCategoryName);

            FetchData("sp_InsertUpdate_MenuCategory");
        }
    }
}
