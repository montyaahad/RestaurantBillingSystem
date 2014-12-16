using System;

namespace Service.DTO
{
	
	public class BillInfo
	{
		
		#region Class Variables
		
		private Int32	_billid;
		private String	_billno;
		private Decimal	_subtotal;
		private Int32	_discountpercent;
		private Decimal	_discountamount;
		private Int32	_vatpercent;
		private Decimal	_vatamount;
		private Decimal	_grandtotal;
		private DateTime	_billdate;
		private Int32	_paymenttype;
		private Int32	_tableno;
		private String	_billstatus;
		private DateTime	_entrydatetime;
		private Int32	_receivedby;
		private String	_remarks;
        
        private Boolean _isclosed;
        private Int32 _servicechargepercent;
        private Decimal _servicechargeamount;
        private Int32 _servicetypeid;
        private Int32 _paymenttypeid;
        private Int32 _waiterid;
        private Int32 _tableid;
        private String  _kotno;

        private Int32 _pax;
        private String _customername;
		
		#endregion
		
		
		public Int32 BillId
		{
			get { return _billid; }
			set { _billid = value; }
		}
		
		
		public String BillNo
		{
			get { return _billno; }
			set { _billno = value; }
		}
		
		
		public Decimal SubTotal
		{
			get { return _subtotal; }
			set { _subtotal = value; }
		}
		
		
		public Int32 DiscountPercent
		{
			get { return _discountpercent; }
			set { _discountpercent = value; }
		}
		
		
		public Decimal DiscountAmount
		{
			get { return _discountamount; }
			set { _discountamount = value; }
		}
		
		
		public Int32 VatPercent
		{
			get { return _vatpercent; }
			set { _vatpercent = value; }
		}
		
		
		public Decimal VatAmount
		{
			get { return _vatamount; }
			set { _vatamount = value; }
		}
		
		
		public Decimal GrandTotal
		{
			get { return _grandtotal; }
			set { _grandtotal = value; }
		}
		
		
		public DateTime BillDate
		{
			get { return _billdate; }
			set { _billdate = value; }
		}
		
		
		public Int32 PaymentType
		{
			get { return _paymenttype; }
			set { _paymenttype = value; }
		}
		
		
		public Int32 TableNo
		{
			get { return _tableno; }
			set { _tableno = value; }
		}
		
		
		public String BillStatus
		{
			get { return _billstatus; }
			set { _billstatus = value; }
		}
		
		
		public DateTime EntryDatetime
		{
			get { return _entrydatetime; }
			set { _entrydatetime = value; }
		}
		
		
		public Int32 ReceivedBy
		{
			get { return _receivedby; }
			set { _receivedby = value; }
		}
		
		
		public String Remarks
		{
			get { return _remarks; }
			set { _remarks = value; }
		}

        public Boolean IsClosed
        {
            get { return _isclosed; }
            set { _isclosed = value; }
        }






        public Int32 ServiceChargePercent
        {
            get { return _servicechargepercent; }
            set { _servicechargepercent = value; }
        }
        public Decimal ServiceChargeAmount
        {
            get { return _servicechargeamount; }
            set { _servicechargeamount = value; }
        }
        public Int32 ServiceTypeId
        {
            get { return _servicetypeid; }
            set { _servicetypeid = value; }
        }
        public Int32 PaymentTypeId
        {
            get { return _paymenttypeid; }
            set { _paymenttypeid = value; }
        }
        public Int32 WaiterId
        {
            get { return _waiterid; }
            set { _waiterid = value; }
        }
        public Int32 TableId
        {
            get { return _tableid; }
            set { _tableid = value; }
        }
        public String KotNo
        {
            get { return _kotno; }
            set { _kotno = value; }
        }

        public Int32 Pax
        {
            get { return _pax; }
            set { _pax = value; }
        }
        public String CustomerName
        {
            get { return _customername; }
            set { _customername = value; }
        }

	}
}

