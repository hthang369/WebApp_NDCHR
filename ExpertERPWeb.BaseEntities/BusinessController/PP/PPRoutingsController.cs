using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region PPRoutings
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:PPRoutingsController
	//Created Date:18 Tháng Sáu 2013
	//-----------------------------------------------------------
	
	public class PPRoutingsController:BaseBusinessController
	{
		public PPRoutingsController()
		{
			dal= new DALBaseProvider("PPRoutings",typeof(PPRoutingsInfo));
		}

        public PPRoutingsInfo GetDataByProduct(int iICProductID, String strRevision = "")
        {
            String str = String.Format(@"   SELECT DISTINCT TOP 1 Routing.* FROM dbo.PPRoutingItems RoutingItem
                                            INNER JOIN dbo.PPRoutings Routing ON Routing.PPRoutingID = RoutingItem.FK_PPRoutingID
                                            WHERE Routing.AAStatus = 'Alive' AND RoutingItem.AAStatus = 'Alive'
                                            AND RoutingItem.FK_ICProductID = {0}"
                                        , iICProductID);

            if(String.IsNullOrEmpty(strRevision) == false)
            {
                str += String.Format(@" AND Routing.PPRoutingNormRevision LIKE '{0}'", strRevision);
            }

            str += String.Format(@" ORDER BY PPRoutingActiveCheck DESC");

            DataSet ds = dal.GetDataSet(str);
            if(ds!=null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                return (PPRoutingsInfo)dal.GetObjectFromDataRow(ds.Tables[0].Rows[0]);
            }

            return null;
        }
        public PPRoutingsInfo GetObjectByProductID(int pICProductID)
        {
            string strQuery = string.Format(@"
                                                SELECT * FROM dbo.PPRoutings
                                                WHERE PPRoutingID = (
                                                                        SELECT FK_PPRoutingID FROM dbo.ICProducts
                                                                        WHERE ICProductID = {0} AND AAStatus='Alive'
                                                                    )
                                                AND AAStatus='Alive'
                                            ", pICProductID);
            DataSet ds = dal.GetDataSet(strQuery);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                return (PPRoutingsInfo)dal.GetObjectFromDataRow(ds.Tables[0].Rows[0]);
            }

            return null;
        }
    }
	#endregion
}