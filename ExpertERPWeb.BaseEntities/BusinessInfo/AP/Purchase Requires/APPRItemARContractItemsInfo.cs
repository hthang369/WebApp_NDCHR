using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region APPRItemARContractItems
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:APPRItemARContractItemsInfo
	//Created Date:Wednesday, April 15, 2015
	//-----------------------------------------------------------
	
	public class APPRItemARContractItemsInfo:BusinessObject
	{
		public APPRItemARContractItemsInfo()
		{
		}
		#region Variables
		protected int _aPPRItemARContractItemID;
		protected int _aPPRItemContractItemID;
		protected String _aAStatus=DefaultAAStatus;
		protected int _fK_APPRItemID;
		protected int _fK_ARContractItemID;
		#endregion

		#region Public properties
		public int APPRItemARContractItemID
		{
			get{return _aPPRItemARContractItemID;}
			set
			{
				if (value != this._aPPRItemARContractItemID)
				{
				_aPPRItemARContractItemID=value;
				NotifyChanged("APPRItemARContractItemID");
				}
			}
		}
		public int APPRItemContractItemID
		{
			get{return _aPPRItemContractItemID;}
			set
			{
				if (value != this._aPPRItemContractItemID)
				{
				_aPPRItemContractItemID=value;
				NotifyChanged("APPRItemContractItemID");
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
		public int FK_APPRItemID
		{
			get{return _fK_APPRItemID;}
			set
			{
				if (value != this._fK_APPRItemID)
				{
				_fK_APPRItemID=value;
				NotifyChanged("FK_APPRItemID");
				}
			}
		}
		public int FK_ARContractItemID
		{
			get{return _fK_ARContractItemID;}
			set
			{
				if (value != this._fK_ARContractItemID)
				{
				_fK_ARContractItemID=value;
				NotifyChanged("FK_ARContractItemID");
				}
			}
		}
		#endregion
	}
	#endregion
}