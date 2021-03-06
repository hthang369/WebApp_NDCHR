using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region HRRecruitReqs
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:HRRecruitReqsController
	//Created Date:27 Tháng Năm 2013
	//-----------------------------------------------------------
	
	public class HRRecruitReqsController:BaseBusinessController
	{
		public HRRecruitReqsController()
		{
			dal= new DALBaseProvider("HRRecruitReqs",typeof(HRRecruitReqsInfo));
		}
        public DataSet GetAllObjectNotExistRecruitPln()
        {
            string strQuery = string.Format(@"select * from HRRecruitReqs where AAStatus='Alive' AND ApprovalStatusCombo='Approved'
                      AND HRRecruitReqID not in (select FK_HRRecruitReqID from HRRecruitPlnItems where AAStatus='Alive'
                                                 AND FK_HRRecruitPlnID in (select HRRecruitPlnID from HRRecruitPlns where AAStatus='Alive'))");
            return dal.GetDataSet(strQuery);
        }
        public DataSet GetAllDataNoneRecruitPnl()
        {
            string strQuery = string.Format(@"SELECT * 
                                            FROM HRRecruitReqs
                                            WHERE AAStatus='Alive'
                                            AND HRRecruitReqExpectDate IS NULL");
            return dal.GetDataSet(strQuery);
        }
                                                                                   
        public DataSet GetAllDataRecruitPnl()
        {
            string strQuery = string.Format(@"SELECT DISTINCT HRRecruitReqs.*
                                                 FROM HRRecruitReqs
                                                 JOIN HRRecruitReqItems 
                                                 ON (HRRecruitReqItems.FK_HRRecruitReqID = HRRecruitReqs.HRRecruitReqID AND HRRecruitReqs.AAStatus = HRRecruitReqItems.AAStatus)
                                                 WHERE HRRecruitReqs.AAStatus='Alive' AND ApprovalStatusCombo='Approved' AND HRRecruitReqItems.HRRecruitReqItemPlnDate IS NOT NULL");
            return dal.GetDataSet(strQuery);
        }
        public DataSet GetAllDataRecruitReqNew()
        {
            string strQuery = string.Format(@"SELECT * 
                                                FROM HRRecruitReqs
                                                 WHERE AAStatus='Alive'
                                                 AND  HRRecruitReqStatusCombo='New'");
            return dal.GetDataSet(strQuery);
        }
        public DataSet GetAllDataRecruitReqAnnoun()
        {
            string strQuery = string.Format(@"SELECT * 
                                            FROM HRRecruitReqs
                                             WHERE AAStatus='Alive'
                                             AND  HRRecruitReqStatusCombo='Announ'");
            return dal.GetDataSet(strQuery);
        }
    }
	#endregion
}