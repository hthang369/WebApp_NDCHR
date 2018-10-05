using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region AREstSOItems
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:AREstSOItemsController
	//Created Date:Wednesday, January 23, 2013
	//-----------------------------------------------------------
	
	public class AREstSOItemsController:BaseBusinessController
	{
		public AREstSOItemsController()
		{
			dal= new DALBaseProvider("AREstSOItems",typeof(AREstSOItemsInfo));
		}
        public AREstSOItemsInfo GetObjectByProductInPeriod(int iICProductID, int iMonth, int iYear)
        {
            string strQuery = string.Format(@"Select Top 1 * from AREstSOItems where AAStatus='Alive' AND FK_ICProductID={0}
                                                AND FK_AREstSOID in (select AREstSOID from AREstSOs where AAStatus='Alive' 
                                                        AND AREstSOPeriod={1} AND AREstSOYear={2})", iICProductID, iMonth, iYear);

            DataSet ds = dal.GetDataSet(strQuery);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                return (AREstSOItemsInfo)dal.GetObjectFromDataRow(ds.Tables[0].Rows[0]);
            return null;
        }

        /// <summary>
        /// Viet Nguyen 2013.01.23
        // Get Qty SOItem Create From EstSO
        /// </summary>
        public double GetQtyInSO(int iEstSOItemID)
        {
            string strQuery = string.Format(@"Select SUM(ARSOItemQty) from ARSOItems where AAStatus='Alive' AND FK_AREstSOItemID={0}", iEstSOItemID);
            DataSet ds = dal.GetDataSet(strQuery);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0] != DBNull.Value)
            {
                try
                {
                    return Convert.ToDouble(ds.Tables[0].Rows[0][0]);
                }
                catch (System.Exception ex)
                {

                }
            }
            return 0;
        }

        /// <summary>
        /// Viet Nguyen 2013.01.24
        /// Get HTS Qty Of EstSO In Period & Year By Product.
        /// </summary>
       public double GetHTSQtyInPeriodByCustomer(int iProductID,int iARSOID,int iPeriod,int iYear)
       {
           string strQuery = string.Format(@"select SUM(AREstSOItemHTSQty) from AREstSOItems
                inner join ARSOItems on AREstSOItems.AREstSOItemID=ARSOItems.FK_AREstSOItemID
                inner join ARSOs on ARSOs.ARSOID=ARSOItems.FK_ARSOID
                inner join AREstSOs on AREstSOs.AREstSOID=AREstSOItems.FK_AREstSOID
                where AREstSOItems.AAStatus='Alive' AND ARSOItems.AAStatus='Alive' AND ARSOs.AAStatus='Alive' AND AREstSOs.AAStatus='Alive'
                AND AREstSOItems.FK_ICProductID={0}
                AND AREstSOPeriod={1} AND AREstSOYear={2}
                AND AREstSOs.FK_ARCustomerID in (Select FK_ARCustomerID from ARSOs where AAStatus='Alive'
	                AND ARSOID ={3})"
                    , iProductID,iPeriod,iYear,iARSOID);
           DataSet ds = dal.GetDataSet(strQuery);
           if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0] != DBNull.Value)
           {
               try
               {
                   return Convert.ToDouble(ds.Tables[0].Rows[0][0]);
               }
               catch (System.Exception ex)
               {

               }
           }
           return 0;
       }
       public DataSet GetAllDataBySO(int iARSOID)
       {
           string strQuery = string.Format(@"select * from AREstSOItems
                                                    where AAStatus='Alive' AND FK_AREstSOID in (select FK_AREstSOID from AREstSOItems 
			                                                    where AAStatus='Alive' 
                                                            AND AREstSOItemID in (select FK_AREstSOItemID from ARSOItems where AAStatus='Alive' AND FK_ARSOID={0}))"
                                                   , iARSOID);
           return dal.GetDataSet(strQuery);
       }

       public int GetMaxModifyCntInEstSOItem()
       {
           string strQuery = string.Format(@"select max(AREstSOItemModifyCnt) from AREstSOItems where AAStatus='Alive'
                                        and FK_AREstSOID in (Select AREstSOID from AREstSOs where AAStatus='Alive')");
           DataSet ds = dal.GetDataSet(strQuery);
           if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0] != DBNull.Value)
               return Convert.ToInt32(ds.Tables[0].Rows[0][0]);
           return 0;
       }

       public DataSet GetAllProductsFromEstSOItems(int iEstSOID)
       {
           String strQuery = string.Format(@"SELECT Distinct FK_ICProductID ,AREstSOItemID  
                                FROM AREstSOItems 
                                WHERE AAStatus = 'Alive' AND FK_AREstSOID={0}", iEstSOID);
           return (DataSet)dal.GetDataSet(strQuery);
       }
	}
	#endregion
}