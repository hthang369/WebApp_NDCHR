using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region GLVouchers
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:GLVouchersController
	//Created Date:Thursday, January 06, 2011
	//-----------------------------------------------------------

    public enum VoucherType
    {
        InPmt = 0,
        OutPmt = 1,
        PmtReq = 2,
        Voucher = 3
    }
	public class GLVouchersController:BaseBusinessController
	{
		public GLVouchersController()
		{
			dal= new DALBaseProvider("GLVouchers",typeof(GLVouchersInfo));
		}

        public void UpdateStatusVoucher(int month, int year, bool isLock)
        {
            string strLock = "";
            if(isLock)
                strLock = "Lock";
            else
                strLock = "New";
            string query = string.Format("UPDATE GLVouchers SET GLVoucherStatusTypeCombo = '{0}' where AAStatus = 'Alive' and MONTH(GLVoucherDate) = '{1}' and YEAR(GLVoucherDate) = N'{2}'",strLock,month,year);
            GMCDbUtil.ExecuteQuery(query);
        }

        public DataSet GetAllDataInPeriod(int period, int year,string status)
        {
            string query = string.Format("Select * from GLVouchers Where AAStatus = 'Alive' and MONTH(GLVoucherDate) = '{0}' and YEAR(GLVoucherDate) = '{1}' and AAPostStatus = '{2}'", period, year, status);
            return dal.GetDataSet(query);
        }

        public DataSet GetAllDataByGroupUserAndApproveStage(String GroupUser, String ApproveStage)
        {
            String query = String.Format("Select * From GLVouchers Where AAStatus = 'Alive' And GLVoucherUserGroupStageStatusCombo = '{0}' And GLVoucherApproveStageStatusCombo = '{1}'", GroupUser, ApproveStage);
            DataSet ds = dal.GetDataSet(query);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                return ds;
            return null;
        }
        public DataSet GetAllDataByGroupUserAndApproveStageAndUser(String GroupUser, String ApproveStage, String User)
        {
            String query = String.Empty;
            if (!String.IsNullOrEmpty(GroupUser))
                query = String.Format("Select * From GLVouchers Where AAStatus = 'Alive' And GLVoucherUserGroupStageStatusCombo = '{0}' And GLVoucherApproveStageStatusCombo = '{1}' And AACreatedUser = '{2}'", GroupUser, ApproveStage, User);
            else
                query = String.Format("Select * From GLVouchers Where AAStatus = 'Alive' And GLVoucherApproveStageStatusCombo = '{0}' And AACreatedUser = '{1}'", ApproveStage, User);
            DataSet ds = dal.GetDataSet(query);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                return ds;
            return null;
        }

        public DataSet GetAllDataByGroupUser(String GroupUser)
        {
            String query = String.Format("Select * From GLVouchers Where AAStatus = 'Alive' And GLVoucherUserGroupStageStatusCombo = '{0}'", GroupUser);
            DataSet ds = dal.GetDataSet(query);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                return ds;
            return null;
        }
        public DataSet GetAllDataByGroupUserAndUser(String GroupUser, String User)
        {
            String query = String.Format("Select * From GLVouchers Where AAStatus = 'Alive' And GLVoucherUserGroupStageStatusCombo = '{0}' And AACreatedUser = '{1}'", GroupUser, User);
            DataSet ds = dal.GetDataSet(query);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                return ds;
            return null;
        }

        public DataSet GetAllDataByGroupUserDistincReject(String GroupUser)
        {
            String query = String.Format("Select * From GLVouchers Where AAStatus = 'Alive' And GLVoucherUserGroupStageStatusCombo = '{0}' And GLVoucherApproveStageStatusCombo != 'Reject'", GroupUser);
            DataSet ds = dal.GetDataSet(query);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                return ds;
            return null;
        }
        public DataSet GetAllDataByGroupUserDistincRejectAndUser(String GroupUser, String User)
        {
            String query = String.Format("Select * From GLVouchers Where AAStatus = 'Alive' And GLVoucherUserGroupStageStatusCombo = '{0}' And GLVoucherApproveStageStatusCombo != 'Reject' And AACreatedUser = '{1}'", GroupUser, User);
            DataSet ds = dal.GetDataSet(query);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                return ds;
            return null;
        }

        public int GetExtenNo(String strPrefix, int iExtenLenght)
        {
            String strQuery = String.Format(@"drop table Temp1
                                                
                                                SELECT ISNUMERIC( RIGHT(GLVoucherNo, {0})) AS isNumber,  RIGHT(GLVoucherNo, {0}) AS ExtenNo
                                                            into Temp1
                                                FROM GLVouchers
                                                WHERE AAStatus = 'Alive'
                                                AND GLVoucherNo LIKE '{1}%'

                                                select isNull(MAX(CAST(ExtenNo AS FLOAT)), 0) from Temp1
                                                WHERE isNumber = 1
                                            ", iExtenLenght, strPrefix);

            DataSet ds = GetDataSet(strQuery);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0
                && ds.Tables[0].Rows[0][0] != null && ds.Tables[0].Rows[0][0] != DBNull.Value)
                return Convert.ToInt32(ds.Tables[0].Rows[0][0]);

            return 0;

        }


        public GLVouchersInfo GetObjectByCarAllocateAndCarAllocateItem(int iCarAllocateID, int iCarAllocateItemID)
        {
            return (GLVouchersInfo)new GLVoucherItemsController().GetVoucherByCarAllocate(iCarAllocateID, iCarAllocateItemID);
        }

        public DataSet GetVoucherByType(VoucherType type, int iObjectID)
        {
            String strQuery = String.Format(@"Select * From GLVouchers 
                                            Where AAStatus = 'Alive'");

            if (type == VoucherType.InPmt)
                strQuery += String.Format(@" AND FK_ARCustomerID = {0} AND GLVoucherTypeCombo = 'InPmt'", iObjectID);
            else if (type == VoucherType.OutPmt)
                strQuery += String.Format(@" AND FK_APSupplierID = {0} AND GLVoucherTypeCombo = 'OutPmt'", iObjectID);
            else if (type == VoucherType.PmtReq)
                strQuery += String.Format(@" AND FK_APSupplierID = {0} AND GLVoucherTypeCombo = 'PmtReq'", iObjectID);
            else if (type == VoucherType.Voucher)
                strQuery += String.Format(@" AND GLVoucherTypeCombo = 'Voucher'");

            return GetDataSet(strQuery);
        }

        public DataSet GetVoucherByType(VoucherType type, int iObjectID, DateTime dtFrom, DateTime dtTo)
        {
            String strTimeCond = DALUtil.GenerateBeetween("GLVoucherDate", dtFrom, dtTo);

            String strQuery = String.Format(@"Select * From GLVouchers 
                                            Where AAStatus = 'Alive'
                                            AND {0}", strTimeCond);

            if (type == VoucherType.InPmt)
                strQuery += String.Format(@" AND (FK_ARCustomerID = {0} OR 0={0}) AND GLVoucherTypeCombo = 'InPmt'", iObjectID);
            else if (type == VoucherType.OutPmt)
                strQuery += String.Format(@" AND (FK_APSupplierID = {0} OR 0={0}) AND GLVoucherTypeCombo = 'OutPmt'", iObjectID);
            else if (type == VoucherType.PmtReq)
                strQuery += String.Format(@" AND (FK_APSupplierID = {0} OR 0={0}) AND GLVoucherTypeCombo = 'PmtReq'", iObjectID);
            else if (type == VoucherType.Voucher)
                strQuery += String.Format(@" AND GLVoucherTypeCombo = 'Voucher'");

            return GetDataSet(strQuery);
        }

        public DataSet GetVoucherByType(VoucherType type, int iObjectID, int iPeriod, int iYear)
        {
            DateTime dtFrom = new DateTime(iYear, iPeriod, 1);
            DateTime dtTo = new DateTime(iYear, iPeriod, DateTime.DaysInMonth(iYear, iPeriod));

            return GetVoucherByType(type, iObjectID, dtFrom, dtTo);
        }

        public int GetCountVoucherPaymentByType(VoucherType type, int iObjectID, DateTime dtFrom, DateTime dtTo)
        {
            String strTimeCond = DALUtil.GenerateBeetween("GLVoucherDate", dtFrom, dtTo);

            String strQuery = String.Format(@"Select COUNT(GLVoucherID) From GLVouchers 
                                            Where AAStatus = 'Alive'
                                            AND {0}", strTimeCond);

            if (type == VoucherType.InPmt)
                strQuery += String.Format(@" AND FK_ARCustomerID = {0} AND GLVoucherTypeCombo = 'InPmt'", iObjectID);
            else if (type == VoucherType.OutPmt)
                strQuery += String.Format(@" AND FK_APSupplierID = {0} AND GLVoucherTypeCombo = 'OutPmt'", iObjectID);
            else if (type == VoucherType.OutPmt)
                strQuery += String.Format(@" AND FK_APSupplierID = {0} AND GLVoucherTypeCombo = 'PmtReq'", iObjectID);
            else if (type == VoucherType.Voucher)
                strQuery += String.Format(@" AND GLVoucherTypeCombo = 'Voucher'");

            DataSet ds = GetDataSet(strQuery);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0
                    && ds.Tables[0].Rows[0][0] != null && ds.Tables[0].Rows[0][0] != DBNull.Value)
                return Convert.ToInt32(ds.Tables[0].Rows[0][0]);

            return 0;

        }

        public int GetCountVoucherPaymentByType(VoucherType type, int iObjectID, int iInvoiceID, DateTime dtFrom, DateTime dtTo)
        {
            String strTimeCond = DALUtil.GenerateBeetween("GLVoucherDate", dtFrom, dtTo);

            String strQuery = String.Format(@"Select COUNT(GLVoucherID) From GLVouchers 
                                            Where AAStatus = 'Alive'
                                            AND {0}", strTimeCond);

            if (type == VoucherType.InPmt)
            {
                strQuery += String.Format(@" AND FK_ARCustomerID = {0} AND GLVoucherTypeCombo = 'InPmt'", iObjectID);
                strQuery += String.Format(@" AND GLVoucherID IN (SELECT FK_GLVoucherID FROM GLVoucherTransactionItems WHERE AAStatus = 'ALive' AND FK_ARInvoiceID = {0})", iInvoiceID);
            }
            else if (type == VoucherType.OutPmt)
            {
                strQuery += String.Format(@" AND FK_APSupplierID = {0} AND GLVoucherTypeCombo = 'OutPmt'", iObjectID);
                strQuery += String.Format(@" AND GLVoucherID IN (SELECT FK_GLVoucherID FROM GLVoucherTransactionItems WHERE AAStatus = 'ALive' AND FK_APPInvoiceID = {0})", iInvoiceID);
            }
            else if (type == VoucherType.PmtReq)
            {
                strQuery += String.Format(@" AND FK_APSupplierID = {0} AND GLVoucherTypeCombo = 'PmtReq'", iObjectID);
                strQuery += String.Format(@" AND GLVoucherID IN (SELECT FK_GLVoucherID FROM GLVoucherTransactionItems WHERE AAStatus = 'ALive' AND FK_APPInvoiceID = {0})", iInvoiceID);
            }
            else if (type == VoucherType.Voucher)
                strQuery += String.Format(@" AND GLVoucherTypeCombo = 'Voucher'");

            DataSet ds = GetDataSet(strQuery);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0
                    && ds.Tables[0].Rows[0][0] != null && ds.Tables[0].Rows[0][0] != DBNull.Value)
                return Convert.ToInt32(ds.Tables[0].Rows[0][0]);

            return 0;

        }

        public int GetSumVoucherPaymentByType(VoucherType type, int iObjectID)
        {
            String strQuery = String.Format(@"Select SUM(GLVoucherPaymentAmtTot) From GLVouchers 
                                            Where AAStatus = 'Alive'");

            if (type == VoucherType.InPmt)
                strQuery += String.Format(@" AND FK_ARCustomerID = {0} AND GLVoucherTypeCombo = 'InPmt'", iObjectID);
            else if (type == VoucherType.OutPmt)
                strQuery += String.Format(@" AND FK_APSupplierID = {0} AND GLVoucherTypeCombo = 'OutPmt'", iObjectID);
            else if (type == VoucherType.OutPmt)
                strQuery += String.Format(@" AND FK_APSupplierID = {0} AND GLVoucherTypeCombo = 'PmtReq'", iObjectID);
            else if (type == VoucherType.Voucher)
                strQuery += String.Format(@" AND GLVoucherTypeCombo = 'Voucher'");

            DataSet ds = GetDataSet(strQuery);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0
                    && ds.Tables[0].Rows[0][0] != null && ds.Tables[0].Rows[0][0] != DBNull.Value)
                return Convert.ToInt32(ds.Tables[0].Rows[0][0]);

            return 0;

        }

        public int GetSumVoucherPaymentByTypeAndPO(VoucherType type, int iPOID)
        {
            String strQuery = String.Format(@"Select SUM(GLVoucherPaymentFAmtTot) From GLVouchers 
                                            Where AAStatus = 'Alive' AND FK_APPOID={0}",iPOID);

            if (type == VoucherType.InPmt)
                strQuery += String.Format(@" AND GLVoucherTypeCombo = 'InPmt'");
            else if (type == VoucherType.OutPmt)
                strQuery += String.Format(@" AND GLVoucherTypeCombo = 'OutPmt'");
            else if (type == VoucherType.PmtReq)
                strQuery += String.Format(@" AND GLVoucherTypeCombo = 'PmtReq'");
            else if (type == VoucherType.Voucher)
                strQuery += String.Format(@" AND GLVoucherTypeCombo = 'Voucher'");

            DataSet ds = GetDataSet(strQuery);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0
                    && ds.Tables[0].Rows[0][0] != null && ds.Tables[0].Rows[0][0] != DBNull.Value)
                return Convert.ToInt32(ds.Tables[0].Rows[0][0]);

            return 0;

        }

        public double GetSumVoucherPaymentByType(VoucherType type, int iObjectID, DateTime dtFrom, DateTime dtTo)
        {
            String strTimeCond = DALUtil.GenerateBeetween("GLVoucherDate", dtFrom, dtTo);

            String strQuery = String.Format(@"Select SUM(GLVoucherPaymentAmtTot) From GLVouchers 
                                            Where AAStatus = 'Alive'
                                            AND {0}", strTimeCond);

            if (type == VoucherType.InPmt)
                strQuery += String.Format(@" AND FK_ARCustomerID = {0} AND GLVoucherTypeCombo = 'InPmt'", iObjectID);
            else if (type == VoucherType.OutPmt)
                strQuery += String.Format(@" AND FK_APSupplierID = {0} AND GLVoucherTypeCombo = 'OutPmt'", iObjectID);
            else if (type == VoucherType.PmtReq)
                strQuery += String.Format(@" AND FK_APSupplierID = {0} AND GLVoucherTypeCombo = 'PmtReq'", iObjectID);
            else if (type == VoucherType.Voucher)
                strQuery += String.Format(@" AND GLVoucherTypeCombo = 'Voucher'");

            DataSet ds = GetDataSet(strQuery);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0
                    && ds.Tables[0].Rows[0][0] != null && ds.Tables[0].Rows[0][0] != DBNull.Value)
                return Convert.ToDouble(ds.Tables[0].Rows[0][0]);

            return 0;
                
        }

        public double GetSumVoucherPaymentByType(VoucherType type, int iObjectID, int iPeriod, int iYear)
        {
            DateTime dtFrom = new DateTime(iYear, iPeriod, 1);
            DateTime dtTo = new DateTime(iYear, iPeriod, DateTime.DaysInMonth(iYear, iPeriod));

            return GetSumVoucherPaymentByType(type, iObjectID, dtFrom, dtTo);

        }

        public GLVouchersInfo GetLastVoucherByType(VoucherType type, int iObjectID)
        {
            String strQuery = String.Format(@"Select top (1) * From GLVouchers 
                                            Where AAStatus = 'Alive'");

            if (type == VoucherType.InPmt)
                strQuery += String.Format(@" AND FK_ARCustomerID = {0} AND GLVoucherTypeCombo = 'InPmt'", iObjectID);
            else if (type == VoucherType.OutPmt)
                strQuery += String.Format(@" AND FK_APSupplierID = {0} AND GLVoucherTypeCombo = 'OutPmt'", iObjectID);
            else if (type == VoucherType.PmtReq)
                strQuery += String.Format(@" AND FK_APSupplierID = {0} AND GLVoucherTypeCombo = 'PmtReq'", iObjectID);
            else if (type == VoucherType.Voucher)
                strQuery += String.Format(@" AND GLVoucherTypeCombo = 'Voucher'");

            strQuery += String.Format(@" ORDER BY GLVoucherDate DESC");

            DataSet ds = GetDataSet(strQuery);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                return (GLVouchersInfo)GetObjectFromDataRow(ds.Tables[0].Rows[0]);

            return null;
        }

        public GLVouchersInfo GetLastVoucherByType(VoucherType type, int iObjectID, int iInvoiceID)
        {
            String strQuery = String.Format(@"Select top (1) * From GLVouchers 
                                            Where AAStatus = 'Alive'");

            if (type == VoucherType.InPmt)
            {
                strQuery += String.Format(@" AND FK_ARCustomerID = {0} AND GLVoucherTypeCombo = 'InPmt'", iObjectID);
                strQuery += String.Format(@" AND GLVoucherID IN (SELECT FK_GLVoucherID FROM GLVoucherTransactionItems WHERE AAStatus = 'ALive' AND FK_ARInvoiceID = {0})", iInvoiceID);
            }
            else if (type == VoucherType.OutPmt)
            {
                strQuery += String.Format(@" AND FK_APSupplierID = {0} AND GLVoucherTypeCombo = 'OutPmt'", iObjectID);
                strQuery += String.Format(@" AND GLVoucherID IN (SELECT FK_GLVoucherID FROM GLVoucherTransactionItems WHERE AAStatus = 'ALive' AND FK_APPInvoiceID = {0})", iInvoiceID);
            }
            else if (type == VoucherType.PmtReq)
            {
                strQuery += String.Format(@" AND FK_APSupplierID = {0} AND GLVoucherTypeCombo = 'PmtReq'", iObjectID);
                strQuery += String.Format(@" AND GLVoucherID IN (SELECT FK_GLVoucherID FROM GLVoucherTransactionItems WHERE AAStatus = 'ALive' AND FK_APPInvoiceID = {0})", iInvoiceID);
            }
            else if (type == VoucherType.Voucher)
                strQuery += String.Format(@" AND GLVoucherTypeCombo = 'Voucher'");

            strQuery += String.Format(@" ORDER BY GLVoucherDate DESC");

            DataSet ds = GetDataSet(strQuery);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                return (GLVouchersInfo)GetObjectFromDataRow(ds.Tables[0].Rows[0]);

            return null;
        }

        public GLVouchersInfo GetHighestVoucherByType(VoucherType type, int iObjectID)
        {
            String strQuery = String.Format(@"Select top (1) * From GLVouchers 
                                            Where AAStatus = 'Alive'");

            if (type == VoucherType.InPmt)
                strQuery += String.Format(@" AND FK_ARCustomerID = {0} AND GLVoucherTypeCombo = 'InPmt'", iObjectID);
            else if (type == VoucherType.OutPmt)
                strQuery += String.Format(@" AND FK_APSupplierID = {0} AND GLVoucherTypeCombo = 'OutPmt'", iObjectID);
            else if (type == VoucherType.PmtReq)
                strQuery += String.Format(@" AND FK_APSupplierID = {0} AND GLVoucherTypeCombo = 'PmtReq'", iObjectID);
            else if (type == VoucherType.Voucher)
                strQuery += String.Format(@" AND GLVoucherTypeCombo = 'Voucher'");

            strQuery += String.Format(@" ORDER BY GLVoucherPaymentAmtTot DESC");

            DataSet ds =  GetDataSet(strQuery);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                return (GLVouchersInfo)GetObjectFromDataRow(ds.Tables[0].Rows[0]);

            return null;
        }

        public DataSet GetListVoucherBySupplierAndInRange(int iSupplierID, DateTime dtFromTemp, DateTime dtToTemp, string[] lstAccount)
        {
            String strAccount = "";
            foreach (String strAcc in lstAccount)
            {
                if (strAcc == "")
                    continue;
                if (strAccount == "")
                {
                    strAccount = String.Format(@"FK_GLCreditAccountID IN (SELECT GLAccountID FROM GLAccounts WHERE AAStatus='Alive' AND (GLAccountNo LIKE '{0}%' ", strAcc);
                }
                else
                {
                    strAccount += String.Format(@" OR GLAccountNo LIKE '{0}%' ", strAcc);
                }
            }
            if (strAccount != "")
                strAccount += "))";
            String strDate = DALUtil.GenerateBeetween("GLJournalDueDate", dtFromTemp, dtToTemp);
            String strQuery = String.Format(@"SELECT *
                                            FROM GLVouchers 
                                            WHERE AAStatus='Alive'
                                            AND (FK_APSupplierID={0} OR 0={0})
                                            AND GLVoucherNo IN (
	                                            SELECT DISTINCT GLJournalDocumentNo
	                                            FROM GLJournals
	                                            WHERE GLJournals.GLJournalDueDate IS NOT NULL
	                                            AND {1}
                                                AND {2}
                                            )
                                            ", iSupplierID, strDate, strAccount);
            return dal.GetDataSet(strQuery);
        }


        public double GetSumFieldOfVoucherBySupplierAndAccountInRange(String strFieldNeedSum, int iSupplierID, String[] strAccountNo, DateTime dtFrom, DateTime dtTo)
        {
            String strAccount = "";
            foreach (String strAcc in strAccountNo)
            {
                if (strAcc == "")
                    continue;
                if (strAccount == "")
                {
                    strAccount = String.Format(@"FK_GLCreditAccountID IN (SELECT GLAccountID FROM GLAccounts WHERE AAStatus='Alive' AND (GLAccountNo LIKE '{0}%' ", strAcc);
                }
                else
                {
                    strAccount += String.Format(@" OR GLAccountNo LIKE '{0}%' ", strAcc);
                }
            }
            if (strAccount != "")
                strAccount += "))";

            String strDate = DALUtil.GenerateBeetween("GLVoucherItemDueDate", dtFrom, dtTo);
            String strQuery = String.Format(@"SELECT SUM({0}) FROM GLVouchers INNER JOIN GLVoucherItems ON GLVouchers.GLVoucherID = GLVoucherItems.FK_GLVoucherID 
                                                WHERE GLVouchers.AAStatus='Alive' 
                                                    AND GLVoucherItems.AAStatus='Alive'
                                                    AND (GLVouchers.FK_APSupplierID={1} OR {1}=0)
                                                    AND GLVoucherItems.GLVoucherItemDueDate IS NOT NULL
                                                    AND {2}
                                                    AND {3}", strFieldNeedSum, iSupplierID, strDate, strAccount);

            DataSet ds = GetDataSet(strQuery);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0] != DBNull.Value)
                return Convert.ToDouble(ds.Tables[0].Rows[0][0]);
            return 0;
        }

        public DataSet GetAllDataBySupplierAndAccountInRange(int iSupplierID, String[] strAccountNo, DateTime dtFrom, DateTime dtTo)
        {
            String strAccount = "";
            foreach (String strAcc in strAccountNo)
            {
                if (strAcc == "")
                    continue;
                if (strAccount == "")
                {
                    strAccount = String.Format(@"FK_GLCreditAccountID IN (SELECT GLAccountID FROM GLAccounts WHERE AAStatus='Alive' AND (GLAccountNo LIKE '{0}%' ", strAcc);
                }
                else
                {
                    strAccount += String.Format(@" OR GLAccountNo LIKE '{0}%' ", strAcc);
                }
            }
            if (strAccount != "")
                strAccount += "))";

            String strDate = DALUtil.GenerateBeetween("GLVoucherItemDueDate", dtFrom, dtTo);
            String strQuery = String.Format(@"SELECT * FROM GLVouchers INNER JOIN GLVoucherItems ON GLVouchers.GLVoucherID = GLVoucherItems.FK_GLVoucherID 
                                                WHERE GLVouchers.AAStatus='Alive' 
                                                    AND GLVoucherItems.AAStatus='Alive'
                                                    AND (GLVouchers.FK_APSupplierID={0} OR {0}=0)
                                                    AND GLVoucherItems.GLVoucherItemDueDate IS NOT NULL
                                                    AND {1}
                                                    AND {2}", iSupplierID, strDate, strAccount);

            return GetDataSet(strQuery);
           
        }
        public DataSet GetAllVouchersNeedPaymentBySupplierInRange(int iSupplierID, DateTime dtFrom, DateTime dtTo)
        {
            String strDate = DALUtil.GenerateBeetween("GLVoucherDate", dtFrom, dtTo);
            String strQuery = String.Format(@"SELECT a.* FROM GLVouchers a
                                                LEFT JOIN (SELECT  FK_GLVoucherID ,
                            COUNT(*) cnt
                    FROM    ( SELECT    FK_GLVoucherID ,
                                        FK_APSupplierID
                              FROM      GLVoucherItems
                              WHERE     AAStatus = 'Alive'
                                        AND ( FK_APSupplierID = {0}
                                              OR {0} = 0
                                            )
                              GROUP BY  FK_GLVoucherID ,
                                        FK_APSupplierID
                            ) AS z
                    GROUP BY z.FK_GLVoucherID) b ON a.GLVoucherID = b.FK_GLVoucherID
                                                WHERE a.AAStatus='Alive' 
                                                    AND (a.FK_APSupplierID={0} OR {0}=0 OR (b.FK_GLVoucherID is not null AND cnt = 1))
                                                    AND {1} AND GLVoucherNeedPaymentCheck=1 AND GLVoucherRFAmtTot>0 ", iSupplierID, strDate);

            return GetDataSet(strQuery);

        }
        public DataSet GetAllVouchersNeedInPmtByCustomerInRange(int iCustomerID, DateTime dtFrom, DateTime dtTo)
        {
            String strDate = DALUtil.GenerateBeetween("GLVoucherDate", dtFrom, dtTo);
            String strQuery = String.Format(@"SELECT  a.*
                                                FROM    GLVouchers a
                                                        LEFT JOIN ( SELECT  FK_GLVoucherID ,
                                                                            COUNT(*) AS Cnt
                                                                    FROM    ( SELECT    FK_GLVoucherID ,
                                                                                        FK_ARCustomerID
                                                                              FROM      GLVoucherItems
                                                                              WHERE     AAStatus = 'Alive'
                                                                                        AND ( FK_ARCustomerID = {0}
                                                                                              OR {0} = 0
                                                                                            )
                                                                              GROUP BY  FK_GLVoucherID ,
                                                                                        FK_ARCustomerID
                                                                            ) AS z
                                                                    GROUP BY FK_GLVoucherID
                                                                  ) b ON a.GLVoucherID = b.FK_GLVoucherID
                                                WHERE   a.AAStatus = 'Alive'
                                                        AND a.FK_ARCustomerID = {0}
                                                        OR {0} = 0
                                                        OR ( b.FK_GLVoucherID IS NOT NULL
                                                             AND Cnt = 1
                                                           )
                                                        AND ( {1} )
                                                        AND GLVoucherNeedPaymentCheck = 1
                                                        AND GLVoucherRFAmtTot > 0 ", iCustomerID, strDate);

            return GetDataSet(strQuery);

        }
        public double GetSUMVoucherRAmt(DateTime dtFrom, DateTime dtTo)
        {
            String strDateCond = DALUtil.GenerateBeetween("GLVoucherDueDate", dtFrom, dtTo);
            String strQuery = String.Format(@"SELECT GLVoucherRAmtTot
                                            FROM dbo.GLVouchers
                                            WHERE AAStatus = 'Alive'
                                            AND GLVoucherNeedPaymentCheck = 'TRUE'
                                            AND {0}", strDateCond);

            DataSet ds = GetDataSet(strQuery);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0
                && ds.Tables[0].Rows[0][0] != null && ds.Tables[0].Rows[0][0] != DBNull.Value)
                return Convert.ToDouble(ds.Tables[0].Rows[0][0]);

            return 0;
        }

        public DataSet GetAllVoucherInComplete(DateTime dtFrom, DateTime dtTo)
        {
            String strDateCond = DALUtil.GenerateBeetween("GLVoucherDueDate", dtFrom, dtTo);
            String strQuery = String.Format(@"SELECT GLVouchers.*
                                            FROM dbo.GLVouchers
                                            WHERE AAStatus = 'Alive'
                                            AND  GLVoucherRAmtTot > 0
                                            AND GLVoucherNeedPaymentCheck = 'TRUE'
                                            AND {0}", strDateCond);

            return GetDataSet(strQuery);
        }

        public double GetSUMPmtReqAmt(DateTime dtFrom, DateTime dtTo)
        {
            String strDateCond = DALUtil.GenerateBeetween("GLVoucherDate", dtFrom, dtTo);
            String strQuery = String.Format(@"SELECT GLVoucherPaymentAmtTot
                                            FROM dbo.GLVouchers
                                            WHERE AAStatus = 'Alive'
                                            AND GLVoucherTypeCombo = 'PmtReq'
                                            AND {0}", strDateCond);

            DataSet ds = GetDataSet(strQuery);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0
                && ds.Tables[0].Rows[0][0] != null && ds.Tables[0].Rows[0][0] != DBNull.Value)
                return Convert.ToDouble(ds.Tables[0].Rows[0][0]);

            return 0;
        }

        public DataSet GetAllVoucherByType(DateTime dtFrom, DateTime dtTo, String strVoucherType)
        {
            String strDateCond = DALUtil.GenerateBeetween("GLVoucherDate", dtFrom, dtTo);
            String strQuery = String.Format(@"SELECT GLVouchers.*
                                            FROM dbo.GLVouchers
                                            WHERE AAStatus = 'Alive'
                                            AND GLVoucherTypeCombo = '{0}'
                                            AND {1}",strVoucherType, strDateCond);

            return GetDataSet(strQuery);
        }


        public DataSet GetAllDataInRangeAndType(DateTime dtFrom, DateTime dtTo, VoucherType type)
        {
            String strDateCond = DALUtil.GenerateBeetween("GLVoucherDate", dtFrom, dtTo);
            String strQuery = String.Format(@"SELECT GLVouchers.*
                                            FROM dbo.GLVouchers
                                            WHERE AAStatus = 'Alive'
                                            AND {0}", strDateCond);

            if (type == VoucherType.InPmt)
                strQuery += String.Format(@" AND GLVoucherTypeCombo = 'InPmt'");
            else if (type == VoucherType.OutPmt)
                strQuery += String.Format(@" AND GLVoucherTypeCombo = 'OutPmt'");
            else if (type == VoucherType.PmtReq)
                strQuery += String.Format(@"AND GLVoucherTypeCombo = 'PmtReq'");
            else if (type == VoucherType.Voucher)
                strQuery += String.Format(@" AND GLVoucherTypeCombo = 'Voucher'");

            return GetDataSet(strQuery);
        }

        public DataSet GetAllDataByVoucherTypeAndObjectInRange(int iObjectID, VoucherType type, DateTime dtFrom, DateTime dtTo)
        {
            String strDateFromCond = DALUtil.GennerateCondition("GLVoucherDate", CompareType.GreaterEqualThan, dtFrom);
            String strDateToCond = DALUtil.GennerateCondition("GLVoucherDate", CompareType.LessThan, dtTo);
            String strQuery = String.Format(@"SELECT GLVouchers.*
                                            FROM dbo.GLVouchers
                                            WHERE AAStatus = 'Alive' AND GLVoucherRFAmtTot>0
                                            AND {0} AND {1}", strDateFromCond, strDateToCond);
            if (type == VoucherType.InPmt)
                strQuery += String.Format(@" AND FK_ARCustomerID = {0} AND GLVoucherTypeCombo = 'InPmt'", iObjectID);
            else if (type == VoucherType.OutPmt)
                strQuery += String.Format(@" AND FK_APSupplierID = {0} AND GLVoucherTypeCombo = 'OutPmt'", iObjectID);
            else if (type == VoucherType.PmtReq)
                strQuery += String.Format(@" AND FK_APSupplierID = {0} AND GLVoucherTypeCombo = 'PmtReq'", iObjectID);
            else if (type == VoucherType.Voucher)
                strQuery += String.Format(@" AND GLVoucherTypeCombo = 'Voucher'");

            return GetDataSet(strQuery);
        }

        public DataSet GetAllPaymentByVoucherType(VoucherType type, int iObjectID)
        {
            String strWhere = "1";
            if (type == VoucherType.InPmt)
                strWhere = String.Format(@" AND FK_ARCustomerID = {0} AND GLVoucherTypeCombo = 'InPmt'", iObjectID);
            else if (type == VoucherType.OutPmt)
                strWhere = String.Format(@" AND FK_APSupplierID = {0} AND GLVoucherTypeCombo = 'OutPmt'", iObjectID);
            else if (type == VoucherType.PmtReq)
                strWhere = String.Format(@" AND FK_APSupplierID = {0} AND GLVoucherTypeCombo = 'PmtReq'", iObjectID);
            else if (type == VoucherType.Voucher)
                strWhere = String.Format(@" AND GLVoucherTypeCombo = 'Voucher'");

            String strQuery = String.Format(@"SELECT GLVouchers.*
                                            FROM dbo.GLVouchers
                                            WHERE AAStatus = 'Alive' 
                                                     {0}", strWhere);
            return GetDataSet(strQuery);
        }

        public DataSet LayDanhSachUyNhiemChiChoChungTu(String strDocNo)
        {
            String str = String.Format(@"   SELECT * FROM dbo.GLVouchers
                                            WHERE AAStatus = 'Alive'
                                            AND GLVoucherTypeCombo = 'OutPmt'
                                            AND GLVoucherID IN (
						                                            SELECT FK_GLVoucherID FROM dbo.GLVoucherTransactionItems
						                                            WHERE AAStatus = 'Alive'
						                                            AND GLVoucherTransactionItemDocNo LIKE '{0}'
						
						                                            UNION
						
						                                            SELECT FK_GLVoucherID FROM dbo.GLVoucherTransactionItems
						                                            WHERE AAStatus = 'Alive'
						                                            AND GLVoucherTransactionItemDocNo IN (
																                                            SELECT GLVoucherNo FROM dbo.GLVouchers
																                                            WHERE AAStatus = 'Alive'
																                                            AND GLVoucherID IN (
																						                                            SELECT FK_GLVoucherID FROM dbo.GLVoucherTransactionItems
																						                                            WHERE AAStatus = 'Alive'
																						                                            AND GLVoucherTransactionItemDocNo LIKE '{0}'
																					                                            )
															                                              )
					                                            )", strDocNo);
            return dal.GetDataSet(str);
        }
    }

    
	#endregion
}