using System;
using System.Text;
using System.Collections.Generic;

namespace ExpertWebLib
{
	#region GEDictionarys
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:GEDictionarysInfo
	//Created Date:Wednesday, April 1, 2015
	//-----------------------------------------------------------
	
	public class GEDictionarysInfo:BusinessObject
	{
		public GEDictionarysInfo()
		{
		}
		#region Variables
		protected int _gEDictionaryID;
		protected String _gEDictionaryTypeCombo=String.Empty;
		protected String _gEDictionaryText=String.Empty;
		protected String _gEDictionaryText1=String.Empty;
		protected String _gEDictionaryText2=String.Empty;
		protected String _gEDictionaryText3=String.Empty;
		#endregion

		#region Public properties
		public int GEDictionaryID
		{
			get{return _gEDictionaryID;}
			set
			{
				if (value != this._gEDictionaryID)
				{
				_gEDictionaryID=value;
				NotifyChanged("GEDictionaryID");
				}
			}
		}
		public String GEDictionaryTypeCombo
		{
			get{return _gEDictionaryTypeCombo;}
			set
			{
				if (value != this._gEDictionaryTypeCombo)
				{
				_gEDictionaryTypeCombo=value;
				NotifyChanged("GEDictionaryTypeCombo");
				}
			}
		}
		public String GEDictionaryText
		{
			get{return _gEDictionaryText;}
			set
			{
				if (value != this._gEDictionaryText)
				{
				_gEDictionaryText=value;
				NotifyChanged("GEDictionaryText");
				}
			}
		}
		public String GEDictionaryText1
		{
			get{return _gEDictionaryText1;}
			set
			{
				if (value != this._gEDictionaryText1)
				{
				_gEDictionaryText1=value;
				NotifyChanged("GEDictionaryText1");
				}
			}
		}
		public String GEDictionaryText2
		{
			get{return _gEDictionaryText2;}
			set
			{
				if (value != this._gEDictionaryText2)
				{
				_gEDictionaryText2=value;
				NotifyChanged("GEDictionaryText2");
				}
			}
		}
		public String GEDictionaryText3
		{
			get{return _gEDictionaryText3;}
			set
			{
				if (value != this._gEDictionaryText3)
				{
				_gEDictionaryText3=value;
				NotifyChanged("GEDictionaryText3");
				}
			}
		}
		#endregion
	}
	#endregion
}