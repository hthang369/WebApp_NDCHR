using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region ViewDocuments
    //-----------------------------------------------------------
    //Generated By: SQLDBTools.NET ? H??? £i?? (v2.0.60)
    //Class: ViewDocumentsInfo
    //Created Date: Wednesday, 13 Dec 2017
    //-----------------------------------------------------------

    public class ViewDocumentsInfo : BusinessObject
    {
        public ViewDocumentsInfo()
        {
        }
        #region Variables
		protected int _viewDocumentMainObjectID;
		protected String _viewDocumentNo = String.Empty;
		protected String _viewDocumentClientPath = String.Empty;
		protected int _viewDocumentID;
		protected String _viewDocumentDesc = String.Empty;
		protected String _viewDocumentTableName = String.Empty;
		protected Nullable<DateTime> _viewDocumentDate;
		protected bool _aASelected = true;
		protected String _viewDocumentCreateUser = String.Empty;
		protected String _viewDocumentUpdateUser = String.Empty;
		protected Nullable<DateTime> _viewDocumentCreateDate;
		protected Nullable<DateTime> _viewDocumentUpdateDate;
		protected String _viewDocumentType = String.Empty;
		protected String _viewDocumentName = String.Empty;
		protected String _viewDocumentStatusCombo = DefaultStatus;
		protected String _viewDocumentTypeDocCombo = String.Empty;
		protected String _viewSalStructObjectValueDisplay = String.Empty;
		protected String _viewSalStructObjectValueMember = String.Empty;
		protected int _viewSalStructObjectValueNumber;
		
        #endregion

        #region Public properties
		public int ViewDocumentMainObjectID
		{
			get { return _viewDocumentMainObjectID; }
			set
			{
				if (value != this._viewDocumentMainObjectID)
				{
					_viewDocumentMainObjectID = value;
					NotifyChanged("ViewDocumentMainObjectID");
				}
			}
		}
		public String ViewDocumentNo
		{
			get { return _viewDocumentNo; }
			set
			{
				if (value != this._viewDocumentNo)
				{
					_viewDocumentNo = value;
					NotifyChanged("ViewDocumentNo");
				}
			}
		}
		public String ViewDocumentClientPath
		{
			get { return _viewDocumentClientPath; }
			set
			{
				if (value != this._viewDocumentClientPath)
				{
					_viewDocumentClientPath = value;
					NotifyChanged("ViewDocumentClientPath");
				}
			}
		}
		public int ViewDocumentID
		{
			get { return _viewDocumentID; }
			set
			{
				if (value != this._viewDocumentID)
				{
					_viewDocumentID = value;
					NotifyChanged("ViewDocumentID");
				}
			}
		}
		public String ViewDocumentDesc
		{
			get { return _viewDocumentDesc; }
			set
			{
				if (value != this._viewDocumentDesc)
				{
					_viewDocumentDesc = value;
					NotifyChanged("ViewDocumentDesc");
				}
			}
		}
		public String ViewDocumentTableName
		{
			get { return _viewDocumentTableName; }
			set
			{
				if (value != this._viewDocumentTableName)
				{
					_viewDocumentTableName = value;
					NotifyChanged("ViewDocumentTableName");
				}
			}
		}
		public Nullable<DateTime> ViewDocumentDate
		{
			get { return _viewDocumentDate; }
			set
			{
				if (value != this._viewDocumentDate)
				{
					_viewDocumentDate = value;
					NotifyChanged("ViewDocumentDate");
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
		public String ViewDocumentCreateUser
		{
			get { return _viewDocumentCreateUser; }
			set
			{
				if (value != this._viewDocumentCreateUser)
				{
					_viewDocumentCreateUser = value;
					NotifyChanged("ViewDocumentCreateUser");
				}
			}
		}
		public String ViewDocumentUpdateUser
		{
			get { return _viewDocumentUpdateUser; }
			set
			{
				if (value != this._viewDocumentUpdateUser)
				{
					_viewDocumentUpdateUser = value;
					NotifyChanged("ViewDocumentUpdateUser");
				}
			}
		}
		public Nullable<DateTime> ViewDocumentCreateDate
		{
			get { return _viewDocumentCreateDate; }
			set
			{
				if (value != this._viewDocumentCreateDate)
				{
					_viewDocumentCreateDate = value;
					NotifyChanged("ViewDocumentCreateDate");
				}
			}
		}
		public Nullable<DateTime> ViewDocumentUpdateDate
		{
			get { return _viewDocumentUpdateDate; }
			set
			{
				if (value != this._viewDocumentUpdateDate)
				{
					_viewDocumentUpdateDate = value;
					NotifyChanged("ViewDocumentUpdateDate");
				}
			}
		}
		public String ViewDocumentType
		{
			get { return _viewDocumentType; }
			set
			{
				if (value != this._viewDocumentType)
				{
					_viewDocumentType = value;
					NotifyChanged("ViewDocumentType");
				}
			}
		}
		public String ViewDocumentName
		{
			get { return _viewDocumentName; }
			set
			{
				if (value != this._viewDocumentName)
				{
					_viewDocumentName = value;
					NotifyChanged("ViewDocumentName");
				}
			}
		}
		public String ViewDocumentStatusCombo
		{
			get { return _viewDocumentStatusCombo; }
			set
			{
				if (value != this._viewDocumentStatusCombo)
				{
					_viewDocumentStatusCombo = value;
					NotifyChanged("ViewDocumentStatusCombo");
				}
			}
		}
		public String ViewDocumentTypeDocCombo
		{
			get { return _viewDocumentTypeDocCombo; }
			set
			{
				if (value != this._viewDocumentTypeDocCombo)
				{
					_viewDocumentTypeDocCombo = value;
					NotifyChanged("ViewDocumentTypeDocCombo");
				}
			}
		}
		public String ViewSalStructObjectValueDisplay
		{
			get { return _viewSalStructObjectValueDisplay; }
			set
			{
				if (value != this._viewSalStructObjectValueDisplay)
				{
					_viewSalStructObjectValueDisplay = value;
					NotifyChanged("ViewSalStructObjectValueDisplay");
				}
			}
		}
		public String ViewSalStructObjectValueMember
		{
			get { return _viewSalStructObjectValueMember; }
			set
			{
				if (value != this._viewSalStructObjectValueMember)
				{
					_viewSalStructObjectValueMember = value;
					NotifyChanged("ViewSalStructObjectValueMember");
				}
			}
		}
		public int ViewSalStructObjectValueNumber
		{
			get { return _viewSalStructObjectValueNumber; }
			set
			{
				if (value != this._viewSalStructObjectValueNumber)
				{
					_viewSalStructObjectValueNumber = value;
					NotifyChanged("ViewSalStructObjectValueNumber");
				}
			}
		}
		
        #endregion
    }
    #endregion
}