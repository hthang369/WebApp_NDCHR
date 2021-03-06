using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region GLPostingHistorys
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:GLPostingHistorysController
	//Created Date:07 Tháng Mười 2013
	//-----------------------------------------------------------
	
	public class GLPostingHistorysController:BaseBusinessController
	{
		public GLPostingHistorysController()
		{
			dal= new DALBaseProvider("GLPostingHistorys",typeof(GLPostingHistorysInfo));
		}
        public DataSet GLPostingHistoryByNameAndID(string sName, int iID)
        {
            String strQuerry = String.Format(@"SELECT * FROM dbo.GLPostingHistorys  
                            WHERE AAStatus = 'Alive'
                                AND GLPostingHistoryAction = 'Post'
                                AND GLPostingHistoryModuleName = '{0}'
                                AND GLPostingHistoryObjectNumber = {1}", sName, iID);
            return GetDataSet(strQuerry);
        }
	}
	#endregion
}