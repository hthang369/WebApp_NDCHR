using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region HRWorkSheetItems
    //-----------------------------------------------------------
    //Generated By: SQLDBTools.Net ♫ Hồռ؏ ₤ĩռᶋ (v2.0.76)
    //Class: HRWorkSheetItemsInfo
    //Created Date: Monday, 23 Apr 2018
    //-----------------------------------------------------------

    public class HRWorkSheetItemsInfo : BusinessObject
    {
        public HRWorkSheetItemsInfo()
        {
        }
        #region Variables
		protected int _hRWorkSheetItemID;
		protected int _fK_HRPeriodID;
		protected Nullable<DateTime> _hRWorkSheetItemDate;
		protected int _fK_HREmployeeID;
		protected String _hRWorkSheetItemValue = String.Empty;
		protected int _fK_HROvertimeRateID;
		protected String _hROvertimeRateTypeCombo = String.Empty;
		protected double _hRWorkSheetItemRateAmt;
		protected double _hRWorkSheetItemHourAmt;
		protected double _hRWorkSheetItemHourCalAmt;
		
        #endregion

        #region Public properties
		public int HRWorkSheetItemID
		{
			get { return _hRWorkSheetItemID; }
			set
			{
				if (value != this._hRWorkSheetItemID)
				{
					_hRWorkSheetItemID = value;
					NotifyChanged("HRWorkSheetItemID");
				}
			}
		}
		public int FK_HRPeriodID
		{
			get { return _fK_HRPeriodID; }
			set
			{
				if (value != this._fK_HRPeriodID)
				{
					_fK_HRPeriodID = value;
					NotifyChanged("FK_HRPeriodID");
				}
			}
		}
		public Nullable<DateTime> HRWorkSheetItemDate
		{
			get { return _hRWorkSheetItemDate; }
			set
			{
				if (value != this._hRWorkSheetItemDate)
				{
					_hRWorkSheetItemDate = value;
					NotifyChanged("HRWorkSheetItemDate");
				}
			}
		}
		public int FK_HREmployeeID
		{
			get { return _fK_HREmployeeID; }
			set
			{
				if (value != this._fK_HREmployeeID)
				{
					_fK_HREmployeeID = value;
					NotifyChanged("FK_HREmployeeID");
				}
			}
		}
		public String HRWorkSheetItemValue
		{
			get { return _hRWorkSheetItemValue; }
			set
			{
				if (value != this._hRWorkSheetItemValue)
				{
					_hRWorkSheetItemValue = value;
					NotifyChanged("HRWorkSheetItemValue");
				}
			}
		}
		public int FK_HROvertimeRateID
		{
			get { return _fK_HROvertimeRateID; }
			set
			{
				if (value != this._fK_HROvertimeRateID)
				{
					_fK_HROvertimeRateID = value;
					NotifyChanged("FK_HROvertimeRateID");
				}
			}
		}
		public String HROvertimeRateTypeCombo
		{
			get { return _hROvertimeRateTypeCombo; }
			set
			{
				if (value != this._hROvertimeRateTypeCombo)
				{
					_hROvertimeRateTypeCombo = value;
					NotifyChanged("HROvertimeRateTypeCombo");
				}
			}
		}
		public double HRWorkSheetItemRateAmt
		{
			get { return _hRWorkSheetItemRateAmt; }
			set
			{
				if (value != this._hRWorkSheetItemRateAmt)
				{
					_hRWorkSheetItemRateAmt = value;
					NotifyChanged("HRWorkSheetItemRateAmt");
				}
			}
		}
		public double HRWorkSheetItemHourAmt
		{
			get { return _hRWorkSheetItemHourAmt; }
			set
			{
				if (value != this._hRWorkSheetItemHourAmt)
				{
					_hRWorkSheetItemHourAmt = value;
					NotifyChanged("HRWorkSheetItemHourAmt");
				}
			}
		}
		public double HRWorkSheetItemHourCalAmt
		{
			get { return _hRWorkSheetItemHourCalAmt; }
			set
			{
				if (value != this._hRWorkSheetItemHourCalAmt)
				{
					_hRWorkSheetItemHourCalAmt = value;
					NotifyChanged("HRWorkSheetItemHourCalAmt");
				}
			}
		}
		
        #endregion
    }
    #endregion
}