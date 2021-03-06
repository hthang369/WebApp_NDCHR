using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region GLEquipmentDecreaseItems
    //-----------------------------------------------------------
    //Generated By: SQLDBTools - LINHCLH
    //Class: GLEquipmentDecreaseItemsInfo
    //Created Date: 02 Jan 2009
    //-----------------------------------------------------------

    public class GLEquipmentDecreaseItemsInfo : BusinessObject
    {
        public GLEquipmentDecreaseItemsInfo()
        {
        }
        #region Variables
		protected int _gLEquipmentDecreaseItemID;
		protected String _aAStatus=DefaultAAStatus;
		protected String _iCShipmentNo=String.Empty;
		protected double _gLEquipmentDecreaseItemShipAmt;
		protected double _gLEquipmentDecreaseItemLife;
		protected double _gLEquipmentDecreaseItemAmt;
		protected double _gLEquipmentDecreaseItemRAmt;
		protected double _gLEquipmentRLife;
		protected int _fK_HRDeparmentID;
		protected int _fK_ICProductID;
		protected int _gLEquipmentDecreaseItemQty;
		protected DateTime _gLEquipmentDecreaseItemDate=DateTime.Now;
		protected double _gLEquipmentDecreaseItemReturnAmt;
		protected String _gLEquipmentDecreaseItemTypeCombo=String.Empty;
		protected String _gLEquipmentAllocateStatus=DefaultStatus;
		protected int _fK_GLEquipmentDecreaseID;
		protected int _fK_GLEquipmentAllocateID;
		protected String _gLEquipmentDecreaseItemDesc=String.Empty;
		protected double _gLEquipmentDecreaseItemFAmt;
		protected double _gLEquipmentDecreaseItemRFAmt;
		protected int _gLEquipmentDecreaseItemRQty;
		protected int _fK_GLDebitAccountID;
		
        #endregion

        #region Public properties
		public int GLEquipmentDecreaseItemID
		{
			get{return _gLEquipmentDecreaseItemID;}
			set
			{
				if (value != this._gLEquipmentDecreaseItemID)
				{
					_gLEquipmentDecreaseItemID=value;
					NotifyChanged("GLEquipmentDecreaseItemID");
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
		public String ICShipmentNo
		{
			get{return _iCShipmentNo;}
			set
			{
				if (value != this._iCShipmentNo)
				{
					_iCShipmentNo=value;
					NotifyChanged("ICShipmentNo");
				}
			}
		}
		public double GLEquipmentDecreaseItemShipAmt
		{
			get{return _gLEquipmentDecreaseItemShipAmt;}
			set
			{
				if (value != this._gLEquipmentDecreaseItemShipAmt)
				{
					_gLEquipmentDecreaseItemShipAmt=value;
					NotifyChanged("GLEquipmentDecreaseItemShipAmt");
				}
			}
		}
		public double GLEquipmentDecreaseItemLife
		{
			get{return _gLEquipmentDecreaseItemLife;}
			set
			{
				if (value != this._gLEquipmentDecreaseItemLife)
				{
					_gLEquipmentDecreaseItemLife=value;
					NotifyChanged("GLEquipmentDecreaseItemLife");
				}
			}
		}
		public double GLEquipmentDecreaseItemAmt
		{
			get{return _gLEquipmentDecreaseItemAmt;}
			set
			{
				if (value != this._gLEquipmentDecreaseItemAmt)
				{
					_gLEquipmentDecreaseItemAmt=value;
					NotifyChanged("GLEquipmentDecreaseItemAmt");
				}
			}
		}
		public double GLEquipmentDecreaseItemRAmt
		{
			get{return _gLEquipmentDecreaseItemRAmt;}
			set
			{
				if (value != this._gLEquipmentDecreaseItemRAmt)
				{
					_gLEquipmentDecreaseItemRAmt=value;
					NotifyChanged("GLEquipmentDecreaseItemRAmt");
				}
			}
		}
		public double GLEquipmentRLife
		{
			get{return _gLEquipmentRLife;}
			set
			{
				if (value != this._gLEquipmentRLife)
				{
					_gLEquipmentRLife=value;
					NotifyChanged("GLEquipmentRLife");
				}
			}
		}
		public int FK_HRDeparmentID
		{
			get{return _fK_HRDeparmentID;}
			set
			{
				if (value != this._fK_HRDeparmentID)
				{
					_fK_HRDeparmentID=value;
					NotifyChanged("FK_HRDeparmentID");
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
		public int GLEquipmentDecreaseItemQty
		{
			get{return _gLEquipmentDecreaseItemQty;}
			set
			{
				if (value != this._gLEquipmentDecreaseItemQty)
				{
					_gLEquipmentDecreaseItemQty=value;
					NotifyChanged("GLEquipmentDecreaseItemQty");
				}
			}
		}
		public DateTime GLEquipmentDecreaseItemDate
		{
			get{return _gLEquipmentDecreaseItemDate;}
			set
			{
				if (value != this._gLEquipmentDecreaseItemDate)
				{
					_gLEquipmentDecreaseItemDate=value;
					NotifyChanged("GLEquipmentDecreaseItemDate");
				}
			}
		}
		public double GLEquipmentDecreaseItemReturnAmt
		{
			get{return _gLEquipmentDecreaseItemReturnAmt;}
			set
			{
				if (value != this._gLEquipmentDecreaseItemReturnAmt)
				{
					_gLEquipmentDecreaseItemReturnAmt=value;
					NotifyChanged("GLEquipmentDecreaseItemReturnAmt");
				}
			}
		}
		public String GLEquipmentDecreaseItemTypeCombo
		{
			get{return _gLEquipmentDecreaseItemTypeCombo;}
			set
			{
				if (value != this._gLEquipmentDecreaseItemTypeCombo)
				{
					_gLEquipmentDecreaseItemTypeCombo=value;
					NotifyChanged("GLEquipmentDecreaseItemTypeCombo");
				}
			}
		}
		public String GLEquipmentAllocateStatus
		{
			get{return _gLEquipmentAllocateStatus;}
			set
			{
				if (value != this._gLEquipmentAllocateStatus)
				{
					_gLEquipmentAllocateStatus=value;
					NotifyChanged("GLEquipmentAllocateStatus");
				}
			}
		}
		public int FK_GLEquipmentDecreaseID
		{
			get{return _fK_GLEquipmentDecreaseID;}
			set
			{
				if (value != this._fK_GLEquipmentDecreaseID)
				{
					_fK_GLEquipmentDecreaseID=value;
					NotifyChanged("FK_GLEquipmentDecreaseID");
				}
			}
		}
		public int FK_GLEquipmentAllocateID
		{
			get{return _fK_GLEquipmentAllocateID;}
			set
			{
				if (value != this._fK_GLEquipmentAllocateID)
				{
					_fK_GLEquipmentAllocateID=value;
					NotifyChanged("FK_GLEquipmentAllocateID");
				}
			}
		}
		public String GLEquipmentDecreaseItemDesc
		{
			get{return _gLEquipmentDecreaseItemDesc;}
			set
			{
				if (value != this._gLEquipmentDecreaseItemDesc)
				{
					_gLEquipmentDecreaseItemDesc=value;
					NotifyChanged("GLEquipmentDecreaseItemDesc");
				}
			}
		}
		public double GLEquipmentDecreaseItemFAmt
		{
			get{return _gLEquipmentDecreaseItemFAmt;}
			set
			{
				if (value != this._gLEquipmentDecreaseItemFAmt)
				{
					_gLEquipmentDecreaseItemFAmt=value;
					NotifyChanged("GLEquipmentDecreaseItemFAmt");
				}
			}
		}
		public double GLEquipmentDecreaseItemRFAmt
		{
			get{return _gLEquipmentDecreaseItemRFAmt;}
			set
			{
				if (value != this._gLEquipmentDecreaseItemRFAmt)
				{
					_gLEquipmentDecreaseItemRFAmt=value;
					NotifyChanged("GLEquipmentDecreaseItemRFAmt");
				}
			}
		}
		public int GLEquipmentDecreaseItemRQty
		{
			get{return _gLEquipmentDecreaseItemRQty;}
			set
			{
				if (value != this._gLEquipmentDecreaseItemRQty)
				{
					_gLEquipmentDecreaseItemRQty=value;
					NotifyChanged("GLEquipmentDecreaseItemRQty");
				}
			}
		}
		public int FK_GLDebitAccountID
		{
			get{return _fK_GLDebitAccountID;}
			set
			{
				if (value != this._fK_GLDebitAccountID)
				{
					_fK_GLDebitAccountID=value;
					NotifyChanged("FK_GLDebitAccountID");
				}
			}
		}
		
        #endregion
    }
    #endregion
}