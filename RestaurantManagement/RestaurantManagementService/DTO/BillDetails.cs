using System;

namespace Service.DTO
{
	public class BillDetails
	{
		
		#region Class Variables
		
		private Int32	_billdetailid;
		private Int32	_billid;
		private Int32	_menuitemid;
		private Int32	_quantity;
		private Decimal	_unitprice;
		private Boolean	_isdiscountavailable;
		private Decimal	_totalprice;
        private Boolean _isdeleted;
        private int _receivedby;
		
		#endregion
		
		
		public Int32 BillDetailId
		{
			get { return _billdetailid; }
			set { _billdetailid = value; }
		}
		
		
		public Int32 BillId
		{
			get { return _billid; }
			set { _billid = value; }
		}
		
		
		public Int32 MenuItemId
		{
			get { return _menuitemid; }
			set { _menuitemid = value; }
		}
		
		
		public Int32 Quantity
		{
			get { return _quantity; }
			set { _quantity = value; }
		}
		
		
		public Decimal UnitPrice
		{
			get { return _unitprice; }
			set { _unitprice = value; }
		}
		
		
		public Boolean IsDiscountAvailable
		{
			get { return _isdiscountavailable; }
			set { _isdiscountavailable = value; }
		}
		
		
		public Decimal TotalPrice
		{
			get { return _totalprice; }
			set { _totalprice = value; }
		}

        public Boolean IsDeleted
        {
            get { return _isdeleted; }
            set { _isdeleted = value; }
        }

        public Int32 ReceivedBy
        {
            get { return _receivedby; }
            set { _receivedby = value; }
        }

        public string MenuItemName { get; set; }
	}
}

