
using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region GEPolicyDefineMthMapCols
    //-----------------------------------------------------------
    //Generated By: SQLDBTools - LINHCLH (v2.1.88)
    //Class: GEPolicyDefineMthMapColsInfo
    //Created Date: Wednesday, 05 Apr 2017
    //-----------------------------------------------------------

    public class GEPolicyDefineMthMapColsInfo : BusinessObject
    {
        public GEPolicyDefineMthMapColsInfo()
        {
        }
        #region Variables
		protected int _gEPolicyDefineMthMapColID;
		protected String _gEPolicyDefineMthMapColTableName = String.Empty;
		protected String _gEPolicyDefineMthMapColParameter = String.Empty;
		protected String _gEPolicyDefineMthMapColCaption = String.Empty;
		protected String _gEPolicyDefineMthMapColType = String.Empty;
		protected String _gEPolicyDefineMthMapColDesc = String.Empty;
		
        #endregion

        #region Public properties
		public int GEPolicyDefineMthMapColID
		{
			get { return _gEPolicyDefineMthMapColID; }
			set
			{
				if (value != this._gEPolicyDefineMthMapColID)
				{
					_gEPolicyDefineMthMapColID = value;
					NotifyChanged("GEPolicyDefineMthMapColID");
				}
			}
		}
		public String GEPolicyDefineMthMapColTableName
		{
			get { return _gEPolicyDefineMthMapColTableName; }
			set
			{
				if (value != this._gEPolicyDefineMthMapColTableName)
				{
					_gEPolicyDefineMthMapColTableName = value;
					NotifyChanged("GEPolicyDefineMthMapColTableName");
				}
			}
		}
		public String GEPolicyDefineMthMapColParameter
		{
			get { return _gEPolicyDefineMthMapColParameter; }
			set
			{
				if (value != this._gEPolicyDefineMthMapColParameter)
				{
					_gEPolicyDefineMthMapColParameter = value;
					NotifyChanged("GEPolicyDefineMthMapColParameter");
				}
			}
		}
		public String GEPolicyDefineMthMapColCaption
		{
			get { return _gEPolicyDefineMthMapColCaption; }
			set
			{
				if (value != this._gEPolicyDefineMthMapColCaption)
				{
					_gEPolicyDefineMthMapColCaption = value;
					NotifyChanged("GEPolicyDefineMthMapColCaption");
				}
			}
		}
		public String GEPolicyDefineMthMapColType
		{
			get { return _gEPolicyDefineMthMapColType; }
			set
			{
				if (value != this._gEPolicyDefineMthMapColType)
				{
					_gEPolicyDefineMthMapColType = value;
					NotifyChanged("GEPolicyDefineMthMapColType");
				}
			}
		}
		public String GEPolicyDefineMthMapColDesc
		{
			get { return _gEPolicyDefineMthMapColDesc; }
			set
			{
				if (value != this._gEPolicyDefineMthMapColDesc)
				{
					_gEPolicyDefineMthMapColDesc = value;
					NotifyChanged("GEPolicyDefineMthMapColDesc");
				}
			}
		}
		
        #endregion
    }
    #endregion
}