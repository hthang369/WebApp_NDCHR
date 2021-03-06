using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region GEPolicys
    //-----------------------------------------------------------
    //Generated By: GMC Studio
    //Class:GEPolicysController
    //Created Date:Thursday, November 26, 2015
    //-----------------------------------------------------------

    public class GEPolicysController : BaseBusinessController
    {
        public GEPolicysController()
        {
            dal = new DALBaseProvider("GEPolicys", typeof(GEPolicysInfo));
        }

        public bool GetAllObjectByFromToDate(int iGEPolicyDefineID, DateTime dtFrom, DateTime dtTo)
        {
            String strQuery = string.Format(@"  SELECT GEPolicyDefineCalcs.FK_GEPolicyDefineID
                                                FROM dbo.GEPolicys INNER JOIN dbo.GEPolicyDefineCalcs ON GEPolicyDefineCalcs.FK_GEPolicyID = GEPolicys.GEPolicyID
				                                                   INNER JOIN dbo.GEPolicyDefines ON GEPolicyDefines.GEPolicyDefineID = GEPolicyDefineCalcs.FK_GEPolicyDefineID
                                                WHERE GEPolicys.AAStatus = 'Alive' AND GEPolicyDefineCalcs.AAStatus ='Alive'
	                                                  AND GEPolicyDefines.GEPolicyDefineTypeCombo != 'New'
	                                                  AND GEPolicyDefineCalcs.FK_GEPolicyDefineID = {0}
	                                                  AND CONVERT(VARCHAR(10),GEPolicys.GEPolicyFDate,112) >= CONVERT(VARCHAR(10),'{1}',112)
	                                                  AND CONVERT(VARCHAR(10),GEPolicys.GEPolicyTDate,112) <= CONVERT(VARCHAR(10),'{2}',112)

                                            ", iGEPolicyDefineID, dtFrom.ToString("yyyyMMdd"), dtTo.ToString("yyyyMMdd"));

            DataSet ds = GetDataSet(strQuery);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0] != DBNull.Value)
            {
                return true;
            }

            return false;
        }

        public void DeleteAllObjectByPolicyDefineForPolicy(int iGEPolicyID, int iGEPolicyDefineID, DateTime dtFrom, DateTime dtTo)
        {
            try
            {
                String strQuery = String.Format(@"  
                                                    DECLARE @CalID INT = {0};
                                                    DECLARE @PolicyDefine INT = {1}; 
                                                    DECLARE @FromDate DATETIME = '{2}';
                                                    DECLARE @ToDate DATETIME = '{3}';
                                                    --DECLARE @ToDate DATETIME = '2016-01-01';
                                                    -----

                                                    DELETE  
                                                    FROM    dbo.GEPolicyItemMths
                                                    WHERE   FK_GEPolicyItemID IN (
                                                            SELECT  GEPolicyItemID
                                                            FROM    dbo.GEPolicyItems
                                                            WHERE   AAStatus = 'Alive' AND FK_GEPolicyDefineCalcID IN (
                                                                    SELECT  GEPolicyDefineCalcID
                                                                    FROM    dbo.GEPolicyDefineCalcs
                                                                            JOIN dbo.GEPolicys ON ( GEPolicys.GEPolicyID = GEPolicyDefineCalcs.FK_GEPolicyID
                                                                                                    AND GEPolicys.AAStatus = GEPolicyDefineCalcs.AAStatus
                                                                                                    AND GEPolicys.AAStatus = 'Alive'
                                                                                                  )
                                                                    WHERE   GEPolicyDefineCalcID <> @CalID
                                                                            AND FK_GEPolicyDefineID = @PolicyDefine
                                                                            AND CONVERT(DATE, GEPolicyFDate) = CONVERT(DATE, @FromDate) ) );
                                                    ------
                                                    DELETE  
                                                    FROM    dbo.GEPolicyItems
                                                    WHERE   AAStatus = 'Alive' AND FK_GEPolicyDefineCalcID IN ( ( SELECT GEPolicyDefineCalcID
                                                                                         FROM   dbo.GEPolicyDefineCalcs
                                                                                                JOIN dbo.GEPolicys ON ( GEPolicys.GEPolicyID = GEPolicyDefineCalcs.FK_GEPolicyID
                                                                                                                  AND GEPolicys.AAStatus = GEPolicyDefineCalcs.AAStatus
                                                                                                                  AND GEPolicys.AAStatus = 'Alive'
                                                                                                                  )
                                                                                         WHERE  GEPolicyDefineCalcID <> @CalID
                                                                                                AND FK_GEPolicyDefineID = @PolicyDefine
                                                                                                AND CONVERT(DATE, GEPolicyFDate) = CONVERT(DATE, @FromDate)
                                                                                       )
                                                                                  );
                                                    ----------
                                                    DELETE 
                                                    FROM    dbo.GEPolicyDefineCalcs
                                                    WHERE   AAStatus = 'Alive' AND GEPolicyDefineCalcID IN (
                                                            SELECT  GEPolicyDefineCalcID
                                                            FROM    dbo.GEPolicyDefineCalcs
                                                                    JOIN dbo.GEPolicys ON ( GEPolicys.GEPolicyID = GEPolicyDefineCalcs.FK_GEPolicyID
                                                                                            AND GEPolicys.AAStatus = GEPolicyDefineCalcs.AAStatus
                                                                                            AND GEPolicys.AAStatus = 'Alive'
                                                                                          )
                                                            WHERE   ( GEPolicyDefineCalcID <> @CalID
                                                                      AND FK_GEPolicyDefineID = @PolicyDefine
                                                                      AND CONVERT(DATE, GEPolicyFDate) = CONVERT(DATE, @FromDate)
                                                                    ) );

                                                      
", iGEPolicyID, iGEPolicyDefineID, dtFrom.ToString("yyyy-MM-dd"), dtTo.ToString("yyyy-MM-dd"));



                GetDataSet(strQuery);
            }
            catch
            {

            }
        }

        public GEPolicysInfo GetObjectByMonthANDYear(int iMonth, int iYear)
        {
            String strQuery = String.Format(@"  SELECT *
                                                FROM  dbo.GEPolicys 
                                                WHERE GEPolicys.AAStatus = 'Alive'
	                                                  AND MONTH(GEPolicys.GEPolicyFDate) ={0}
	                                                  AND YEAR(GEPolicys.GEPolicyFDate) = {1}", iMonth, iYear);

            DataSet ds = GetDataSet(strQuery);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                return (GEPolicysInfo)new GEPolicysController().GetObjectFromDataRow(ds.Tables[0].Rows[0]);
            }

            return null;
        }
    }
    #endregion
}