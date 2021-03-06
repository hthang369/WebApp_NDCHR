using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region CMNews
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:CMNewsController
	//Created Date:Thursday, April 30, 2009
	//-----------------------------------------------------------
	
	public class CMNewsController:BaseBusinessController
	{
        private static readonly string spGetNewsByTopicAndCreateUserAndNewStatus = "CMNews_SelectByFK_CMTopicIDAndCreateUserAndNewStatus";
        private static readonly string spGetNewsByCreateUserAndNewStatus = "CMNews_SelectByCreateUserAndNewStatus";

		public CMNewsController()
		{
			dal= new DALBaseProvider("CMNews",typeof(CMNewsInfo));
		}

        public DataSet GetNewsByTopicAndCreateUserAndNewStatus(int iCMTopicID, String strAACreatedUser, String strCMNewStatus)
        {
            return dal.GetDataSet(spGetNewsByTopicAndCreateUserAndNewStatus, iCMTopicID, strAACreatedUser, strCMNewStatus);
        }

        public DataSet GetNewsByCreateUserAndNewStats(String strAACreateUser, String strCMNewStatus)
        {
            return dal.GetDataSet(spGetNewsByCreateUserAndNewStatus, strAACreateUser, strCMNewStatus);
        }
	}
	#endregion
}