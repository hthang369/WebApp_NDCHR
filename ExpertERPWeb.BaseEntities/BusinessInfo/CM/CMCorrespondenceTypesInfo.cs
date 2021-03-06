using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region CMCorrespondenceTypes
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:CMCorrespondenceTypesInfo
	//Created Date:Tuesday, June 09, 2009
	//-----------------------------------------------------------
	
	public class CMCorrespondenceTypesInfo:BusinessObject
	{
		public CMCorrespondenceTypesInfo()
		{
		}
		#region Variables
		protected int _cMCorrespondenceTypeID;
		protected String _aAStatus=DefaultAAStatus;
		protected String _aACreatedUser=String.Empty;
		protected String _aAUpdatedUser=String.Empty;
		protected DateTime _aACreatedDate=DateTime.MaxValue;
		protected DateTime _aAUpdatedDate=DateTime.MaxValue;
		protected String _cMCorrespondenceTypeNo=String.Empty;
		protected String _cMCorrespondenceTypeName=String.Empty;
		protected String _cMCorrespondenceTypeDesc=String.Empty;
		#endregion

		#region Public properties
		public int CMCorrespondenceTypeID
		{
			get{return _cMCorrespondenceTypeID;}
			set
			{
				if (value != this._cMCorrespondenceTypeID)
				{
				_cMCorrespondenceTypeID=value;
				NotifyChanged("CMCorrespondenceTypeID");
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
		public String CMCorrespondenceTypeNo
		{
			get{return _cMCorrespondenceTypeNo;}
			set
			{
				if (value != this._cMCorrespondenceTypeNo)
				{
				_cMCorrespondenceTypeNo=value;
				NotifyChanged("CMCorrespondenceTypeNo");
				}
			}
		}
		public String CMCorrespondenceTypeName
		{
			get{return _cMCorrespondenceTypeName;}
			set
			{
				if (value != this._cMCorrespondenceTypeName)
				{
				_cMCorrespondenceTypeName=value;
				NotifyChanged("CMCorrespondenceTypeName");
				}
			}
		}
		public String CMCorrespondenceTypeDesc
		{
			get{return _cMCorrespondenceTypeDesc;}
			set
			{
				if (value != this._cMCorrespondenceTypeDesc)
				{
				_cMCorrespondenceTypeDesc=value;
				NotifyChanged("CMCorrespondenceTypeDesc");
				}
			}
		}
		#endregion
	}
	#endregion
}