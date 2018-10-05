using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region GENumberings
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:GENumberingsInfo
	//Created Date:04 Tháng Bảy 2014
	//-----------------------------------------------------------
	
	public class GENumberingsInfo:BusinessObject
	{
		public GENumberingsInfo()
		{
		}
		#region Variables
		protected int _gENumberingID;
		protected String _aACreatedUser=String.Empty;
		protected Nullable<DateTime> _aACreatedDate;
		protected String _aAUpdatedUser=String.Empty;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _gENumberingName=String.Empty;
		protected String _gENumberingPrefix=String.Empty;
		protected int _gENumberingLength;
		protected int _gENumberingStart;
		protected String _gENumberingDesc=String.Empty;
		protected bool _gENumberingByDate=true;
		protected String _gENumberingDateFormat=String.Empty;
		protected int _gENumberingDateStart;
		protected String _gENumberingSeparate=String.Empty;
		protected bool _gENumberingIsAutoChecked=true;
		protected int _gENumberingAutoNumber;
		protected int _gENumberingOF01;
		protected int _gENumberingOF02;
		protected int _gENumberingOF03;
		protected String _gENumberingObjectType=String.Empty;
		#endregion

		#region Public properties
		public int GENumberingID
		{
			get{return _gENumberingID;}
			set
			{
				if (value != this._gENumberingID)
				{
				_gENumberingID=value;
				NotifyChanged("GENumberingID");
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
		public String GENumberingName
		{
			get{return _gENumberingName;}
			set
			{
				if (value != this._gENumberingName)
				{
				_gENumberingName=value;
				NotifyChanged("GENumberingName");
				}
			}
		}
		public String GENumberingPrefix
		{
			get{return _gENumberingPrefix;}
			set
			{
				if (value != this._gENumberingPrefix)
				{
				_gENumberingPrefix=value;
				NotifyChanged("GENumberingPrefix");
				}
			}
		}
		public int GENumberingLength
		{
			get{return _gENumberingLength;}
			set
			{
				if (value != this._gENumberingLength)
				{
				_gENumberingLength=value;
				NotifyChanged("GENumberingLength");
				}
			}
		}
		public int GENumberingStart
		{
			get{return _gENumberingStart;}
			set
			{
				if (value != this._gENumberingStart)
				{
				_gENumberingStart=value;
				NotifyChanged("GENumberingStart");
				}
			}
		}
		public String GENumberingDesc
		{
			get{return _gENumberingDesc;}
			set
			{
				if (value != this._gENumberingDesc)
				{
				_gENumberingDesc=value;
				NotifyChanged("GENumberingDesc");
				}
			}
		}
		public bool GENumberingByDate
		{
			get{return _gENumberingByDate;}
			set
			{
				if (value != this._gENumberingByDate)
				{
				_gENumberingByDate=value;
				NotifyChanged("GENumberingByDate");
				}
			}
		}
		public String GENumberingDateFormat
		{
			get{return _gENumberingDateFormat;}
			set
			{
				if (value != this._gENumberingDateFormat)
				{
				_gENumberingDateFormat=value;
				NotifyChanged("GENumberingDateFormat");
				}
			}
		}
		public int GENumberingDateStart
		{
			get{return _gENumberingDateStart;}
			set
			{
				if (value != this._gENumberingDateStart)
				{
				_gENumberingDateStart=value;
				NotifyChanged("GENumberingDateStart");
				}
			}
		}
		public String GENumberingSeparate
		{
			get{return _gENumberingSeparate;}
			set
			{
				if (value != this._gENumberingSeparate)
				{
				_gENumberingSeparate=value;
				NotifyChanged("GENumberingSeparate");
				}
			}
		}
		public bool GENumberingIsAutoChecked
		{
			get{return _gENumberingIsAutoChecked;}
			set
			{
				if (value != this._gENumberingIsAutoChecked)
				{
				_gENumberingIsAutoChecked=value;
				NotifyChanged("GENumberingIsAutoChecked");
				}
			}
		}
		public int GENumberingAutoNumber
		{
			get{return _gENumberingAutoNumber;}
			set
			{
				if (value != this._gENumberingAutoNumber)
				{
				_gENumberingAutoNumber=value;
				NotifyChanged("GENumberingAutoNumber");
				}
			}
		}
		public int GENumberingOF01
		{
			get{return _gENumberingOF01;}
			set
			{
				if (value != this._gENumberingOF01)
				{
				_gENumberingOF01=value;
				NotifyChanged("GENumberingOF01");
				}
			}
		}
		public int GENumberingOF02
		{
			get{return _gENumberingOF02;}
			set
			{
				if (value != this._gENumberingOF02)
				{
				_gENumberingOF02=value;
				NotifyChanged("GENumberingOF02");
				}
			}
		}
		public int GENumberingOF03
		{
			get{return _gENumberingOF03;}
			set
			{
				if (value != this._gENumberingOF03)
				{
				_gENumberingOF03=value;
				NotifyChanged("GENumberingOF03");
				}
			}
		}
		public String GENumberingObjectType
		{
			get{return _gENumberingObjectType;}
			set
			{
				if (value != this._gENumberingObjectType)
				{
				_gENumberingObjectType=value;
				NotifyChanged("GENumberingObjectType");
				}
			}
		}
		#endregion
	}
	#endregion
}