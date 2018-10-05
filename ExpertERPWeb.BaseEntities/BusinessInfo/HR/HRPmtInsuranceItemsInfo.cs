using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region HRPmtInsuranceItems
    //-----------------------------------------------------------
    //Generated By: GMC Studio
    //Class:HRPmtInsuranceItemsInfo
    //Created Date:25 Tháng Mười Một 2013
    //-----------------------------------------------------------

    public class HRPmtInsuranceItemsInfo : BusinessObject
    {
        public HRPmtInsuranceItemsInfo()
        {
        }
        #region Variables
        protected int _hRPmtInsuranceItemID;
        protected String _hRPmtInsuranceItemNo = String.Empty;
        protected int _fK_HRPmtInsuranceID;
        protected int _fK_HREmployeeID;
        protected int _fK_HREmployeeInsuranceID;
        protected int _fK_HRInsuranceID;
        protected double _hRPmtInsuranceItemBHXHAmt;
        protected double _hRPmtInsuranceItemBHYTAmt;
        protected double _hRPmtInsuranceItemBHTNAmt;
        protected double _hRPmtInsuranceItemBHAmtTot;
        protected int _fK_HRSectionID;
        protected int _fK_HRDepartmentID;
        protected double _hREmployeeContractSalaryAmount;
        protected Nullable<DateTime> _hREmployeeInsuranceDateFrom;
        protected double _hRPmtInsuranceItemComBHXHAmt;
        protected double _hRPmtInsuranceItemComBHYTAmt;
        protected double _hRPmtInsuranceItemComBHTNAmt;
        #endregion

        #region Public properties
        public int HRPmtInsuranceItemID
        {
            get { return _hRPmtInsuranceItemID; }
            set
            {
                if (value != this._hRPmtInsuranceItemID)
                {
                    _hRPmtInsuranceItemID = value;
                    NotifyChanged("HRPmtInsuranceItemID");
                }
            }
        }
        public String HRPmtInsuranceItemNo
        {
            get { return _hRPmtInsuranceItemNo; }
            set
            {
                if (value != this._hRPmtInsuranceItemNo)
                {
                    _hRPmtInsuranceItemNo = value;
                    NotifyChanged("HRPmtInsuranceItemNo");
                }
            }
        }
        public int FK_HRPmtInsuranceID
        {
            get { return _fK_HRPmtInsuranceID; }
            set
            {
                if (value != this._fK_HRPmtInsuranceID)
                {
                    _fK_HRPmtInsuranceID = value;
                    NotifyChanged("FK_HRPmtInsuranceID");
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
        public int FK_HREmployeeInsuranceID
        {
            get { return _fK_HREmployeeInsuranceID; }
            set
            {
                if (value != this._fK_HREmployeeInsuranceID)
                {
                    _fK_HREmployeeInsuranceID = value;
                    NotifyChanged("FK_HREmployeeInsuranceID");
                }
            }
        }
        public int FK_HRInsuranceID
        {
            get { return _fK_HRInsuranceID; }
            set
            {
                if (value != this._fK_HRInsuranceID)
                {
                    _fK_HRInsuranceID = value;
                    NotifyChanged("FK_HRInsuranceID");
                }
            }
        }
        public double HRPmtInsuranceItemBHXHAmt
        {
            get { return _hRPmtInsuranceItemBHXHAmt; }
            set
            {
                if (value != this._hRPmtInsuranceItemBHXHAmt)
                {
                    _hRPmtInsuranceItemBHXHAmt = value;
                    NotifyChanged("HRPmtInsuranceItemBHXHAmt");
                }
            }
        }
        public double HRPmtInsuranceItemBHYTAmt
        {
            get { return _hRPmtInsuranceItemBHYTAmt; }
            set
            {
                if (value != this._hRPmtInsuranceItemBHYTAmt)
                {
                    _hRPmtInsuranceItemBHYTAmt = value;
                    NotifyChanged("HRPmtInsuranceItemBHYTAmt");
                }
            }
        }
        public double HRPmtInsuranceItemBHTNAmt
        {
            get { return _hRPmtInsuranceItemBHTNAmt; }
            set
            {
                if (value != this._hRPmtInsuranceItemBHTNAmt)
                {
                    _hRPmtInsuranceItemBHTNAmt = value;
                    NotifyChanged("HRPmtInsuranceItemBHTNAmt");
                }
            }
        }
        public double HRPmtInsuranceItemBHAmtTot
        {
            get { return _hRPmtInsuranceItemBHAmtTot; }
            set
            {
                if (value != this._hRPmtInsuranceItemBHAmtTot)
                {
                    _hRPmtInsuranceItemBHAmtTot = value;
                    NotifyChanged("HRPmtInsuranceItemBHAmtTot");
                }
            }
        }
        public int FK_HRSectionID
        {
            get { return _fK_HRSectionID; }
            set
            {
                if (value != this._fK_HRSectionID)
                {
                    _fK_HRSectionID = value;
                    NotifyChanged("FK_HRSectionID");
                }
            }
        }
        public int FK_HRDepartmentID
        {
            get { return _fK_HRDepartmentID; }
            set
            {
                if (value != this._fK_HRDepartmentID)
                {
                    _fK_HRDepartmentID = value;
                    NotifyChanged("FK_HRDepartmentID");
                }
            }
        }
        public double HREmployeeContractSalaryAmount
        {
            get { return _hREmployeeContractSalaryAmount; }
            set
            {
                if (value != this._hREmployeeContractSalaryAmount)
                {
                    _hREmployeeContractSalaryAmount = value;
                    NotifyChanged("HREmployeeContractSalaryAmount");
                }
            }
        }
        public Nullable<DateTime> HREmployeeInsuranceDateFrom
        {
            get { return _hREmployeeInsuranceDateFrom; }
            set
            {
                if (value != this._hREmployeeInsuranceDateFrom)
                {
                    _hREmployeeInsuranceDateFrom = value;
                    NotifyChanged("HREmployeeInsuranceDateFrom");
                }
            }
        }
        public double HRPmtInsuranceItemComBHXHAmt
        {
            get { return _hRPmtInsuranceItemComBHXHAmt; }
            set
            {
                if (value != this._hRPmtInsuranceItemComBHXHAmt)
                {
                    _hRPmtInsuranceItemComBHXHAmt = value;
                    NotifyChanged("HRPmtInsuranceItemComBHXHAmt");
                }
            }
        }
        public double HRPmtInsuranceItemComBHYTAmt
        {
            get { return _hRPmtInsuranceItemComBHYTAmt; }
            set
            {
                if (value != this._hRPmtInsuranceItemComBHYTAmt)
                {
                    _hRPmtInsuranceItemComBHYTAmt = value;
                    NotifyChanged("HRPmtInsuranceItemComBHYTAmt");
                }
            }
        }
        public double HRPmtInsuranceItemComBHTNAmt
        {
            get { return _hRPmtInsuranceItemComBHTNAmt; }
            set
            {
                if (value != this._hRPmtInsuranceItemComBHTNAmt)
                {
                    _hRPmtInsuranceItemComBHTNAmt = value;
                    NotifyChanged("HRPmtInsuranceItemComBHTNAmt");
                }
            }
        }
        #endregion
    }
    #endregion
}