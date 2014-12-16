using System;

namespace Service.DTO
{
	public class ServiceType
	{
		
		#region Class Variables
		
		private Int32	_servicetypeid;
		private String	_servicetype;
		
		#endregion
		
		public Int32 ServiceTypeId
		{
			get { return _servicetypeid; }
			set { _servicetypeid = value; }
		}
		
		public String ServiceTypeName
		{
			get { return _servicetype; }
			set { _servicetype = value; }
		}
	}
}

