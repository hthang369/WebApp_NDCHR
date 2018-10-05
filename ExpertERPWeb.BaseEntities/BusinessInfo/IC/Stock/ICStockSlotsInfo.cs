using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ICStockSlots
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ICStockSlotsInfo
	//Created Date:Friday, February 13, 2009
	//-----------------------------------------------------------
	
	public class ICStockSlotsInfo:BusinessObject
	{
		public ICStockSlotsInfo()
		{
		}
		#region Variables
		protected int _iCStockSlotID;
		protected String _aAStatus=DefaultAAStatus;
		protected String _aACreatedUser=String.Empty;
		protected String _aAUpdatedUser=String.Empty;
		protected DateTime _aACreatedDate=DateTime.MaxValue;
		protected DateTime _aAUpdatedDate=DateTime.MaxValue;
		protected int _fK_ICStockID;
		protected String _iCStockSlotNo=String.Empty;
		protected String _iCStockSlotName=String.Empty;
		protected String _iCStockSlotDesc=String.Empty;
		protected String _iCStockSlotOF01Combo=String.Empty;
		protected String _iCStockSlotOF02Combo=String.Empty;
		#endregion

		#region Public properties
		public int ICStockSlotID
		{
			get{return _iCStockSlotID;}
			set
			{
				if (value != this._iCStockSlotID)
				{
				_iCStockSlotID=value;
				NotifyChanged("ICStockSlotID");
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
		public String AACreatedUser
		{
			get{return _aACreatedUser;}
			set
			{
				if (value != this._aACreatedUser)
				{
				_aACreatedUser=value;
				NotifyChanged("AACreatedUser");
				}
			}
		}
		public String AAUpdatedUser
		{
			get{return _aAUpdatedUser;}
			set
			{
				if (value != this._aAUpdatedUser)
				{
				_aAUpdatedUser=value;
				NotifyChanged("AAUpdatedUser");
				}
			}
		}
		public DateTime AACreatedDate
		{
			get{return _aACreatedDate;}
			set
			{
				if (value != this._aACreatedDate)
				{
				_aACreatedDate=value;
				NotifyChanged("AACreatedDate");
				}
			}
		}
		public DateTime AAUpdatedDate
		{
			get{return _aAUpdatedDate;}
			set
			{
				if (value != this._aAUpdatedDate)
				{
				_aAUpdatedDate=value;
				NotifyChanged("AAUpdatedDate");
				}
			}
		}
		public int FK_ICStockID
		{
			get{return _fK_ICStockID;}
			set
			{
				if (value != this._fK_ICStockID)
				{
				_fK_ICStockID=value;
				NotifyChanged("FK_ICStockID");
				}
			}
		}
		public String ICStockSlotNo
		{
			get{return _iCStockSlotNo;}
			set
			{
				if (value != this._iCStockSlotNo)
				{
				_iCStockSlotNo=value;
				NotifyChanged("ICStockSlotNo");
				}
			}
		}
		public String ICStockSlotName
		{
			get{return _iCStockSlotName;}
			set
			{
				if (value != this._iCStockSlotName)
				{
				_iCStockSlotName=value;
				NotifyChanged("ICStockSlotName");
				}
			}
		}
		public String ICStockSlotDesc
		{
			get{return _iCStockSlotDesc;}
			set
			{
				if (value != this._iCStockSlotDesc)
				{
				_iCStockSlotDesc=value;
				NotifyChanged("ICStockSlotDesc");
				}
			}
		}
		public String ICStockSlotOF01Combo
		{
			get{return _iCStockSlotOF01Combo;}
			set
			{
				if (value != this._iCStockSlotOF01Combo)
				{
				_iCStockSlotOF01Combo=value;
				NotifyChanged("ICStockSlotOF01Combo");
				}
			}
		}
		public String ICStockSlotOF02Combo
		{
			get{return _iCStockSlotOF02Combo;}
			set
			{
				if (value != this._iCStockSlotOF02Combo)
				{
				_iCStockSlotOF02Combo=value;
				NotifyChanged("ICStockSlotOF02Combo");
				}
			}
		}
		#endregion
	}
	#endregion
}