using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region GEInvTypes
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:GEInvTypesInfo
	//Created Date:Thursday, February 20, 2014
	//-----------------------------------------------------------
	
	public class GEInvTypesInfo:BusinessObject
	{
		public GEInvTypesInfo()
		{
		}
		#region Variables
		protected int _gEInvTypeID;
		protected String _aAStatus=DefaultAAStatus;
		protected String _gEInvTypeNo=String.Empty;
		protected String _gEInvTypeName=String.Empty;
		#endregion

		#region Public properties
		public int GEInvTypeID
		{
			get{return _gEInvTypeID;}
			set
			{
				if (value != this._gEInvTypeID)
				{
				_gEInvTypeID=value;
				NotifyChanged("GEInvTypeID");
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
		public String GEInvTypeNo
		{
			get{return _gEInvTypeNo;}
			set
			{
				if (value != this._gEInvTypeNo)
				{
				_gEInvTypeNo=value;
				NotifyChanged("GEInvTypeNo");
				}
			}
		}
		public String GEInvTypeName
		{
			get{return _gEInvTypeName;}
			set
			{
				if (value != this._gEInvTypeName)
				{
				_gEInvTypeName=value;
				NotifyChanged("GEInvTypeName");
				}
			}
		}
		#endregion
	}
	#endregion
}