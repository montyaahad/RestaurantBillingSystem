using System;

namespace Service.DTO
{
	public class Waiters
	{
		
		#region Class Variables
		
		private Int32	_waiterid;
		private String	_waitername;
		private String	_waitercode;
		
		#endregion
		
		public Int32 WaiterId
		{
			get { return _waiterid; }
			set { _waiterid = value; }
		}
		
		public String WaiterName
		{
			get { return _waitername; }
			set { _waitername = value; }
		}
		
		public String WaiterCode
		{
			get { return _waitercode; }
			set { _waitercode = value; }
		}
	}
}

