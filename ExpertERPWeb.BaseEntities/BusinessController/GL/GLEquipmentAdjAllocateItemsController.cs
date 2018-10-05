using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region GLEquipmentAdjAllocateItems
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:GLEquipmentAdjAllocateItemsController
	//Created Date:14 July 2015
	//-----------------------------------------------------------
	
	public class GLEquipmentAdjAllocateItemsController:BaseBusinessController
	{
		public GLEquipmentAdjAllocateItemsController()
		{
			dal= new DALBaseProvider("GLEquipmentAdjAllocateItems",typeof(GLEquipmentAdjAllocateItemsInfo));
		}

        public GLEquipmentAdjAllocateItemsInfo GetLastObjectByProductInPeriodAndYear(int iICProductID, int iPeriod, int iYear)
        {
            string strQuery = string.Format(@"SELECT TOP 1
                                    dbo.GLEquipmentAdjAllocateItems.*
                            FROM    dbo.GLEquipmentAdjAllocateItems
                                    INNER JOIN dbo.GLEquipmentAdjAllocates ON dbo.GLEquipmentAdjAllocateItems.FK_GLEquipmentAdjAllocateID = dbo.GLEquipmentAdjAllocates.GLEquipmentAdjAllocateID
                                                                              AND dbo.GLEquipmentAdjAllocateItems.AAStatus = 'Alive'
                                                                              AND dbo.GLEquipmentAdjAllocates.AAStatus = 'Alive'
                                                                              AND dbo.GLEquipmentAdjAllocateItems.FK_ICProductID = {0}
                                                                              AND MONTH(dbo.GLEquipmentAdjAllocates.GLEquipmentAdjAllocateDate) = {1}
                                                                              AND YEAR(dbo.GLEquipmentAdjAllocates.GLEquipmentAdjAllocateDate) = {2}
                            ORDER BY dbo.GLEquipmentAdjAllocates.GLEquipmentAdjAllocateDate DESC ,
                                    GLEquipmentAdjAllocateItemID DESC",iICProductID,iPeriod,iYear);
            DataSet ds = GetDataSet(strQuery);
            GLEquipmentAdjAllocateItemsInfo objGLEquipmentAdjAllocateItemInfo=null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                objGLEquipmentAdjAllocateItemInfo = (GLEquipmentAdjAllocateItemsInfo)GetObjectFromDataRow(ds.Tables[0].Rows[0]);
                
            }
            return objGLEquipmentAdjAllocateItemInfo;
        }

	}
	#endregion
}