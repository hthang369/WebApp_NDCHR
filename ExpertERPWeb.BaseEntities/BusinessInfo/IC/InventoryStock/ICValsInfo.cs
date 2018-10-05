 using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region ICVals
    //-----------------------------------------------------------
    //Generated By: SQLDBTools.NET - LINHCLH (v2.0.15)
    //Class: ICValsInfo
    //Created Date: Tuesday, 11 Jul 2017
    //-----------------------------------------------------------

    public class ICValsInfo : BusinessObject
    {
        public ICValsInfo()
        {
        }
        #region Variables
		protected int _iCValID;
		protected int _fK_ICProductID;
		protected double _iCValBegQty;
		protected double _iCValBegAmtTot;
		protected double _iCValShpQty;
		protected double _iCValRcpQty;
		protected double _iCValRcpCostTot;
		protected double _iCValEndQty;
		protected int _iCPeriod;
		protected int _iCYear;
		protected double _iCValShpCostTot;
		protected double _iCValEndAmtTot;
		protected double _iCValUnitCost;
		protected int _fK_ICStockID;
		protected int _fK_PPPhaseCfgID;
		protected int _fK_ICProductGroupID;
		protected int _fK_ICBrandID;
		protected double _iCValSaleQty;
		protected double _iCValSaleAmtTot;
		protected double _iCValSupRetQty;
		protected double _iCValProShpQty;
		protected double _iCValTranShpQty;
		protected double _iCValOtherShpQty;
		protected double _iCValCustRetRcpQty;
		protected double _iCValImportRcpQty;
		protected double _iCValTranRcpQty;
		protected double _iCValProductUnitCost;
		protected double _iCValProductCostAmtTot;
		protected double _iCValProductFUnitCost;
		protected double _iCValShpFCostTot;
		protected double _iCValRcpFCostTot;
		protected double _iCValEndFAmtTot;
		protected double _iCValBegFAmtTot;
		protected double _iCValProductFCostAmtTot;
		protected double _iCValFUnitCost;
		protected int _fK_ICStockTypeID;
		
        #endregion

        #region Public properties
		public int ICValID
		{
			get { return _iCValID; }
			set
			{
				if (value != this._iCValID)
				{
					_iCValID = value;
					NotifyChanged("ICValID");
				}
			}
		}
		public int FK_ICProductID
		{
			get { return _fK_ICProductID; }
			set
			{
				if (value != this._fK_ICProductID)
				{
					_fK_ICProductID = value;
					NotifyChanged("FK_ICProductID");
				}
			}
		}
		public double ICValBegQty
		{
			get { return _iCValBegQty; }
			set
			{
				if (value != this._iCValBegQty)
				{
					_iCValBegQty = value;
					NotifyChanged("ICValBegQty");
				}
			}
		}
		public double ICValBegAmtTot
		{
			get { return _iCValBegAmtTot; }
			set
			{
				if (value != this._iCValBegAmtTot)
				{
					_iCValBegAmtTot = value;
					NotifyChanged("ICValBegAmtTot");
				}
			}
		}
		public double ICValShpQty
		{
			get { return _iCValShpQty; }
			set
			{
				if (value != this._iCValShpQty)
				{
					_iCValShpQty = value;
					NotifyChanged("ICValShpQty");
				}
			}
		}
		public double ICValRcpQty
		{
			get { return _iCValRcpQty; }
			set
			{
				if (value != this._iCValRcpQty)
				{
					_iCValRcpQty = value;
					NotifyChanged("ICValRcpQty");
				}
			}
		}
		public double ICValRcpCostTot
		{
			get { return _iCValRcpCostTot; }
			set
			{
				if (value != this._iCValRcpCostTot)
				{
					_iCValRcpCostTot = value;
					NotifyChanged("ICValRcpCostTot");
				}
			}
		}
		public double ICValEndQty
		{
			get { return _iCValEndQty; }
			set
			{
				if (value != this._iCValEndQty)
				{
					_iCValEndQty = value;
					NotifyChanged("ICValEndQty");
				}
			}
		}
		public int ICPeriod
		{
			get { return _iCPeriod; }
			set
			{
				if (value != this._iCPeriod)
				{
					_iCPeriod = value;
					NotifyChanged("ICPeriod");
				}
			}
		}
		public int ICYear
		{
			get { return _iCYear; }
			set
			{
				if (value != this._iCYear)
				{
					_iCYear = value;
					NotifyChanged("ICYear");
				}
			}
		}
		public double ICValShpCostTot
		{
			get { return _iCValShpCostTot; }
			set
			{
				if (value != this._iCValShpCostTot)
				{
					_iCValShpCostTot = value;
					NotifyChanged("ICValShpCostTot");
				}
			}
		}
		public double ICValEndAmtTot
		{
			get { return _iCValEndAmtTot; }
			set
			{
				if (value != this._iCValEndAmtTot)
				{
					_iCValEndAmtTot = value;
					NotifyChanged("ICValEndAmtTot");
				}
			}
		}
		public double ICValUnitCost
		{
			get { return _iCValUnitCost; }
			set
			{
				if (value != this._iCValUnitCost)
				{
					_iCValUnitCost = value;
					NotifyChanged("ICValUnitCost");
				}
			}
		}
		public int FK_ICStockID
		{
			get { return _fK_ICStockID; }
			set
			{
				if (value != this._fK_ICStockID)
				{
					_fK_ICStockID = value;
					NotifyChanged("FK_ICStockID");
				}
			}
		}
		public int FK_PPPhaseCfgID
		{
			get { return _fK_PPPhaseCfgID; }
			set
			{
				if (value != this._fK_PPPhaseCfgID)
				{
					_fK_PPPhaseCfgID = value;
					NotifyChanged("FK_PPPhaseCfgID");
				}
			}
		}
		public int FK_ICProductGroupID
		{
			get { return _fK_ICProductGroupID; }
			set
			{
				if (value != this._fK_ICProductGroupID)
				{
					_fK_ICProductGroupID = value;
					NotifyChanged("FK_ICProductGroupID");
				}
			}
		}
		public int FK_ICBrandID
		{
			get { return _fK_ICBrandID; }
			set
			{
				if (value != this._fK_ICBrandID)
				{
					_fK_ICBrandID = value;
					NotifyChanged("FK_ICBrandID");
				}
			}
		}
		public double ICValSaleQty
		{
			get { return _iCValSaleQty; }
			set
			{
				if (value != this._iCValSaleQty)
				{
					_iCValSaleQty = value;
					NotifyChanged("ICValSaleQty");
				}
			}
		}
		public double ICValSaleAmtTot
		{
			get { return _iCValSaleAmtTot; }
			set
			{
				if (value != this._iCValSaleAmtTot)
				{
					_iCValSaleAmtTot = value;
					NotifyChanged("ICValSaleAmtTot");
				}
			}
		}
		public double ICValSupRetQty
		{
			get { return _iCValSupRetQty; }
			set
			{
				if (value != this._iCValSupRetQty)
				{
					_iCValSupRetQty = value;
					NotifyChanged("ICValSupRetQty");
				}
			}
		}
		public double ICValProShpQty
		{
			get { return _iCValProShpQty; }
			set
			{
				if (value != this._iCValProShpQty)
				{
					_iCValProShpQty = value;
					NotifyChanged("ICValProShpQty");
				}
			}
		}
		public double ICValTranShpQty
		{
			get { return _iCValTranShpQty; }
			set
			{
				if (value != this._iCValTranShpQty)
				{
					_iCValTranShpQty = value;
					NotifyChanged("ICValTranShpQty");
				}
			}
		}
		public double ICValOtherShpQty
		{
			get { return _iCValOtherShpQty; }
			set
			{
				if (value != this._iCValOtherShpQty)
				{
					_iCValOtherShpQty = value;
					NotifyChanged("ICValOtherShpQty");
				}
			}
		}
		public double ICValCustRetRcpQty
		{
			get { return _iCValCustRetRcpQty; }
			set
			{
				if (value != this._iCValCustRetRcpQty)
				{
					_iCValCustRetRcpQty = value;
					NotifyChanged("ICValCustRetRcpQty");
				}
			}
		}
		public double ICValImportRcpQty
		{
			get { return _iCValImportRcpQty; }
			set
			{
				if (value != this._iCValImportRcpQty)
				{
					_iCValImportRcpQty = value;
					NotifyChanged("ICValImportRcpQty");
				}
			}
		}
		public double ICValTranRcpQty
		{
			get { return _iCValTranRcpQty; }
			set
			{
				if (value != this._iCValTranRcpQty)
				{
					_iCValTranRcpQty = value;
					NotifyChanged("ICValTranRcpQty");
				}
			}
		}
		public double ICValProductUnitCost
		{
			get { return _iCValProductUnitCost; }
			set
			{
				if (value != this._iCValProductUnitCost)
				{
					_iCValProductUnitCost = value;
					NotifyChanged("ICValProductUnitCost");
				}
			}
		}
		public double ICValProductCostAmtTot
		{
			get { return _iCValProductCostAmtTot; }
			set
			{
				if (value != this._iCValProductCostAmtTot)
				{
					_iCValProductCostAmtTot = value;
					NotifyChanged("ICValProductCostAmtTot");
				}
			}
		}
		public double ICValProductFUnitCost
		{
			get { return _iCValProductFUnitCost; }
			set
			{
				if (value != this._iCValProductFUnitCost)
				{
					_iCValProductFUnitCost = value;
					NotifyChanged("ICValProductFUnitCost");
				}
			}
		}
		public double ICValShpFCostTot
		{
			get { return _iCValShpFCostTot; }
			set
			{
				if (value != this._iCValShpFCostTot)
				{
					_iCValShpFCostTot = value;
					NotifyChanged("ICValShpFCostTot");
				}
			}
		}
		public double ICValRcpFCostTot
		{
			get { return _iCValRcpFCostTot; }
			set
			{
				if (value != this._iCValRcpFCostTot)
				{
					_iCValRcpFCostTot = value;
					NotifyChanged("ICValRcpFCostTot");
				}
			}
		}
		public double ICValEndFAmtTot
		{
			get { return _iCValEndFAmtTot; }
			set
			{
				if (value != this._iCValEndFAmtTot)
				{
					_iCValEndFAmtTot = value;
					NotifyChanged("ICValEndFAmtTot");
				}
			}
		}
		public double ICValBegFAmtTot
		{
			get { return _iCValBegFAmtTot; }
			set
			{
				if (value != this._iCValBegFAmtTot)
				{
					_iCValBegFAmtTot = value;
					NotifyChanged("ICValBegFAmtTot");
				}
			}
		}
		public double ICValProductFCostAmtTot
		{
			get { return _iCValProductFCostAmtTot; }
			set
			{
				if (value != this._iCValProductFCostAmtTot)
				{
					_iCValProductFCostAmtTot = value;
					NotifyChanged("ICValProductFCostAmtTot");
				}
			}
		}
		public double ICValFUnitCost
		{
			get { return _iCValFUnitCost; }
			set
			{
				if (value != this._iCValFUnitCost)
				{
					_iCValFUnitCost = value;
					NotifyChanged("ICValFUnitCost");
				}
			}
		}
		public int FK_ICStockTypeID
		{
			get { return _fK_ICStockTypeID; }
			set
			{
				if (value != this._fK_ICStockTypeID)
				{
					_fK_ICStockTypeID = value;
					NotifyChanged("FK_ICStockTypeID");
				}
			}
		}
		
        #endregion
    }
    #endregion
}