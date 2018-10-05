using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region GLTranCfgGroupDefaultValues
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:GLTranCfgGroupDefaultValuesInfo
	//Created Date:Tuesday, January 6, 2015
	//-----------------------------------------------------------
	
	public class GLTranCfgGroupDefaultValuesInfo:BusinessObject
	{
		public GLTranCfgGroupDefaultValuesInfo()
		{
		}
		#region Variables
		protected int _gLTranCfgGroupDefaultValueID;
		protected int _fK_GLTranCfgGroupID;
		protected String _gLTranCfgGroupDefaultValueTable=String.Empty;
		protected String _gLTranCfgGroupDefaultValueField=String.Empty;
		protected String _gLTranCfgGroupDefaultValueName=String.Empty;
		protected String _gLTranCfgGroupDefaultValueNo=String.Empty;
		protected int _fK_GLTranCfgGroupModuleTableID;
		#endregion

		#region Public properties
		public int GLTranCfgGroupDefaultValueID
		{
			get{return _gLTranCfgGroupDefaultValueID;}
			set
			{
				if (value != this._gLTranCfgGroupDefaultValueID)
				{
				_gLTranCfgGroupDefaultValueID=value;
				NotifyChanged("GLTranCfgGroupDefaultValueID");
				}
			}
		}
		public int FK_GLTranCfgGroupID
		{
			get{return _fK_GLTranCfgGroupID;}
			set
			{
				if (value != this._fK_GLTranCfgGroupID)
				{
				_fK_GLTranCfgGroupID=value;
				NotifyChanged("FK_GLTranCfgGroupID");
				}
			}
		}
		public String GLTranCfgGroupDefaultValueTable
		{
			get{return _gLTranCfgGroupDefaultValueTable;}
			set
			{
				if (value != this._gLTranCfgGroupDefaultValueTable)
				{
				_gLTranCfgGroupDefaultValueTable=value;
				NotifyChanged("GLTranCfgGroupDefaultValueTable");
				}
			}
		}
		public String GLTranCfgGroupDefaultValueField
		{
			get{return _gLTranCfgGroupDefaultValueField;}
			set
			{
				if (value != this._gLTranCfgGroupDefaultValueField)
				{
				_gLTranCfgGroupDefaultValueField=value;
				NotifyChanged("GLTranCfgGroupDefaultValueField");
				}
			}
		}
		public String GLTranCfgGroupDefaultValueName
		{
			get{return _gLTranCfgGroupDefaultValueName;}
			set
			{
				if (value != this._gLTranCfgGroupDefaultValueName)
				{
				_gLTranCfgGroupDefaultValueName=value;
				NotifyChanged("GLTranCfgGroupDefaultValueName");
				}
			}
		}
		public String GLTranCfgGroupDefaultValueNo
		{
			get{return _gLTranCfgGroupDefaultValueNo;}
			set
			{
				if (value != this._gLTranCfgGroupDefaultValueNo)
				{
				_gLTranCfgGroupDefaultValueNo=value;
				NotifyChanged("GLTranCfgGroupDefaultValueNo");
				}
			}
		}
		public int FK_GLTranCfgGroupModuleTableID
		{
			get{return _fK_GLTranCfgGroupModuleTableID;}
			set
			{
				if (value != this._fK_GLTranCfgGroupModuleTableID)
				{
				_fK_GLTranCfgGroupModuleTableID=value;
				NotifyChanged("FK_GLTranCfgGroupModuleTableID");
				}
			}
		}
		#endregion
	}
	#endregion
}