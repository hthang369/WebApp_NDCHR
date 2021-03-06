using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region ViewCashFlowDetails
    //-----------------------------------------------------------
    //Generated By: GMC Studio
    //Class:ViewCashFlowDetailsInfo
    //Created Date:26 April 2013
    //-----------------------------------------------------------

    public class ViewCashFlowDetailsInfo : BusinessObject
    {
        public ViewCashFlowDetailsInfo()
        {
        }
        #region Variables
        protected int _viewCashFlowDetailID;
        protected String _aACashFlowDetailTypeCombo = String.Empty;
        protected double _amtTot;
        protected DateTime _fromDate = DateTime.Now;
        protected DateTime _toDate = DateTime.Now;
        #endregion

        #region Public properties
        public int ViewCashFlowDetailID
        {
            get { return _viewCashFlowDetailID; }
            set
            {
                if (value != this._viewCashFlowDetailID)
                {
                    _viewCashFlowDetailID = value;
                    NotifyChanged("ViewCashFlowDetailID");
                }
            }
        }
        public String AACashFlowDetailTypeCombo
        {
            get { return _aACashFlowDetailTypeCombo; }
            set
            {
                if (value != this._aACashFlowDetailTypeCombo)
                {
                    _aACashFlowDetailTypeCombo = value;
                    NotifyChanged("AACashFlowDetailTypeCombo");
                }
            }
        }
        public double AmtTot
        {
            get { return _amtTot; }
            set
            {
                if (value != this._amtTot)
                {
                    _amtTot = value;
                    NotifyChanged("AmtTot");
                }
            }
        }
        public DateTime FromDate
        {
            get { return _fromDate; }
            set
            {
                if (value != this._fromDate)
                {
                    _fromDate = value;
                    NotifyChanged("FromDate");
                }
            }
        }
        public DateTime ToDate
        {
            get { return _toDate; }
            set
            {
                if (value != this._toDate)
                {
                    _toDate = value;
                    NotifyChanged("ToDate");
                }
            }
        }
        #endregion
    }
    #endregion
}