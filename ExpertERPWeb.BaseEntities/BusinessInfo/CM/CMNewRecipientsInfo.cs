using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region CMNewRecipients
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:CMNewRecipientsInfo
	//Created Date:Saturday, May 02, 2009
	//-----------------------------------------------------------
	
	public class CMNewRecipientsInfo:BusinessObject
	{
		public CMNewRecipientsInfo()
		{
		}
		#region Variables
		protected int _cMNewRecipientID;
		protected String _cMNewRecipientUserName=String.Empty;
		protected String _cMNewRecipientName=String.Empty;
		protected String _cMNewRecipientEmail=String.Empty;
		protected int _fK_CMNewID;
		#endregion

		#region Public properties
		public int CMNewRecipientID
		{
			get{return _cMNewRecipientID;}
			set
			{
				if (value != this._cMNewRecipientID)
				{
				_cMNewRecipientID=value;
				NotifyChanged("CMNewRecipientID");
				}
			}
		}
		public String CMNewRecipientUserName
		{
			get{return _cMNewRecipientUserName;}
			set
			{
				if (value != this._cMNewRecipientUserName)
				{
				_cMNewRecipientUserName=value;
				NotifyChanged("CMNewRecipientUserName");
				}
			}
		}
		public String CMNewRecipientName
		{
			get{return _cMNewRecipientName;}
			set
			{
				if (value != this._cMNewRecipientName)
				{
				_cMNewRecipientName=value;
				NotifyChanged("CMNewRecipientName");
				}
			}
		}
		public String CMNewRecipientEmail
		{
			get{return _cMNewRecipientEmail;}
			set
			{
				if (value != this._cMNewRecipientEmail)
				{
				_cMNewRecipientEmail=value;
				NotifyChanged("CMNewRecipientEmail");
				}
			}
		}
		public int FK_CMNewID
		{
			get{return _fK_CMNewID;}
			set
			{
				if (value != this._fK_CMNewID)
				{
				_fK_CMNewID=value;
				NotifyChanged("FK_CMNewID");
				}
			}
		}
		#endregion
	}
	#endregion
}