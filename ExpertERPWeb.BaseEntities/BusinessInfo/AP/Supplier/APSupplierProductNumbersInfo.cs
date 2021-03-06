using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region APSupplierProductNumbers
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:APSupplierProductNumbersInfo
	//Created Date:Tuesday, October 6, 2015
	//-----------------------------------------------------------
	
	public class APSupplierProductNumbersInfo:BusinessObject
	{
		public APSupplierProductNumbersInfo()
		{
		}
		#region Variables
		protected int _aPSupplierProductNumberID;
		protected String _aAStatus=DefaultAAStatus;
		protected int _fK_APSupplierID;
		protected int _fK_ICProductID;
		protected String _aPSupplierProductNumber=String.Empty;
		protected String _aPSupplierProductNumberDesc=String.Empty;
		protected String _aPSupplierProductName=String.Empty;
		#endregion

		#region Public properties
		public int APSupplierProductNumberID
		{
			get{return _aPSupplierProductNumberID;}
			set
			{
				if (value != this._aPSupplierProductNumberID)
				{
				_aPSupplierProductNumberID=value;
				NotifyChanged("APSupplierProductNumberID");
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
		public int FK_APSupplierID
		{
			get{return _fK_APSupplierID;}
			set
			{
				if (value != this._fK_APSupplierID)
				{
				_fK_APSupplierID=value;
				NotifyChanged("FK_APSupplierID");
				}
			}
		}
		public int FK_ICProductID
		{
			get{return _fK_ICProductID;}
			set
			{
				if (value != this._fK_ICProductID)
				{
				_fK_ICProductID=value;
				NotifyChanged("FK_ICProductID");
				}
			}
		}
		public String APSupplierProductNumber
		{
			get{return _aPSupplierProductNumber;}
			set
			{
				if (value != this._aPSupplierProductNumber)
				{
				_aPSupplierProductNumber=value;
				NotifyChanged("APSupplierProductNumber");
				}
			}
		}
		public String APSupplierProductNumberDesc
		{
			get{return _aPSupplierProductNumberDesc;}
			set
			{
				if (value != this._aPSupplierProductNumberDesc)
				{
				_aPSupplierProductNumberDesc=value;
				NotifyChanged("APSupplierProductNumberDesc");
				}
			}
		}
		public String APSupplierProductName
		{
			get{return _aPSupplierProductName;}
			set
			{
				if (value != this._aPSupplierProductName)
				{
				_aPSupplierProductName=value;
				NotifyChanged("APSupplierProductName");
				}
			}
		}
		#endregion
	}
	#endregion
}