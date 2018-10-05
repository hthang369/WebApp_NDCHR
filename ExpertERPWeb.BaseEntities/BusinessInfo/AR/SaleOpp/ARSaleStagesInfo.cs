using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ARSaleStages
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ARSaleStagesInfo
	//Created Date:Wednesday, May 23, 2012
	//-----------------------------------------------------------
	
	public class ARSaleStagesInfo:BusinessObject
	{
		public ARSaleStagesInfo()
		{
		}
		#region Variables
		protected int _aRSaleStageID;
		protected Nullable<DateTime> _aACreatedDate;
		protected String _aACreatedUser=String.Empty;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _aAUpdatedUser=String.Empty;
		protected String _aAStatus=DefaultAAStatus;
		protected String _aRSaleStageNo=String.Empty;
		protected String _aRSaleStageName=String.Empty;
		protected String _aRSaleStageDesc=String.Empty;
		protected double _aRSaleStageClosingPct;
		protected String _aRSaleStageDocTypeCombo=String.Empty;
		#endregion

		#region Public properties
		public int ARSaleStageID
		{
			get{return _aRSaleStageID;}
			set
			{
				if (value != this._aRSaleStageID)
				{
				_aRSaleStageID=value;
				NotifyChanged("ARSaleStageID");
				}
			}
		}
		public Nullable<DateTime> AACreatedDate
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
		public Nullable<DateTime> AAUpdatedDate
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
		public String ARSaleStageNo
		{
			get{return _aRSaleStageNo;}
			set
			{
				if (value != this._aRSaleStageNo)
				{
				_aRSaleStageNo=value;
				NotifyChanged("ARSaleStageNo");
				}
			}
		}
		public String ARSaleStageName
		{
			get{return _aRSaleStageName;}
			set
			{
				if (value != this._aRSaleStageName)
				{
				_aRSaleStageName=value;
				NotifyChanged("ARSaleStageName");
				}
			}
		}
		public String ARSaleStageDesc
		{
			get{return _aRSaleStageDesc;}
			set
			{
				if (value != this._aRSaleStageDesc)
				{
				_aRSaleStageDesc=value;
				NotifyChanged("ARSaleStageDesc");
				}
			}
		}
		public double ARSaleStageClosingPct
		{
			get{return _aRSaleStageClosingPct;}
			set
			{
				if (value != this._aRSaleStageClosingPct)
				{
				_aRSaleStageClosingPct=value;
				NotifyChanged("ARSaleStageClosingPct");
				}
			}
		}
		public String ARSaleStageDocTypeCombo
		{
			get{return _aRSaleStageDocTypeCombo;}
			set
			{
				if (value != this._aRSaleStageDocTypeCombo)
				{
				_aRSaleStageDocTypeCombo=value;
				NotifyChanged("ARSaleStageDocTypeCombo");
				}
			}
		}
		#endregion
	}
	#endregion
}