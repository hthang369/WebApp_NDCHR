using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ARFlowChartItems
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ARFlowChartItemsController
	//Created Date:Saturday, May 14, 2016
	//-----------------------------------------------------------
	
	public class ARFlowChartItemsController:BaseBusinessController
	{
		public ARFlowChartItemsController()
		{
			dal= new DALBaseProvider("ARFlowChartItems",typeof(ARFlowChartItemsInfo));
		}

        public DataSet GetAllDataByFirstParent(int iObjectID)
        {
            string strQuery = string.Format("SELECT * FROM ARFlowChartItems WHERE AAStatus = 'Alive' AND FK_ARFlowChartItemID = 0 AND ARFlowChartItemTypeCombo = 'Chart' AND FK_ARFlowChartID = {0}", iObjectID);
            return GetDataSet(strQuery);
        }
        public DataSet GetAllDataFlowChartItems(int iObjectID, string type = "")
        {
            string strQuery = string.Format("SELECT * FROM ARFlowChartItems WHERE AAStatus = 'Alive' AND ARFlowChartItemTypeCombo = '{1}' AND FK_ARFlowChartID = {0}", iObjectID, type);
            return GetDataSet(strQuery);
        }
        public DataSet GetAllDataFlowChartItemsByForeignColumn(int iObjectID, string type = "")
        {
            return GetAllDataByColumns(new string[] { "FK_ARFlowChartItemID", "ARFlowChartItemType" }, new string[] { iObjectID.ToString(), type });
        }
        public DataSet GetAllDataByIDAndListType(int iObjectID, params string[] lstType)
        {
            string strQuery = string.Format("SELECT * FROM ARFlowChartItems WHERE AAStatus = 'Alive' AND ARFlowChartItemTypeCombo IN ('{1}') AND FK_ARFlowChartID = {0}", iObjectID, string.Join("','", lstType));
            return GetDataSet(strQuery);
        }
        public DataSet GetAllDataByIDAndType(int iObjectID, string type = "")
        {
            string strQuery = string.Format("SELECT * FROM ARFlowChartItems WHERE AAStatus = 'Alive' AND ARFlowChartItemTypeCombo LIKE '{1}%' AND FK_ARFlowChartID = {0}", iObjectID, type);
            return GetDataSet(strQuery);
        }
        public DataSet GetAllDataByIDAndLayout(int iObjectID, string iObjectItemID)
        {
            string strQuery = string.Format(@"
IF OBJECT_ID('tempdb..#view') IS NOT NULL DROP TABLE #view
IF OBJECT_ID('tempdb..#view1') IS NOT NULL DROP TABLE #view1
SELECT ARFlowChartItemID,FK_ICSemiProductID,ARFlowChartItemLine,ARFlowChartItemTypeCombo
INTO #view
FROM ARFlowChartItems 
WHERE AAStatus = 'Alive' AND (ARFlowChartItemID IN({0}) OR FK_ARFlowChartItemID IN({0}))

SELECT ARFlowChartItemID
INTO #view1
FROM ARFlowChartItems
WHERE FK_ICSemiProductID IN(SELECT FK_ICSemiProductID FROM #view WHERE ARFlowChartItemTypeCombo = 'Layout')
AND ARFlowChartItemLine IN(SELECT ARFlowChartItemLine FROM #view WHERE ARFlowChartItemTypeCombo = 'Paper')
AND FK_ARFlowChartID = {1}

SELECT * FROM ARFlowChartItems
WHERE (ARFlowChartItemID IN(SELECT ARFlowChartItemID FROM #view)
OR (ARFlowChartItemID IN(SELECT ARFlowChartItemID FROM #view1)
OR  FK_ARFlowChartItemID IN(SELECT ARFlowChartItemID FROM #view1)))", iObjectItemID, iObjectID);
            return GetDataSet(strQuery);
        }
        public DataSet GetAllDataByObjectIDAndLayoutAndListType(int iObjectID, int iLayoutID, params string[] lstType)
        {
            string strQuery = string.Format(@"
                SELECT ARFlowChartItemID,FK_ICProductID,FK_ARFlowChartItemID,ARFlowChartItemTypeCombo
                INTO #view
                FROM ARFlowChartItems 
                WHERE AAStatus = 'Alive' AND FK_ARFlowChartID = {0}
                    AND ARFlowChartItemTypeCombo IN('{2}')

                SELECT ARFlowChartItemID,FK_ICProductID,FK_ARFlowChartItemID,ARFlowChartItemTypeCombo
                INTO #layout
                FROM #view 
                WHERE ARFlowChartItemID = {1}
                
                SELECT *
				FROM ARFlowChartItems a
				WHERE ARFlowChartItemID IN(
                SELECT ARFlowChartItemID FROM #layout
                UNION
                SELECT ARFlowChartItemID FROM #view
                WHERE (FK_ICProductID = (SELECT FK_ICProductID FROM #layout)
                    OR FK_ARFlowChartItemID = 0
                    OR FK_ARFlowChartItemID IN (SELECT ARFlowChartItemID FROM #view WHERE ARFlowChartItemTypeCombo = 'Formula'))
                AND ARFlowChartItemTypeCombo NOT LIKE 'Layout')
                ", iObjectID, iLayoutID, string.Join("','", lstType));
            return GetDataSet(strQuery);
        }
    }
	#endregion
}