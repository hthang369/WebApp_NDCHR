using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region GLTranCfgGroupRptParams
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:GLTranCfgGroupRptParamsInfo
	//Created Date:Tuesday, January 6, 2015
	//-----------------------------------------------------------
	
	public class GLTranCfgGroupRptParamsInfo:BusinessObject
	{
		public GLTranCfgGroupRptParamsInfo()
		{
		}
		#region Variables
		protected int _gLTranCfgGroupRptParamID;
		protected String _gLTranCfgGroupRptParamName=String.Empty;
		protected String _gLTranCfgGroupRptParamField=String.Empty;
		protected int _fK_GLTranCfgGroupRptID;
		protected bool _gLTranCfgGroupRptParamDisplay=true;
		protected String _gLTranCfgGroupRptParamDesc=String.Empty;
		protected String _gLTranCfgGroupRptParamValue=String.Empty;
		#endregion

		#region Public properties
		public int GLTranCfgGroupRptParamID
		{
			get{return _gLTranCfgGroupRptParamID;}
			set
			{
				if (value != this._gLTranCfgGroupRptParamID)
				{
				_gLTranCfgGroupRptParamID=value;
				NotifyChanged("GLTranCfgGroupRptParamID");
				}
			}
		}
		public String GLTranCfgGroupRptParamName
		{
			get{return _gLTranCfgGroupRptParamName;}
			set
			{
				if (value != this._gLTranCfgGroupRptParamName)
				{
				_gLTranCfgGroupRptParamName=value;
				NotifyChanged("GLTranCfgGroupRptParamName");
				}
			}
		}
		public String GLTranCfgGroupRptParamField
		{
			get{return _gLTranCfgGroupRptParamField;}
			set
			{
				if (value != this._gLTranCfgGroupRptParamField)
				{
				_gLTranCfgGroupRptParamField=value;
				NotifyChanged("GLTranCfgGroupRptParamField");
				}
			}
		}
		public int FK_GLTranCfgGroupRptID
		{
			get{return _fK_GLTranCfgGroupRptID;}
			set
			{
				if (value != this._fK_GLTranCfgGroupRptID)
				{
				_fK_GLTranCfgGroupRptID=value;
				NotifyChanged("FK_GLTranCfgGroupRptID");
				}
			}
		}
		public bool GLTranCfgGroupRptParamDisplay
		{
			get{return _gLTranCfgGroupRptParamDisplay;}
			set
			{
				if (value != this._gLTranCfgGroupRptParamDisplay)
				{
				_gLTranCfgGroupRptParamDisplay=value;
				NotifyChanged("GLTranCfgGroupRptParamDisplay");
				}
			}
		}
		public String GLTranCfgGroupRptParamDesc
		{
			get{return _gLTranCfgGroupRptParamDesc;}
			set
			{
				if (value != this._gLTranCfgGroupRptParamDesc)
				{
				_gLTranCfgGroupRptParamDesc=value;
				NotifyChanged("GLTranCfgGroupRptParamDesc");
				}
			}
		}
		public String GLTranCfgGroupRptParamValue
		{
			get{return _gLTranCfgGroupRptParamValue;}
			set
			{
				if (value != this._gLTranCfgGroupRptParamValue)
				{
				_gLTranCfgGroupRptParamValue=value;
				NotifyChanged("GLTranCfgGroupRptParamValue");
				}
			}
		}
		#endregion
	}
	#endregion
}