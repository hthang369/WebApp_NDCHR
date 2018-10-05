using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region PPCostFactorItems
    //-----------------------------------------------------------
    //Generated By: GMC Studio
    //Class:PPCostFactorItemsController
    //Created Date:14 Tháng Mười Một 2014
    //-----------------------------------------------------------

    public class PPCostFactorItemsController : BaseBusinessController
    {
        public PPCostFactorItemsController()
        {
            dal = new DALBaseProvider("PPCostFactorItems", typeof(PPCostFactorItemsInfo));
        }

        public DataSet GetAllDataByAccountNo(string accNo)
        {
            string strQuery = null;
            if (accNo != "635")
            {
                strQuery = string.Format(@"
                                             SELECT * FROM dbo.PPCostFactorItems
                                              WHERE FK_GLAccountID IN(
                                                                      SELECT GLAccountID FROM GLAccounts 
                                                                      WHERE AAStatus = 'Alive' AND GLAccountNo LIKE '{0}%'
                                                                                AND GLAccounts.GLAccountID NOT IN (
                                                                                                                    SELECT FK_GLAccountParentID FROM GLAccounts WHERE AAStatus = 'Alive'))
                                             ORDER BY FK_PPCostFactorID ASC"
                                          , accNo);
            }
            else
            {
                strQuery = string.Format(@"
                                             SELECT * FROM dbo.PPCostFactorItems
                                             WHERE FK_GLAccountID IN(
                                                                      SELECT GLAccountID FROM GLAccounts 
                                                                      WHERE AAStatus = 'Alive' AND (GLAccountNo LIKE '{0}%'  or GLAccountNo LIKE '811%')
                                                                                AND GLAccounts.GLAccountID NOT IN (
                                                                                                                    SELECT FK_GLAccountParentID FROM GLAccounts WHERE AAStatus = 'Alive'))
                                             ORDER BY FK_PPCostFactorID ASC"
                          , accNo);
            }

            return GetDataSet(strQuery);
        }

        public int GetPPCostFactorInFactorItemByGLAcountID(int iGLAcountID)
        {
            string strQuery = string.Format(@"
                                            SELECT * FROM dbo.PPCostFactorItems
                                            WHERE FK_GLAccountID='{0}'
            ", iGLAcountID);
            DataSet ds = GetDataSet(strQuery);
            PPCostFactorItemsController objPPCostFactorItemCtrl = new PPCostFactorItemsController();
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                PPCostFactorItemsInfo objPPCostFactorItemInfo = (PPCostFactorItemsInfo)objPPCostFactorItemCtrl.GetObjectFromDataRow(ds.Tables[0].Rows[0]);
                if (objPPCostFactorItemInfo == null) return 0;
                {
                    return objPPCostFactorItemInfo.FK_PPCostFactorID;
                }
            }
            return 0;
        }

    }
    #endregion
}