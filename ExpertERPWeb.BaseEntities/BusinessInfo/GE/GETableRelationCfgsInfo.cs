using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region GETableRelationCfgs
    //-----------------------------------------------------------
    //Generated By: SQLDBTools.NET ♫ Hồռ؏ ₤ĩռᶋ (v2.0.68)
    //Class: GETableRelationCfgsInfo
    //Created Date: Saturday, 20 Jan 2018
    //-----------------------------------------------------------

    public class GETableRelationCfgsInfo : BusinessObject
    {
        public GETableRelationCfgsInfo()
        {
        }
        #region Variables
		protected int _gETableRelationCfgID;
		protected bool _aASelected = true;
		protected String _tableName = String.Empty;
		protected String _columnName = String.Empty;
		protected String _referenceTableName = String.Empty;
		protected String _referenceColumnName = String.Empty;
		protected String _moduleName = String.Empty;
		
        #endregion

        #region Public properties
		public int GETableRelationCfgID
		{
			get { return _gETableRelationCfgID; }
			set
			{
				if (value != this._gETableRelationCfgID)
				{
					_gETableRelationCfgID = value;
					NotifyChanged("GETableRelationCfgID");
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
		public String TableName
		{
			get { return _tableName; }
			set
			{
				if (value != this._tableName)
				{
					_tableName = value;
					NotifyChanged("TableName");
				}
			}
		}
		public String ColumnName
		{
			get { return _columnName; }
			set
			{
				if (value != this._columnName)
				{
					_columnName = value;
					NotifyChanged("ColumnName");
				}
			}
		}
		public String ReferenceTableName
		{
			get { return _referenceTableName; }
			set
			{
				if (value != this._referenceTableName)
				{
					_referenceTableName = value;
					NotifyChanged("ReferenceTableName");
				}
			}
		}
		public String ReferenceColumnName
		{
			get { return _referenceColumnName; }
			set
			{
				if (value != this._referenceColumnName)
				{
					_referenceColumnName = value;
					NotifyChanged("ReferenceColumnName");
				}
			}
		}
		public String ModuleName
		{
			get { return _moduleName; }
			set
			{
				if (value != this._moduleName)
				{
					_moduleName = value;
					NotifyChanged("ModuleName");
				}
			}
		}
		
        #endregion
    }
    #endregion
}