
using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region ICTransferQCs
    //-----------------------------------------------------------
    //Generated By: SQLDBTools - LINHCLH (v2.1.63)
    //Class: ICTransferQCsInfo
    //Created Date: Monday, 08 Aug 2016
    //-----------------------------------------------------------

    public class ICTransferQCsInfo : BusinessObject
    {
        public ICTransferQCsInfo()
        {
        }
        #region Variables
		protected int _iCTransferQCID;
		protected String _aAStatus = DefaultAAStatus;
		protected int _fK_ICQCID;
		protected int _fK_ICTransferID;
		
        #endregion

        #region Public properties
		public int ICTransferQCID
		{
			get { return _iCTransferQCID; }
			set
			{
				if (value != this._iCTransferQCID)
				{
					_iCTransferQCID = value;
					NotifyChanged("ICTransferQCID");
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
		public int FK_ICQCID
		{
			get { return _fK_ICQCID; }
			set
			{
				if (value != this._fK_ICQCID)
				{
					_fK_ICQCID = value;
					NotifyChanged("FK_ICQCID");
				}
			}
		}
		public int FK_ICTransferID
		{
			get { return _fK_ICTransferID; }
			set
			{
				if (value != this._fK_ICTransferID)
				{
					_fK_ICTransferID = value;
					NotifyChanged("FK_ICTransferID");
				}
			}
		}
		
        #endregion
    }
    #endregion
}