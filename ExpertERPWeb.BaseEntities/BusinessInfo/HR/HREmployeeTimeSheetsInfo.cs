using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region HREmployeeTimeSheets
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:HREmployeeTimeSheetsInfo
	//Created Date:20 Tháng Chín 2013
	//-----------------------------------------------------------
	
	public class HREmployeeTimeSheetsInfo:BusinessObject
	{
		public HREmployeeTimeSheetsInfo()
		{
		}
		#region Variables
		protected int _hREmployeeTimeSheetID;
		protected Nullable<DateTime> _aACreatedDate;
		protected String _aACreatedUser=String.Empty;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _aAUpdatedUser=String.Empty;
		protected int _fK_HREmployeeID;
		protected int _fK_HRShiftID;
		protected int _hREmployeeTimeSheetPeriod;
		protected int _hREmployeeTimeSheetYear;
		protected bool _hREmployeeTimeSheetD1=false;
		protected bool _hREmployeeTimeSheetD2= false;
		protected bool _hREmployeeTimeSheetD3= false;
		protected bool _hREmployeeTimeSheetD4= false;
		protected bool _hREmployeeTimeSheetD5=false;
		protected bool _hREmployeeTimeSheetD6=false;
		protected bool _hREmployeeTimeSheetD7=false;
		protected bool _hREmployeeTimeSheetD8=false;
		protected bool _hREmployeeTimeSheetD9=false;
		protected bool _hREmployeeTimeSheetD10=false;
		protected bool _hREmployeeTimeSheetD11=false;
		protected bool _hREmployeeTimeSheetD12=false;
		protected bool _hREmployeeTimeSheetD13=false;
		protected bool _hREmployeeTimeSheetD14=false;
		protected bool _hREmployeeTimeSheetD15=false;
		protected bool _hREmployeeTimeSheetD16=false;
		protected bool _hREmployeeTimeSheetD17=false;
		protected bool _hREmployeeTimeSheetD18=false;
		protected bool _hREmployeeTimeSheetD19=false;
		protected bool _hREmployeeTimeSheetD20=false;
		protected bool _hREmployeeTimeSheetD21=false;
		protected bool _hREmployeeTimeSheetD22=false;
		protected bool _hREmployeeTimeSheetD23=false;
		protected bool _hREmployeeTimeSheetD24=false;
		protected bool _hREmployeeTimeSheetD25=false;
		protected bool _hREmployeeTimeSheetD26=false;
		protected bool _hREmployeeTimeSheetD27=false;
		protected bool _hREmployeeTimeSheetD28=false;
		protected bool _hREmployeeTimeSheetD29=false;
		protected bool _hREmployeeTimeSheetD30=false;
		protected bool _hREmployeeTimeSheetD31=false;
		protected int _hREmployeeTimeSheetOrder;
		#endregion

		#region Public properties
		public int HREmployeeTimeSheetID
		{
			get{return _hREmployeeTimeSheetID;}
			set
			{
				if (value != this._hREmployeeTimeSheetID)
				{
				_hREmployeeTimeSheetID=value;
				NotifyChanged("HREmployeeTimeSheetID");
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
		public int FK_HREmployeeID
		{
			get{return _fK_HREmployeeID;}
			set
			{
				if (value != this._fK_HREmployeeID)
				{
				_fK_HREmployeeID=value;
				NotifyChanged("FK_HREmployeeID");
				}
			}
		}
		public int FK_HRShiftID
		{
			get{return _fK_HRShiftID;}
			set
			{
				if (value != this._fK_HRShiftID)
				{
				_fK_HRShiftID=value;
				NotifyChanged("FK_HRShiftID");
				}
			}
		}
		public int HREmployeeTimeSheetPeriod
		{
			get{return _hREmployeeTimeSheetPeriod;}
			set
			{
				if (value != this._hREmployeeTimeSheetPeriod)
				{
				_hREmployeeTimeSheetPeriod=value;
				NotifyChanged("HREmployeeTimeSheetPeriod");
				}
			}
		}
		public int HREmployeeTimeSheetYear
		{
			get{return _hREmployeeTimeSheetYear;}
			set
			{
				if (value != this._hREmployeeTimeSheetYear)
				{
				_hREmployeeTimeSheetYear=value;
				NotifyChanged("HREmployeeTimeSheetYear");
				}
			}
		}
		public bool HREmployeeTimeSheetD1
		{
			get{return _hREmployeeTimeSheetD1;}
			set
			{
				if (value != this._hREmployeeTimeSheetD1)
				{
				_hREmployeeTimeSheetD1=value;
				NotifyChanged("HREmployeeTimeSheetD1");
				}
			}
		}
		public bool HREmployeeTimeSheetD2
		{
			get{return _hREmployeeTimeSheetD2;}
			set
			{
				if (value != this._hREmployeeTimeSheetD2)
				{
				_hREmployeeTimeSheetD2=value;
				NotifyChanged("HREmployeeTimeSheetD2");
				}
			}
		}
		public bool HREmployeeTimeSheetD3
		{
			get{return _hREmployeeTimeSheetD3;}
			set
			{
				if (value != this._hREmployeeTimeSheetD3)
				{
				_hREmployeeTimeSheetD3=value;
				NotifyChanged("HREmployeeTimeSheetD3");
				}
			}
		}
		public bool HREmployeeTimeSheetD4
		{
			get{return _hREmployeeTimeSheetD4;}
			set
			{
				if (value != this._hREmployeeTimeSheetD4)
				{
				_hREmployeeTimeSheetD4=value;
				NotifyChanged("HREmployeeTimeSheetD4");
				}
			}
		}
		public bool HREmployeeTimeSheetD5
		{
			get{return _hREmployeeTimeSheetD5;}
			set
			{
				if (value != this._hREmployeeTimeSheetD5)
				{
				_hREmployeeTimeSheetD5=value;
				NotifyChanged("HREmployeeTimeSheetD5");
				}
			}
		}
		public bool HREmployeeTimeSheetD6
		{
			get{return _hREmployeeTimeSheetD6;}
			set
			{
				if (value != this._hREmployeeTimeSheetD6)
				{
				_hREmployeeTimeSheetD6=value;
				NotifyChanged("HREmployeeTimeSheetD6");
				}
			}
		}
		public bool HREmployeeTimeSheetD7
		{
			get{return _hREmployeeTimeSheetD7;}
			set
			{
				if (value != this._hREmployeeTimeSheetD7)
				{
				_hREmployeeTimeSheetD7=value;
				NotifyChanged("HREmployeeTimeSheetD7");
				}
			}
		}
		public bool HREmployeeTimeSheetD8
		{
			get{return _hREmployeeTimeSheetD8;}
			set
			{
				if (value != this._hREmployeeTimeSheetD8)
				{
				_hREmployeeTimeSheetD8=value;
				NotifyChanged("HREmployeeTimeSheetD8");
				}
			}
		}
		public bool HREmployeeTimeSheetD9
		{
			get{return _hREmployeeTimeSheetD9;}
			set
			{
				if (value != this._hREmployeeTimeSheetD9)
				{
				_hREmployeeTimeSheetD9=value;
				NotifyChanged("HREmployeeTimeSheetD9");
				}
			}
		}
		public bool HREmployeeTimeSheetD10
		{
			get{return _hREmployeeTimeSheetD10;}
			set
			{
				if (value != this._hREmployeeTimeSheetD10)
				{
				_hREmployeeTimeSheetD10=value;
				NotifyChanged("HREmployeeTimeSheetD10");
				}
			}
		}
		public bool HREmployeeTimeSheetD11
		{
			get{return _hREmployeeTimeSheetD11;}
			set
			{
				if (value != this._hREmployeeTimeSheetD11)
				{
				_hREmployeeTimeSheetD11=value;
				NotifyChanged("HREmployeeTimeSheetD11");
				}
			}
		}
		public bool HREmployeeTimeSheetD12
		{
			get{return _hREmployeeTimeSheetD12;}
			set
			{
				if (value != this._hREmployeeTimeSheetD12)
				{
				_hREmployeeTimeSheetD12=value;
				NotifyChanged("HREmployeeTimeSheetD12");
				}
			}
		}
		public bool HREmployeeTimeSheetD13
		{
			get{return _hREmployeeTimeSheetD13;}
			set
			{
				if (value != this._hREmployeeTimeSheetD13)
				{
				_hREmployeeTimeSheetD13=value;
				NotifyChanged("HREmployeeTimeSheetD13");
				}
			}
		}
		public bool HREmployeeTimeSheetD14
		{
			get{return _hREmployeeTimeSheetD14;}
			set
			{
				if (value != this._hREmployeeTimeSheetD14)
				{
				_hREmployeeTimeSheetD14=value;
				NotifyChanged("HREmployeeTimeSheetD14");
				}
			}
		}
		public bool HREmployeeTimeSheetD15
		{
			get{return _hREmployeeTimeSheetD15;}
			set
			{
				if (value != this._hREmployeeTimeSheetD15)
				{
				_hREmployeeTimeSheetD15=value;
				NotifyChanged("HREmployeeTimeSheetD15");
				}
			}
		}
		public bool HREmployeeTimeSheetD16
		{
			get{return _hREmployeeTimeSheetD16;}
			set
			{
				if (value != this._hREmployeeTimeSheetD16)
				{
				_hREmployeeTimeSheetD16=value;
				NotifyChanged("HREmployeeTimeSheetD16");
				}
			}
		}
		public bool HREmployeeTimeSheetD17
		{
			get{return _hREmployeeTimeSheetD17;}
			set
			{
				if (value != this._hREmployeeTimeSheetD17)
				{
				_hREmployeeTimeSheetD17=value;
				NotifyChanged("HREmployeeTimeSheetD17");
				}
			}
		}
		public bool HREmployeeTimeSheetD18
		{
			get{return _hREmployeeTimeSheetD18;}
			set
			{
				if (value != this._hREmployeeTimeSheetD18)
				{
				_hREmployeeTimeSheetD18=value;
				NotifyChanged("HREmployeeTimeSheetD18");
				}
			}
		}
		public bool HREmployeeTimeSheetD19
		{
			get{return _hREmployeeTimeSheetD19;}
			set
			{
				if (value != this._hREmployeeTimeSheetD19)
				{
				_hREmployeeTimeSheetD19=value;
				NotifyChanged("HREmployeeTimeSheetD19");
				}
			}
		}
		public bool HREmployeeTimeSheetD20
		{
			get{return _hREmployeeTimeSheetD20;}
			set
			{
				if (value != this._hREmployeeTimeSheetD20)
				{
				_hREmployeeTimeSheetD20=value;
				NotifyChanged("HREmployeeTimeSheetD20");
				}
			}
		}
		public bool HREmployeeTimeSheetD21
		{
			get{return _hREmployeeTimeSheetD21;}
			set
			{
				if (value != this._hREmployeeTimeSheetD21)
				{
				_hREmployeeTimeSheetD21=value;
				NotifyChanged("HREmployeeTimeSheetD21");
				}
			}
		}
		public bool HREmployeeTimeSheetD22
		{
			get{return _hREmployeeTimeSheetD22;}
			set
			{
				if (value != this._hREmployeeTimeSheetD22)
				{
				_hREmployeeTimeSheetD22=value;
				NotifyChanged("HREmployeeTimeSheetD22");
				}
			}
		}
		public bool HREmployeeTimeSheetD23
		{
			get{return _hREmployeeTimeSheetD23;}
			set
			{
				if (value != this._hREmployeeTimeSheetD23)
				{
				_hREmployeeTimeSheetD23=value;
				NotifyChanged("HREmployeeTimeSheetD23");
				}
			}
		}
		public bool HREmployeeTimeSheetD24
		{
			get{return _hREmployeeTimeSheetD24;}
			set
			{
				if (value != this._hREmployeeTimeSheetD24)
				{
				_hREmployeeTimeSheetD24=value;
				NotifyChanged("HREmployeeTimeSheetD24");
				}
			}
		}
		public bool HREmployeeTimeSheetD25
		{
			get{return _hREmployeeTimeSheetD25;}
			set
			{
				if (value != this._hREmployeeTimeSheetD25)
				{
				_hREmployeeTimeSheetD25=value;
				NotifyChanged("HREmployeeTimeSheetD25");
				}
			}
		}
		public bool HREmployeeTimeSheetD26
		{
			get{return _hREmployeeTimeSheetD26;}
			set
			{
				if (value != this._hREmployeeTimeSheetD26)
				{
				_hREmployeeTimeSheetD26=value;
				NotifyChanged("HREmployeeTimeSheetD26");
				}
			}
		}
		public bool HREmployeeTimeSheetD27
		{
			get{return _hREmployeeTimeSheetD27;}
			set
			{
				if (value != this._hREmployeeTimeSheetD27)
				{
				_hREmployeeTimeSheetD27=value;
				NotifyChanged("HREmployeeTimeSheetD27");
				}
			}
		}
		public bool HREmployeeTimeSheetD28
		{
			get{return _hREmployeeTimeSheetD28;}
			set
			{
				if (value != this._hREmployeeTimeSheetD28)
				{
				_hREmployeeTimeSheetD28=value;
				NotifyChanged("HREmployeeTimeSheetD28");
				}
			}
		}
		public bool HREmployeeTimeSheetD29
		{
			get{return _hREmployeeTimeSheetD29;}
			set
			{
				if (value != this._hREmployeeTimeSheetD29)
				{
				_hREmployeeTimeSheetD29=value;
				NotifyChanged("HREmployeeTimeSheetD29");
				}
			}
		}
		public bool HREmployeeTimeSheetD30
		{
			get{return _hREmployeeTimeSheetD30;}
			set
			{
				if (value != this._hREmployeeTimeSheetD30)
				{
				_hREmployeeTimeSheetD30=value;
				NotifyChanged("HREmployeeTimeSheetD30");
				}
			}
		}
		public bool HREmployeeTimeSheetD31
		{
			get{return _hREmployeeTimeSheetD31;}
			set
			{
				if (value != this._hREmployeeTimeSheetD31)
				{
				_hREmployeeTimeSheetD31=value;
				NotifyChanged("HREmployeeTimeSheetD31");
				}
			}
		}
		public int HREmployeeTimeSheetOrder
		{
			get{return _hREmployeeTimeSheetOrder;}
			set
			{
				if (value != this._hREmployeeTimeSheetOrder)
				{
				_hREmployeeTimeSheetOrder=value;
				NotifyChanged("HREmployeeTimeSheetOrder");
				}
			}
		}
		#endregion
	}
	#endregion
}