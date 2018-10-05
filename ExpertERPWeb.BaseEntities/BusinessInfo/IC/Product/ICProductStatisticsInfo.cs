using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;

namespace ExpertERP.BusinessEntities
{
    public class ICProductStatisticsInfo
    {
        protected int _iCProductID;
        protected String _iCProductNo = String.Empty;
        protected String _iCProductDesc = String.Empty;
        protected String _iCProductName = String.Empty;
        protected double _total;
        protected double _percent;

        public double ICProductRevenusPercent
        {
            get { return _percent; }
            set { _percent = value; }
        }

        public double ICProductRevenus
        {
            get { return _total; }
            set { _total = value; }
        }

        public int ICProductID
        {
            get { return _iCProductID; }
            set { _iCProductID = value; }
        }

        public String ICProductNo
        {
            get { return _iCProductNo; }
            set { _iCProductNo = value; }
        }

        public String ICProductName
        {
            get { return _iCProductName; }
            set { _iCProductName = value; }
        }

        public String ICProductDesc
        {
            get { return _iCProductDesc; }
            set { _iCProductDesc = value; }
        }
    }
}
