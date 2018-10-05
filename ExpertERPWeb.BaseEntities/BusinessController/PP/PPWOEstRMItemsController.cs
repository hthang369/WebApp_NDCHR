using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region PPWOEstRMItems
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:PPWOEstRMItemsController
	//Created Date:Monday, September 26, 2011
	//-----------------------------------------------------------
	
	public class PPWOEstRMItemsController:BaseBusinessController
	{
		public PPWOEstRMItemsController()
		{
			dal= new DALBaseProvider("PPWOEstRMItems",typeof(PPWOEstRMItemsInfo));
		}

        public PPWOEstRMItemsInfo GetObjectByWOProductAndProductParent(int iWO, int iICProductID, int iParentProductID)
        {
            string strQuery = string.Format(@"SELECT * FROM dbo.PPWOEstRMItems
                                                    WHERE FK_PPWOID={0}
                                                    AND (FK_ICProductID={1} or {1}=0)
                                                    AND (FK_ICFGProductID={2} or {2}=0)", iWO, iICProductID, iParentProductID);
            DataSet ds = dal.GetDataSet(strQuery);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                return (PPWOEstRMItemsInfo)dal.GetObjectFromDataRow(ds.Tables[0].Rows[0]);
            return null;
        }
    }
	#endregion
}