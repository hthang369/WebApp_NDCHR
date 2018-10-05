using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ViewRelatedTransHistorys
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ViewRelatedTransHistorysInfo
	//Created Date:27 Tháng Mười Một 2013
	//-----------------------------------------------------------
	
	public class ViewRelatedTransHistorysInfo:BusinessObject
	{
		public ViewRelatedTransHistorysInfo()
		{
		}
		#region Variables
		protected int _viewRelatedTransHistoryID;
		protected int _viewRelatedTransHistoryLevel;
		protected int _fK_GERelatedTranID;
		protected int _fK_GERelatedTranParentID;
		protected int _gERelatedTranDocID;
		protected String _gERelatedTranDocTableName=String.Empty;
		protected String _gERelatedTranDocModuleName=String.Empty;
		protected String _viewRelatedTransHistoryDocNo=String.Empty;
		protected Nullable<DateTime> _viewRelatedTransHistoryDocDate;
		protected String _viewRelatedTransHistoryModuleDesc=String.Empty;
		protected String _viewRelatedTransHistoryByUser=String.Empty;
		#endregion

		#region Public properties
		public int ViewRelatedTransHistoryID
		{
			get{return _viewRelatedTransHistoryID;}
			set
			{
				if (value != this._viewRelatedTransHistoryID)
				{
				_viewRelatedTransHistoryID=value;
				NotifyChanged("ViewRelatedTransHistoryID");
				}
			}
		}
		public int ViewRelatedTransHistoryLevel
		{
			get{return _viewRelatedTransHistoryLevel;}
			set
			{
				if (value != this._viewRelatedTransHistoryLevel)
				{
				_viewRelatedTransHistoryLevel=value;
				NotifyChanged("ViewRelatedTransHistoryLevel");
				}
			}
		}
		public int FK_GERelatedTranID
		{
			get{return _fK_GERelatedTranID;}
			set
			{
				if (value != this._fK_GERelatedTranID)
				{
				_fK_GERelatedTranID=value;
				NotifyChanged("FK_GERelatedTranID");
				}
			}
		}
		public int FK_GERelatedTranParentID
		{
			get{return _fK_GERelatedTranParentID;}
			set
			{
				if (value != this._fK_GERelatedTranParentID)
				{
				_fK_GERelatedTranParentID=value;
				NotifyChanged("FK_GERelatedTranParentID");
				}
			}
		}
		public int GERelatedTranDocID
		{
			get{return _gERelatedTranDocID;}
			set
			{
				if (value != this._gERelatedTranDocID)
				{
				_gERelatedTranDocID=value;
				NotifyChanged("GERelatedTranDocID");
				}
			}
		}
		public String GERelatedTranDocTableName
		{
			get{return _gERelatedTranDocTableName;}
			set
			{
				if (value != this._gERelatedTranDocTableName)
				{
				_gERelatedTranDocTableName=value;
				NotifyChanged("GERelatedTranDocTableName");
				}
			}
		}
		public String GERelatedTranDocModuleName
		{
			get{return _gERelatedTranDocModuleName;}
			set
			{
				if (value != this._gERelatedTranDocModuleName)
				{
				_gERelatedTranDocModuleName=value;
				NotifyChanged("GERelatedTranDocModuleName");
				}
			}
		}
		public String ViewRelatedTransHistoryDocNo
		{
			get{return _viewRelatedTransHistoryDocNo;}
			set
			{
				if (value != this._viewRelatedTransHistoryDocNo)
				{
				_viewRelatedTransHistoryDocNo=value;
				NotifyChanged("ViewRelatedTransHistoryDocNo");
				}
			}
		}
		public Nullable<DateTime> ViewRelatedTransHistoryDocDate
		{
			get{return _viewRelatedTransHistoryDocDate;}
			set
			{
				if (value != this._viewRelatedTransHistoryDocDate)
				{
				_viewRelatedTransHistoryDocDate=value;
				NotifyChanged("ViewRelatedTransHistoryDocDate");
				}
			}
		}
		public String ViewRelatedTransHistoryModuleDesc
		{
			get{return _viewRelatedTransHistoryModuleDesc;}
			set
			{
				if (value != this._viewRelatedTransHistoryModuleDesc)
				{
				_viewRelatedTransHistoryModuleDesc=value;
				NotifyChanged("ViewRelatedTransHistoryModuleDesc");
				}
			}
		}
		public String ViewRelatedTransHistoryByUser
		{
			get{return _viewRelatedTransHistoryByUser;}
			set
			{
				if (value != this._viewRelatedTransHistoryByUser)
				{
				_viewRelatedTransHistoryByUser=value;
				NotifyChanged("ViewRelatedTransHistoryByUser");
				}
			}
		}
		#endregion
	}
	#endregion
}