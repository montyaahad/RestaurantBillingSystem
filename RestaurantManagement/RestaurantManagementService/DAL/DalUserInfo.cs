using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Service.DAL
{
    internal class DalUserInfo : BaseDal
    {
        public DalUserInfo()
        {
            SelectAll = "sp_Select_UserInfo_All";
            SelectById = "sp_Select_UserInfo_By_Username";
            IdParam = "@username";
            //DeleteSql = "sp_Delete_MenuCategory";
        }

        public DataTable GetUserInfoByUsername(string username)
        {
            ClearParameter();

            AddParameter("@username", username);


            return FetchData("sp_Select_UserInfo_By_Username");
        }

    }
}
