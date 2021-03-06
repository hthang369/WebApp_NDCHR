﻿using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;


namespace ExpertERP.BusinessEntities
{
    #region ARCustomers
    //-----------------------------------------------------------
    //Generated By: GMC Studio
    //Class:ARCustomersController
    //Created Date:Saturday, March 15, 2008
    //-----------------------------------------------------------

    public class ARCustomersController : BaseBusinessController
    {
        public ARCustomersController()
        {
            dal = new DALBaseProvider("ARCustomers", typeof(ARCustomersInfo));
        }
        public DataSet GetAllCustomerInSO()
        {
            String strQuery = String.Format("Select * from [dbo].[ARCustomers] WHERE [ARCustomerID] In (SELECT [FK_ARCustomerID] FROM [dbo].[ARSOs] WHERE [AAStatus]='{0}') AND [AAStatus]='{0}'", BusinessObject.DefaultAAStatus);
            return (DataSet)dal.GetDataSet(strQuery);
        }

        public DataSet GetAllCustomerDept()
        {
            String strQuery = String.Format("Select * from [dbo].[ARCustomers] WHERE AAStatus = 'Alive'");
            return (DataSet)dal.GetDataSet(strQuery);
        }

        public DataSet GetAllCustomerDeptByGroup(int iGroupID)
        {
            String strQuery = String.Format("Select * from [dbo].[ARCustomers] WHERE AAStatus = 'Alive' AND [ARCustomerOutstandingBalance] >0 AND FK_ARCustomerGroupID = {0}", iGroupID);
            return (DataSet)dal.GetDataSet(strQuery);
        }

        public DataSet GetAllCustomerHasJournal(DateTime dtFrom, DateTime dtTo)
        {
            String strQuery = String.Format(@"  SELECT * FROM [dbo].[ARCustomers] 
                                                WHERE AAStatus = 'Alive' 
                                                AND ARCustomerID IN (
                                                                        SELECT FK_ARCustomerID FROM GLJournals WHERE GLJournalDate >= '{0}' AND GLJournalDate <= '{1}'
                                                                        UNION
                                                                        SELECT FK_ARCustomerIDCredit AS FK_ARCustomerID FROM GLJournals WHERE GLJournalDate >= '{0}' AND GLJournalDate <= '{1}'
                                                                    )"
                , String.Format("{0:yyyy/M/d HH:mm:ss}", dtFrom), String.Format("{0:yyyy/M/d HH:mm:ss}", dtTo));

            return (DataSet)dal.GetDataSet(strQuery);
        }

        public DataSet GetAllCustIDs()
        {
            String strQuery = String.Format(@"  SELECT ARCustomerID FROM [dbo].[ARCustomers] 
                                                WHERE AAStatus = 'Alive' 
                                                AND ARCustomerID IN (
                                                                        SELECT FK_ARCustomerID FROM GLJournals
                                                                        UNION
                                                                        SELECT FK_ARCustomerIDCredit AS FK_ARCustomerID FROM GLJournals
                                                                    )");
            return (DataSet)dal.GetDataSet(strQuery);
        }

        public DateTime CheckARCustomerOpeningBalance(ARCustomersInfo CustomerInfo)
        {
            String strQuery = "";
            DataSet ds = new DataSet();

            #region Kiểm tra trong ARSOs
            strQuery = String.Format(@"Select MIN(ARSODate) from [dbo].[ARSOs] 
                                            WHERE AAStatus = 'Alive' 
                                            AND FK_ARCustomerID='{0}'
                                            AND ARSODate < '{1}'", CustomerInfo.ARCustomerID, String.Format("{0:yyyy/M/d HH:mm:ss}", CustomerInfo.ARCustomerOpeningBalanceDate));
            ds = dal.GetDataSet(strQuery);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0].ToString() != "")
            {
                return (DateTime)ds.Tables[0].Rows[0][0];
            }
            #endregion

            #region Kiểm tra trong GLVouchers
            strQuery = String.Format(@"Select MIN(GLVoucherDate) from [dbo].[GLVouchers] 
                                            WHERE AAStatus = 'Alive' 
                                            AND FK_ARCustomerID='{0}'
                                            AND GLVoucherDate < '{1}'", CustomerInfo.ARCustomerID, String.Format("{0:yyyy/M/d HH:mm:ss}", CustomerInfo.ARCustomerOpeningBalanceDate));
            ds = dal.GetDataSet(strQuery);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0].ToString() != "")
            {
                return (DateTime)ds.Tables[0].Rows[0][0];
            }
            #endregion

            #region Kiểm tra trong ARInvoices
            strQuery = String.Format(@"Select MIN(ARInvoiceDate) from [dbo].[ARInvoices] 
                                            WHERE AAStatus = 'Alive' 
                                            AND FK_ARCustomerID='{0}'
                                            AND ARInvoiceDate < '{1}'", CustomerInfo.ARCustomerID, String.Format("{0:yyyy/M/d HH:mm:ss}", CustomerInfo.ARCustomerOpeningBalanceDate));
            ds = dal.GetDataSet(strQuery);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0].ToString() != "")
            {
                return (DateTime)ds.Tables[0].Rows[0][0];
            }
            #endregion

