using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ICShipmentDebitNotes
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ICShipmentDebitNotesInfo
	//Created Date:21 Tháng Bảy 2011
	//-----------------------------------------------------------
	
	public class ICShipmentDebitNotesInfo:BusinessObject
	{
		public ICShipmentDebitNotesInfo()
		{
		}
		#region Variables
		protected int _iCShipmentDebitNoteID;
		protected String _aAStatus=DefaultAAStatus;
		protected int _fK_ICShipmentID;
		protected int _fK_APDebitNoteID;
		#endregion

		#region Public properties
		public int ICShipmentDebitNoteID
		{
			get{return _iCShipmentDebitNoteID;}
			set
			{
				if (value != this._iCShipmentDebitNoteID)
				{
				_iCShipmentDebitNoteID=value;
				NotifyChanged("ICShipmentDebitNoteID");
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
		public int FK_ICShipmentID
		{
			get{return _fK_ICShipmentID;}
			set
			{
				if (value != this._fK_ICShipmentID)
				{
				_fK_ICShipmentID=value;
				NotifyChanged("FK_ICShipmentID");
				}
			}
		}
		public int FK_APDebitNoteID
		{
			get{return _fK_APDebitNoteID;}
			set
			{
				if (value != this._fK_APDebitNoteID)
				{
				_fK_APDebitNoteID=value;
				NotifyChanged("FK_APDebitNoteID");
				}
			}
		}
		#endregion
	}
	#endregion
}