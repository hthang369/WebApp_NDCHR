using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region GLBudgetScnItemPeriods
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:GLBudgetScnItemPeriodsController
	//Created Date:21 Tháng Tám 2012
	//-----------------------------------------------------------
	
	public class GLBudgetScnItemPeriodsController:BaseBusinessController
	{
		public GLBudgetScnItemPeriodsController()
		{
			dal= new DALBaseProvider("GLBudgetScnItemPeriods",typeof(GLBudgetScnItemPeriodsInfo));
		}

        public DataSet GetAllPeriodByAccountInMonth(int iAccountID, int iMonth, int iYear)
        {
            String strQuery = String.Format(@"select GLBudgetScnItems.FK_GLAccountID, GLBudgetScnItemPeriods.* 
                                                from GLBudgetScnItemPeriods, GLBudgetScnItems, GLBudgetScns
                                                WHERE GLBudgetScnItemPeriods.AAstatus = 'ALive'
                                                AND  GLBudgetScnItems.AAstatus = 'ALive'
                                                AND  GLBudgetScns.AAstatus = 'ALive'
                                                AND GLBudgetScnItemPeriods.FK_GLBudgetScnItemID = GLBudgetScnItems.GLBudgetScnItemID
                                                AND GLBudgetScnItems.FK_GLBudgetScnID = GLBudgetScns.GLBudgetScnID
                                                AND GLBudgetScnItems.FK_GLAccountID = {0}
                                                AND GLBudgetScnItemPeriods.GLBudgetScnItemPeriodPeriod = {1}
                                                AND GLBudgetScns.GLBudgetScnYear = {2}
                                                ", iAccountID, iMonth, iYear);

            return GetDataSet(strQuery);
        }

        public double GetSummaryItemAmt(int iBudgetScnItemID, String strFieldName)
        {
            String strQuery = String.Format(@"SELECT SUM({0}) FROM GLBudgetScnItemPeriods
                                                WHERE AAStatus = 'Alive' AND FK_GLBudgetScnItemID = {1}", strFieldName, iBudgetScnItemID);

            DataSet ds = GetDataSet(strQuery);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0
                    && ds.Tables[0].Rows[0][0] != null && ds.Tables[0].Rows[0][0] != DBNull.Value)

                return Convert.ToDouble(ds.Tables[0].Rows[0][0]);

            return 0;
        }
	}
	#endregion
}