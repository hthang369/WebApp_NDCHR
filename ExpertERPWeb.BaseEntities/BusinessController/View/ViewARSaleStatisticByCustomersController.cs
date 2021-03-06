using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ViewARSaleStatisticByCustomers
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:ViewARSaleStatisticByCustomersController
	//Created Date:Friday, March 16, 2012
	//-----------------------------------------------------------
	
	public class ViewARSaleStatisticByCustomersController:BaseBusinessController
	{
		public ViewARSaleStatisticByCustomersController()
		{
			dal= new DALBaseProvider("ViewARSaleStatisticByCustomers",typeof(ViewARSaleStatisticByCustomersInfo));
		}
        public List<ViewARSaleStatisticByCustomersInfo> GetListInInvoiceByEmployeeInRange(int iHREmployeeID,int iPeriod,int iYear)
        {
            string str = string.Format(@"SELECT FK_ARCustomerID,SUM(ARInvoiceAmtTot),COUNT(*) FROM dbo.ARInvoices WHERE AAStatus='Alive' AND
                                            FK_HREmployeeID={0} and Month(ARInvoiceDate)={1} and Year(ARInvoiceDate)={2}
                                            GROUP BY FK_ARCustomerID",iHREmployeeID,iPeriod,iYear);
            DataSet ds = dal.GetDataSet(str);
            List<ViewARSaleStatisticByCustomersInfo> lst=new List<ViewARSaleStatisticByCustomersInfo>();
            if(ds!=null&&ds.Tables.Count>0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    if(dr[0]!=DBNull.Value&&dr[1]!=DBNull.Value&&dr[2]!=DBNull.Value)
                    {
                        ViewARSaleStatisticByCustomersInfo info = new ViewARSaleStatisticByCustomersInfo();
                        info.FK_ARCustomerID = Convert.ToInt32(dr[0]);
                        info.ViewARSaleStatisticInvoiceAmtTot = Convert.ToDouble(dr[1]);
                        info.ViewARSaleStatisticByCustomerQty = Convert.ToDouble(dr[2]);
                        lst.Add(info);
                    }
                }
            }
            return lst;
        }
        public DataSet GetAllDataInInvoiceByCustomerInRange(int iARCustomerID, int iPeriod, int iYear)
        {
            string strQuery = string.Format(@"SELECT FK_ARCustomerID,SUM(ARInvoiceAmtTot) AS ViewARSaleStatisticInvoiceAmtTot,COUNT(*) AS ViewARSaleStatisticByCustomerQty
                                                            FROM dbo.ARInvoices 
                                                            WHERE AAStatus='Alive' AND (FK_ARCustomerID={0} OR 0={0}) 
                                                            AND MONTH(ARInvoiceDate)={1} AND YEAR(ARInvoiceDate)={2}
                                                            GROUP BY FK_ARCustomerID "
                                                            , iARCustomerID, iPeriod, iYear);
            return dal.GetDataSet(strQuery);
        }

	}
	#endregion
}