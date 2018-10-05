using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region APPOLogisticItems
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:APPOLogisticItemsInfo
	//Created Date:Thursday, November 8, 2012
	//-----------------------------------------------------------
	
	public class APPOLogisticItemsInfo:BusinessObject
	{
		public APPOLogisticItemsInfo()
		{
		}
		#region Variables
		protected int _aPPOLogisticItemID;
		protected String _aAStatus=DefaultAAStatus;
		protected int _fK_APPOID;
		protected String _aPPOLogisticItemContNo=String.Empty;
		protected String _aPPOLogisticItemSealNo=String.Empty;
		protected double _aPPOLogisticItemGWeight;
		protected double _aPPOLogisticItemNWeight;
		protected double _aPPOLogisticItemVolumn;
		protected double _aPPOLogisticItemPackage;
		protected String _aPPOLogisticItemDesc=String.Empty;
		protected String _aPPOLogisticItemContType=String.Empty;
		#endregion

		#region Public properties
		public int APPOLogisticItemID
		{
			get{return _aPPOLogisticItemID;}
			set
			{
				if (value != this._aPPOLogisticItemID)
				{
				_aPPOLogisticItemID=value;
				NotifyChanged("APPOLogisticItemID");
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
		public String APPOLogisticItemContNo
		{
			get{return _aPPOLogisticItemContNo;}
			set
			{
				if (value != this._aPPOLogisticItemContNo)
				{
				_aPPOLogisticItemContNo=value;
				NotifyChanged("APPOLogisticItemContNo");
				}
			}
		}
		public String APPOLogisticItemSealNo
		{
			get{return _aPPOLogisticItemSealNo;}
			set
			{
				if (value != this._aPPOLogisticItemSealNo)
				{
				_aPPOLogisticItemSealNo=value;
				NotifyChanged("APPOLogisticItemSealNo");
				}
			}
		}
		public double APPOLogisticItemGWeight
		{
			get{return _aPPOLogisticItemGWeight;}
			set
			{
				if (value != this._aPPOLogisticItemGWeight)
				{
				_aPPOLogisticItemGWeight=value;
				NotifyChanged("APPOLogisticItemGWeight");
				}
			}
		}
		public double APPOLogisticItemNWeight
		{
			get{return _aPPOLogisticItemNWeight;}
			set
			{
				if (value != this._aPPOLogisticItemNWeight)
				{
				_aPPOLogisticItemNWeight=value;
				NotifyChanged("APPOLogisticItemNWeight");
				}
			}
		}
		public double APPOLogisticItemVolumn
		{
			get{return _aPPOLogisticItemVolumn;}
			set
			{
				if (value != this._aPPOLogisticItemVolumn)
				{
				_aPPOLogisticItemVolumn=value;
				NotifyChanged("APPOLogisticItemVolumn");
				}
			}
		}
		public double APPOLogisticItemPackage
		{
			get{return _aPPOLogisticItemPackage;}
			set
			{
				if (value != this._aPPOLogisticItemPackage)
				{
				_aPPOLogisticItemPackage=value;
				NotifyChanged("APPOLogisticItemPackage");
				}
			}
		}
		public String APPOLogisticItemDesc
		{
			get{return _aPPOLogisticItemDesc;}
			set
			{
				if (value != this._aPPOLogisticItemDesc)
				{
				_aPPOLogisticItemDesc=value;
				NotifyChanged("APPOLogisticItemDesc");
				}
			}
		}
		public String APPOLogisticItemContType
		{
			get{return _aPPOLogisticItemContType;}
			set
			{
				if (value != this._aPPOLogisticItemContType)
				{
				_aPPOLogisticItemContType=value;
				NotifyChanged("APPOLogisticItemContType");
				}
			}
		}
		#endregion
	}
	#endregion
}