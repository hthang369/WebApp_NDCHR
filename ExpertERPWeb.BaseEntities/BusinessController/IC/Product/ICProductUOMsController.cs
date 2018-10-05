using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ICProductUOMs
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ICProductUOMsController
	//Created Date:Tuesday, February 24, 2009
	//-----------------------------------------------------------
	
	public class ICProductUOMsController:BaseBusinessController
	{
		public ICProductUOMsController()
		{
			dal= new DALBaseProvider("ICProductUOMs",typeof(ICProductUOMsInfo));
		}
        public ICProductUOMsInfo GetProductUOMByProductUOM(int iProductID, int iUOMID)
        {
            string strQuery = string.Format(@"Select * from ICProductUOMs where AAStatus='Alive' AND FK_ICProductID={0}
                                                      AND FK_ICUOMID={1}", iProductID, iUOMID);
            DataSet ds = dal.GetDataSet(strQuery);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                return (ICProductUOMsInfo)dal.GetObjectFromDataRow(ds.Tables[0].Rows[0]);
            return null;
        }
	}
	#endregion
}