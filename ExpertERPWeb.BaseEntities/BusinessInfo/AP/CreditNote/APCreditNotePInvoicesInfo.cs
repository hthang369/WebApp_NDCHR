using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region APCreditNotePInvoices
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:APCreditNotePInvoicesInfo
	//Created Date:06 Tháng Chín 2012
	//-----------------------------------------------------------
	
	public class APCreditNotePInvoicesInfo:BusinessObject
	{
		public APCreditNotePInvoicesInfo()
		{
		}
		#region Variables
		protected int _aPCreditNotePInvoiceID;
		protected String _aAStatus=DefaultAAStatus;
		protected int _fK_APCreditNoteID;
		protected int _fK_APPInvoiceID;
		#endregion

		#region Public properties
		public int APCreditNotePInvoiceID
		{
			get{return _aPCreditNotePInvoiceID;}
			set
			{
				if (value != this._aPCreditNotePInvoiceID)
				{
				_aPCreditNotePInvoiceID=value;
				NotifyChanged("APCreditNotePInvoiceID");
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
		public int FK_APCreditNoteID
		{
			get{return _fK_APCreditNoteID;}
			set
			{
				if (value != this._fK_APCreditNoteID)
				{
				_fK_APCreditNoteID=value;
				NotifyChanged("FK_APCreditNoteID");
				}
			}
		}
		public int FK_APPInvoiceID
		{
			get{return _fK_APPInvoiceID;}
			set
			{
				if (value != this._fK_APPInvoiceID)
				{
				_fK_APPInvoiceID=value;
				NotifyChanged("FK_APPInvoiceID");
				}
			}
		}
		#endregion
	}
	#endregion
}