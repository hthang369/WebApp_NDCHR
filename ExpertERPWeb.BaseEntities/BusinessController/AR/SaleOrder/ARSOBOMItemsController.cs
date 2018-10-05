using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ARSOBOMItems
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:ARSOBOMItemsController
	//Created Date:Thursday, June 23, 2011
	//-----------------------------------------------------------
	
	public class ARSOBOMItemsController:BaseBusinessController
	{
		public ARSOBOMItemsController()
		{
			dal= new DALBaseProvider("ARSOBOMItems",typeof(ARSOBOMItemsInfo));
		}

        public DataSet GetSOBOMItemByICProduct(int iICproductID)
        {
            String strQuery = String.Format(@"  SELECT *
                                                FROM dbo.ARSOBOMItems
                                                WHERE AAStatus = 'Alive' AND FK_ICProductParentID != 0 ", iICproductID);

            DataSet ds = GetDataSet(strQuery);
            return ds;
        }

        public DataSet GetAllSOBOMItemByShpPlnItem(int iARShpPlnItemID)
        {
            string str = string.Format(@"SELECT  *
                                        FROM    dbo.ARSOBOMItems
                                        WHERE   AAStatus = 'Alive'
                                                AND FK_ARSOItemID IN (
                                                SELECT TOP 1
                                                        ARSOItemID
                                                FROM    dbo.ARSOItems
                                                        INNER JOIN dbo.ARSOs ON ( ARSOs.ARSOID = ARSOItems.FK_ARSOID
                                                                                  AND ARSOs.AAStatus = ARSOItems.AAStatus
                                                                                  AND ARSOs.AAStatus = 'Alive'
                                                                                )
                                                        INNER JOIN dbo.ARShpPlanItems ON ( ARShpPlanItems.FK_ARSOID = ARSOs.ARSOID
                                                                                           AND ARShpPlanItems.FK_ARSOItemID = ARSOItems.ARSOItemID
                                                                                           AND ARShpPlanItems.AAStatus = ARSOItems.AAStatus
												                                           AND ARShpPlanItems.ARShpPlanItemID = {0}
                                                                                         )
                                                        INNER JOIN dbo.ARShpPlans ON ( ARShpPlans.ARShpPlanID = ARShpPlanItems.FK_ARShpPlanID
                                                                                       AND ARShpPlans.AAStatus = ARShpPlanItems.AAStatus
                                                                                     ) )", iARShpPlnItemID);
            return dal.GetDataSet(str);
        }

        public DataSet GetAllSOBOMItemByPkgOrderItem(int iPPPkgOrderItemID)
        {
            string str = string.Format(@"SELECT  *
                                        FROM    dbo.ARSOBOMItems
                                        WHERE   AAStatus = 'Alive'
                                                AND FK_ARSOItemID IN (
                                                SELECT TOP 1
                                                        ARSOItemID
                                                FROM    dbo.ARSOItems
                                                        INNER JOIN dbo.ARSOs ON ( ARSOs.ARSOID = ARSOItems.FK_ARSOID
                                                                                  AND ARSOs.AAStatus = ARSOItems.AAStatus
                                                                                  AND ARSOs.AAStatus = 'Alive'
                                                                                )
                                                        INNER JOIN dbo.ARShpPlanItems ON ( ARShpPlanItems.FK_ARSOID = ARSOs.ARSOID
                                                                                           AND ARShpPlanItems.FK_ARSOItemID = ARSOItems.ARSOItemID
                                                                                           AND ARShpPlanItems.AAStatus = ARSOItems.AAStatus
                                                                                         )
                                                        INNER JOIN dbo.ARShpPlans ON ( ARShpPlans.ARShpPlanID = ARShpPlanItems.FK_ARShpPlanID
                                                                                       AND ARShpPlans.AAStatus = ARShpPlanItems.AAStatus
                                                                                     )
                                                        INNER JOIN dbo.PPPkgOrderItems ON ( PPPkgOrderItems.FK_ARShpPlanItemID = ARShpPlanItems.ARShpPlanItemID
                                                                                            AND PPPkgOrderItems.FK_ARSOID = ARSOs.ARSOID
                                                                                            AND PPPkgOrderItems.FK_ARSOItemID = ARSOItems.ARSOItemID
                                                                                            AND PPPkgOrderItems.AAStatus = ARShpPlanItems.AAStatus
													                                        AND PPPkgOrderItems.PPPkgOrderItemID = {0}
                                                                                          )
                                                        INNER JOIN dbo.PPPkgOrders ON ( PPPkgOrders.PPPkgOrderID = PPPkgOrderItems.FK_PPPkgOrderID
                                                                                        AND PPPkgOrders.AAStatus = PPPkgOrderItems.AAStatus
                                                                                      ) )
											 ", iPPPkgOrderItemID);
            return dal.GetDataSet(str);
        }
	}
	#endregion
}