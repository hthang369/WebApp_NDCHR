using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ARCreditNoteSaleReturns
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ARCreditNoteSaleReturnsInfo
	//Created Date:27 Tháng Tám 2012
	//-----------------------------------------------------------
	
	public class ARCreditNoteSaleReturnsInfo:BusinessObject
	{
		public ARCreditNoteSaleReturnsInfo()
		{
		}
		#region Variables
		protected int _aRCreditNoteSaleReturnID;
		protected String _aAStatus=DefaultAAStatus;
		protected int _fK_ARSaleReturnID;
		protected int _fK_ARCreditNoteID;
		#endregion

		#region Public properties
		public int ARCreditNoteSaleReturnID
		{
			get{return _aRCreditNoteSaleReturnID;}
			set
			{
				if (value != this._aRCreditNoteSaleReturnID)
				{
				_aRCreditNoteSaleReturnID=value;
				NotifyChanged("ARCreditNoteSaleReturnID");
				}
			}
		}
		public String AAStatus
		{
			get{return _aAStatus;}
			set
			{
				if (value != this._aAStatus)
				{
				_aAStatus=value;
				NotifyChanged("AAStatus");
				}
			}
		}
		public int FK_ARSaleReturnID
		{
			get{return _fK_ARSaleReturnID;}
			set
			{
				if (value != this._fK_ARSaleReturnID)
				{
				_fK_ARSaleReturnID=value;
				NotifyChanged("FK_ARSaleReturnID");
				}
			}
		}
		public int FK_ARCreditNoteID
		{
			get{return _fK_ARCreditNoteID;}
			set
			{
				if (value != this._fK_ARCreditNoteID)
				{
				_fK_ARCreditNoteID=value;
				NotifyChanged("FK_ARCreditNoteID");
				}
			}
		}
		#endregion
	}
	#endregion
}