using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ARQuotItemSOItems
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ARQuotItemSOItemsInfo
	//Created Date:Tuesday, January 19, 2010
	//-----------------------------------------------------------
	
	public class ARQuotItemSOItemsInfo:BusinessObject
	{
		public ARQuotItemSOItemsInfo()
		{
		}
		#region Variables
		protected int _aRQuotItemSOItemID;
		protected String _aAStatus=DefaultAAStatus;
		protected int _fK_ARQuotItemID;
		protected int _fK_ARSOItemID;
		#endregion

		#region Public properties
		public int ARQuotItemSOItemID
		{
			get{return _aRQuotItemSOItemID;}
			set
			{
				if (value != this._aRQuotItemSOItemID)
				{
				_aRQuotItemSOItemID=value;
				NotifyChanged("ARQuotItemSOItemID");
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
		public int FK_ARQuotItemID
		{
			get{return _fK_ARQuotItemID;}
			set
			{
				if (value != this._fK_ARQuotItemID)
				{
				_fK_ARQuotItemID=value;
				NotifyChanged("FK_ARQuotItemID");
				}
			}
		}
		public int FK_ARSOItemID
		{
			get{return _fK_ARSOItemID;}
			set
			{
				if (value != this._fK_ARSOItemID)
				{
				_fK_ARSOItemID=value;
				NotifyChanged("FK_ARSOItemID");
				}
			}
		}
		#endregion
	}
	#endregion
}