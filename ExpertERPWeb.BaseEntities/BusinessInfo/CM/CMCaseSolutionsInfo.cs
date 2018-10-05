using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region CMCaseSolutions
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:CMCaseSolutionsInfo
	//Created Date:10 Tháng Tám 2012
	//-----------------------------------------------------------
	
	public class CMCaseSolutionsInfo:BusinessObject
	{
		public CMCaseSolutionsInfo()
		{
		}
		#region Variables
		protected int _cMCaseSolutionID;
		protected int _fK_CMCaseID;
		protected int _fK_CMSolutionID;
		#endregion

		#region Public properties
		public int CMCaseSolutionID
		{
			get{return _cMCaseSolutionID;}
			set
			{
				if (value != this._cMCaseSolutionID)
				{
				_cMCaseSolutionID=value;
				NotifyChanged("CMCaseSolutionID");
				}
			}
		}
		public int FK_CMCaseID
		{
			get{return _fK_CMCaseID;}
			set
			{
				if (value != this._fK_CMCaseID)
				{
				_fK_CMCaseID=value;
				NotifyChanged("FK_CMCaseID");
				}
			}
		}
		public int FK_CMSolutionID
		{
			get{return _fK_CMSolutionID;}
			set
			{
				if (value != this._fK_CMSolutionID)
				{
				_fK_CMSolutionID=value;
				NotifyChanged("FK_CMSolutionID");
				}
			}
		}
		#endregion
	}
	#endregion
}