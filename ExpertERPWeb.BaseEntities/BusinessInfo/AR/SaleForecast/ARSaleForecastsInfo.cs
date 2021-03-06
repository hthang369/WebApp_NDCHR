 using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region ARSaleForecasts
    //-----------------------------------------------------------
    //Generated By: SQLDBTools.NET - LINHCLH (v2.0.36)
    //Class: ARSaleForecastsInfo
    //Created Date: Wednesday, 20 Sep 2017
    //-----------------------------------------------------------

    public class ARSaleForecastsInfo : BusinessObject
    {
        public ARSaleForecastsInfo()
        {
        }
        #region Variables
		protected int _aRSaleForecastID;
		protected DateTime _aACreatedDate = DateTime.Now;
		protected String _aACreatedUser = String.Empty;
		protected DateTime _aAUpdatedDate = DateTime.Now;
		protected String _aAUpdatedUser = String.Empty;
		protected String _aAStatus = DefaultAAStatus;
		protected bool _aASelected = true;
		protected String _aRSaleForecastNo = String.Empty;
		protected String _aRSaleForecastName = String.Empty;
		protected String _aRSaleForecastDesc = String.Empty;
		protected Nullable<DateTime> _aRSaleForeCastDate;
		protected int _aRSaleForecastYear;
		protected int _fK_ARCustomerID;
		protected int _aRSaleForecastPeriod;
		protected Nullable<DateTime> _aRSaleForeCastShpDate;
		protected bool _aRSaleForecastActiveCheck = true;
		
        #endregion

        #region Public properties
		public int ARSaleForecastID
		{
			get { return _aRSaleForecastID; }
			set
			{
				if (value != this._aRSaleForecastID)
				{
					_aRSaleForecastID = value;
					NotifyChanged("ARSaleForecastID");
				}
			}
		}
		public DateTime AACreatedDate
		{
			get { return _aACreatedDate; }
			set
			{
				if (value != this._aACreatedDate)
				{
					_aACreatedDate = value;
					NotifyChanged("AACreatedDate");
				}
			}
		}
		public String AACreatedUser
		{
			get { return _aACreatedUser; }
			set
			{
				if (value != this._aACreatedUser)
				{
					_aACreatedUser = value;
					NotifyChanged("AACreatedUser");
				}
			}
		}
		public DateTime AAUpdatedDate
		{
			get { return _aAUpdatedDate; }
			set
			{
				if (value != this._aAUpdatedDate)
				{
					_aAUpdatedDate = value;
					NotifyChanged("AAUpdatedDate");
				}
			}
		}
		public String AAUpdatedUser
		{
			get { return _aAUpdatedUser; }
			set
			{
				if (value != this._aAUpdatedUser)
				{
					_aAUpdatedUser = value;
					NotifyChanged("AAUpdatedUser");
				}
			}
		}
		public String AAStatus
		{
			get { return _aAStatus; }
			set
			{
				if (value != this._aAStatus)
				{
					_aAStatus = value;
					NotifyChanged("AAStatus");
				}
			}
		}
		public bool AASelected
		{
			get { return _aASelected; }
			set
			{
				if (value != this._aASelected)
				{
					_aASelected = value;
					NotifyChanged("AASelected");
				}
			}
		}
		public String ARSaleForecastNo
		{
			get { return _aRSaleForecastNo; }
			set
			{
				if (value != this._aRSaleForecastNo)
				{
					_aRSaleForecastNo = value;
					NotifyChanged("ARSaleForecastNo");
				}
			}
		}
		public String ARSaleForecastName
		{
			get { return _aRSaleForecastName; }
			set
			{
				if (value != this._aRSaleForecastName)
				{
					_aRSaleForecastName = value;
					NotifyChanged("ARSaleForecastName");
				}
			}
		}
		public String ARSaleForecastDesc
		{
			get { return _aRSaleForecastDesc; }
			set
			{
				if (value != this._aRSaleForecastDesc)
				{
					_aRSaleForecastDesc = value;
					NotifyChanged("ARSaleForecastDesc");
				}
			}
		}
		public Nullable<DateTime> ARSaleForeCastDate
		{
			get { return _aRSaleForeCastDate; }
			set
			{
				if (value != this._aRSaleForeCastDate)
				{
					_aRSaleForeCastDate = value;
					NotifyChanged("ARSaleForeCastDate");
				}
			}
		}
		public int ARSaleForecastYear
		{
			get { return _aRSaleForecastYear; }
			set
			{
				if (value != this._aRSaleForecastYear)
				{
					_aRSaleForecastYear = value;
					NotifyChanged("ARSaleForecastYear");
				}
			}
		}
		public int FK_ARCustomerID
		{
			get { return _fK_ARCustomerID; }
			set
			{
				if (value != this._fK_ARCustomerID)
				{
					_fK_ARCustomerID = value;
					NotifyChanged("FK_ARCustomerID");
				}
			}
		}
		public int ARSaleForecastPeriod
		{
			get { return _aRSaleForecastPeriod; }
			set
			{
				if (value != this._aRSaleForecastPeriod)
				{
					_aRSaleForecastPeriod = value;
					NotifyChanged("ARSaleForecastPeriod");
				}
			}
		}
		public Nullable<DateTime> ARSaleForeCastShpDate
		{
			get { return _aRSaleForeCastShpDate; }
			set
			{
				if (value != this._aRSaleForeCastShpDate)
				{
					_aRSaleForeCastShpDate = value;
					NotifyChanged("ARSaleForeCastShpDate");
				}
			}
		}
		public bool ARSaleForecastActiveCheck
		{
			get { return _aRSaleForecastActiveCheck; }
			set
			{
				if (value != this._aRSaleForecastActiveCheck)
				{
					_aRSaleForecastActiveCheck = value;
					NotifyChanged("ARSaleForecastActiveCheck");
				}
			}
		}
		
        #endregion
    }
    #endregion
}