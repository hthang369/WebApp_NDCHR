using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region HRCapcitys
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:HRCapcitysInfo
	//Created Date:26 Tháng Chín 2013
	//-----------------------------------------------------------
	
	public class HRCapcitysInfo:BusinessObject
	{
		public HRCapcitysInfo()
		{
		}
		#region Variables
		protected int _hRCapcityID;
		#endregion

		#region Public properties
		public int HRCapcityID
		{
			get{return _hRCapcityID;}
			set
			{
				if (value != this._hRCapcityID)
				{
				_hRCapcityID=value;
				NotifyChanged("HRCapcityID");
				}
			}
		}
		#endregion
	}
	#endregion
}