using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ARSellerStatDtls
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ARSellerStatDtlsInfo
	//Created Date:Wednesday, February 24, 2010
	//-----------------------------------------------------------
	
	public class ARSellerStatDtlsInfo:BusinessObject
	{
		public ARSellerStatDtlsInfo()
		{
		}
		#region Variables
		protected int _aRSellerStatDtlID;
		protected int _fK_ARSellerStatID;
		protected int _fK_ARQuotID;
		protected int _fK_ARSOID;
		#endregion

		#region Public properties
		public int ARSellerStatDtlID
		{
			get{return _aRSellerStatDtlID;}
			set
			{
				if (value != this._aRSellerStatDtlID)
				{
				_aRSellerStatDtlID=value;
				NotifyChanged("ARSellerStatDtlID");
				}
			}
		}
		public int FK_ARSellerStatID
		{
			get{return _fK_ARSellerStatID;}
			set
			{
				if (value != this._fK_ARSellerStatID)
				{
				_fK_ARSellerStatID=value;
				NotifyChanged("FK_ARSellerStatID");
				}
			}
		}
		public int FK_ARQuotID
		{
			get{return _fK_ARQuotID;}
			set
			{
				if (value != this._fK_ARQuotID)
				{
				_fK_ARQuotID=value;
				NotifyChanged("FK_ARQuotID");
				}
			}
		}
		public int FK_ARSOID
		{
			get{return _fK_ARSOID;}
			set
			{
				if (value != this._fK_ARSOID)
				{
				_fK_ARSOID=value;
				NotifyChanged("FK_ARSOID");
				}
			}
		}
		#endregion
	}
	#endregion
}