            #region Kiểm tra trong ARCreditNotes
            strQuery = String.Format(@"Select MIN(ARCreditNoteDate) from [dbo].[ARCreditNotes] 
                                            WHERE AAStatus = 'Alive' 
                                            AND FK_ARCustomerID='{0}'
                                            AND ARCreditNoteDate < '{1}'", CustomerInfo.ARCustomerID, String.Format("{0:yyyy/M/d HH:mm:ss}", CustomerInfo.ARCustomerOpeningBalanceDate));
            ds = dal.GetDataSet(strQuery);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0].ToString() != "")
            {
                return (DateTime)ds.Tables[0].Rows[0][0];
            }
            #endregion

            return (DateTime)CustomerInfo.ARCustomerOpeningBalanceDate;
        }
        public int GetMaxExtentionNumber(String StrStart, int ExtentionLength)
        {
            String strQuery = String.Format(@"
                                                drop table Temp1
                                                drop table Temp2
                                                select RIGHT(ARCustomerNo, 6) AS ProductNo INTO Temp1
                                                FROM ARCustomers WHERE AAStatus = 'Alive'

                                                select ISNUMERIC( RIGHT(ProductNo, {0})) AS isNumber,  RIGHT(ProductNo, {0}) AS No
                                                            into Temp2
                                                FROM Temp1 WHERE ProductNo Like '{1}%'

                                                select MAX(CAST(No AS FLOAT)) from Temp2
                                                WHERE isNumber = 1
                                                ", ExtentionLength, StrStart);
            DataSet ds = GetDataSet(strQuery);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0
                    && ds.Tables[0].Rows[0][0] != null && ds.Tables[0].Rows[0][0] != DBNull.Value)
            {
                try
                {
                    return Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                }
                catch (Exception ex)
                {
                    return 0;
                }
            }

            return 0;
        }

        public void UpdateOpeningBalance(double dAmt, DateTime dtDate, int iSupplierID)
        {
            string strQuery = String.Format(@"UPDATE ARCustomers SET ARCustomerOpeningBalance={1},ARCustomerOpeningBalanceDate='{2}' WHERE ARCustomerID={0}", iSupplierID, dAmt, String.Format("{0:yyyy/M/d HH:mm:ss}", dtDate));
            GetDataSet(strQuery);
        }
        public DataSet LayARCustomerID(String strARCustomerNo)
        {
            string strQuery = String.Format(@"SELECT * FROM ARCustomers WHERE AAStatus = 'Alive' AND ARCustomerNo = '{0}'", strARCustomerNo);
            return GetDataSet(strQuery);
        }
        public DataTable GetDataTableAliasColumnCombo(ref String strValue, ref String strDisplay, String strTableName)
        {
            String strQuery = String.Format(@"SELECT Parent.AAColumnAliasCaption, Parent.AAColumnAliasName FROM dbo.AAColumnAlias Parent
                                                INNER JOIN (
                                                            SELECT MAX(AAColumnAliasID) AS AAColumnAliasID FROM dbo.AAColumnAlias
                                                            WHERE AAStatus = 'Alive'
                                                            AND AATableName LIKE '{0}'
                                                            GROUP BY AAColumnAliasName
                                                ) AS Child ON Child.AAColumnAliasID = Parent.AAColumnAliasID
                                                INNER JOIN (
												            SELECT tab.name AS TableName, col.name AS ColumnName 
												            FROM sys.columns col
												            INNER JOIN sys.tables tab ON tab.object_id = col.object_id 
																			            AND tab.name LIKE '{0}'
												) AS Col ON Parent.AAColumnAliasName = Col.ColumnName
                                                ORDER BY Parent.AAColumnAliasCaption
                                                ", strTableName);
            DataSet ds = new AAColumnAliasController().GetDataSet(strQuery);
            if (ds != null && ds.Tables.Count > 0)
            {
                strValue = "AAColumnAliasName";
                strDisplay = "AAColumnAliasCaption";
                return ds.Tables[0];
            }
            return new DataTable();
        }

        public DataSet GetCustomerByCondition(string strCondition)
        {
            if (!string.IsNullOrEmpty(strCondition))
                if (!strCondition.ToUpper().StartsWith(" AND "))
                    strCondition = " AND " + strCondition;

            String str = String.Format(@"SELECT * FROM dbo.ARCustomers WHERE AAStatus = 'Alive' {0}", strCondition);
            return GetDataSet(str);
        }
        public int GetCustomerIDByNo(string strNo)
        {
            int iID = 0;
            string strQry = string.Format(@"SELECT * FROM dbo.ARCustomers 
                                            WHERE AAStatus = 'Alive'
                                            AND ARCustomerNo = '{0}'", strNo);
            DataSet ds = GetDataSet(strQry);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                ARCustomersInfo objARCustomersInfo = (ARCustomersInfo)GetObjectFromDataRow(ds.Tables[0].Rows[0]);
                if (objARCustomersInfo.ARCustomerID > 0)
                    iID = objARCustomersInfo.ARCustomerID;
            }
            return iID;
        }
    }
    #endregion
}