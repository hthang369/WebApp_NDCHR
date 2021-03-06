using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region FAAssetDecreaseItems
    //-----------------------------------------------------------
    //Generated By: SQLDBTools - LINHCLH
    //Class: FAAssetDecreaseItemsInfo
    //Created Date: 01 Jan 2009
    //-----------------------------------------------------------

    public class FAAssetDecreaseItemsInfo : BusinessObject
    {
        public FAAssetDecreaseItemsInfo()
        {
        }
        #region Variables
		protected int _fAAssetDecreaseItemID;
		protected Nullable<DateTime> _aACreatedDate;
		protected String _aACreatedUser=String.Empty;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _aAUpdatedUser=String.Empty;
		protected String _aAStatus=DefaultAAStatus;
		protected bool _aASelected=true;
		protected int _fK_FAAssetID;
		protected int _fK_FAAssetDecreaseID;
		protected String _fAAssetDecreaseItemStatusCombo=DefaultStatus;
		protected double _fAAssetDecreaseItemDeprAmt;
		protected double _fAAssetDecreaseItemAccumDeprAmt;
		protected double _fAAssetDecreaseItemNetBookAmt;
		protected double _fAAssetDecreaseItemDeprItemAmt;
		protected String _fAAssetDecreaseItemDeprItemDesc=String.Empty;
		protected double _fAAssetDecreaseItemRAmt;
		protected double _fAAssetDeprItemCostAmt;
		protected String _fAAssetDecreaseItemTypeCombo=String.Empty;
		protected String _fAAssetCurrentStatus=DefaultStatus;
		protected double _fAAssetDecreaseItemCostOverhead;
		protected double _fAAssetDecreaseItemNetBookFAmt;
		protected double _fAAssetDecreaseItemAccumDeprFAmt;
		protected double _fAAssetDecreaseItemLife;
		
        #endregion

        #region Public properties
		public int FAAssetDecreaseItemID
		{
			get{return _fAAssetDecreaseItemID;}
			set
			{
				if (value != this._fAAssetDecreaseItemID)
				{
					_fAAssetDecreaseItemID=value;
					NotifyChanged("FAAssetDecreaseItemID");
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
		public int FK_FAAssetID
		{
			get{return _fK_FAAssetID;}
			set
			{
				if (value != this._fK_FAAssetID)
				{
					_fK_FAAssetID=value;
					NotifyChanged("FK_FAAssetID");
				}
			}
		}
		public int FK_FAAssetDecreaseID
		{
			get{return _fK_FAAssetDecreaseID;}
			set
			{
				if (value != this._fK_FAAssetDecreaseID)
				{
					_fK_FAAssetDecreaseID=value;
					NotifyChanged("FK_FAAssetDecreaseID");
				}
			}
		}
		public String FAAssetDecreaseItemStatusCombo
		{
			get{return _fAAssetDecreaseItemStatusCombo;}
			set
			{
				if (value != this._fAAssetDecreaseItemStatusCombo)
				{
					_fAAssetDecreaseItemStatusCombo=value;
					NotifyChanged("FAAssetDecreaseItemStatusCombo");
				}
			}
		}
		public double FAAssetDecreaseItemDeprAmt
		{
			get{return _fAAssetDecreaseItemDeprAmt;}
			set
			{
				if (value != this._fAAssetDecreaseItemDeprAmt)
				{
					_fAAssetDecreaseItemDeprAmt=value;
					NotifyChanged("FAAssetDecreaseItemDeprAmt");
				}
			}
		}
		public double FAAssetDecreaseItemAccumDeprAmt
		{
			get{return _fAAssetDecreaseItemAccumDeprAmt;}
			set
			{
				if (value != this._fAAssetDecreaseItemAccumDeprAmt)
				{
					_fAAssetDecreaseItemAccumDeprAmt=value;
					NotifyChanged("FAAssetDecreaseItemAccumDeprAmt");
				}
			}
		}
		public double FAAssetDecreaseItemNetBookAmt
		{
			get{return _fAAssetDecreaseItemNetBookAmt;}
			set
			{
				if (value != this._fAAssetDecreaseItemNetBookAmt)
				{
					_fAAssetDecreaseItemNetBookAmt=value;
					NotifyChanged("FAAssetDecreaseItemNetBookAmt");
				}
			}
		}
		public double FAAssetDecreaseItemDeprItemAmt
		{
			get{return _fAAssetDecreaseItemDeprItemAmt;}
			set
			{
				if (value != this._fAAssetDecreaseItemDeprItemAmt)
				{
					_fAAssetDecreaseItemDeprItemAmt=value;
					NotifyChanged("FAAssetDecreaseItemDeprItemAmt");
				}
			}
		}
		public String FAAssetDecreaseItemDeprItemDesc
		{
			get{return _fAAssetDecreaseItemDeprItemDesc;}
			set
			{
				if (value != this._fAAssetDecreaseItemDeprItemDesc)
				{
					_fAAssetDecreaseItemDeprItemDesc=value;
					NotifyChanged("FAAssetDecreaseItemDeprItemDesc");
				}
			}
		}
		public double FAAssetDecreaseItemRAmt
		{
			get{return _fAAssetDecreaseItemRAmt;}
			set
			{
				if (value != this._fAAssetDecreaseItemRAmt)
				{
					_fAAssetDecreaseItemRAmt=value;
					NotifyChanged("FAAssetDecreaseItemRAmt");
				}
			}
		}
		public double FAAssetDeprItemCostAmt
		{
			get{return _fAAssetDeprItemCostAmt;}
			set
			{
				if (value != this._fAAssetDeprItemCostAmt)
				{
					_fAAssetDeprItemCostAmt=value;
					NotifyChanged("FAAssetDeprItemCostAmt");
				}
			}
		}
		public String FAAssetDecreaseItemTypeCombo
		{
			get{return _fAAssetDecreaseItemTypeCombo;}
			set
			{
				if (value != this._fAAssetDecreaseItemTypeCombo)
				{
					_fAAssetDecreaseItemTypeCombo=value;
					NotifyChanged("FAAssetDecreaseItemTypeCombo");
				}
			}
		}
		public String FAAssetCurrentStatus
		{
			get{return _fAAssetCurrentStatus;}
			set
			{
				if (value != this._fAAssetCurrentStatus)
				{
					_fAAssetCurrentStatus=value;
					NotifyChanged("FAAssetCurrentStatus");
				}
			}
		}
		public double FAAssetDecreaseItemCostOverhead
		{
			get{return _fAAssetDecreaseItemCostOverhead;}
			set
			{
				if (value != this._fAAssetDecreaseItemCostOverhead)
				{
					_fAAssetDecreaseItemCostOverhead=value;
					NotifyChanged("FAAssetDecreaseItemCostOverhead");
				}
			}
		}
		public double FAAssetDecreaseItemNetBookFAmt
		{
			get{return _fAAssetDecreaseItemNetBookFAmt;}
			set
			{
				if (value != this._fAAssetDecreaseItemNetBookFAmt)
				{
					_fAAssetDecreaseItemNetBookFAmt=value;
					NotifyChanged("FAAssetDecreaseItemNetBookFAmt");
				}
			}
		}
		public double FAAssetDecreaseItemAccumDeprFAmt
		{
			get{return _fAAssetDecreaseItemAccumDeprFAmt;}
			set
			{
				if (value != this._fAAssetDecreaseItemAccumDeprFAmt)
				{
					_fAAssetDecreaseItemAccumDeprFAmt=value;
					NotifyChanged("FAAssetDecreaseItemAccumDeprFAmt");
				}
			}
		}
		public double FAAssetDecreaseItemLife
		{
			get{return _fAAssetDecreaseItemLife;}
			set
			{
				if (value != this._fAAssetDecreaseItemLife)
				{
					_fAAssetDecreaseItemLife=value;
					NotifyChanged("FAAssetDecreaseItemLife");
				}
			}
		}
		
        #endregion
    }
    #endregion
}