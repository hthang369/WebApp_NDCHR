using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region AREstSOItemHistorys
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:AREstSOItemHistorysInfo
	//Created Date:02 Tháng Bảy 2013
	//-----------------------------------------------------------
	
	public class AREstSOItemHistorysInfo:BusinessObject
	{
		public AREstSOItemHistorysInfo()
		{
		}
		#region Variables
		protected int _aREstSOItemHistoryID;
		protected String _aACreatedUser=String.Empty;
		protected Nullable<DateTime> _aACreatedDate;
		protected String _aAUpdatedUser=String.Empty;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _aAStatus=DefaultAAStatus;
		protected bool _aASelected=true;
		protected int _fK_AREstSOItemID;
		protected int _fK_AREstSOID;
		protected int _fK_ICProductID;
		protected double _aREstSOItemHistoryQty;
		protected double _aREstSOItemHistoryPriority;
		protected double _aREstSOItemHistorySaleQty;
		protected double _aREstSOItemHistoryMinStock;
		protected double _aREstSOItemHistoryInvActual;
		protected double _aREstSOItemHistoryNTSQty;
		protected double _aREstSOItemHistoryATSQty;
		protected double _aREstSOItemHistoryATSPct;
		protected int _aREstSOItemHistoryATSCnt;
		protected double _aREstSOItemHistoryHTSQty;
		protected double _aREstSOItemHistoryHTSPct;
		protected double _aREstSOItemHistoryMinShpQty;
		protected double _aREstSOItemHistoryModifyCnt;
		protected double _aREstSOItemHistoryUnitPrice;
		protected double _aREstSOItemHistoryTotalPrice;
		protected double _aREstSOItemHistoryUnitMaterialCBM;
		protected double _aREstSOItemHistoryMaterialCBM;
		protected double _aREstSOItemHistoryOnProductionQty;
		protected double _aREstSOItemHistoryOnWOQty;
		protected double _aREstSOItemHistoryFinishQty;
		protected double _aREstSOItemHistoryUnitPkgCBM;
		protected double _aREstSOItemHistoryPkgCBM;
		protected double _aREstSOItemHistoryRNTSQty;
		protected double _aREstSOItemHistoryOldQty;
		protected double _aREstSOItemHistoryOldPriority;
		protected double _aREstSOItemHistoryOldSaleQty;
		protected double _aREstSOItemHistoryOldMinStock;
		protected double _aREstSOItemHistoryOldInvActual;
		protected double _aREstSOItemHistoryOldNTSQty;
		protected double _aREstSOItemHistoryOldATSQty;
		protected double _aREstSOItemHistoryOldATSPct;
		protected int _aREstSOItemHistoryOldATSCnt;
		protected double _aREstSOItemHistoryOldHTSQty;
		protected double _aREstSOItemHistoryOldHTSPct;
		protected double _aREstSOItemHistoryOldMinShpQty;
		protected double _aREstSOItemHistoryOldModifyCnt;
		protected double _aREstSOItemHistoryOldUnitPrice;
		protected double _aREstSOItemHistoryOldTotalPrice;
		protected double _aREstSOItemHistoryOldUnitMaterialCBM;
		protected double _aREstSOItemHistoryOldMaterialCBM;
		protected double _aREstSOItemHistoryOldOnProductionQty;
		protected double _aREstSOItemHistoryOldOnWOQty;
		protected double _aREstSOItemHistoryOldFinishQty;
		protected double _aREstSOItemHistoryOldUnitPkgCBM;
		protected double _aREstSOItemHistoryOldPkgCBM;
		protected double _aREstSOItemHistoryOldRNTSQty;
		protected Nullable<DateTime> _aREstSOItemHistoryDate;
		#endregion

		#region Public properties
		public int AREstSOItemHistoryID
		{
			get{return _aREstSOItemHistoryID;}
			set
			{
				if (value != this._aREstSOItemHistoryID)
				{
				_aREstSOItemHistoryID=value;
				NotifyChanged("AREstSOItemHistoryID");
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
		public bool AASelected
		{
			get{return _aASelected;}
			set
			{
				if (value != this._aASelected)
				{
				_aASelected=value;
				NotifyChanged("AASelected");
				}
			}
		}
		public int FK_AREstSOItemID
		{
			get{return _fK_AREstSOItemID;}
			set
			{
				if (value != this._fK_AREstSOItemID)
				{
				_fK_AREstSOItemID=value;
				NotifyChanged("FK_AREstSOItemID");
				}
			}
		}
		public int FK_AREstSOID
		{
			get{return _fK_AREstSOID;}
			set
			{
				if (value != this._fK_AREstSOID)
				{
				_fK_AREstSOID=value;
				NotifyChanged("FK_AREstSOID");
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
		public double AREstSOItemHistoryQty
		{
			get{return _aREstSOItemHistoryQty;}
			set
			{
				if (value != this._aREstSOItemHistoryQty)
				{
				_aREstSOItemHistoryQty=value;
				NotifyChanged("AREstSOItemHistoryQty");
				}
			}
		}
		public double AREstSOItemHistoryPriority
		{
			get{return _aREstSOItemHistoryPriority;}
			set
			{
				if (value != this._aREstSOItemHistoryPriority)
				{
				_aREstSOItemHistoryPriority=value;
				NotifyChanged("AREstSOItemHistoryPriority");
				}
			}
		}
		public double AREstSOItemHistorySaleQty
		{
			get{return _aREstSOItemHistorySaleQty;}
			set
			{
				if (value != this._aREstSOItemHistorySaleQty)
				{
				_aREstSOItemHistorySaleQty=value;
				NotifyChanged("AREstSOItemHistorySaleQty");
				}
			}
		}
		public double AREstSOItemHistoryMinStock
		{
			get{return _aREstSOItemHistoryMinStock;}
			set
			{
				if (value != this._aREstSOItemHistoryMinStock)
				{
				_aREstSOItemHistoryMinStock=value;
				NotifyChanged("AREstSOItemHistoryMinStock");
				}
			}
		}
		public double AREstSOItemHistoryInvActual
		{
			get{return _aREstSOItemHistoryInvActual;}
			set
			{
				if (value != this._aREstSOItemHistoryInvActual)
				{
				_aREstSOItemHistoryInvActual=value;
				NotifyChanged("AREstSOItemHistoryInvActual");
				}
			}
		}
		public double AREstSOItemHistoryNTSQty
		{
			get{return _aREstSOItemHistoryNTSQty;}
			set
			{
				if (value != this._aREstSOItemHistoryNTSQty)
				{
				_aREstSOItemHistoryNTSQty=value;
				NotifyChanged("AREstSOItemHistoryNTSQty");
				}
			}
		}
		public double AREstSOItemHistoryATSQty
		{
			get{return _aREstSOItemHistoryATSQty;}
			set
			{
				if (value != this._aREstSOItemHistoryATSQty)
				{
				_aREstSOItemHistoryATSQty=value;
				NotifyChanged("AREstSOItemHistoryATSQty");
				}
			}
		}
		public double AREstSOItemHistoryATSPct
		{
			get{return _aREstSOItemHistoryATSPct;}
			set
			{
				if (value != this._aREstSOItemHistoryATSPct)
				{
				_aREstSOItemHistoryATSPct=value;
				NotifyChanged("AREstSOItemHistoryATSPct");
				}
			}
		}
		public int AREstSOItemHistoryATSCnt
		{
			get{return _aREstSOItemHistoryATSCnt;}
			set
			{
				if (value != this._aREstSOItemHistoryATSCnt)
				{
				_aREstSOItemHistoryATSCnt=value;
				NotifyChanged("AREstSOItemHistoryATSCnt");
				}
			}
		}
		public double AREstSOItemHistoryHTSQty
		{
			get{return _aREstSOItemHistoryHTSQty;}
			set
			{
				if (value != this._aREstSOItemHistoryHTSQty)
				{
				_aREstSOItemHistoryHTSQty=value;
				NotifyChanged("AREstSOItemHistoryHTSQty");
				}
			}
		}
		public double AREstSOItemHistoryHTSPct
		{
			get{return _aREstSOItemHistoryHTSPct;}
			set
			{
				if (value != this._aREstSOItemHistoryHTSPct)
				{
				_aREstSOItemHistoryHTSPct=value;
				NotifyChanged("AREstSOItemHistoryHTSPct");
				}
			}
		}
		public double AREstSOItemHistoryMinShpQty
		{
			get{return _aREstSOItemHistoryMinShpQty;}
			set
			{
				if (value != this._aREstSOItemHistoryMinShpQty)
				{
				_aREstSOItemHistoryMinShpQty=value;
				NotifyChanged("AREstSOItemHistoryMinShpQty");
				}
			}
		}
		public double AREstSOItemHistoryModifyCnt
		{
			get{return _aREstSOItemHistoryModifyCnt;}
			set
			{
				if (value != this._aREstSOItemHistoryModifyCnt)
				{
				_aREstSOItemHistoryModifyCnt=value;
				NotifyChanged("AREstSOItemHistoryModifyCnt");
				}
			}
		}
		public double AREstSOItemHistoryUnitPrice
		{
			get{return _aREstSOItemHistoryUnitPrice;}
			set
			{
				if (value != this._aREstSOItemHistoryUnitPrice)
				{
				_aREstSOItemHistoryUnitPrice=value;
				NotifyChanged("AREstSOItemHistoryUnitPrice");
				}
			}
		}
		public double AREstSOItemHistoryTotalPrice
		{
			get{return _aREstSOItemHistoryTotalPrice;}
			set
			{
				if (value != this._aREstSOItemHistoryTotalPrice)
				{
				_aREstSOItemHistoryTotalPrice=value;
				NotifyChanged("AREstSOItemHistoryTotalPrice");
				}
			}
		}
		public double AREstSOItemHistoryUnitMaterialCBM
		{
			get{return _aREstSOItemHistoryUnitMaterialCBM;}
			set
			{
				if (value != this._aREstSOItemHistoryUnitMaterialCBM)
				{
				_aREstSOItemHistoryUnitMaterialCBM=value;
				NotifyChanged("AREstSOItemHistoryUnitMaterialCBM");
				}
			}
		}
		public double AREstSOItemHistoryMaterialCBM
		{
			get{return _aREstSOItemHistoryMaterialCBM;}
			set
			{
				if (value != this._aREstSOItemHistoryMaterialCBM)
				{
				_aREstSOItemHistoryMaterialCBM=value;
				NotifyChanged("AREstSOItemHistoryMaterialCBM");
				}
			}
		}
		public double AREstSOItemHistoryOnProductionQty
		{
			get{return _aREstSOItemHistoryOnProductionQty;}
			set
			{
				if (value != this._aREstSOItemHistoryOnProductionQty)
				{
				_aREstSOItemHistoryOnProductionQty=value;
				NotifyChanged("AREstSOItemHistoryOnProductionQty");
				}
			}
		}
		public double AREstSOItemHistoryOnWOQty
		{
			get{return _aREstSOItemHistoryOnWOQty;}
			set
			{
				if (value != this._aREstSOItemHistoryOnWOQty)
				{
				_aREstSOItemHistoryOnWOQty=value;
				NotifyChanged("AREstSOItemHistoryOnWOQty");
				}
			}
		}
		public double AREstSOItemHistoryFinishQty
		{
			get{return _aREstSOItemHistoryFinishQty;}
			set
			{
				if (value != this._aREstSOItemHistoryFinishQty)
				{
				_aREstSOItemHistoryFinishQty=value;
				NotifyChanged("AREstSOItemHistoryFinishQty");
				}
			}
		}
		public double AREstSOItemHistoryUnitPkgCBM
		{
			get{return _aREstSOItemHistoryUnitPkgCBM;}
			set
			{
				if (value != this._aREstSOItemHistoryUnitPkgCBM)
				{
				_aREstSOItemHistoryUnitPkgCBM=value;
				NotifyChanged("AREstSOItemHistoryUnitPkgCBM");
				}
			}
		}
		public double AREstSOItemHistoryPkgCBM
		{
			get{return _aREstSOItemHistoryPkgCBM;}
			set
			{
				if (value != this._aREstSOItemHistoryPkgCBM)
				{
				_aREstSOItemHistoryPkgCBM=value;
				NotifyChanged("AREstSOItemHistoryPkgCBM");
				}
			}
		}
		public double AREstSOItemHistoryRNTSQty
		{
			get{return _aREstSOItemHistoryRNTSQty;}
			set
			{
				if (value != this._aREstSOItemHistoryRNTSQty)
				{
				_aREstSOItemHistoryRNTSQty=value;
				NotifyChanged("AREstSOItemHistoryRNTSQty");
				}
			}
		}
		public double AREstSOItemHistoryOldQty
		{
			get{return _aREstSOItemHistoryOldQty;}
			set
			{
				if (value != this._aREstSOItemHistoryOldQty)
				{
				_aREstSOItemHistoryOldQty=value;
				NotifyChanged("AREstSOItemHistoryOldQty");
				}
			}
		}
		public double AREstSOItemHistoryOldPriority
		{
			get{return _aREstSOItemHistoryOldPriority;}
			set
			{
				if (value != this._aREstSOItemHistoryOldPriority)
				{
				_aREstSOItemHistoryOldPriority=value;
				NotifyChanged("AREstSOItemHistoryOldPriority");
				}
			}
		}
		public double AREstSOItemHistoryOldSaleQty
		{
			get{return _aREstSOItemHistoryOldSaleQty;}
			set
			{
				if (value != this._aREstSOItemHistoryOldSaleQty)
				{
				_aREstSOItemHistoryOldSaleQty=value;
				NotifyChanged("AREstSOItemHistoryOldSaleQty");
				}
			}
		}
		public double AREstSOItemHistoryOldMinStock
		{
			get{return _aREstSOItemHistoryOldMinStock;}
			set
			{
				if (value != this._aREstSOItemHistoryOldMinStock)
				{
				_aREstSOItemHistoryOldMinStock=value;
				NotifyChanged("AREstSOItemHistoryOldMinStock");
				}
			}
		}
		public double AREstSOItemHistoryOldInvActual
		{
			get{return _aREstSOItemHistoryOldInvActual;}
			set
			{
				if (value != this._aREstSOItemHistoryOldInvActual)
				{
				_aREstSOItemHistoryOldInvActual=value;
				NotifyChanged("AREstSOItemHistoryOldInvActual");
				}
			}
		}
		public double AREstSOItemHistoryOldNTSQty
		{
			get{return _aREstSOItemHistoryOldNTSQty;}
			set
			{
				if (value != this._aREstSOItemHistoryOldNTSQty)
				{
				_aREstSOItemHistoryOldNTSQty=value;
				NotifyChanged("AREstSOItemHistoryOldNTSQty");
				}
			}
		}
		public double AREstSOItemHistoryOldATSQty
		{
			get{return _aREstSOItemHistoryOldATSQty;}
			set
			{
				if (value != this._aREstSOItemHistoryOldATSQty)
				{
				_aREstSOItemHistoryOldATSQty=value;
				NotifyChanged("AREstSOItemHistoryOldATSQty");
				}
			}
		}
		public double AREstSOItemHistoryOldATSPct
		{
			get{return _aREstSOItemHistoryOldATSPct;}
			set
			{
				if (value != this._aREstSOItemHistoryOldATSPct)
				{
				_aREstSOItemHistoryOldATSPct=value;
				NotifyChanged("AREstSOItemHistoryOldATSPct");
				}
			}
		}
		public int AREstSOItemHistoryOldATSCnt
		{
			get{return _aREstSOItemHistoryOldATSCnt;}
			set
			{
				if (value != this._aREstSOItemHistoryOldATSCnt)
				{
				_aREstSOItemHistoryOldATSCnt=value;
				NotifyChanged("AREstSOItemHistoryOldATSCnt");
				}
			}
		}
		public double AREstSOItemHistoryOldHTSQty
		{
			get{return _aREstSOItemHistoryOldHTSQty;}
			set
			{
				if (value != this._aREstSOItemHistoryOldHTSQty)
				{
				_aREstSOItemHistoryOldHTSQty=value;
				NotifyChanged("AREstSOItemHistoryOldHTSQty");
				}
			}
		}
		public double AREstSOItemHistoryOldHTSPct
		{
			get{return _aREstSOItemHistoryOldHTSPct;}
			set
			{
				if (value != this._aREstSOItemHistoryOldHTSPct)
				{
				_aREstSOItemHistoryOldHTSPct=value;
				NotifyChanged("AREstSOItemHistoryOldHTSPct");
				}
			}
		}
		public double AREstSOItemHistoryOldMinShpQty
		{
			get{return _aREstSOItemHistoryOldMinShpQty;}
			set
			{
				if (value != this._aREstSOItemHistoryOldMinShpQty)
				{
				_aREstSOItemHistoryOldMinShpQty=value;
				NotifyChanged("AREstSOItemHistoryOldMinShpQty");
				}
			}
		}
		public double AREstSOItemHistoryOldModifyCnt
		{
			get{return _aREstSOItemHistoryOldModifyCnt;}
			set
			{
				if (value != this._aREstSOItemHistoryOldModifyCnt)
				{
				_aREstSOItemHistoryOldModifyCnt=value;
				NotifyChanged("AREstSOItemHistoryOldModifyCnt");
				}
			}
		}
		public double AREstSOItemHistoryOldUnitPrice
		{
			get{return _aREstSOItemHistoryOldUnitPrice;}
			set
			{
				if (value != this._aREstSOItemHistoryOldUnitPrice)
				{
				_aREstSOItemHistoryOldUnitPrice=value;
				NotifyChanged("AREstSOItemHistoryOldUnitPrice");
				}
			}
		}
		public double AREstSOItemHistoryOldTotalPrice
		{
			get{return _aREstSOItemHistoryOldTotalPrice;}
			set
			{
				if (value != this._aREstSOItemHistoryOldTotalPrice)
				{
				_aREstSOItemHistoryOldTotalPrice=value;
				NotifyChanged("AREstSOItemHistoryOldTotalPrice");
				}
			}
		}
		public double AREstSOItemHistoryOldUnitMaterialCBM
		{
			get{return _aREstSOItemHistoryOldUnitMaterialCBM;}
			set
			{
				if (value != this._aREstSOItemHistoryOldUnitMaterialCBM)
				{
				_aREstSOItemHistoryOldUnitMaterialCBM=value;
				NotifyChanged("AREstSOItemHistoryOldUnitMaterialCBM");
				}
			}
		}
		public double AREstSOItemHistoryOldMaterialCBM
		{
			get{return _aREstSOItemHistoryOldMaterialCBM;}
			set
			{
				if (value != this._aREstSOItemHistoryOldMaterialCBM)
				{
				_aREstSOItemHistoryOldMaterialCBM=value;
				NotifyChanged("AREstSOItemHistoryOldMaterialCBM");
				}
			}
		}
		public double AREstSOItemHistoryOldOnProductionQty
		{
			get{return _aREstSOItemHistoryOldOnProductionQty;}
			set
			{
				if (value != this._aREstSOItemHistoryOldOnProductionQty)
				{
				_aREstSOItemHistoryOldOnProductionQty=value;
				NotifyChanged("AREstSOItemHistoryOldOnProductionQty");
				}
			}
		}
		public double AREstSOItemHistoryOldOnWOQty
		{
			get{return _aREstSOItemHistoryOldOnWOQty;}
			set
			{
				if (value != this._aREstSOItemHistoryOldOnWOQty)
				{
				_aREstSOItemHistoryOldOnWOQty=value;
				NotifyChanged("AREstSOItemHistoryOldOnWOQty");
				}
			}
		}
		public double AREstSOItemHistoryOldFinishQty
		{
			get{return _aREstSOItemHistoryOldFinishQty;}
			set
			{
				if (value != this._aREstSOItemHistoryOldFinishQty)
				{
				_aREstSOItemHistoryOldFinishQty=value;
				NotifyChanged("AREstSOItemHistoryOldFinishQty");
				}
			}
		}
		public double AREstSOItemHistoryOldUnitPkgCBM
		{
			get{return _aREstSOItemHistoryOldUnitPkgCBM;}
			set
			{
				if (value != this._aREstSOItemHistoryOldUnitPkgCBM)
				{
				_aREstSOItemHistoryOldUnitPkgCBM=value;
				NotifyChanged("AREstSOItemHistoryOldUnitPkgCBM");
				}
			}
		}
		public double AREstSOItemHistoryOldPkgCBM
		{
			get{return _aREstSOItemHistoryOldPkgCBM;}
			set
			{
				if (value != this._aREstSOItemHistoryOldPkgCBM)
				{
				_aREstSOItemHistoryOldPkgCBM=value;
				NotifyChanged("AREstSOItemHistoryOldPkgCBM");
				}
			}
		}
		public double AREstSOItemHistoryOldRNTSQty
		{
			get{return _aREstSOItemHistoryOldRNTSQty;}
			set
			{
				if (value != this._aREstSOItemHistoryOldRNTSQty)
				{
				_aREstSOItemHistoryOldRNTSQty=value;
				NotifyChanged("AREstSOItemHistoryOldRNTSQty");
				}
			}
		}
		public Nullable<DateTime> AREstSOItemHistoryDate
		{
			get{return _aREstSOItemHistoryDate;}
			set
			{
				if (value != this._aREstSOItemHistoryDate)
				{
				_aREstSOItemHistoryDate=value;
				NotifyChanged("AREstSOItemHistoryDate");
				}
			}
		}
		#endregion
	}
	#endregion
}