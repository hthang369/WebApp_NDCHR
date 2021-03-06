using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region GLAdjCostDistPrepaidItems
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:GLAdjCostDistPrepaidItemsInfo
	//Created Date:11 July 2015
	//-----------------------------------------------------------
	
	public class GLAdjCostDistPrepaidItemsInfo:BusinessObject
	{
		public GLAdjCostDistPrepaidItemsInfo()
		{
		}
		#region Variables
		protected int _gLAdjCostDistPrepaidItemID;
		protected Nullable<DateTime> _aACreatedDate;
		protected String _aACreatedUser=String.Empty;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _aAUpdatedUser=String.Empty;
		protected String _aAStatus=DefaultAAStatus;
		protected bool _aASelected=true;
		protected int _fK_GLAdjCostDistPrepaidID;
		protected int _fK_GLCostAllocateID;
		protected int _fK_GLCostDistOldID;
		protected int _fK_GLCostDistNewID;
		protected String _gLAdjCostDistPrepaidItemDesc=String.Empty;
		#endregion

		#region Public properties
		public int GLAdjCostDistPrepaidItemID
		{
			get{return _gLAdjCostDistPrepaidItemID;}
			set
			{
				if (value != this._gLAdjCostDistPrepaidItemID)
				{
				_gLAdjCostDistPrepaidItemID=value;
				NotifyChanged("GLAdjCostDistPrepaidItemID");
				}
			}
		}
		public Nullable<DateTime> AACreatedDate
		{
			get{return _aACreatedDate;}
			set
			{
				if (value != this._aACreatedDate)
				{
				_aACreatedDate=value;
				NotifyChanged("AACreatedDate");
				}
			}
		}
		public String AACreatedUser
		{
			get{return _aACreatedUser;}
			set
			{
				if (value != this._aACreatedUser)
				{
				_aACreatedUser=value;
				NotifyChanged("AACreatedUser");
				}
			}
		}
		public Nullable<DateTime> AAUpdatedDate
		{
			get{return _aAUpdatedDate;}
			set
			{
				if (value != this._aAUpdatedDate)
				{
				_aAUpdatedDate=value;
				NotifyChanged("AAUpdatedDate");
				}
			}
		}
		public String AAUpdatedUser
		{
			get{return _aAUpdatedUser;}
			set
			{
				if (value != this._aAUpdatedUser)
				{
				_aAUpdatedUser=value;
				NotifyChanged("AAUpdatedUser");
				}
			}
		}
		public String AAStatus
		{
			get{return _aAStatus;}
			set
			{
				if (value != this._aAStatus)
				{
				_aAStatus=value;
				NotifyChanged("AAStatus");
				}
			}
		}
		public bool AASelected
		{
			get{return _aASelected;}
			set
			{
				if (value != this._aASelected)
				{
				_aASelected=value;
				NotifyChanged("AASelected");
				}
			}
		}
		public int FK_GLAdjCostDistPrepaidID
		{
			get{return _fK_GLAdjCostDistPrepaidID;}
			set
			{
				if (value != this._fK_GLAdjCostDistPrepaidID)
				{
				_fK_GLAdjCostDistPrepaidID=value;
				NotifyChanged("FK_GLAdjCostDistPrepaidID");
				}
			}
		}
		public int FK_GLCostAllocateID
		{
			get{return _fK_GLCostAllocateID;}
			set
			{
				if (value != this._fK_GLCostAllocateID)
				{
				_fK_GLCostAllocateID=value;
				NotifyChanged("FK_GLCostAllocateID");
				}
			}
		}
		public int FK_GLCostDistOldID
		{
			get{return _fK_GLCostDistOldID;}
			set
			{
				if (value != this._fK_GLCostDistOldID)
				{
				_fK_GLCostDistOldID=value;
				NotifyChanged("FK_GLCostDistOldID");
				}
			}
		}
		public int FK_GLCostDistNewID
		{
			get{return _fK_GLCostDistNewID;}
			set
			{
				if (value != this._fK_GLCostDistNewID)
				{
				_fK_GLCostDistNewID=value;
				NotifyChanged("FK_GLCostDistNewID");
				}
			}
		}
		public String GLAdjCostDistPrepaidItemDesc
		{
			get{return _gLAdjCostDistPrepaidItemDesc;}
			set
			{
				if (value != this._gLAdjCostDistPrepaidItemDesc)
				{
				_gLAdjCostDistPrepaidItemDesc=value;
				NotifyChanged("GLAdjCostDistPrepaidItemDesc");
				}
			}
		}
		#endregion
	}
	#endregion
}