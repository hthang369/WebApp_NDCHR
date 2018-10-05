using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ARSellerProducts
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ARSellerProductsInfo
	//Created Date:Friday, March 14, 2008
	//-----------------------------------------------------------
	
	public class ARSellerProductsInfo:BusinessObject
	{
		public ARSellerProductsInfo()
		{
		}
		#region Variables
		protected int _aRSellerProductID;
		protected String _aAStat=String.Empty;
		protected int _aRSellerID;
		protected int _iCProductID;
		protected double _aRSellerProductProvisionPercent;
		protected double _aRSellerProductProvisionValue;
		protected String _aRSellerProductDesc=String.Empty;
		#endregion

		#region Public properties
		public int ARSellerProductID
		{
			get{return _aRSellerProductID;}
			set
			{
				if (value != this._aRSellerProductID)
				{
				_aRSellerProductID=value;
				NotifyChanged("ARSellerProductID");
				}
			}
		}
		public String AAStat
		{
			get{return _aAStat;}
			set
			{
				if (value != this._aAStat)
				{
				_aAStat=value;
				NotifyChanged("AAStat");
				}
			}
		}
		public int ARSellerID
		{
			get{return _aRSellerID;}
			set
			{
				if (value != this._aRSellerID)
				{
				_aRSellerID=value;
				NotifyChanged("ARSellerID");
				}
			}
		}
		public int ICProductID
		{
			get{return _iCProductID;}
			set
			{
				if (value != this._iCProductID)
				{
				_iCProductID=value;
				NotifyChanged("ICProductID");
				}
			}
		}
		public double ARSellerProductProvisionPercent
		{
			get{return _aRSellerProductProvisionPercent;}
			set
			{
				if (value != this._aRSellerProductProvisionPercent)
				{
				_aRSellerProductProvisionPercent=value;
				NotifyChanged("ARSellerProductProvisionPercent");
				}
			}
		}
		public double ARSellerProductProvisionValue
		{
			get{return _aRSellerProductProvisionValue;}
			set
			{
				if (value != this._aRSellerProductProvisionValue)
				{
				_aRSellerProductProvisionValue=value;
				NotifyChanged("ARSellerProductProvisionValue");
				}
			}
		}
		public String ARSellerProductDesc
		{
			get{return _aRSellerProductDesc;}
			set
			{
				if (value != this._aRSellerProductDesc)
				{
				_aRSellerProductDesc=value;
				NotifyChanged("ARSellerProductDesc");
				}
			}
		}
		#endregion
	}
	#endregion
}