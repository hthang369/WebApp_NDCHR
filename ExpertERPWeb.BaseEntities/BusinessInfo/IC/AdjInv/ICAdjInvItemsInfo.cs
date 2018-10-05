
using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region ICAdjInvItems
    //-----------------------------------------------------------
    //Generated By: SQLDBTools - LINHCLH (v2.1.78)
    //Class: ICAdjInvItemsInfo
    //Created Date: Tuesday, 18 Oct 2016
    //-----------------------------------------------------------

    public class ICAdjInvItemsInfo : BusinessObject
    {
        public ICAdjInvItemsInfo()
        {
        }
        #region Variables
		protected int _iCAdjInvItemID;
		protected String _aAStatus = DefaultAAStatus;
		protected int _fK_ICAdjInvID;
		protected int _fK_ICProductID;
		protected String _iCAdjInvItemProductType = String.Empty;
		protected String _iCAdjInvItemTypeCombo = String.Empty;
		protected String _iCAdjInvItemProductSerialNo = String.Empty;
		protected String _iCAdjInvItemProductDesc = String.Empty;
		protected double _iCAdjInvItemOldQty;
		protected double _iCAdjInvItemNewQty;
		protected String _iCAdjInvItemComment = String.Empty;
		protected int _fK_ICStockID;
		protected double _iCAdjInvItemVolume;
		protected double _iCAdjInvItemQty;
		protected String _iCAdjInvItemLotNo = String.Empty;
		protected double _iCAdjInvItemStkQty;
		protected int _fK_ICStockUOMID;
		protected String _iCAdjInvItemUOM = String.Empty;
		protected double _iCAdjInvItemAllocateQty;
		protected bool _iCAdjInvItemIsValidInv = true;
		protected String _iCPackageLockTypeCombo = String.Empty;
		protected int _fK_GLDebitAccountID;
		protected int _fK_GLCreditAccountID;
		protected double _iCAdjInvItemCostTot;
		protected String _iCAdjInvItemDesc = String.Empty;
		protected double _iCAdjInvItemUnitCost;
		protected int _fK_ICStkUOMID;
		protected int _fK_ICUOMID;
		protected double _iCAdjInvItemRQty;
		protected double _iCAdjInvItemRStkQty;
		protected int _fK_ICWeightUOMID;
		protected int _fK_ICVolumeUOMID;
		protected double _iCAdjInvItemWTot;
		protected double _iCAdjInvItemVTot;
		protected double _iCAdjInvItemFact;
		protected String _gLTOF01Combo = String.Empty;
		protected String _gLTOF02Combo = String.Empty;
		protected String _gLTOF03Combo = String.Empty;
		protected String _gLTOF04Combo = String.Empty;
		protected String _gLTOF05Combo = String.Empty;
		protected String _gLTOF06Combo = String.Empty;
		protected String _gLTOF07Combo = String.Empty;
		protected String _gLTOF08Combo = String.Empty;
		protected String _gLTOF09Combo = String.Empty;
		protected String _gLTOF10Combo = String.Empty;
		protected int _fK_PPCostCenterID;
		protected double _iCAdjInvItemFCostTot;
		protected int _fK_ICStockSlotID;
		
        #endregion

        #region Public properties
		public int ICAdjInvItemID
		{
			get { return _iCAdjInvItemID; }
			set
			{
				if (value != this._iCAdjInvItemID)
				{
					_iCAdjInvItemID = value;
					NotifyChanged("ICAdjInvItemID");
				}
			}
		}
		public String AAStatus
		{
			get { return _aAStatus; }
			set
			{
				if (value != this._aAStatus)
				{
					_aAStatus = value;
					NotifyChanged("AAStatus");
				}
			}
		}
		public int FK_ICAdjInvID
		{
			get { return _fK_ICAdjInvID; }
			set
			{
				if (value != this._fK_ICAdjInvID)
				{
					_fK_ICAdjInvID = value;
					NotifyChanged("FK_ICAdjInvID");
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
		public String ICAdjInvItemProductType
		{
			get { return _iCAdjInvItemProductType; }
			set
			{
				if (value != this._iCAdjInvItemProductType)
				{
					_iCAdjInvItemProductType = value;
					NotifyChanged("ICAdjInvItemProductType");
				}
			}
		}
		public String ICAdjInvItemTypeCombo
		{
			get { return _iCAdjInvItemTypeCombo; }
			set
			{
				if (value != this._iCAdjInvItemTypeCombo)
				{
					_iCAdjInvItemTypeCombo = value;
					NotifyChanged("ICAdjInvItemTypeCombo");
				}
			}
		}
		public String ICAdjInvItemProductSerialNo
		{
			get { return _iCAdjInvItemProductSerialNo; }
			set
			{
				if (value != this._iCAdjInvItemProductSerialNo)
				{
					_iCAdjInvItemProductSerialNo = value;
					NotifyChanged("ICAdjInvItemProductSerialNo");
				}
			}
		}
		public String ICAdjInvItemProductDesc
		{
			get { return _iCAdjInvItemProductDesc; }
			set
			{
				if (value != this._iCAdjInvItemProductDesc)
				{
					_iCAdjInvItemProductDesc = value;
					NotifyChanged("ICAdjInvItemProductDesc");
				}
			}
		}
		public double ICAdjInvItemOldQty
		{
			get { return _iCAdjInvItemOldQty; }
			set
			{
				if (value != this._iCAdjInvItemOldQty)
				{
					_iCAdjInvItemOldQty = value;
					NotifyChanged("ICAdjInvItemOldQty");
				}
			}
		}
		public double ICAdjInvItemNewQty
		{
			get { return _iCAdjInvItemNewQty; }
			set
			{
				if (value != this._iCAdjInvItemNewQty)
				{
					_iCAdjInvItemNewQty = value;
					NotifyChanged("ICAdjInvItemNewQty");
				}
			}
		}
		public String ICAdjInvItemComment
		{
			get { return _iCAdjInvItemComment; }
			set
			{
				if (value != this._iCAdjInvItemComment)
				{
					_iCAdjInvItemComment = value;
					NotifyChanged("ICAdjInvItemComment");
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
		public double ICAdjInvItemVolume
		{
			get { return _iCAdjInvItemVolume; }
			set
			{
				if (value != this._iCAdjInvItemVolume)
				{
					_iCAdjInvItemVolume = value;
					NotifyChanged("ICAdjInvItemVolume");
				}
			}
		}
		public double ICAdjInvItemQty
		{
			get { return _iCAdjInvItemQty; }
			set
			{
				if (value != this._iCAdjInvItemQty)
				{
					_iCAdjInvItemQty = value;
					NotifyChanged("ICAdjInvItemQty");
				}
			}
		}
		public String ICAdjInvItemLotNo
		{
			get { return _iCAdjInvItemLotNo; }
			set
			{
				if (value != this._iCAdjInvItemLotNo)
				{
					_iCAdjInvItemLotNo = value;
					NotifyChanged("ICAdjInvItemLotNo");
				}
			}
		}
		public double ICAdjInvItemStkQty
		{
			get { return _iCAdjInvItemStkQty; }
			set
			{
				if (value != this._iCAdjInvItemStkQty)
				{
					_iCAdjInvItemStkQty = value;
					NotifyChanged("ICAdjInvItemStkQty");
				}
			}
		}
		public int FK_ICStockUOMID
		{
			get { return _fK_ICStockUOMID; }
			set
			{
				if (value != this._fK_ICStockUOMID)
				{
					_fK_ICStockUOMID = value;
					NotifyChanged("FK_ICStockUOMID");
				}
			}
		}
		public String ICAdjInvItemUOM
		{
			get { return _iCAdjInvItemUOM; }
			set
			{
				if (value != this._iCAdjInvItemUOM)
				{
					_iCAdjInvItemUOM = value;
					NotifyChanged("ICAdjInvItemUOM");
				}
			}
		}
		public double ICAdjInvItemAllocateQty
		{
			get { return _iCAdjInvItemAllocateQty; }
			set
			{
				if (value != this._iCAdjInvItemAllocateQty)
				{
					_iCAdjInvItemAllocateQty = value;
					NotifyChanged("ICAdjInvItemAllocateQty");
				}
			}
		}
		public bool ICAdjInvItemIsValidInv
		{
			get { return _iCAdjInvItemIsValidInv; }
			set
			{
				if (value != this._iCAdjInvItemIsValidInv)
				{
					_iCAdjInvItemIsValidInv = value;
					NotifyChanged("ICAdjInvItemIsValidInv");
				}
			}
		}
		public String ICPackageLockTypeCombo
		{
			get { return _iCPackageLockTypeCombo; }
			set
			{
				if (value != this._iCPackageLockTypeCombo)
				{
					_iCPackageLockTypeCombo = value;
					NotifyChanged("ICPackageLockTypeCombo");
				}
			}
		}
		public int FK_GLDebitAccountID
		{
			get { return _fK_GLDebitAccountID; }
			set
			{
				if (value != this._fK_GLDebitAccountID)
				{
					_fK_GLDebitAccountID = value;
					NotifyChanged("FK_GLDebitAccountID");
				}
			}
		}
		public int FK_GLCreditAccountID
		{
			get { return _fK_GLCreditAccountID; }
			set
			{
				if (value != this._fK_GLCreditAccountID)
				{
					_fK_GLCreditAccountID = value;
					NotifyChanged("FK_GLCreditAccountID");
				}
			}
		}
		public double ICAdjInvItemCostTot
		{
			get { return _iCAdjInvItemCostTot; }
			set
			{
				if (value != this._iCAdjInvItemCostTot)
				{
					_iCAdjInvItemCostTot = value;
					NotifyChanged("ICAdjInvItemCostTot");
				}
			}
		}
		public String ICAdjInvItemDesc
		{
			get { return _iCAdjInvItemDesc; }
			set
			{
				if (value != this._iCAdjInvItemDesc)
				{
					_iCAdjInvItemDesc = value;
					NotifyChanged("ICAdjInvItemDesc");
				}
			}
		}
		public double ICAdjInvItemUnitCost
		{
			get { return _iCAdjInvItemUnitCost; }
			set
			{
				if (value != this._iCAdjInvItemUnitCost)
				{
					_iCAdjInvItemUnitCost = value;
					NotifyChanged("ICAdjInvItemUnitCost");
				}
			}
		}
		public int FK_ICStkUOMID
		{
			get { return _fK_ICStkUOMID; }
			set
			{
				if (value != this._fK_ICStkUOMID)
				{
					_fK_ICStkUOMID = value;
					NotifyChanged("FK_ICStkUOMID");
				}
			}
		}
		public int FK_ICUOMID
		{
			get { return _fK_ICUOMID; }
			set
			{
				if (value != this._fK_ICUOMID)
				{
					_fK_ICUOMID = value;
					NotifyChanged("FK_ICUOMID");
				}
			}
		}
		public double ICAdjInvItemRQty
		{
			get { return _iCAdjInvItemRQty; }
			set
			{
				if (value != this._iCAdjInvItemRQty)
				{
					_iCAdjInvItemRQty = value;
					NotifyChanged("ICAdjInvItemRQty");
				}
			}
		}
		public double ICAdjInvItemRStkQty
		{
			get { return _iCAdjInvItemRStkQty; }
			set
			{
				if (value != this._iCAdjInvItemRStkQty)
				{
					_iCAdjInvItemRStkQty = value;
					NotifyChanged("ICAdjInvItemRStkQty");
				}
			}
		}
		public int FK_ICWeightUOMID
		{
			get { return _fK_ICWeightUOMID; }
			set
			{
				if (value != this._fK_ICWeightUOMID)
				{
					_fK_ICWeightUOMID = value;
					NotifyChanged("FK_ICWeightUOMID");
				}
			}
		}
		public int FK_ICVolumeUOMID
		{
			get { return _fK_ICVolumeUOMID; }
			set
			{
				if (value != this._fK_ICVolumeUOMID)
				{
					_fK_ICVolumeUOMID = value;
					NotifyChanged("FK_ICVolumeUOMID");
				}
			}
		}
		public double ICAdjInvItemWTot
		{
			get { return _iCAdjInvItemWTot; }
			set
			{
				if (value != this._iCAdjInvItemWTot)
				{
					_iCAdjInvItemWTot = value;
					NotifyChanged("ICAdjInvItemWTot");
				}
			}
		}
		public double ICAdjInvItemVTot
		{
			get { return _iCAdjInvItemVTot; }
			set
			{
				if (value != this._iCAdjInvItemVTot)
				{
					_iCAdjInvItemVTot = value;
					NotifyChanged("ICAdjInvItemVTot");
				}
			}
		}
		public double ICAdjInvItemFact
		{
			get { return _iCAdjInvItemFact; }
			set
			{
				if (value != this._iCAdjInvItemFact)
				{
					_iCAdjInvItemFact = value;
					NotifyChanged("ICAdjInvItemFact");
				}
			}
		}
		public String GLTOF01Combo
		{
			get { return _gLTOF01Combo; }
			set
			{
				if (value != this._gLTOF01Combo)
				{
					_gLTOF01Combo = value;
					NotifyChanged("GLTOF01Combo");
				}
			}
		}
		public String GLTOF02Combo
		{
			get { return _gLTOF02Combo; }
			set
			{
				if (value != this._gLTOF02Combo)
				{
					_gLTOF02Combo = value;
					NotifyChanged("GLTOF02Combo");
				}
			}
		}
		public String GLTOF03Combo
		{
			get { return _gLTOF03Combo; }
			set
			{
				if (value != this._gLTOF03Combo)
				{
					_gLTOF03Combo = value;
					NotifyChanged("GLTOF03Combo");
				}
			}
		}
		public String GLTOF04Combo
		{
			get { return _gLTOF04Combo; }
			set
			{
				if (value != this._gLTOF04Combo)
				{
					_gLTOF04Combo = value;
					NotifyChanged("GLTOF04Combo");
				}
			}
		}
		public String GLTOF05Combo
		{
			get { return _gLTOF05Combo; }
			set
			{
				if (value != this._gLTOF05Combo)
				{
					_gLTOF05Combo = value;
					NotifyChanged("GLTOF05Combo");
				}
			}
		}
		public String GLTOF06Combo
		{
			get { return _gLTOF06Combo; }
			set
			{
				if (value != this._gLTOF06Combo)
				{
					_gLTOF06Combo = value;
					NotifyChanged("GLTOF06Combo");
				}
			}
		}
		public String GLTOF07Combo
		{
			get { return _gLTOF07Combo; }
			set
			{
				if (value != this._gLTOF07Combo)
				{
					_gLTOF07Combo = value;
					NotifyChanged("GLTOF07Combo");
				}
			}
		}
		public String GLTOF08Combo
		{
			get { return _gLTOF08Combo; }
			set
			{
				if (value != this._gLTOF08Combo)
				{
					_gLTOF08Combo = value;
					NotifyChanged("GLTOF08Combo");
				}
			}
		}
		public String GLTOF09Combo
		{
			get { return _gLTOF09Combo; }
			set
			{
				if (value != this._gLTOF09Combo)
				{
					_gLTOF09Combo = value;
					NotifyChanged("GLTOF09Combo");
				}
			}
		}
		public String GLTOF10Combo
		{
			get { return _gLTOF10Combo; }
			set
			{
				if (value != this._gLTOF10Combo)
				{
					_gLTOF10Combo = value;
					NotifyChanged("GLTOF10Combo");
				}
			}
		}
		public int FK_PPCostCenterID
		{
			get { return _fK_PPCostCenterID; }
			set
			{
				if (value != this._fK_PPCostCenterID)
				{
					_fK_PPCostCenterID = value;
					NotifyChanged("FK_PPCostCenterID");
				}
			}
		}
		public double ICAdjInvItemFCostTot
		{
			get { return _iCAdjInvItemFCostTot; }
			set
			{
				if (value != this._iCAdjInvItemFCostTot)
				{
					_iCAdjInvItemFCostTot = value;
					NotifyChanged("ICAdjInvItemFCostTot");
				}
			}
		}
		public int FK_ICStockSlotID
		{
			get { return _fK_ICStockSlotID; }
			set
			{
				if (value != this._fK_ICStockSlotID)
				{
					_fK_ICStockSlotID = value;
					NotifyChanged("FK_ICStockSlotID");
				}
			}
		}
		
        #endregion
    }
    #endregion
}