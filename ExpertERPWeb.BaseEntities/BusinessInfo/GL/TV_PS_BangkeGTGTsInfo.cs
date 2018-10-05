using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region TV_PS_BangkeGTGTs
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:TV_PS_BangkeGTGTsInfo
	//Created Date:Thursday, May 20, 2010
	//-----------------------------------------------------------
	
	public class TV_PS_BangkeGTGTsInfo:BusinessObject
	{
		public TV_PS_BangkeGTGTsInfo()
		{
		}
		#region Variables
		protected int _tV_PS_BangkeGTGTID;
		protected String _tenDoiTuongCongNo=String.Empty;
		protected String _diaChi=String.Empty;
		protected String _maSoThue=String.Empty;
		protected String _seriHD=String.Empty;
		protected String _soHD=String.Empty;
		protected Nullable<DateTime> _ngayCT;
		protected String _noiDung=String.Empty;
		protected double _doanhSo;
		protected double _thueSuat;
		protected double _tienThue;
		protected String _tenHangtrenBangKe=String.Empty;
		protected bool _muavao=true;
		protected bool _daHuy=true;
		protected int _tV_PS_ChungtuID;
		#endregion

		#region Public properties
		public int TV_PS_BangkeGTGTID
		{
			get{return _tV_PS_BangkeGTGTID;}
			set
			{
				if (value != this._tV_PS_BangkeGTGTID)
				{
				_tV_PS_BangkeGTGTID=value;
				NotifyChanged("TV_PS_BangkeGTGTID");
				}
			}
		}
		public String TenDoiTuongCongNo
		{
			get{return _tenDoiTuongCongNo;}
			set
			{
				if (value != this._tenDoiTuongCongNo)
				{
				_tenDoiTuongCongNo=value;
				NotifyChanged("TenDoiTuongCongNo");
				}
			}
		}
		public String DiaChi
		{
			get{return _diaChi;}
			set
			{
				if (value != this._diaChi)
				{
				_diaChi=value;
				NotifyChanged("DiaChi");
				}
			}
		}
		public String MaSoThue
		{
			get{return _maSoThue;}
			set
			{
				if (value != this._maSoThue)
				{
				_maSoThue=value;
				NotifyChanged("MaSoThue");
				}
			}
		}
		public String SeriHD
		{
			get{return _seriHD;}
			set
			{
				if (value != this._seriHD)
				{
				_seriHD=value;
				NotifyChanged("SeriHD");
				}
			}
		}
		public String SoHD
		{
			get{return _soHD;}
			set
			{
				if (value != this._soHD)
				{
				_soHD=value;
				NotifyChanged("SoHD");
				}
			}
		}
		public Nullable<DateTime> NgayCT
		{
			get{return _ngayCT;}
			set
			{
				if (value != this._ngayCT)
				{
				_ngayCT=value;
				NotifyChanged("NgayCT");
				}
			}
		}
		public String NoiDung
		{
			get{return _noiDung;}
			set
			{
				if (value != this._noiDung)
				{
				_noiDung=value;
				NotifyChanged("NoiDung");
				}
			}
		}
		public double DoanhSo
		{
			get{return _doanhSo;}
			set
			{
				if (value != this._doanhSo)
				{
				_doanhSo=value;
				NotifyChanged("DoanhSo");
				}
			}
		}
		public double ThueSuat
		{
			get{return _thueSuat;}
			set
			{
				if (value != this._thueSuat)
				{
				_thueSuat=value;
				NotifyChanged("ThueSuat");
				}
			}
		}
		public double TienThue
		{
			get{return _tienThue;}
			set
			{
				if (value != this._tienThue)
				{
				_tienThue=value;
				NotifyChanged("TienThue");
				}
			}
		}
		public String TenHangtrenBangKe
		{
			get{return _tenHangtrenBangKe;}
			set
			{
				if (value != this._tenHangtrenBangKe)
				{
				_tenHangtrenBangKe=value;
				NotifyChanged("TenHangtrenBangKe");
				}
			}
		}
		public bool Muavao
		{
			get{return _muavao;}
			set
			{
				if (value != this._muavao)
				{
				_muavao=value;
				NotifyChanged("Muavao");
				}
			}
		}
		public bool DaHuy
		{
			get{return _daHuy;}
			set
			{
				if (value != this._daHuy)
				{
				_daHuy=value;
				NotifyChanged("DaHuy");
				}
			}
		}
		public int TV_PS_ChungtuID
		{
			get{return _tV_PS_ChungtuID;}
			set
			{
				if (value != this._tV_PS_ChungtuID)
				{
				_tV_PS_ChungtuID=value;
				NotifyChanged("TV_PS_ChungtuID");
				}
			}
		}
		#endregion
	}
	#endregion
}