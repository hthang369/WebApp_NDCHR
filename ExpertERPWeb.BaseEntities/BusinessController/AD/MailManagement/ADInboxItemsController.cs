using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ADInboxItems
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ADInboxItemsController
	//Created Date:29 Tháng Sáu 2012
	//-----------------------------------------------------------
	
	public class ADInboxItemsController:BaseBusinessController
	{
		public ADInboxItemsController()
		{
			dal= new DALBaseProvider("ADInboxItems",typeof(ADInboxItemsInfo));
		}

        public DataSet GetAllInboxItemsByUser(string strADUserName)
        {
            string strQuery = String.Format(@"SELECT * FROM ADInboxItems WHERE   AAStatus = 'Alive'
                                                        AND (
                                                                ( ADMailToUsers LIKE '{0};' + '%'
                                                                  OR ADMailToUsers LIKE '%;' + '{0}' + ';%'
                                                                  OR ADMailToUsers LIKE '%' + ';{0}'
                                                                )
                                                            OR ( ADMailCCUsers LIKE '{0};' + '%'
                                                                  OR ADMailCCUsers LIKE '%;' + '{0}' + ';%'
                                                                  OR ADMailCCUsers LIKE '%' + ';{0}'
                                                                )
                                                            OR ( ADMailReadUsers LIKE '{0};' + '%'
                                                                  OR ADMailReadUsers LIKE '%;' + '{0}' + ';%'
                                                                  OR ADMailReadUsers LIKE '%' + ';{0}'
                                                                )
                                                            )", strADUserName);

            return dal.GetDataSet(strQuery);
        }

        public DataSet GetAllInboxUnReadItemsByUser(string strADUserName)
        {
            string strQuery = String.Format(@"  SELECT  *
                                                FROM    ADInboxItems
                                                WHERE   AAStatus = 'Alive'
                                                        AND (
                                                            ( ADMailToUsers LIKE '{0};' + '%'
                                                              OR ADMailToUsers LIKE '%;' + '{0}' + ';%'
                                                              OR ADMailToUsers LIKE '%' + ';{0}'
                                                            )
                                                        OR ( ADMailCCUsers LIKE '{0};' + '%'
                                                              OR ADMailCCUsers LIKE '%;' + '{0}' + ';%'
                                                              OR ADMailCCUsers LIKE '%' + ';{0}'
                                                            ))
                                                        AND ( 
                                                                ( ADMailReadUsers NOT LIKE '{0};' + '%'
                                                                  AND ADMailReadUsers NOT LIKE '%;' + '{0}' + ';%'
                                                                  AND ADMailReadUsers NOT LIKE '%' + ';{0}'
                                                                )
                                                            OR
                                                                (
                                                                    ADInboxItemProtocol = 'Approval'
                                                                    AND 
                                                                    (ADInboxItemAction IS NULL OR ADInboxItemAction = '')
                                                                )
                                                            )"
                                                , strADUserName);

            return dal.GetDataSet(strQuery);
        }

        public DataSet GetAllInboxUnReadItemsByUserInRange(string strUserName,DateTime dtFrom,DateTime dtTo)
        {
            String strDate = DALUtil.GenerateBeetween("ADInboxItemDate", dtFrom, dtTo);
            string strQuery = String.Format(@"SELECT  *
                                                FROM    ADInboxItems
                                                WHERE   AAStatus = 'Alive'
                                                        AND (
                                                                ( ADMailToUsers LIKE '{0};' + '%'
                                                                  OR ADMailToUsers LIKE '%;' + '{0}' + ';%'
                                                                  OR ADMailToUsers LIKE '%' + ';{0}'
                                                                )
                                                            OR 
                                                                ( ADMailCCUsers LIKE '{0};' + '%'
                                                                  OR ADMailCCUsers LIKE '%;' + '{0}' + ';%'
                                                                  OR ADMailCCUsers LIKE '%' + ';{0}'
                                                                )
                                                            )
                                                        AND ( 
                                                                ( ADMailReadUsers NOT LIKE '{0};' + '%'
                                                                  AND ADMailReadUsers NOT LIKE '%;' + '{0}' + ';%'
                                                                  AND ADMailReadUsers NOT LIKE '%' + ';{0}'
                                                                )
                                                            OR
                                                                (
                                                                    ADInboxItemProtocol = 'Approval'
                                                                    AND 
                                                                    (ADInboxItemAction IS NULL OR ADInboxItemAction = '')
                                                                )
                                                            )
                                                        AND {1}"
                                            , strUserName, strDate);

            return dal.GetDataSet(strQuery);
        }

        public ADInboxItemsInfo GetFirstObjectByDocTypeAndDocID(String strDocType, String strDocNo)
        {
            String strQuery = String.Format(@"SELECT  *
                                                FROM    dbo.ADInboxItems
                                                WHERE   AAStatus = 'Alive'
                                                        AND ADInboxItemDocType = '{0}'
                                                        AND ADInboxItemDocNo = '{1}'", strDocType, strDocNo);

            DataSet ds = GetDataSet(strQuery);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                return (ADInboxItemsInfo)GetObjectFromDataRow(ds.Tables[0].Rows[0]);

            return null;
        }

        public ADInboxItemsInfo GetLastInbox(String strDocType, String strDocNo, string strTableName, int iObjectID, string strProtocol, string strApprovalTypeCombo, int iADApprovalProcID, int iADApprovalProcStepID)
        {
            String strQuery = String.Format(@"SELECT  *
                                            FROM    dbo.ADInboxItems
                                            WHERE   AAStatus = 'Alive'
                                                    AND ADInboxItemDocType = '{0}'
                                                    AND ADInboxItemDocNo = '{1}'
		                                            AND ADInboxItemTableName = '{2}'
		                                            AND ADInboxItemObjectID = {3}
                                                    AND ADInboxItemProtocol = '{4}'
                                                    AND ADApprovalTypeCombo = '{5}'
                                                    AND FK_ADApprovalProcID = {6}
                                                    AND FK_ADApprovalProcStepID = {7}
                                            ORDER BY ADInboxItemID DESC"
                                                , strDocType, strDocNo, strTableName, iObjectID, strProtocol, strApprovalTypeCombo, iADApprovalProcID, iADApprovalProcStepID);

            DataSet ds = GetDataSet(strQuery);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                return (ADInboxItemsInfo)GetObjectFromDataRow(ds.Tables[0].Rows[0]);

            return null;
        }

        public ADInboxItemsInfo GetLastObjectByDocNo(string strDocType, string strDocNo)
        {
            String strQuery = String.Format(@"SELECT TOP 1
                                                            *
                                                    FROM    dbo.ADInboxItems
                                                    WHERE   AAStatus = 'Alive'
                                                            AND ADInboxItemDocType = '{0}'
                                                            AND ADInboxItemDocNo = N'{1}'
                                                    ORDER BY ADInboxItemID DESC", strDocType, strDocNo);
            DataSet ds = GetDataSet(strQuery);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                return (ADInboxItemsInfo)GetObjectFromDataRow(ds.Tables[0].Rows[0]);
            }

            return null;
        }
        public ADInboxItemsInfo GetADInboxItemByDocNo(string strModule, string strDocNo, int iLevel)
        {
            String strQuery = String.Format(@"SELECT   TOP 1 ADInboxItems.*
                                                    FROM    dbo.ADInboxItems ADInboxItems
                                                            INNER JOIN dbo.ADUsers ADUsers ON ( ADUsers.ADUserID = ADInboxItems.FK_ADFromUserID
                                                                                        AND ADInboxItemDocType = '{0}'
                                                                                        AND ADInboxItemDocNo = '{1}'
                                                                                        AND ADInboxItems.AAStatus = 'Alive'
                                                                                        AND ADUsers.AAStatus = 'Alive'
                                                                                      )
                                                            INNER JOIN dbo.ADApprovalProcSteps ADApprovalProcSteps ON ( AssignUsers LIKE '%'
                                                                                                    + ADUserName + ';%'
                                                                                                    AND ADApprovalProcSteps.AAStatus = 'Alive'
                                                                                                    AND ADApprovalProcStepLevel = {2}
                                                                                                  )
                                                            INNER JOIN dbo.ADApprovalProcs ADApprovalProcs ON ( ADApprovalProcs.ADApprovalProcID = ADApprovalProcSteps.FK_ADApprovalProcID
                                                                                                AND ADDocumentType = '{0}'
                                                                                                AND ADApprovalProcs.AAStatus = 'Alive'
                                                                                              )
                                                    ORDER BY ADApprovalProcStepLevel ASC", strModule, strDocNo, iLevel);

            DataSet ds = GetDataSet(strQuery);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                return (ADInboxItemsInfo)GetObjectFromDataRow(ds.Tables[0].Rows[0]);
            }

            return null;
        }

        public DataSet GetUserLevelApproval(string strModule, string strDocNo)
        {
            String strQuery = String.Format(@"SELECT    ADUserID ,
                                                        ADUserName ,
                                                        FK_ADFromUserID ,
                                                        ADApprovalProcStepLevel
                                              FROM      dbo.ADInboxItems
                                                        INNER JOIN dbo.ADUsers ON ( ADUsers.ADUserID = ADInboxItems.FK_ADFromUserID
                                                                                    AND ADInboxItemDocType = '{0}'
                                                                                    AND ADInboxItemDocNo = '{1}'                                                                                    
                                                                                    AND ADInboxItems.AAStatus = 'Alive'
                                                                                    AND dbo.ADUsers.AAStatus = 'Alive'
                                                                                  )
                                                        INNER JOIN dbo.ADApprovalProcSteps ON ( AssignUsers LIKE '%'+ ADUserName + ';%'
                                                                                                AND ADApprovalProcSteps.AAStatus = 'Alive'
                                                                                              )
                                                        INNER JOIN dbo.ADApprovalProcs ON ( ADApprovalProcs.ADApprovalProcID = ADApprovalProcSteps.FK_ADApprovalProcID
                                                                                            AND ADDocumentType = '{0}'
                                                                                            AND ADApprovalProcs.AAStatus = 'Alive'
                                                                                          )
                                                GROUP BY            ADUserID ,
                                                                    ADUserName ,
                                                                    FK_ADFromUserID ,
                                                                    ADApprovalProcStepLevel
                                                ORDER BY ADApprovalProcStepLevel ASC", strModule, strDocNo);
            return dal.GetDataSet(strQuery);
        }
        public void DeleteByDocTypeAndDocID(string sDocType, int iDocID)
        {
            String strQuery = String.Format(@"
UPDATE ADInboxItems
    SET AAStatus = 'Delete'
    WHERE ADInboxItemDocType = '{0}'
        AND ADInboxItemObjectID = {1}
"
                , sDocType, iDocID);
            dal.RunQuery(strQuery);
        }
    }
	#endregion
}