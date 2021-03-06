using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region PPCostConsolidates
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:GLPeriodCostCentersController
	//Created Date:14 March 2013
	//-----------------------------------------------------------
	
	public class PPCostConsolidatesController:BaseBusinessController
	{
		public PPCostConsolidatesController()
		{
			dal= new DALBaseProvider("PPCostConsolidates",typeof(PPCostConsolidatesInfo));
		}

        public void DeletePeriodCostCenterByCostType(int iYear, int iPeriod, String strCostType)
        {
            String strQuery = String.Format(@"DELETE PPCostConsolidates 
                                            WHERE 
                                            PPPeriod = {0}
                                            AND PPYear = {1}
                                            AND FK_ICStockID > 0
                                            AND PPCostTypeCombo = '{2}'", iPeriod, iYear, strCostType);

            GetDataSet(strQuery);
        }

        public DataSet GetAllCostConsolidates(int iPeriod, int iYear, String strCostType)
        {
            String strQuery = String.Format(@"SELECT * FROM PPCostConsolidates
                                                WHERE PPPeriod = {0}
                                                AND PPYear = {1}
                                                AND FK_ICStockID > 0
                                                ", iPeriod, iYear);
            if (String.IsNullOrEmpty(strCostType) == false)
                strQuery += String.Format(@" AND PPCostTypeCombo like '{0}'", strCostType);

            return GetDataSet(strQuery);
        }

        public DataSet GetAllCostConsolidates(int iPeriod, int iYear, int iCostFactorID, String strCostType)
        {
            String strQuery = String.Format(@"SELECT * FROM PPCostConsolidates
                                                WHERE PPPeriod = {0}
                                                AND PPYear = {1}
                                                AND FK_ICStockID > 0
                                                AND FK_PPProductionCostFactorID = {2}
                                                ", iPeriod, iYear, iCostFactorID);
            if (String.IsNullOrEmpty(strCostType) == false)
                strQuery += String.Format(@" AND PPCostTypeCombo like '{0}'", strCostType);

            return GetDataSet(strQuery);
        }
        public DataSet GetAllCostConsolidateByFactorTypes(int iPeriod, int iYear,String strProductionCostFactorType, string strCostType)
        {
            String strQuery = String.Format(@"SELECT * FROM PPCostConsolidates
                                                WHERE PPPeriod = {0}
                                                AND PPYear = {1}
                                                AND FK_PPProductionCostFactorID IN 
                                                                    (SELECT PPProductionCostFactorID 
                                                                            FROM PPProductionCostFactors 
                                                                            WHERE AAStatus = 'Alive'
                                                                            AND PPProductionCostFactorTypeCombo = '{2}') 
                                                ", iPeriod, iYear, strProductionCostFactorType);

            if(string.IsNullOrEmpty(strCostType) == false)
                strQuery += String.Format(" AND PPCostTypeCombo = '{0}'", strCostType);

            return GetDataSet(strQuery);
        }

        public DataSet GetAllCostConsolidates(int iPeriod, int iYear, String strCostType, bool isNeedAllocate)
        {
            String strQuery = String.Format(@"SELECT * FROM PPCostConsolidates
                                                WHERE PPPeriod = {0}
                                                AND PPYear = {1}
                                                AND IsNeedAllocated = '{2}'
                                                AND FK_ICStockID > 0
                                                ", iPeriod, iYear, isNeedAllocate);
            if (String.IsNullOrEmpty(strCostType) == false)
                strQuery += String.Format(@" AND PPCostTypeCombo like '{0}'", strCostType);

            return GetDataSet(strQuery);
        }

        public DataSet GetAllCostOverall(int iPeriod, int iYear)
        {
            String strQuery = String.Format(@"SELECT * FROM PPCostConsolidates
                                                WHERE FK_ICStockID = 0
                                                AND PPPeriod = {0} AND PPYear = {1}", iPeriod, iYear);

            return GetDataSet(strQuery);
        }

        public void DeleteCostConsolidateInPeriod(int iYear, int iPeriod, int iStockID, String strCostConsolidateType, String strCostFactorType)
        {
            String strQuery = String.Format(@"DELETE PPCostConsolidates
                                                WHERE PPPeriod = {0}
                                                AND PPYear = {1}
                                                AND (FK_ICStockID = {2} OR {2} = 0)
                                                AND PPCostTypeCombo = '{3}'
                                                AND FK_PPProductionCostFactorID IN (    SELECT  PPProductionCostFactorID
                                                                                        FROM    PPProductionCostFactors
                                                                                        WHERE   PPProductionCostFactorTypeCombo = '{4}'
		                                                                                --AND PPProductionCostFactors.AAStatus = 'Alive' 
                                                                                    )", iPeriod, iYear, iStockID, strCostConsolidateType, strCostFactorType);

            GetDataSet(strQuery);
        }

        public void DeleteCostConsolidateInPeriod(int iYear, int iPeriod, String strCostConsolidateType)
        {
            String strQuery = String.Format(@"DELETE PPCostConsolidates
                                                WHERE PPPeriod = {0}
                                                AND PPYear = {1}
                                                AND PPCostTypeCombo = '{2}'", iPeriod, iYear, strCostConsolidateType);

            GetDataSet(strQuery);
        }

        public void DeleteCostConsolidateInPeriod(int iYear, int iPeriod)
        {
            String strQuery = String.Format(@"  DELETE PPCostConsolidates
                                                WHERE PPPeriod = {0}
                                                AND PPYear = {1}", iPeriod, iYear);

            GetDataSet(strQuery);
        }

        public DataSet GetAllDataGroupAccountByStockANDDate(int iStockID, int iPeriod, int iYear)
        {
            String str = String.Format(@"   SELECT FK_ICStockID, FK_GLAccountID, SUM(PPCostConsolidateAmt) AS PPCostConsolidateAmt 
                                            FROM dbo.PPCostConsolidates
                                            WHERE FK_ICStockID = {0}
                                            AND PPPeriod = {1}
                                            AND PPYear= {2}
                                            GROUP BY FK_ICStockID, FK_GLAccountID", iStockID, iPeriod, iYear);
            return dal.GetDataSet(str);
        }
        public DataSet GetAllDataGroupAccountByStockANDDateANDType(int iStockID, int iPeriod, int iYear, String strCostFactorType)
        {
            String str = String.Format(@"   SELECT FK_ICStockID, FK_GLAccountID, SUM(PPCostConsolidateAmt) AS PPCostConsolidateAmt 
                                            FROM dbo.PPCostConsolidates
                                            WHERE FK_ICStockID = {0}
                                            AND PPPeriod = {1}
                                            AND PPYear= {2}
                                            AND FK_PPProductionCostFactorID IN (    SELECT  PPProductionCostFactorID
                                                                                    FROM    PPProductionCostFactors
                                                                                    WHERE   PPProductionCostFactorTypeCombo = '{3}'
                                                                                )
                                            GROUP BY FK_ICStockID, FK_GLAccountID", iStockID, iPeriod, iYear, strCostFactorType);
            return dal.GetDataSet(str);
        }
	}
	#endregion
}