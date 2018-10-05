using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region GEPolicyItemMths
    //-----------------------------------------------------------
    //Generated By: GMC Studio
    //Class:GEPolicyItemMthsController
    //Created Date:Thursday, November 26, 2015
    //-----------------------------------------------------------

    public class GEPolicyItemMthsController : BaseBusinessController
    {
        public GEPolicyItemMthsController()
        {
            dal = new DALBaseProvider("GEPolicyItemMths", typeof(GEPolicyItemMthsInfo));
        }

        public int GetObjectIDByParam(String strParam)
        {
            string strQuery = string.Format(@"  Select GEPolicyDefineMthID 
                                                FROM GEPolicyDefineMths 
                                                Where AAStatus = 'Alive' AND GEPolicyDefineMthParam = '{0}' ", strParam);
            int iID = 0;

            DataSet ds = GetDataSet(strQuery);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0] != DBNull.Value)
            {
                iID = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
            }

            return iID;
        }

        public DataSet GetAllObjectByForiegnKeyPolicy_PolicyDefineCalc_PolicyItem(int iGEPolicyID, int iGEPolicyDefineCalcID, int iGEPolicyItemID)
        {
            String strQuery = String.Format(@"  SELECT  GEPolicyItemMths.*
                                                FROM    dbo.GEPolicys
                                                        INNER JOIN dbo.GEPolicyDefineCalcs ON GEPolicyDefineCalcs.FK_GEPolicyID = GEPolicys.GEPolicyID
                                                        INNER JOIN dbo.GEPolicyItems ON GEPolicyItems.FK_GEPolicyDefineCalcID = GEPolicyDefineCalcs.GEPolicyDefineCalcID
                                                        INNER JOIN dbo.GEPolicyItemMths ON GEPolicyItemMths.FK_GEPolicyItemID = GEPolicyItems.GEPolicyItemID
                                                WHERE   GEPolicys.AAStatus = 'Alive'
                                                        AND GEPolicyDefineCalcs.AAStatus = 'Alive'
                                                        AND ( GEPolicys.GEPolicyID = {0}
                                                              OR 0 = {0}
                                                            )
                                                        AND ( GEPolicyDefineCalcs.GEPolicyDefineCalcID = {1}
                                                              OR 0 = {1}
                                                            )
                                                        AND ( GEPolicyItems.GEPolicyItemID = {2}
                                                              OR 0 = {2}
                                                            )", iGEPolicyID, iGEPolicyDefineCalcID, iGEPolicyItemID);

            DataSet ds = GetDataSet(strQuery);
            return ds;
        }



        public DataSet GetAllObjectByForiegnKeyPolicy_PolicyDefineCalc_PolicyItem_From_To(GEPolicysInfo objGEPolicysInfo, int iGEPolicyDefineCalcID, int iGEPolicyItemID)
        {
            String strQuery = String.Format(@"         SELECT GEPolicyItemMths.*
                                                FROM dbo.GEPolicys INNER JOIN dbo.GEPolicyDefineCalcs ON GEPolicyDefineCalcs.FK_GEPolicyID = GEPolicys.GEPolicyID
                                                                   INNER JOIN dbo.GEPolicyItems ON GEPolicyItems.FK_GEPolicyDefineID = GEPolicyDefineCalcs.FK_GEPolicyDefineID
				                                                   INNER JOIN dbo.GEPolicyItemMths ON GEPolicyItemMths.FK_GEPolicyItemID = GEPolicyItems.GEPolicyItemID
                                                WHERE GEPolicyItems.AAStatus = 'Alive' AND GEPolicys.AAStatus = 'Alive' AND GEPolicyDefineCalcs.AAStatus = 'Alive'
                                                      AND YEAR(GEPolicys.GEPolicyFDate) = {0} AND MONTH(GEPolicys.GEPolicyFDate) = {1}
	                                                  AND FK_GEPolicyDefineCalcID = {2}
                                                      AND FK_GEPolicyItemID = {3}
                                              ", objGEPolicysInfo.GEPolicyFDate.Value.Year, objGEPolicysInfo.GEPolicyFDate.Value.Month, iGEPolicyDefineCalcID, iGEPolicyItemID);

            DataSet ds = GetDataSet(strQuery);
            return ds;
        }
        public double GetResultPolicyCalByPayrollTypeAndEmployeeID(DateTime dtFdate, DateTime dtTdate, string strPayrollType, string strPayrollTypeNo, int iEmployeeID)
        {
            string strQuery = string.Format(@"SELECT GEPolicyItemMthFAmt
                                             FROM   dbo.GEPolicys
                                            INNER JOIN dbo.GEPolicyDefineCalcs ON ( GEPolicyDefineCalcs.FK_GEPolicyID = GEPolicys.GEPolicyID
                                                                                    AND GEPolicyDefineCalcs.AAStatus = GEPolicys.AAStatus
                                                                                    )
                                            INNER JOIN dbo.GEPolicyDefines ON ( GEPolicyDefines.GEPolicyDefineID = GEPolicyDefineCalcs.FK_GEPolicyDefineID
                                                                                AND GEPolicyDefines.AAStatus = GEPolicyDefineCalcs.AAStatus
                                                                                )
                                            INNER JOIN dbo.GEPolicyTypes ON ( GEPolicyTypes.GEPolicyTypeID = GEPolicyDefines.FK_GEPolicyTypeID
                                                                                AND GEPolicyTypes.AAStatus = GEPolicyDefines.AAStatus
                                                                            )
                                            INNER JOIN dbo.HRPayrollTypes ON ( HRPayrollTypes.HRPayrollTypeID = GEPolicyTypes.FK_HRPayrollTypeID
                                                                                AND HRPayrollTypes.AASelected = GEPolicyTypes.AASelected
                                                                                )
                                            INNER  JOIN dbo.GEPolicyItems ON ( GEPolicyItems.FK_GEPolicyDefineCalcID = GEPolicyDefineCalcs.GEPolicyDefineCalcID
                                                                                AND GEPolicyItems.AAStatus = GEPolicyDefineCalcs.AAStatus
                                                                                )
                                            INNER JOIN dbo.GEPolicyItemMths ON ( GEPolicyItemMths.FK_GEPolicyItemID = GEPolicyItems.GEPolicyItemID
                                                                                    AND GEPolicyItemMths.AAStatus = GEPolicyDefines.AAStatus
                                                                                )
                                            INNER JOIN dbo.GEPolicyDefineMths ON ( GEPolicyDefineMths.GEPolicyDefineMthID = GEPolicyItemMths.FK_GEPolicyDefineMthID
                                                                                    AND GEPolicyDefineMths.AAStatus = GEPolicyItemMths.AAStatus
                                                                                    )
                                            INNER JOIN dbo.GLObjects ON ( GEPolicyItems.FK_GLObjectID = GLObjects.GLObjectID
                                                                            AND GLObjects.AAStatus = GEPolicyItems.AAStatus
                                                                        )
                                            INNER JOIN dbo.HREmployees ON ( HREmployees.HREmployeeID = GLObjects.FK_ObjectRefID )
                                        WHERE  GEPolicys.AAStatus = 'Alive'
                                            AND GEPolicyDefineMths.GEPolicyDefineMthTypeCombo = 'Result'
                                            AND CONVERT(NVARCHAR(10), GEPolicyFDate, 112) = '{0}'
                                            AND CONVERT(NVARCHAR(10), GEPolicyTDate, 112) = '{1}'
                                            AND GEPolicyDefines.GEPayrollTypeAttributeCombo = '{2}'
		                                    AND HRPayrollTypeNo='{3}'
		                                    AND HREmployeeID={4}", dtFdate.ToString("yyyMMdd"), dtTdate.ToString("yyyMMdd"), strPayrollType, strPayrollTypeNo, iEmployeeID);
            DataSet ds = dal.GetDataSet(strQuery);
            double dbkq = 0;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dbkq = Convert.ToDouble(ds.Tables[0].Rows[0][0]);
            }
            return dbkq;
        }
    public DataSet GetResultPolicyCalByFDateTDate(DateTime dtFdate, DateTime dtTdate)
        {
            string strQuery = string.Format(@"SELECT HREmployeeID,
                                                HRPayrollTypeNo,
                                                GEPolicyDefines.GEPayrollTypeAttributeCombo GEPayrollTypeAttributeCombo,
                                                ISNULL(GEPolicyItemMthFAmt,0) GEPolicyItemMthFAmt
                                             FROM   dbo.GEPolicys
                                            INNER JOIN dbo.GEPolicyDefineCalcs ON ( GEPolicyDefineCalcs.FK_GEPolicyID = GEPolicys.GEPolicyID
                                                                                    AND GEPolicyDefineCalcs.AAStatus = GEPolicys.AAStatus
                                                                                    )
                                            INNER JOIN dbo.GEPolicyDefines ON ( GEPolicyDefines.GEPolicyDefineID = GEPolicyDefineCalcs.FK_GEPolicyDefineID
                                                                                AND GEPolicyDefines.AAStatus = GEPolicyDefineCalcs.AAStatus
                                                                                )
                                            INNER JOIN dbo.GEPolicyTypes ON ( GEPolicyTypes.GEPolicyTypeID = GEPolicyDefines.FK_GEPolicyTypeID
                                                                                AND GEPolicyTypes.AAStatus = GEPolicyDefines.AAStatus
                                                                            )
                                            INNER JOIN dbo.HRPayrollTypes ON ( HRPayrollTypes.HRPayrollTypeID = GEPolicyTypes.FK_HRPayrollTypeID
                                                                                AND HRPayrollTypes.AASelected = GEPolicyTypes.AASelected
                                                                                )
                                            INNER  JOIN dbo.GEPolicyItems ON ( GEPolicyItems.FK_GEPolicyDefineCalcID = GEPolicyDefineCalcs.GEPolicyDefineCalcID
                                                                                AND GEPolicyItems.AAStatus = GEPolicyDefineCalcs.AAStatus
                                                                                )
                                            INNER JOIN dbo.GEPolicyItemMths ON ( GEPolicyItemMths.FK_GEPolicyItemID = GEPolicyItems.GEPolicyItemID
                                                                                    AND GEPolicyItemMths.AAStatus = GEPolicyDefines.AAStatus
                                                                                )
                                            INNER JOIN dbo.GEPolicyDefineMths ON ( GEPolicyDefineMths.GEPolicyDefineMthID = GEPolicyItemMths.FK_GEPolicyDefineMthID
                                                                                    AND GEPolicyDefineMths.AAStatus = GEPolicyItemMths.AAStatus
                                                                                    )
                                            INNER JOIN dbo.GLObjects ON ( GEPolicyItems.FK_GLObjectID = GLObjects.GLObjectID
                                                                            AND GLObjects.AAStatus = GEPolicyItems.AAStatus
                                                                        )
                                            INNER JOIN dbo.HREmployees ON ( HREmployees.HREmployeeID = GLObjects.FK_ObjectRefID )
                                        WHERE  GEPolicys.AAStatus = 'Alive'
                                            AND GEPolicyDefineMths.GEPolicyDefineMthTypeCombo = 'Result'
                                            AND CONVERT(NVARCHAR(10), GEPolicyFDate, 112) = '{0}'
                                            AND CONVERT(NVARCHAR(10), GEPolicyTDate, 112) = '{1}'", dtFdate.ToString("yyyMMdd"), dtTdate.ToString("yyyMMdd"));
            return dal.GetDataSet(strQuery);
        }
    }
    #endregion
}