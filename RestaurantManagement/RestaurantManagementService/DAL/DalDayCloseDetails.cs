using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Service.DTO;
using System.Data;

namespace Service.DAL
{
    internal class DalDayCloseDetails : BaseDal
    {
        public DalDayCloseDetails()
        {
            SelectAll = "";
            SelectById = "";
            IdParam = "@id";
            DeleteSql = "";
        }

        public void InsertOrUpdate(DayCloseDetails obj)
        {
            ClearParameter();


            AddParameter("@id", obj.Id);
            AddParameter("@closingdate", obj.ClosingDate);
            AddParameter("@newdate", obj.NewDate);
            AddParameter("@entrydatetime", obj.EntryDateTime);
            AddParameter("@userid", obj.UserId);

            FetchData("sp_InsertUpdate_DayCloseDetails");
        }

        public DateTime GetSystemDate()
        {
            ClearParameter();


            DataTable dt = FetchData("sp_Get_SystemDate");
            DateTime sdate = Convert.ToDateTime(dt.Rows[0][0]);

            return sdate;
        }

        public void GetDbBackup(string path)
        {
            ClearParameter();

            AddParameter("@path", path);

            FetchData("sp_Get_DB_Backup");
        }

        public DateTime GetValidityDate()
        {
            ClearParameter();


            DataTable dt = FetchData("sp_Get_ValidDate");
            DateTime sdate = Convert.ToDateTime(dt.Rows[0][0]);

            return sdate;
        }
    }
}
