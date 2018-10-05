using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region APSupplierDimentions
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:APSupplierDimentionsInfo
	//Created Date:07 Tháng Giêng 2013
	//-----------------------------------------------------------
	
	public class APSupplierDimentionsInfo:BusinessObject
	{
		public APSupplierDimentionsInfo()
		{
		}
		#region Variables
		protected int _aPSupplierDimentionID;
		protected String _aAStatus=DefaultAAStatus;
		protected String _aPSupplierDimentionNo=String.Empty;
		protected String _aPSupplierDimentionName=String.Empty;
		protected String _aPSupplierDimentionDesc=String.Empty;
		protected String _aDDimentionTypeCombo=String.Empty;
		protected String _aPSupplierDimentionCode=String.Empty;
		protected String _aPSupplierDimentionTypeCombo=String.Empty;
		#endregion

		#region Public properties
		public int APSupplierDimentionID
		{
			get{return _aPSupplierDimentionID;}
			set
			{
				if (value != this._aPSupplierDimentionID)
				{
				_aPSupplierDimentionID=value;
				NotifyChanged("APSupplierDimentionID");
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
		public String APSupplierDimentionNo
		{
			get{return _aPSupplierDimentionNo;}
			set
			{
				if (value != this._aPSupplierDimentionNo)
				{
				_aPSupplierDimentionNo=value;
				NotifyChanged("APSupplierDimentionNo");
				}
			}
		}
		public String APSupplierDimentionName
		{
			get{return _aPSupplierDimentionName;}
			set
			{
				if (value != this._aPSupplierDimentionName)
				{
				_aPSupplierDimentionName=value;
				NotifyChanged("APSupplierDimentionName");
				}
			}
		}
		public String APSupplierDimentionDesc
		{
			get{return _aPSupplierDimentionDesc;}
			set
			{
				if (value != this._aPSupplierDimentionDesc)
				{
				_aPSupplierDimentionDesc=value;
				NotifyChanged("APSupplierDimentionDesc");
				}
			}
		}
		public String ADDimentionTypeCombo
		{
			get{return _aDDimentionTypeCombo;}
			set
			{
				if (value != this._aDDimentionTypeCombo)
				{
				_aDDimentionTypeCombo=value;
				NotifyChanged("ADDimentionTypeCombo");
				}
			}
		}
		public String APSupplierDimentionCode
		{
			get{return _aPSupplierDimentionCode;}
			set
			{
				if (value != this._aPSupplierDimentionCode)
				{
				_aPSupplierDimentionCode=value;
				NotifyChanged("APSupplierDimentionCode");
				}
			}
		}
		public String APSupplierDimentionTypeCombo
		{
			get{return _aPSupplierDimentionTypeCombo;}
			set
			{
				if (value != this._aPSupplierDimentionTypeCombo)
				{
				_aPSupplierDimentionTypeCombo=value;
				NotifyChanged("APSupplierDimentionTypeCombo");
				}
			}
		}
		#endregion
	}
	#endregion
}