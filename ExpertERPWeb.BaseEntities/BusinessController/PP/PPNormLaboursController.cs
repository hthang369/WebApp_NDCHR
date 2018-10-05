using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region PPNormLabours
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:PPNormLaboursController
	//Created Date:13 Tháng Năm 2014
	//-----------------------------------------------------------
	
	public class PPNormLaboursController:BaseBusinessController
	{
		public PPNormLaboursController()
		{
			dal= new DALBaseProvider("PPNormLabours",typeof(PPNormLaboursInfo));
		}

        public DataSet GetAllDataLastByFinishGoodANDCustomer(int iFGProductID, int iARCustomerID)
        {
            string strQuery = string.Format(@"  SELECT * FROM PPNormLabours 
                                                WHERE FK_PPNormID IN (
                                                                        SELECT TOP 1 PPNormID FROM PPNorms 
                                                                        WHERE AAStatus = 'Alive' 
                                                                        AND FK_ICProductID = {0}
                                                                        AND FK_ARCustomerID = {1}
                                                                        ORDER BY PPNormID DESC
                                                                    )
                                                ", iFGProductID, iARCustomerID);
            return dal.GetDataSet(strQuery);
        }
        public DataSet GetAllDataByListNormID(params string[] arrNormID)
        {
            return GetDataSet(string.Format("SELECT * FROM PPNormLabours WHERE AAStatus = 'Alive' AND FK_PPNormID IN({0})", string.Join(",", arrNormID)));
        }
	}
	#endregion
}