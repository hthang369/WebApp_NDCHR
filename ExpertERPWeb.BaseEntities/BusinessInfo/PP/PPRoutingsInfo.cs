using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region PPRoutings
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:PPRoutingsInfo
	//Created Date:Sunday, August 2, 2015
	//-----------------------------------------------------------
	
	public class PPRoutingsInfo:BusinessObject
	{
		public PPRoutingsInfo()
		{
		}
		#region Variables
		protected int _pPRoutingID;
		protected Nullable<DateTime> _aACreatedDate;
		protected String _aACreatedUser=String.Empty;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _aAUpdatedUser=String.Empty;
		protected String _aAStatus=DefaultAAStatus;
		protected bool _aASelected=true;
		protected String _pPRoutingNo=String.Empty;
		protected String _pPRoutingDesc=String.Empty;
		protected Nullable<DateTime> _pPRoutingDate;
		protected String _pPRoutingRevision=String.Empty;
		protected int _fK_ARCustomerID;
		protected int _fK_HREmployeeID;
		protected double _pPRoutingEstRMCost;
		protected double _pPRoutingEstLabourCost;
		protected double _pPRoutingEstOverheadCost;
		protected double _pPRoutingEstCost;
		protected String _pPRoutingNormRevision=String.Empty;
		protected String _pPRoutingTypeCombo=String.Empty;
		protected String _aAModule=String.Empty;
		protected int _fK_ARCustomerProductReqItemID;
		protected bool _pPRoutingActiveCheck=true;
		#endregion

		#region Public properties
		public int PPRoutingID
		{
			get{return _pPRoutingID;}
			set
			{
				if (value != this._pPRoutingID)
				{
				_pPRoutingID=value;
				NotifyChanged("PPRoutingID");
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
		public String PPRoutingNo
		{
			get{return _pPRoutingNo;}
			set
			{
				if (value != this._pPRoutingNo)
				{
				_pPRoutingNo=value;
				NotifyChanged("PPRoutingNo");
				}
			}
		}
		public String PPRoutingDesc
		{
			get{return _pPRoutingDesc;}
			set
			{
				if (value != this._pPRoutingDesc)
				{
				_pPRoutingDesc=value;
				NotifyChanged("PPRoutingDesc");
				}
			}
		}
		public Nullable<DateTime> PPRoutingDate
		{
			get{return _pPRoutingDate;}
			set
			{
				if (value != this._pPRoutingDate)
				{
				_pPRoutingDate=value;
				NotifyChanged("PPRoutingDate");
				}
			}
		}
		public String PPRoutingRevision
		{
			get{return _pPRoutingRevision;}
			set
			{
				if (value != this._pPRoutingRevision)
				{
				_pPRoutingRevision=value;
				NotifyChanged("PPRoutingRevision");
				}
			}
		}
		public int FK_ARCustomerID
		{
			get{return _fK_ARCustomerID;}
			set
			{
				if (value != this._fK_ARCustomerID)
				{
				_fK_ARCustomerID=value;
				NotifyChanged("FK_ARCustomerID");
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
		public double PPRoutingEstRMCost
		{
			get{return _pPRoutingEstRMCost;}
			set
			{
				if (value != this._pPRoutingEstRMCost)
				{
				_pPRoutingEstRMCost=value;
				NotifyChanged("PPRoutingEstRMCost");
				}
			}
		}
		public double PPRoutingEstLabourCost
		{
			get{return _pPRoutingEstLabourCost;}
			set
			{
				if (value != this._pPRoutingEstLabourCost)
				{
				_pPRoutingEstLabourCost=value;
				NotifyChanged("PPRoutingEstLabourCost");
				}
			}
		}
		public double PPRoutingEstOverheadCost
		{
			get{return _pPRoutingEstOverheadCost;}
			set
			{
				if (value != this._pPRoutingEstOverheadCost)
				{
				_pPRoutingEstOverheadCost=value;
				NotifyChanged("PPRoutingEstOverheadCost");
				}
			}
		}
		public double PPRoutingEstCost
		{
			get{return _pPRoutingEstCost;}
			set
			{
				if (value != this._pPRoutingEstCost)
				{
				_pPRoutingEstCost=value;
				NotifyChanged("PPRoutingEstCost");
				}
			}
		}
		public String PPRoutingNormRevision
		{
			get{return _pPRoutingNormRevision;}
			set
			{
				if (value != this._pPRoutingNormRevision)
				{
				_pPRoutingNormRevision=value;
				NotifyChanged("PPRoutingNormRevision");
				}
			}
		}
		public String PPRoutingTypeCombo
		{
			get{return _pPRoutingTypeCombo;}
			set
			{
				if (value != this._pPRoutingTypeCombo)
				{
				_pPRoutingTypeCombo=value;
				NotifyChanged("PPRoutingTypeCombo");
				}
			}
		}
		public String AAModule
		{
			get{return _aAModule;}
			set
			{
				if (value != this._aAModule)
				{
				_aAModule=value;
				NotifyChanged("AAModule");
				}
			}
		}
		public int FK_ARCustomerProductReqItemID
		{
			get{return _fK_ARCustomerProductReqItemID;}
			set
			{
				if (value != this._fK_ARCustomerProductReqItemID)
				{
				_fK_ARCustomerProductReqItemID=value;
				NotifyChanged("FK_ARCustomerProductReqItemID");
				}
			}
		}
		public bool PPRoutingActiveCheck
		{
			get{return _pPRoutingActiveCheck;}
			set
			{
				if (value != this._pPRoutingActiveCheck)
				{
				_pPRoutingActiveCheck=value;
				NotifyChanged("PPRoutingActiveCheck");
				}
			}
		}
		#endregion
	}
	#endregion
}