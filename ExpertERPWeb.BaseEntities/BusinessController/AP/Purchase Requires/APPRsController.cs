﻿using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region APPRs
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:APPRsController
	//Created Date:Monday, January 25, 2010
	//-----------------------------------------------------------
	
	public class APPRsController:BaseBusinessController
	{
		public APPRsController()
		{
			dal= new DALBaseProvider("APPRs",typeof(APPRsInfo));
		}

        public DataSet GetAPPRs(DateTime dtFrom, DateTime dtTo)
        {
            String strQuery = String.Format(@"SELECT * FROM dbo.APPRs WHERE AAStatus='Alive' 
                                            AND CONVERT(VARCHAR(10), [APPRDate], 112)>= CONVERT(VARCHAR(10), '{0}', 112) 
                                            AND CONVERT(VARCHAR(10), [APPRDate], 112)<= CONVERT(VARCHAR(10), '{1}', 112)", dtFrom.ToString("yyyyMMdd"), dtTo.ToString("yyyyMMdd"));
            return dal.GetDataSet(strQuery);
        }

        public Boolean CheckPRCreatePO(int iAPPRID)
        {
            string str = string.Format(@"SELECT  *
                                        FROM    dbo.APPRs
                                        WHERE   AAStatus = 'Alive'
		                                        AND APPRID = {0}
                                                AND APPRID NOT IN (
                                                SELECT DISTINCT
                                                        APPRID
                                                FROM    dbo.APPRs
                                                        INNER JOIN dbo.APPRItems ON ( APPRItems.FK_APPRID = APPRs.APPRID
                                                                                      AND APPRItems.AAStatus = APPRs.AAStatus
                                                                                      AND APPRs.AAStatus = 'Alive'
                                                                                    )
                                                        INNER JOIN dbo.APPRItemPOItems ON ( APPRItemPOItems.FK_APPRItemID = APPRItems.APPRItemID
                                                                                            AND APPRItemPOItems.AAStatus = APPRItems.AAStatus
                                                                                          )
                                                        INNER JOIN dbo.APPOItems ON ( APPOItems.APPOItemID = APPRItemPOItems.FK_APPOItemID
                                                                                      AND APPOItems.AAStatus = APPRItemPOItems.AAStatus
                                                                                    )
                                                        INNER JOIN dbo.APPOs ON ( APPOs.APPOID = APPOItems.FK_APPOID
                                                                                  AND APPOs.AAStatus = APPOItems.AAStatus
                                                                                ) )"
                , iAPPRID);

            DataSet ds = dal.GetDataSet(str);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                return false;

            return true;
        }
        public DataSet GetAllDataApproval(string strSubWhere)
        {
            string strQuery = string.Format(@"SELECT APPRID,APPRNo,APPRName,APPRDate,MAX(ADApprovalProcStepLevel) AS APPRCostTot
                                                FROM APPRs pr JOIN ADDocHistorys hs ON pr.APPRNo = hs.DocNo AND pr.AAStatus = 'Alive' AND hs.AAStatus = 'Alive'
                                                JOIN ADApprovalProcSteps app ON hs.FK_ADApprovalProdStepID = ADApprovalProcStepID AND app.AAStatus = 'Alive'
                                                WHERE {0} GROUP BY APPRID,APPRNo,APPRName,APPRDate", strSubWhere.Substring(0, strSubWhere.LastIndexOf("AND")));
            return GetDataSet(strQuery);
        }
	}
	#endregion
}