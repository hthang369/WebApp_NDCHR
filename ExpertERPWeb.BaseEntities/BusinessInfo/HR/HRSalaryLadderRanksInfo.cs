
using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region HRSalaryLadderRanks
    //-----------------------------------------------------------
    //Generated By: SQLDBTools - LINHCLH (v2.1.88)
    //Class: HRSalaryLadderRanksInfo
    //Created Date: Tuesday, 23 May 2017
    //-----------------------------------------------------------

    public class HRSalaryLadderRanksInfo : BusinessObject
    {
        public HRSalaryLadderRanksInfo()
        {
        }
        #region Variables
        protected int _hRSalaryLadderRankID;
        protected int _fK_HRSalaryLadderID;
        protected int _fK_HRSalaryRankID;
        protected double _hRSalaryLadderRankValue;
        protected String _hRSalaryLadderRankText = String.Empty;

        #endregion

        #region Public properties
        public int HRSalaryLadderRankID
        {
            get { return _hRSalaryLadderRankID; }
            set
            {
                if (value != this._hRSalaryLadderRankID)
                {
                    _hRSalaryLadderRankID = value;
                    NotifyChanged("HRSalaryLadderRankID");
                }
            }
        }
        public int FK_HRSalaryLadderID
        {
            get { return _fK_HRSalaryLadderID; }
            set
            {
                if (value != this._fK_HRSalaryLadderID)
                {
                    _fK_HRSalaryLadderID = value;
                    NotifyChanged("FK_HRSalaryLadderID");
                }
            }
        }
        public int FK_HRSalaryRankID
        {
            get { return _fK_HRSalaryRankID; }
            set
            {
                if (value != this._fK_HRSalaryRankID)
                {
                    _fK_HRSalaryRankID = value;
                    NotifyChanged("FK_HRSalaryRankID");
                }
            }
        }
        public double HRSalaryLadderRankValue
        {
            get { return _hRSalaryLadderRankValue; }
            set
            {
                if (value != this._hRSalaryLadderRankValue)
                {
                    _hRSalaryLadderRankValue = value;
                    NotifyChanged("HRSalaryLadderRankValue");
                }
            }
        }
        public String HRSalaryLadderRankText
        {
            get { return _hRSalaryLadderRankText; }
            set
            {
                if (value != this._hRSalaryLadderRankText)
                {
                    _hRSalaryLadderRankText = value;
                    NotifyChanged("HRSalaryLadderRankText");
                }
            }
        }

        #endregion
    }
    #endregion
}