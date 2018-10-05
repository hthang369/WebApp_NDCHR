using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ARSaleOppCompetitors
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ARSaleOppCompetitorsInfo
	//Created Date:26 Tháng Bảy 2012
	//-----------------------------------------------------------
	
	public class ARSaleOppCompetitorsInfo:BusinessObject
	{
		public ARSaleOppCompetitorsInfo()
		{
		}
		#region Variables
		protected int _aRSaleOppCompetitorID;
		protected Nullable<DateTime> _aACreatedDate;
		protected String _aACreatedUser=String.Empty;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _aAUpdatedUser=String.Empty;
		protected String _aAStatus=DefaultAAStatus;
		protected int _fK_ARSaleOppID;
		protected int _fK_ARCompetitorID;
		protected String _aRSaleOppCompetitorLevelCombo=String.Empty;
		protected String _aRSaleOppCompetitorRemark=String.Empty;
		protected String _aRSaleOppCompetitorStatusCombo=DefaultStatus;
		protected double _aRSaleOppCompetivePct;
		protected int _fK_CMAccountID;
		#endregion

		#region Public properties
		public int ARSaleOppCompetitorID
		{
			get{return _aRSaleOppCompetitorID;}
			set
			{
				if (value != this._aRSaleOppCompetitorID)
				{
				_aRSaleOppCompetitorID=value;
				NotifyChanged("ARSaleOppCompetitorID");
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
		public int FK_ARCompetitorID
		{
			get{return _fK_ARCompetitorID;}
			set
			{
				if (value != this._fK_ARCompetitorID)
				{
				_fK_ARCompetitorID=value;
				NotifyChanged("FK_ARCompetitorID");
				}
			}
		}
		public String ARSaleOppCompetitorLevelCombo
		{
			get{return _aRSaleOppCompetitorLevelCombo;}
			set
			{
				if (value != this._aRSaleOppCompetitorLevelCombo)
				{
				_aRSaleOppCompetitorLevelCombo=value;
				NotifyChanged("ARSaleOppCompetitorLevelCombo");
				}
			}
		}
		public String ARSaleOppCompetitorRemark
		{
			get{return _aRSaleOppCompetitorRemark;}
			set
			{
				if (value != this._aRSaleOppCompetitorRemark)
				{
				_aRSaleOppCompetitorRemark=value;
				NotifyChanged("ARSaleOppCompetitorRemark");
				}
			}
		}
		public String ARSaleOppCompetitorStatusCombo
		{
			get{return _aRSaleOppCompetitorStatusCombo;}
			set
			{
				if (value != this._aRSaleOppCompetitorStatusCombo)
				{
				_aRSaleOppCompetitorStatusCombo=value;
				NotifyChanged("ARSaleOppCompetitorStatusCombo");
				}
			}
		}
		public double ARSaleOppCompetivePct
		{
			get{return _aRSaleOppCompetivePct;}
			set
			{
				if (value != this._aRSaleOppCompetivePct)
				{
				_aRSaleOppCompetivePct=value;
				NotifyChanged("ARSaleOppCompetivePct");
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