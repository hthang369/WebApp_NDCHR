using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ViewGLVoucherTransactions
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ViewGLVoucherTransactionsController
	//Created Date:09 Tháng Mười Một 2012
	//-----------------------------------------------------------
	
	public class ViewGLVoucherTransactionsController:BaseBusinessController
	{
		public ViewGLVoucherTransactionsController()
		{
			dal= new DALBaseProvider("ViewGLVoucherTransactions",typeof(ViewGLVoucherTransactionsInfo));
		}

        public void InsertViewGLVoucherTran(GLVouchersInfo VoucherInfo)
        {

            ViewGLVoucherTransactionsInfo ViewGLVoucherTranInfo = new ViewGLVoucherTransactionsInfo();
            ViewGLVoucherTransactionsController ViewGLVoucherTranCtrl = new ViewGLVoucherTransactionsController();
            DataSet ds = ViewGLVoucherTranCtrl.GetAllDataByForeignColumn("FK_GLVoucherID", VoucherInfo.GLVoucherID);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                ViewGLVoucherTransactionsInfo ViewGLVoucherTraninfo = (ViewGLVoucherTransactionsInfo)ViewGLVoucherTranCtrl.GetObjectFromDataRow(ds.Tables[0].Rows[0]);
                if (ViewGLVoucherTraninfo != null)
                {
                    ViewGLVoucherTranInfo = ViewGLVoucherTraninfo;
                }
            }
            string strCreditNo = "";
            string strDebitNo = "";
            ViewGLVoucherTranInfo.FK_GLVoucherID = VoucherInfo.GLVoucherID;
            ViewGLVoucherTranInfo.ViewGLVoucherTranPayToName = VoucherInfo.GLOutPmtPayToName;
            ViewGLVoucherTranInfo.ViewGLTranPayToDesc = VoucherInfo.GLOutPmtPayToDesc;
            ViewGLVoucherTranInfo.ViewGLOutTranDesc = VoucherInfo.GLVoucherDesc;
            ViewGLVoucherTranInfo.ViewGLTranAmt = VoucherInfo.GLVoucherPaymentAmtTot;

            Dictionary<int, String> lstDebits = new Dictionary<int, String>();
            Dictionary<int, String> lstCredits = new Dictionary<int, String>();

            GLVoucherTransactionItemsController VoucherTranItemCtrl = new GLVoucherTransactionItemsController();
            ds = VoucherTranItemCtrl.GetAllDataByForeignColumn("FK_GLVoucherID", VoucherInfo.GLVoucherID);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    GLVoucherTransactionItemsInfo VoucherTranItemInfo = (GLVoucherTransactionItemsInfo)VoucherTranItemCtrl.GetObjectFromDataRow(dr);
                    if (VoucherTranItemInfo != null)
                    {
                        if (VoucherTranItemInfo.FK_GLDebitAccountID != 0)
                        {
                            if (!lstDebits.ContainsKey(VoucherTranItemInfo.FK_GLDebitAccountID))
                            {
                                GLAccountsInfo AccountInfo = (GLAccountsInfo)new GLAccountsController().GetObjectByID(VoucherTranItemInfo.FK_GLDebitAccountID);
                                if (AccountInfo != null)
                                {
                                    lstDebits.Add(VoucherTranItemInfo.FK_GLDebitAccountID, AccountInfo.GLAccountNo);
                                }
                            }

                        }
                        if (VoucherTranItemInfo.FK_GLDebitVATAccountID != 0)
                        {
                            if (!lstDebits.ContainsKey(VoucherTranItemInfo.FK_GLDebitVATAccountID))
                            {
                                GLAccountsInfo AccountDebitVAT = (GLAccountsInfo)new GLAccountsController().GetObjectByID(VoucherTranItemInfo.FK_GLDebitVATAccountID);
                                if (AccountDebitVAT != null)
                                {
                                    lstDebits.Add(VoucherTranItemInfo.FK_GLDebitVATAccountID, AccountDebitVAT.GLAccountNo);
                                }
                            }
                        }
                        if (VoucherTranItemInfo.FK_GLCreditAccountID != 0)
                        {
                            if (!lstCredits.ContainsKey(VoucherTranItemInfo.FK_GLCreditAccountID))
                            {
                                GLAccountsInfo AccountCredit = (GLAccountsInfo)new GLAccountsController().GetObjectByID(VoucherTranItemInfo.FK_GLCreditAccountID);
                                if (AccountCredit != null)
                                {
                                    lstCredits.Add(VoucherTranItemInfo.FK_GLCreditAccountID, AccountCredit.GLAccountNo);
                                }
                            }
                        }

                        if (VoucherTranItemInfo.FK_GLCreditVATAccountID != 0)
                        {
                            if (!lstCredits.ContainsKey(VoucherTranItemInfo.FK_GLCreditVATAccountID))
                            {
                                GLAccountsInfo AccountCredit = (GLAccountsInfo)new GLAccountsController().GetObjectByID(VoucherTranItemInfo.FK_GLCreditVATAccountID);
                                if (AccountCredit != null)
                                {
                                    lstCredits.Add(VoucherTranItemInfo.FK_GLCreditVATAccountID, AccountCredit.GLAccountNo);
                                }
                            }
                        }


                    }
                }
            }
            foreach (int key in lstDebits.Keys)
            {
                if (strDebitNo == "")
                {
                    strDebitNo += lstDebits[key];
                }
                else
                    strDebitNo += "," + lstDebits[key];
            }
            foreach (int key in lstCredits.Keys)
            {
                if (strCreditNo == "")
                {
                    strCreditNo += lstCredits[key];
                }
                else
                    strCreditNo += "," + lstCredits[key];
            }
            ViewGLVoucherTranInfo.ViewGLAccountNoCredit = strCreditNo;
            ViewGLVoucherTranInfo.ViewGLAccountNoDebit = strDebitNo;
            if (ViewGLVoucherTranInfo.ViewGLVoucherTranID == 0)
            {
                ViewGLVoucherTranCtrl.CreateObject(ViewGLVoucherTranInfo);
            }
            else
            {
                ViewGLVoucherTranCtrl.UpdateObject(ViewGLVoucherTranInfo);
            }
        }
	}
	#endregion
}