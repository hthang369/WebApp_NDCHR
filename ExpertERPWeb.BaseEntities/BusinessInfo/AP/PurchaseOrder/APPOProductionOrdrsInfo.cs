using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region APPOProductionOrdrs
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:APPOProductionOrdrsInfo
	//Created Date:24 Tháng Mười Hai 2014
	//-----------------------------------------------------------
	
	public class APPOProductionOrdrsInfo:BusinessObject
	{
		public APPOProductionOrdrsInfo()
		{
		}
		#region Variables
		protected int _aPPOProductionOrdrID;
		protected String _aAStatus=DefaultAAStatus;
		protected int _fK_APPOID;
		protected int _fK_PPProductionOrdrID;
		#endregion

		#region Public properties
		public int APPOProductionOrdrID
		{
			get{return _aPPOProductionOrdrID;}
			set
			{
				if (value != this._aPPOProductionOrdrID)
				{
				_aPPOProductionOrdrID=value;
				NotifyChanged("APPOProductionOrdrID");
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
		public int FK_APPOID
		{
			get{return _fK_APPOID;}
			set
			{
				if (value != this._fK_APPOID)
				{
				_fK_APPOID=value;
				NotifyChanged("FK_APPOID");
				}
			}
		}
		public int FK_PPProductionOrdrID
		{
			get{return _fK_PPProductionOrdrID;}
			set
			{
				if (value != this._fK_PPProductionOrdrID)
				{
				_fK_PPProductionOrdrID=value;
				NotifyChanged("FK_PPProductionOrdrID");
				}
			}
		}
		#endregion
	}
	#endregion
}