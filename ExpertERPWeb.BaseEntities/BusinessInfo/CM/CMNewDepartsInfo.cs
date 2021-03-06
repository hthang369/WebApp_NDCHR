using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region CMNewDeparts
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:CMNewDepartsInfo
	//Created Date:Thursday, April 09, 2009
	//-----------------------------------------------------------
	
	public class CMNewDepartsInfo:BusinessObject
	{
		public CMNewDepartsInfo()
		{
		}
		#region Variables
		protected int _cMNewDepartID;
		protected String _aAStatus=DefaultAAStatus;
		protected String _cMNewDepartNo=String.Empty;
		protected String _cMNewDepartName=String.Empty;
		protected int _fK_HRDepartmentID;
		protected int _fK_CMNewID;
		protected String _cMNewDepartDesc=String.Empty;
		protected String _aACreatedUser=String.Empty;
		protected String _aAUpdatedUser=String.Empty;
		protected DateTime _aACreatedDate=DateTime.MaxValue;
		protected DateTime _aAUpdatedDate=DateTime.MaxValue;
		#endregion

		#region Public properties
		public int CMNewDepartID
		{
			get{return _cMNewDepartID;}
			set
			{
				if (value != this._cMNewDepartID)
				{
				_cMNewDepartID=value;
				NotifyChanged("CMNewDepartID");
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
		public String CMNewDepartNo
		{
			get{return _cMNewDepartNo;}
			set
			{
				if (value != this._cMNewDepartNo)
				{
				_cMNewDepartNo=value;
				NotifyChanged("CMNewDepartNo");
				}
			}
		}
		public String CMNewDepartName
		{
			get{return _cMNewDepartName;}
			set
			{
				if (value != this._cMNewDepartName)
				{
				_cMNewDepartName=value;
				NotifyChanged("CMNewDepartName");
				}
			}
		}
		public int FK_HRDepartmentID
		{
			get{return _fK_HRDepartmentID;}
			set
			{
				if (value != this._fK_HRDepartmentID)
				{
				_fK_HRDepartmentID=value;
				NotifyChanged("FK_HRDepartmentID");
				}
			}
		}
		public int FK_CMNewID
		{
			get{return _fK_CMNewID;}
			set
			{
				if (value != this._fK_CMNewID)
				{
				_fK_CMNewID=value;
				NotifyChanged("FK_CMNewID");
				}
			}
		}
		public String CMNewDepartDesc
		{
			get{return _cMNewDepartDesc;}
			set
			{
				if (value != this._cMNewDepartDesc)
				{
				_cMNewDepartDesc=value;
				NotifyChanged("CMNewDepartDesc");
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
		public DateTime AACreatedDate
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
		public DateTime AAUpdatedDate
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
		#endregion
	}
	#endregion
}