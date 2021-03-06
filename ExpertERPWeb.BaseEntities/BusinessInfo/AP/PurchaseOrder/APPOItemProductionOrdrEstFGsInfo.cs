using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region APPOItemProductionOrdrEstFGs
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:APPOItemProductionOrdrEstFGsInfo
	//Created Date:24 Tháng Mười Hai 2014
	//-----------------------------------------------------------
	
	public class APPOItemProductionOrdrEstFGsInfo:BusinessObject
	{
		public APPOItemProductionOrdrEstFGsInfo()
		{
		}
		#region Variables
		protected int _aPPOItemProductionOrdrEstFGID;
		protected String _aAStatus=DefaultAAStatus;
		protected int _fK_APPOItemID;
		protected int _fK_PPProductionOrdrEstFGID;
		#endregion

		#region Public properties
		public int APPOItemProductionOrdrEstFGID
		{
			get{return _aPPOItemProductionOrdrEstFGID;}
			set
			{
				if (value != this._aPPOItemProductionOrdrEstFGID)
				{
				_aPPOItemProductionOrdrEstFGID=value;
				NotifyChanged("APPOItemProductionOrdrEstFGID");
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
		public int FK_APPOItemID
		{
			get{return _fK_APPOItemID;}
			set
			{
				if (value != this._fK_APPOItemID)
				{
				_fK_APPOItemID=value;
				NotifyChanged("FK_APPOItemID");
				}
			}
		}
		public int FK_PPProductionOrdrEstFGID
		{
			get{return _fK_PPProductionOrdrEstFGID;}
			set
			{
				if (value != this._fK_PPProductionOrdrEstFGID)
				{
				_fK_PPProductionOrdrEstFGID=value;
				NotifyChanged("FK_PPProductionOrdrEstFGID");
				}
			}
		}
		#endregion
	}
	#endregion
}