
using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region HRInterviewResults
    //-----------------------------------------------------------
    //Generated By: SQLDBTools - LINHCLH (v2.1.89)
    //Class: HRInterviewResultsInfo
    //Created Date: Friday, 14 Jul 2017
    //-----------------------------------------------------------

    public class HRInterviewResultsInfo : BusinessObject
    {
        public HRInterviewResultsInfo()
        {
        }
        #region Variables
		protected int _hRInterviewResultID;
		protected int _fK_HRCandidateID;
		protected String _hRInterviewResultLevelCombo = String.Empty;
		protected String _hRInterviewResultRankCombo = String.Empty;
		protected String _hRInterviewResultDesc = String.Empty;
		
        #endregion

        #region Public properties
		public int HRInterviewResultID
		{
			get { return _hRInterviewResultID; }
			set
			{
				if (value != this._hRInterviewResultID)
				{
					_hRInterviewResultID = value;
					NotifyChanged("HRInterviewResultID");
				}
			}
		}
		public int FK_HRCandidateID
		{
			get { return _fK_HRCandidateID; }
			set
			{
				if (value != this._fK_HRCandidateID)
				{
					_fK_HRCandidateID = value;
					NotifyChanged("FK_HRCandidateID");
				}
			}
		}
		public String HRInterviewResultLevelCombo
		{
			get { return _hRInterviewResultLevelCombo; }
			set
			{
				if (value != this._hRInterviewResultLevelCombo)
				{
					_hRInterviewResultLevelCombo = value;
					NotifyChanged("HRInterviewResultLevelCombo");
				}
			}
		}
		public String HRInterviewResultRankCombo
		{
			get { return _hRInterviewResultRankCombo; }
			set
			{
				if (value != this._hRInterviewResultRankCombo)
				{
					_hRInterviewResultRankCombo = value;
					NotifyChanged("HRInterviewResultRankCombo");
				}
			}
		}
		public String HRInterviewResultDesc
		{
			get { return _hRInterviewResultDesc; }
			set
			{
				if (value != this._hRInterviewResultDesc)
				{
					_hRInterviewResultDesc = value;
					NotifyChanged("HRInterviewResultDesc");
				}
			}
		}
		
        #endregion
    }
    #endregion
}