using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Service.DTO;
using Service.DAL;
using System.Data;

namespace Service.BLL
{
    public class BllUserInfo : BaseBll<DTO.UserInfo>
    {
        public BllUserInfo()
		{
			Dal = new DalUserInfo();
			
		}

        public override int InsertOrUpdate(UserInfo obj)
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

        public override UserInfo LoadFromReader(DataTableReader reader)
        {
            var temp = new UserInfo();
            if (reader != null && !reader.IsClosed)
            {
                temp.UserId = reader.GetInt32(0);
                if (!reader.IsDBNull(1)) temp.UserName = reader.GetString(1);
                if (!reader.IsDBNull(2)) temp.UserPassword = reader.GetString(2);

            }

            return temp;
        }

        public List<DTO.UserInfo> GetUserInfoByUsername(string username)
        {
            try
            {
                DataTable dt = new DalUserInfo().GetUserInfoByUsername(username);

                return LoadLists(dt.CreateDataReader());
            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}
