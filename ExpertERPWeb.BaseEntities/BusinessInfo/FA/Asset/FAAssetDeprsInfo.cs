using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region FAAssetDecreases
    //-----------------------------------------------------------
    //Generated By: GMC Studio
    //Class: FAAssetDecreasesInfo
    //Created Date: 11 Mar 2015
    //-----------------------------------------------------------

    public class FAAssetDecreasesInfo : BusinessObject
    {
        public FAAssetDecreasesInfo()
        {
        }
        #region Variables
		protected int _fAAssetDecreaseID;
		protected Nullable<DateTime> _aACreatedDate;
		protected String _aACreatedUser=String.Empty;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _aAUpdatedUser=String.Empty;
		protected String _aAStatus=DefaultAAStatus;
		protected String _fAAssetDecreaseNo=String.Empty;
		protected String _fAAssetDecreaseName=String.Empty;
		protected String _fAAssetDecreaseDesc=String.Empty;
		protected String _fAAssetDecreaseTypeCombo=String.Empty;
		protected DateTime _fAAssetDecreaseDate=DateTime.Now;
		protected bool _aASelected=true;
		protected String _aAPostStatus=DefaultStatus;
		protected String _aALastPostNo=String.Empty;
		protected Nullable<DateTime> _aALastPostDate;
		protected Nullable<DateTime> _fAAssetDecreaseJrnDate;
		
        #endregion

        #region Public properties
		public int FAAssetDecreaseID
		{
			get{return _fAAssetDecreaseID;}
			set
			{
				if (value != this._fAAssetDecreaseID)
				{
					_fAAssetDecreaseID=value;
					NotifyChanged("FAAssetDecreaseID");
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
		public String FAAssetDecreaseNo
		{
			get{return _fAAssetDecreaseNo;}
			set
			{
				if (value != this._fAAssetDecreaseNo)
				{
					_fAAssetDecreaseNo=value;
					NotifyChanged("FAAssetDecreaseNo");
				}
			}
		}
		public String FAAssetDecreaseName
		{
			get{return _fAAssetDecreaseName;}
			set
			{
				if (value != this._fAAssetDecreaseName)
				{
					_fAAssetDecreaseName=value;
					NotifyChanged("FAAssetDecreaseName");
				}
			}
		}
		public String FAAssetDecreaseDesc
		{
			get{return _fAAssetDecreaseDesc;}
			set
			{
				if (value != this._fAAssetDecreaseDesc)
				{
					_fAAssetDecreaseDesc=value;
					NotifyChanged("FAAssetDecreaseDesc");
				}
			}
		}
		public String FAAssetDecreaseTypeCombo
		{
			get{return _fAAssetDecreaseTypeCombo;}
			set
			{
				if (value != this._fAAssetDecreaseTypeCombo)
				{
					_fAAssetDecreaseTypeCombo=value;
					NotifyChanged("FAAssetDecreaseTypeCombo");
				}
			}
		}
		public DateTime FAAssetDecreaseDate
		{
			get{return _fAAssetDecreaseDate;}
			set
			{
				if (value != this._fAAssetDecreaseDate)
				{
					_fAAssetDecreaseDate=value;
					NotifyChanged("FAAssetDecreaseDate");
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
		public String AAPostStatus
		{
			get{return _aAPostStatus;}
			set
			{
				if (value != this._aAPostStatus)
				{
					_aAPostStatus=value;
					NotifyChanged("AAPostStatus");
				}
			}
		}
		public String AALastPostNo
		{
			get{return _aALastPostNo;}
			set
			{
				if (value != this._aALastPostNo)
				{
					_aALastPostNo=value;
					NotifyChanged("AALastPostNo");
				}
			}
		}
		public Nullable<DateTime> AALastPostDate
		{
			get{return _aALastPostDate;}
			set
			{
				if (value != this._aALastPostDate)
				{
					_aALastPostDate=value;
					NotifyChanged("AALastPostDate");
				}
			}
		}
		public Nullable<DateTime> FAAssetDecreaseJrnDate
		{
			get{return _fAAssetDecreaseJrnDate;}
			set
			{
				if (value != this._fAAssetDecreaseJrnDate)
				{
					_fAAssetDecreaseJrnDate=value;
					NotifyChanged("FAAssetDecreaseJrnDate");
				}
			}
		}
		
        #endregion
    }
    #endregion
}