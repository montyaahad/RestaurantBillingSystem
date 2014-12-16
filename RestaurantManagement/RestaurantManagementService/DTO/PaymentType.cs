using System;

namespace Service.DTO
{
	public class PaymentType
	{
		
		#region Class Variables
		
		private Int32	_paymenttypeid;
		private String	_paymenttype;
		
		#endregion
		
		public Int32 PaymentTypeId
		{
			get { return _paymenttypeid; }
			set { _paymenttypeid = value; }
		}
		
		public String PaymentTypeName
		{
			get { return _paymenttype; }
			set { _paymenttype = value; }
		}
	}
}

