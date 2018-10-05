using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region PPOBWIPItemDetails
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:PPOBWIPItemDetailsInfo
	//Created Date:Monday, June 27, 2016
	//-----------------------------------------------------------
	
	public class PPOBWIPItemDetailsInfo:BusinessObject
	{
		public PPOBWIPItemDetailsInfo()
		{
		}
		#region Variables
		protected int _pPOBWIPItemDetailID;
		protected String _aAStatus=DefaultAAStatus;
		protected bool _aASelected=true;
		protected int _fK_PPCostCenterID;
		protected double _pPOBWIPItemDetailAmtTot;
		protected int _fK_PPOBWIPItemID;
		#endregion

		#region Public properties
		public int PPOBWIPItemDetailID
		{
			get{return _pPOBWIPItemDetailID;}
			set
			{
				if (value != this._pPOBWIPItemDetailID)
				{
				_pPOBWIPItemDetailID=value;
				NotifyChanged("PPOBWIPItemDetailID");
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
		public bool AASelected
		{
			get{return _aASelected;}
			set
			{
				if (value != this._aASelected)
				{
				_aASelected=value;
				NotifyChanged("AASelected");
				}
			}
		}
		public int FK_PPCostCenterID
		{
			get{return _fK_PPCostCenterID;}
			set
			{
				if (value != this._fK_PPCostCenterID)
				{
				_fK_PPCostCenterID=value;
				NotifyChanged("FK_PPCostCenterID");
				}
			}
		}
		public double PPOBWIPItemDetailAmtTot
		{
			get{return _pPOBWIPItemDetailAmtTot;}
			set
			{
				if (value != this._pPOBWIPItemDetailAmtTot)
				{
				_pPOBWIPItemDetailAmtTot=value;
				NotifyChanged("PPOBWIPItemDetailAmtTot");
				}
			}
		}
		public int FK_PPOBWIPItemID
		{
			get{return _fK_PPOBWIPItemID;}
			set
			{
				if (value != this._fK_PPOBWIPItemID)
				{
				_fK_PPOBWIPItemID=value;
				NotifyChanged("FK_PPOBWIPItemID");
				}
			}
		}
		#endregion
	}
	#endregion
}