﻿using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region PPResourceProductivitys
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:PPResourceProductivitysController
	//Created Date:23 April 2015
	//-----------------------------------------------------------
	
	public class PPResourceProductivitysController:BaseBusinessController
	{
		public PPResourceProductivitysController()
		{
			dal= new DALBaseProvider("PPResourceProductivitys",typeof(PPResourceProductivitysInfo));
		}


        public DataSet GetAllObjectByICProductID(int iResourceID)
        {
            String str = String.Format(@"   SELECT *
                                            FROM dbo.PPResourceProductivitys
                                            WHERE AAStatus = 'Alive'
                                                  AND FK_PPResourceID = {0}"
                                        , iResourceID);
            return dal.GetDataSet(str);
        }
        public DataSet GetAllObjectByPPResourceIDAndResourceItem(int iResourceID, int iResourceItemID)
        {
            String str = String.Format(@"   SELECT *
                                            FROM dbo.PPResourceProductivitys
                                            WHERE AAStatus = 'Alive'
                                                  AND FK_PPResourceID = {0}
                                                  AND FK_PPResourceItemID = {1}"
                                        , iResourceID,iResourceItemID);
            return dal.GetDataSet(str);
        }

        // NhamNDH -03/2017- Lấy danh sách sản phẩm nguồn lực có sản xuất
        public DataSet GetListProductByResource(int iResourceID, int iResourceItemID, int iResourceRegimeID)
        {
            String strQuery = string.Format(@"  SELECT FK_ICProductID
                                                FROM dbo.PPResourceProductivitys
                                                INNER JOIN dbo.PPResourceItems ON PPResourceItems.PPResourceItemID = PPResourceProductivitys.FK_PPResourceItemID
								                                                AND PPResourceItems.AAStatus = 'Alive'
                                                INNER JOIN dbo.PPResources ON PPResources.PPResourceID = PPResourceItems.FK_PPResourceID
							                                                AND PPResources.AAStatus = 'Alive'
                                                WHERE PPResourceProductivitys.AAStatus = 'Alive' AND PPResourceID = {0} 
	                                                  AND PPResourceItemID = {1} AND FK_PPResourceRegimeID = {2}
                                                GROUP BY FK_ICProductID
                                            ", iResourceID, iResourceItemID,iResourceRegimeID);
            return dal.GetDataSet(strQuery);
        }
    }
	#endregion
}