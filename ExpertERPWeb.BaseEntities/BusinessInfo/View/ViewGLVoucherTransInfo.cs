using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ViewGLVoucherTrans
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ViewGLVoucherTransInfo
	//Created Date:29 Tháng Mười Hai 2012
	//-----------------------------------------------------------
	
	public class ViewGLVoucherTransInfo:BusinessObject
	{
		public ViewGLVoucherTransInfo()
		{
		}
		#region Variables
		protected int _viewGLVoucherTranID;
		protected String _aAStatus=DefaultAAStatus;
		protected int _fK_GLVoucherID;
		protected String _viewGLVoucherTranPayToName=String.Empty;
		protected String _viewGLTranPayToDesc=String.Empty;
		protected String _viewGLOutTranDesc=String.Empty;
		protected double _viewGLTranAmt;
		protected String _viewGLAccountNoCredit=String.Empty;
		protected String _viewGLAccountNoDebit=String.Empty;
		#endregion

		#region Public properties
		public int ViewGLVoucherTranID
		{
			get{return _viewGLVoucherTranID;}
			set
			{
				if (value != this._viewGLVoucherTranID)
				{
				_viewGLVoucherTranID=value;
				NotifyChanged("ViewGLVoucherTranID");
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
		public int FK_GLVoucherID
		{
			get{return _fK_GLVoucherID;}
			set
			{
				if (value != this._fK_GLVoucherID)
				{
				_fK_GLVoucherID=value;
				NotifyChanged("FK_GLVoucherID");
				}
			}
		}
		public String ViewGLVoucherTranPayToName
		{
			get{return _viewGLVoucherTranPayToName;}
			set
			{
				if (value != this._viewGLVoucherTranPayToName)
				{
				_viewGLVoucherTranPayToName=value;
				NotifyChanged("ViewGLVoucherTranPayToName");
				}
			}
		}
		public String ViewGLTranPayToDesc
		{
			get{return _viewGLTranPayToDesc;}
			set
			{
				if (value != this._viewGLTranPayToDesc)
				{
				_viewGLTranPayToDesc=value;
				NotifyChanged("ViewGLTranPayToDesc");
				}
			}
		}
		public String ViewGLOutTranDesc
		{
			get{return _viewGLOutTranDesc;}
			set
			{
				if (value != this._viewGLOutTranDesc)
				{
				_viewGLOutTranDesc=value;
				NotifyChanged("ViewGLOutTranDesc");
				}
			}
		}
		public double ViewGLTranAmt
		{
			get{return _viewGLTranAmt;}
			set
			{
				if (value != this._viewGLTranAmt)
				{
				_viewGLTranAmt=value;
				NotifyChanged("ViewGLTranAmt");
				}
			}
		}
		public String ViewGLAccountNoCredit
		{
			get{return _viewGLAccountNoCredit;}
			set
			{
				if (value != this._viewGLAccountNoCredit)
				{
				_viewGLAccountNoCredit=value;
				NotifyChanged("ViewGLAccountNoCredit");
				}
			}
		}
		public String ViewGLAccountNoDebit
		{
			get{return _viewGLAccountNoDebit;}
			set
			{
				if (value != this._viewGLAccountNoDebit)
				{
				_viewGLAccountNoDebit=value;
				NotifyChanged("ViewGLAccountNoDebit");
				}
			}
		}
		#endregion
	}
	#endregion
}