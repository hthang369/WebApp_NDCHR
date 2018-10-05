using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region HRKPISuggeItems
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:HRKPISuggeItemsInfo
	//Created Date:Tuesday, July 10, 2018
	//-----------------------------------------------------------
	
	public class HRKPISuggeItemsInfo:BusinessObject
	{
		public HRKPISuggeItemsInfo()
		{
		}
		#region Variables
		protected int _hRKPISuggeItemID;
		protected int _fK_HRKPISuggeID;
		protected int _fK_HREmployeeID;
		protected int _fK_HRPositionID;
		protected double _hRKPISuggeItemValue;
		#endregion

		#region Public properties
		public int HRKPISuggeItemID
		{
			get{return _hRKPISuggeItemID;}
			set
			{
				if (value != this._hRKPISuggeItemID)
				{
				_hRKPISuggeItemID=value;
				NotifyChanged("HRKPISuggeItemID");
				}
			}
		}
		public int FK_HRKPISuggeID
		{
			get{return _fK_HRKPISuggeID;}
			set
			{
				if (value != this._fK_HRKPISuggeID)
				{
				_fK_HRKPISuggeID=value;
				NotifyChanged("FK_HRKPISuggeID");
				}
			}
		}
		public int FK_HREmployeeID
		{
			get{return _fK_HREmployeeID;}
			set
			{
				if (value != this._fK_HREmployeeID)
				{
				_fK_HREmployeeID=value;
				NotifyChanged("FK_HREmployeeID");
				}
			}
		}
		public int FK_HRPositionID
		{
			get{return _fK_HRPositionID;}
			set
			{
				if (value != this._fK_HRPositionID)
				{
				_fK_HRPositionID=value;
				NotifyChanged("FK_HRPositionID");
				}
			}
		}
		public double HRKPISuggeItemValue
		{
			get{return _hRKPISuggeItemValue;}
			set
			{
				if (value != this._hRKPISuggeItemValue)
				{
				_hRKPISuggeItemValue=value;
				NotifyChanged("HRKPISuggeItemValue");
				}
			}
		}
		#endregion
	}
	#endregion
}