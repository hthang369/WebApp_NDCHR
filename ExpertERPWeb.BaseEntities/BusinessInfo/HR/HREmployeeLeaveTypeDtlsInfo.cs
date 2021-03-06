using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region HREmployeeLeaveTypeDtls
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:HREmployeeLeaveTypeDtlsInfo
	//Created Date:10 Tháng Giêng 2013
	//-----------------------------------------------------------
	
	public class HREmployeeLeaveTypeDtlsInfo:BusinessObject
	{
		public HREmployeeLeaveTypeDtlsInfo()
		{
		}
		#region Variables
		protected int _hREmployeeLeaveTypeDtlID;
		protected String _aAStatus=DefaultAAStatus;
		protected int _fK_HREmployeeLeaveTypeID;
		protected String _hREmployeeLeaveTypeDtlName=String.Empty;
		protected double _hREmployeeLeaveTypeDtlPctAmt;
		protected String _hREmployeeLeaveTypeDtlDesc=String.Empty;
		protected String _hREmployeeLeaveTypeDtlOF01=String.Empty;
		protected String _hREmployeeLeaveTypeDtlOF02=String.Empty;
		protected String _hREmployeeLeaveTypeDtlOF03=String.Empty;
		protected String _hREmployeeLeaveTypeDtlOF04=String.Empty;
		#endregion

		#region Public properties
		public int HREmployeeLeaveTypeDtlID
		{
			get{return _hREmployeeLeaveTypeDtlID;}
			set
			{
				if (value != this._hREmployeeLeaveTypeDtlID)
				{
				_hREmployeeLeaveTypeDtlID=value;
				NotifyChanged("HREmployeeLeaveTypeDtlID");
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
		public int FK_HREmployeeLeaveTypeID
		{
			get{return _fK_HREmployeeLeaveTypeID;}
			set
			{
				if (value != this._fK_HREmployeeLeaveTypeID)
				{
				_fK_HREmployeeLeaveTypeID=value;
				NotifyChanged("FK_HREmployeeLeaveTypeID");
				}
			}
		}
		public String HREmployeeLeaveTypeDtlName
		{
			get{return _hREmployeeLeaveTypeDtlName;}
			set
			{
				if (value != this._hREmployeeLeaveTypeDtlName)
				{
				_hREmployeeLeaveTypeDtlName=value;
				NotifyChanged("HREmployeeLeaveTypeDtlName");
				}
			}
		}
		public double HREmployeeLeaveTypeDtlPctAmt
		{
			get{return _hREmployeeLeaveTypeDtlPctAmt;}
			set
			{
				if (value != this._hREmployeeLeaveTypeDtlPctAmt)
				{
				_hREmployeeLeaveTypeDtlPctAmt=value;
				NotifyChanged("HREmployeeLeaveTypeDtlPctAmt");
				}
			}
		}
		public String HREmployeeLeaveTypeDtlDesc
		{
			get{return _hREmployeeLeaveTypeDtlDesc;}
			set
			{
				if (value != this._hREmployeeLeaveTypeDtlDesc)
				{
				_hREmployeeLeaveTypeDtlDesc=value;
				NotifyChanged("HREmployeeLeaveTypeDtlDesc");
				}
			}
		}
		public String HREmployeeLeaveTypeDtlOF01
		{
			get{return _hREmployeeLeaveTypeDtlOF01;}
			set
			{
				if (value != this._hREmployeeLeaveTypeDtlOF01)
				{
				_hREmployeeLeaveTypeDtlOF01=value;
				NotifyChanged("HREmployeeLeaveTypeDtlOF01");
				}
			}
		}
		public String HREmployeeLeaveTypeDtlOF02
		{
			get{return _hREmployeeLeaveTypeDtlOF02;}
			set
			{
				if (value != this._hREmployeeLeaveTypeDtlOF02)
				{
				_hREmployeeLeaveTypeDtlOF02=value;
				NotifyChanged("HREmployeeLeaveTypeDtlOF02");
				}
			}
		}
		public String HREmployeeLeaveTypeDtlOF03
		{
			get{return _hREmployeeLeaveTypeDtlOF03;}
			set
			{
				if (value != this._hREmployeeLeaveTypeDtlOF03)
				{
				_hREmployeeLeaveTypeDtlOF03=value;
				NotifyChanged("HREmployeeLeaveTypeDtlOF03");
				}
			}
		}
		public String HREmployeeLeaveTypeDtlOF04
		{
			get{return _hREmployeeLeaveTypeDtlOF04;}
			set
			{
				if (value != this._hREmployeeLeaveTypeDtlOF04)
				{
				_hREmployeeLeaveTypeDtlOF04=value;
				NotifyChanged("HREmployeeLeaveTypeDtlOF04");
				}
			}
		}
		#endregion
	}
	#endregion
}