using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region PRSlrAdjItems
    //-----------------------------------------------------------
    //Generated By: Expert Studio
    //Class:PRSlrAdjItemsController
    //Created Date:09 Tháng Giêng 2013
    //-----------------------------------------------------------

    public class PRSlrAdjItemsController : BaseBusinessController
    {
        public PRSlrAdjItemsController()
        {
            dal = new DALBaseProvider("PRSlrAdjItems", typeof(PRSlrAdjItemsInfo));
        }
        public DataSet GetAllItemInPeriod(int iHREmployeeID, int iPeriod, int iYear)
        {
            string strQuery = String.Format(@"  SELECT * FROM PRSlrAdjItems 
                                                WHERE FK_HREmployeeID = {0}
                                                AND FK_PRSlrAdjID IN (
                                                                        SELECT PRSlrAdjID FROM PRSlrAdjs 
                                                                        WHERE AAStatus = 'Alive'
                                                                        AND MONTH(PRSlrAdjEffectDate) = {1} 
                                                                        AND YEAR(PRSlrAdjEffectDate) = {2}
                                                                     )", iHREmployeeID, iPeriod, iYear);
            return GetDataSet(strQuery);
        }
        public DataSet GetAllDataInCompleteByEmployee(int iEmployeeID, DateTime dtEffectDate)
        {
            String strDate = DALUtil.GennerateCondition("PRSlrAdjEffectDate", CompareType.LessEqualThan, dtEffectDate);
            String strQuery = String.Format(@"SELECT *
                                            FROM
                                            dbo.PRSlrAdjItems WHERE AAStatus='Alive' 
                                            AND FK_HREmployeeID={0}
                                                AND PRSlrAdjItemStatusCombo<>'Complete'
                                            AND FK_PRSlrAdjID IN (SELECT PRSlrAdjID FROM PRSlrAdjs WHERE AAStatus='Alive' AND {1} )", iEmployeeID, strDate);
            return GetDataSet(strQuery);
        }
    }
    #endregion
}