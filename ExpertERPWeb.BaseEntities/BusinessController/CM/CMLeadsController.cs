using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region CMLeads
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:CMLeadsController
	//Created Date:23 Tháng Bảy 2012
	//-----------------------------------------------------------
	
	public class CMLeadsController:BaseBusinessController
	{
		public CMLeadsController()
		{
			dal= new DALBaseProvider("CMLeads",typeof(CMLeadsInfo));
		}

        public int GetCountLeadByCampaignID(int iCampaignID)
        {
            string strQuery = String.Format(@"SELECT COUNT(*) FROM CMLeads WHERE AAStatus='Alive' AND FK_CMCampaignID={0}", iCampaignID);
            DataSet ds =(DataSet) GetDataSet(strQuery);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0] != DBNull.Value)
                return Convert.ToInt32(ds.Tables[0].Rows[0][0]);

            return 0;
        }

        public DataSet GetAllLeadByCampaignID(int iCampaignID)
        {
            string strQuery = String.Format(@"SELECT * FROM CMLeads WHERE AAStatus='Alive' AND FK_CMCampaignID={0}", iCampaignID);
            return GetDataSet(strQuery);
        }

        public int GetCountLeadBySeller(int iSellerID)
        {
            string strQuery = String.Format(@"SELECT COUNT(*) FROM CMLeads WHERE AAStatus='Alive' AND FK_ARSellerID={0}", iSellerID);
            DataSet ds = (DataSet)GetDataSet(strQuery);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0] != DBNull.Value)
                return Convert.ToInt32(ds.Tables[0].Rows[0][0]);

            return 0;
        }

        public int GetCountLeadBySeller(int iSellerID, DateTime dtFrom, DateTime dtTo)
        {
            String strTime = DALUtil.GenerateBeetween("CMLeadAssignDate", dtFrom, dtTo);
            string strQuery = String.Format(@"SELECT COUNT(*) FROM CMLeads WHERE AAStatus='Alive' AND FK_ARSellerID={0} AND {1}", iSellerID, strTime);

            DataSet ds = (DataSet)GetDataSet(strQuery);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0] != DBNull.Value)
                return Convert.ToInt32(ds.Tables[0].Rows[0][0]);

            return 0;
        }

        public DataSet GetAllLeadBySeller(int iSellerID, DateTime dtFrom, DateTime dtTo)
        {
            String strTime = DALUtil.GenerateBeetween("CMLeadAssignDate", dtFrom, dtTo);
            string strQuery = String.Format(@"SELECT * FROM CMLeads WHERE AAStatus='Alive' AND FK_ARSellerID={0} AND {1}", iSellerID, strTime);

            return GetDataSet(strQuery);
        }

        public DataSet GetAllLeadNotAssign(int iCampaign, DateTime DateFrom, DateTime DateTo)
        {
            String strDateCond = DALUtil.GenerateBeetween("CMLeadDate", DateFrom, DateTo);
            string strQuery = String.Format(@"SELECT * 
                                                FROM CMLeads 
                                                WHERE AAStatus='Alive' 
                                                AND FK_HREmployeeID NOT IN (SELECT HREmployeeID FROM HREmployees WHERE AAStatus = 'Alive')
                                                AND {0}",strDateCond);
            if (iCampaign != 0)
            {
                strQuery += String.Format(@" AND FK_CMCampaignID={0}", iCampaign) ;
            }
            return dal.GetDataSet(strQuery);
        }

        public DataSet GetAllLeadsByEmployee(int iEmployeeID, DateTime DateFrom, DateTime DateTo)
        {
            String strEmp = String.Empty;
            if (iEmployeeID > 0)
                strEmp = String.Format(@" AND FK_HREmployeeID = {0}", iEmployeeID);

            String strTime = DALUtil.GenerateBeetween("CMLeadAssignDate", DateFrom, DateTo);

            string strQuery = String.Format(@"SELECT * FROM CMLeads WHERE AAStatus='Alive' AND FK_HREmployeeID=0 AND {1} {2}", iEmployeeID, strTime, strEmp);
            return dal.GetDataSet(strQuery);
        }

        public List<BusinessObject> GetObjectsLikeNo(string LeadNo)
        {
            string strQuery=String.Format("SELECT * FROM CMLeads WHERE AAStatus='Alive' AND CMLeadNo LIKE '%{0}%'",LeadNo);
            DataSet ds = GetDataSet(strQuery);
            List<BusinessObject> list = GetListFromDataset(ds);
            return list;
        }
    }
	#endregion
}
