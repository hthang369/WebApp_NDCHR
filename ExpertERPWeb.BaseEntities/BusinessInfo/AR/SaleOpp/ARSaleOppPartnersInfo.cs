using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ARSaleOppPartners
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ARSaleOppPartnersInfo
	//Created Date:26 Tháng Bảy 2012
	//-----------------------------------------------------------
	
	public class ARSaleOppPartnersInfo:BusinessObject
	{
		public ARSaleOppPartnersInfo()
		{
		}
		#region Variables
		protected int _aRSaleOppPartnerID;
		protected Nullable<DateTime> _aACreatedDate;
		protected String _aACreatedUser=String.Empty;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _aAUpdatedUser=String.Empty;
		protected String _aAStatus=DefaultAAStatus;
		protected int _fK_ARSaleOppID;
		protected int _fK_ARPartnerID;
		protected String _aRSaleOppPartnerLevelCombo=String.Empty;
		protected String _aRSaleOppPartnerRemark=String.Empty;
		protected double _aRSaleOppInvolvePct;
		protected double _aRSaleOppCommPct;
		protected int _fK_CMAccountID;
		#endregion

		#region Public properties
		public int ARSaleOppPartnerID
		{
			get{return _aRSaleOppPartnerID;}
			set
			{
				if (value != this._aRSaleOppPartnerID)
				{
				_aRSaleOppPartnerID=value;
				NotifyChanged("ARSaleOppPartnerID");
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
		public int FK_ARSaleOppID
		{
			get{return _fK_ARSaleOppID;}
			set
			{
				if (value != this._fK_ARSaleOppID)
				{
				_fK_ARSaleOppID=value;
				NotifyChanged("FK_ARSaleOppID");
				}
			}
		}
		public int FK_ARPartnerID
		{
			get{return _fK_ARPartnerID;}
			set
			{
				if (value != this._fK_ARPartnerID)
				{
				_fK_ARPartnerID=value;
				NotifyChanged("FK_ARPartnerID");
				}
			}
		}
		public String ARSaleOppPartnerLevelCombo
		{
			get{return _aRSaleOppPartnerLevelCombo;}
			set
			{
				if (value != this._aRSaleOppPartnerLevelCombo)
				{
				_aRSaleOppPartnerLevelCombo=value;
				NotifyChanged("ARSaleOppPartnerLevelCombo");
				}
			}
		}
		public String ARSaleOppPartnerRemark
		{
			get{return _aRSaleOppPartnerRemark;}
			set
			{
				if (value != this._aRSaleOppPartnerRemark)
				{
				_aRSaleOppPartnerRemark=value;
				NotifyChanged("ARSaleOppPartnerRemark");
				}
			}
		}
		public double ARSaleOppInvolvePct
		{
			get{return _aRSaleOppInvolvePct;}
			set
			{
				if (value != this._aRSaleOppInvolvePct)
				{
				_aRSaleOppInvolvePct=value;
				NotifyChanged("ARSaleOppInvolvePct");
				}
			}
		}
		public double ARSaleOppCommPct
		{
			get{return _aRSaleOppCommPct;}
			set
			{
				if (value != this._aRSaleOppCommPct)
				{
				_aRSaleOppCommPct=value;
				NotifyChanged("ARSaleOppCommPct");
				}
			}
		}
		public int FK_CMAccountID
		{
			get{return _fK_CMAccountID;}
			set
			{
				if (value != this._fK_CMAccountID)
				{
				_fK_CMAccountID=value;
				NotifyChanged("FK_CMAccountID");
				}
			}
		}
		#endregion
	}
	#endregion
}