using System;

namespace Service.DTO
{
	public class TableDetails
	{
		
		#region Class Variables
		
		private Int32	_tableid;
		private String	_tablecode;
		
		#endregion
		
		public Int32 TableId
		{
			get { return _tableid; }
			set { _tableid = value; }
		}
		
		public String TableCode
		{
			get { return _tablecode; }
			set { _tablecode = value; }
		}
	}
}

