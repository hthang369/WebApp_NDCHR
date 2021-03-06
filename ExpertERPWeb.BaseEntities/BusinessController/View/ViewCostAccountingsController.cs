using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ViewCostAccountings
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ViewCostAccountingsController
	//Created Date:08 Tháng Giêng 2013
	//-----------------------------------------------------------
	
	public class ViewCostAccountingsController:BaseBusinessController
	{
		public ViewCostAccountingsController()
		{
			dal= new DALBaseProvider("ViewCostAccountings",typeof(ViewCostAccountingsInfo));
		}

        public DataSet GetAllJournalByAccountTypeInRange(DateTime dtFrom, DateTime dtTo, string psCostDistPostingTypeCombo="")
        {
            String strTimeCond = DALUtil.GenerateBeetween("GLJournalDate", dtFrom, dtTo);
            String strQuery = String.Format(@"
SELECT  *
INTO    #tGLJournals
FROM    GLJournals
WHERE   GLJournals.GLJournalAmt <> 0
        AND GLJournals.FK_GLCostCenterID > 0
        --AND GLJournals.FK_GLCostDistID > 0
        AND {0}

--Bang ket qua
SELECT  KQ.FK_GLAccountID ,
        GLAccountNo ,
        GLAccountName ,
        KQ.FK_GLCostCenterID ,
        GLCostCenters.GLCostCenterNo ,
        GLCostCenters.GLCostCenterName ,
        GLCostCenters.FK_GLCostCenterParentID ,
        GLCostCenterParents.GLCostCenterNo AS GLCostCenterParentNo ,
        KQ.FK_GLCostDistID ,
        GLCostDistNo ,
        GLCostDistName ,
        GLJournalAmt
FROM    ( SELECT    FK_GLAccountID ,
                    FK_GLCostCenterID ,
                    FK_GLCostDistID ,
                    SUM(PS.GLJournalAmt) AS GLJournalAmt
          FROM      ( 
--CP Ghi tang
                      SELECT    GLJournals.GLJournalID ,
                                GLJournals.FK_GLDebitAccountID AS FK_GLAccountID ,
                                -GLJournals.GLJournalAmt AS GLJournalAmt
                      FROM      #tGLJournals AS GLJournals
                                INNER JOIN GLAccounts ON GLAccounts.AAStatus = 'Alive'
                                                         AND GLJournals.FK_GLDebitAccountID = GLAccounts.GLAccountID
                                                         AND LEFT(GLAccounts.GLAccountNo,
                                                              1) IN ( '6', '8' )
                      UNION ALL
--CP Ghi Giam
                      SELECT    GLJournals.GLJournalID ,
                                GLJournals.FK_GLCreditAccountID AS FK_GLAccountID ,
                                GLJournals.GLJournalAmt AS GLJournalAmt
                      FROM      #tGLJournals AS GLJournals
                                INNER JOIN GLAccounts ON GLAccounts.AAStatus = 'Alive'
                                                         AND GLJournals.FK_GLCreditAccountID = GLAccounts.GLAccountID
                                                         AND LEFT(GLAccounts.GLAccountNo,
                                                              1) IN ( '6', '8' )
                      WHERE     GLJournals.GLJournalAmt <> 0
                                AND GLJournals.FK_GLCostCenterID > 0
                                AND GLJournals.FK_GLCostDistID > 0
                      UNION ALL
--Doanh thu Ghi Tang
                      SELECT    GLJournals.GLJournalID ,
                                GLJournals.FK_GLCreditAccountID AS FK_GLAccountID ,
                                GLJournals.GLJournalAmt AS GLJournalAmt
                      FROM      #tGLJournals AS GLJournals
                                INNER JOIN GLAccounts ON GLAccounts.AAStatus = 'Alive'
                                                         AND GLJournals.FK_GLCreditAccountID = GLAccounts.GLAccountID
                                                         AND LEFT(GLAccounts.GLAccountNo,
                                                              1) IN ( '5', '7' )
                      WHERE     GLJournals.GLJournalAmt <> 0
                                AND GLJournals.FK_GLCostCenterID > 0
                                AND GLJournals.FK_GLCostDistID > 0
                      UNION ALL
--Doanh thu Ghi giam
                      SELECT    GLJournals.GLJournalID ,
                                GLJournals.FK_GLDebitAccountID AS FK_GLAccountID ,
                                -GLJournals.GLJournalAmt AS GLJournalAmt
                      FROM      #tGLJournals AS GLJournals
                                INNER JOIN GLAccounts ON GLAccounts.AAStatus = 'Alive'
                                                         AND GLJournals.FK_GLDebitAccountID = GLAccounts.GLAccountID
                                                         AND LEFT(GLAccounts.GLAccountNo,
                                                              1) IN ( '5', '7' )
                      WHERE     GLJournals.GLJournalAmt <> 0
                                AND GLJournals.FK_GLCostCenterID > 0
                                AND GLJournals.FK_GLCostDistID > 0
                    ) AS PS
                    INNER JOIN #tGLJournals AS GLJournals ON PS.GLJournalID = GLJournals.GLJournalID
          GROUP BY  FK_GLAccountID ,
                    FK_GLCostCenterID ,
                    FK_GLCostDistID
        ) AS KQ
        INNER JOIN GLAccounts ON GLAccounts.AAStatus = 'Alive'
                                 AND KQ.FK_GLAccountID = GLAccounts.GLAccountID
        INNER JOIN GLCostCenters ON GLCostCenters.AAStatus = 'Alive'
                                    AND KQ.FK_GLCostCenterID = GLCostCenters.GLCostCenterID
        LEFT JOIN GLCostDists ON GLCostDists.AAStatus = 'Alive'
                                  AND KQ.FK_GLCostDistID = GLCostDists.GLCostDistID", strTimeCond);
        if (psCostDistPostingTypeCombo != "")
            strQuery += String.Format(@"
                                  AND GLCostDistPostingTypeCombo = '{0}'",psCostDistPostingTypeCombo);

        strQuery += String.Format(@"
        LEFT JOIN GLCostCenters AS GLCostCenterParents ON GLCostCenterParents.AAStatus = 'Alive'
                                                           AND GLCostCenters.FK_GLCostCenterParentID = GLCostCenterParents.GLCostCenterID
DROP TABLE #tGLJournals");

            return dal.GetDataSet(strQuery);
        }
	}


	#endregion
}