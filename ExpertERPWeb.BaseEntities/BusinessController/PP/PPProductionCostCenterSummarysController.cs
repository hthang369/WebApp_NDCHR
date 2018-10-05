using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region PPProductionCostCenterSummarys
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:PPProductionCostCenterSummarysController
	//Created Date:21 Tháng Mười Một 2014
	//-----------------------------------------------------------
	
	public class PPProductionCostCenterSummarysController:BaseBusinessController
	{
		public PPProductionCostCenterSummarysController()
		{
			dal= new DALBaseProvider("PPProductionCostCenterSummarys",typeof(PPProductionCostCenterSummarysInfo));
		}

        public void DeleteAllDataByYearANDPeriod(int iYear, int iPeriod)
        {
            String str = String.Format(@"   DELETE dbo.PPProductionCostCenterSummarys
                                            WHERE PPYear = {0}
                                            AND PPPeriod = {1}"
                                            , iYear, iPeriod);
            dal.GetDataSet(str);
        }

        public void DeleteAllDataByYearANDPeriod(int iYear, int iPeriod, int iPPProductionCostCenterID)
        {
            String str = String.Format(@"   DELETE dbo.PPProductionCostCenterSummarys
                                            WHERE PPYear = {0}
                                            AND PPPeriod = {1}
                                            AND FK_PPProductionCostCenterID = {2}"
                                            , iYear, iPeriod, iPPProductionCostCenterID);
            dal.GetDataSet(str);
        }

        public DataSet GetAllDataByYearANDPeriod(int iYear, int iPeriod)
        {
            String str = String.Format(@"   SELECT * FROM dbo.PPProductionCostCenterSummarys
                                            WHERE PPYear = {0}
                                            AND PPPeriod = {1}"
                                            , iYear, iPeriod);
            return dal.GetDataSet(str);
        }

        public DataSet GetAllDataByYearANDPeriod(int iYear, int iPeriod, int iPPProductionCostCenterID)
        {
            String str = String.Format(@"   SELECT * FROM dbo.PPProductionCostCenterSummarys
                                            WHERE PPYear = {0}
                                            AND PPPeriod = {1}
                                            AND FK_PPProductionCostCenterID = {2}"
                                            , iYear, iPeriod, iPPProductionCostCenterID);
            return dal.GetDataSet(str);
        }

        public DataSet GetAllDataSumByYearANDPeriod(int iYear, int iPeriod)
        {
            String str = String.Format(@"   SELECT FK_PPProductionCostCenterID,
                                            FK_PPProductionCostFactorID, 
                                            FK_PPCostCenterID, FK_PPCostFactorID, FK_GLAccountID,
                                            PPYear, PPPeriod,
                                            SUM(PPProductionCostCenterSummaryAmt) AS PPProductionCostCenterSummaryAmt
                                            FROM dbo.PPProductionCostCenterSummarys
                                            WHERE PPYear = {0}
                                            AND PPPeriod = {1}
                                            GROUP BY FK_PPProductionCostCenterID,
                                            FK_PPProductionCostFactorID, 
                                            FK_PPCostCenterID, FK_PPCostFactorID, FK_GLAccountID,
                                            PPYear, PPPeriod"
                                            , iYear, iPeriod);
            return dal.GetDataSet(str);
        }

        public DataSet LayTapPhiTrongSoCai(int iYear, int iPeriod, int iPPProductionCostCenterID)
        {
            String str = String.Format(@"
                                            --Xóa tất cả các bảng tạm
                                            IF(OBJECT_ID('tempdb..#Account154') > 0) DROP TABLE #Account154
                                            IF(OBJECT_ID('tempdb..#ProductionCostCenter') > 0) DROP TABLE #ProductionCostCenter
                                            IF(OBJECT_ID('tempdb..#ProductionCostFactorAccount') > 0) DROP TABLE #ProductionCostFactorAccount

                                            --Tạo bảng chứa các tài khoản 154
                                            SELECT GLAccountID INTO #Account154 FROM dbo.GLAccounts
                                            WHERE AAStatus = 'Alive'
                                            AND GLAccountNo LIKE '154%'

                                            --Tạo bảng chứa các tập phí có trong cấu hình tính giá thành
                                            SELECT dbo.PPProductionCostCenters.PPProductionCostCenterID,
                                            dbo.PPProductionCostCenters.FK_PPCostCenterID
                                            INTO #ProductionCostCenter
                                            FROM dbo.PPProductionCostCenters
                                            WHERE (dbo.PPProductionCostCenters.PPProductionCostCenterID = {2} OR {2} = 0)
                                            AND PPYear = {0}
                                            AND PPPeriod = {1}

                                            --Tạo bảng chứa các YTCP và tài khoản của YTCP đó trong cấu hình tính giá thành
                                            SELECT dbo.PPProductionCostFactors.PPProductionCostFactorID,
                                            dbo.PPProductionCostFactorItems.FK_PPCostFactorID, 
                                            dbo.PPProductionCostFactorItems.FK_GLAccountID
                                            INTO #ProductionCostFactorAccount
                                            FROM dbo.PPProductionCostFactorItems
                                            INNER JOIN dbo.PPProductionCostFactors ON PPProductionCostFactors.FK_PPCostFactorID = PPProductionCostFactorItems.FK_PPCostFactorID
                                            WHERE PPYear = {0}
                                            AND PPPeriod = {1}

                                            --Query tập hợp dữ liệu
                                            SELECT
                                            TB.PPProductionCostCenterID AS FK_PPProductionCostCenterID,
                                            TB.PPProductionCostFactorID AS FK_PPProductionCostFactorID, 
                                            TB.FK_PPCostCenterID, TB.FK_PPCostFactorID, TB.FK_GLAccountID,
                                            {0} AS PPYear, {1} AS PPPeriod, FK_ICProductID,
                                            SUM(GLJournalAmt) AS PPProductionCostCenterSummaryAmt
                                            FROM 
                                            (
                                            SELECT ProductionCostCenter.PPProductionCostCenterID,
                                            ProductionCostCenter.FK_PPCostCenterID,
                                            FactorAccount.PPProductionCostFactorID,
                                            FactorAccount.FK_PPCostFactorID,
                                            FactorAccount.FK_GLAccountID,
											Journal.FK_ICProductFGID AS FK_ICProductID,
                                            Journal.GLJournalAmt
                                            FROM dbo.GLJournals Journal
                                            INNER JOIN #ProductionCostCenter ProductionCostCenter ON ProductionCostCenter.FK_PPCostCenterID = Journal.FK_PPCostCenterID
                                            INNER JOIN #ProductionCostFactorAccount FactorAccount ON Journal.FK_GLDebitAccountID = FactorAccount.FK_GLAccountID
                                            WHERE Journal.GLJournalYear = {0}
                                            AND Journal.GLJournalPeriod = {1}

                                            UNION ALL

                                            SELECT ProductionCostCenter.PPProductionCostCenterID,
                                            ProductionCostCenter.FK_PPCostCenterID,
                                            FactorAccount.PPProductionCostFactorID, 
                                            FactorAccount.FK_PPCostFactorID, 
                                            FactorAccount.FK_GLAccountID,
											Journal.FK_ICProductFGID AS FK_ICProductID,
                                            (-1) * Journal.GLJournalAmt AS GLJournalAmt
                                            FROM dbo.GLJournals Journal
                                            INNER JOIN #ProductionCostCenter ProductionCostCenter ON ProductionCostCenter.FK_PPCostCenterID = Journal.FK_PPCostCenterID
                                            INNER JOIN #ProductionCostFactorAccount FactorAccount ON Journal.FK_GLCreditAccountID = FactorAccount.FK_GLAccountID
                                            INNER JOIN #Account154 Account154 ON Account154.GLAccountID != Journal.FK_GLDebitAccountID
                                            WHERE Journal.GLJournalYear = {0}
                                            AND Journal.GLJournalPeriod = {1}
                                            ) AS TB
                                            GROUP BY TB.PPProductionCostCenterID, TB.FK_PPCostCenterID, TB.PPProductionCostFactorID, TB.FK_PPCostFactorID, TB.FK_GLAccountID, FK_ICProductID
                                            ", iYear, iPeriod, iPPProductionCostCenterID);
            return dal.GetDataSet(str);
        }
	}
	#endregion
}