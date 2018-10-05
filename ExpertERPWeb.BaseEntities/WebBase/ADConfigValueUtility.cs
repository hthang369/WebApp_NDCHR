using ExpertWebLib;
using System;
using System.Collections;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace ExpertERPWeb.BaseEntities
{
    public class ADConfigValueUtility
    {
        public const string ADConfigValueAll = "All";
        public const string ADConfigValueSellPrice = "SellPrice";
        public const string ADConfigValueBuyPrice = "BuyPrice";
        public const string ADConfigValuePaymentMethod = "PaymentMethod";
        public const string ADConfigValueCustomerType = "CustomerType";
        public const string ADConfigValueCustomerInvoiceType = "CustomerInvoiceType";
        public const string ADConfigValueCustomerOrderType = "CustomerOrderType";
        public const string ADConfigValueSupplierType = "SupplierType";
        public const string ADConfigValueProductCostingMethod = "ProductCostingMethod";
        public const string ADConfigValueProductType = "ProductType";
        public const string ADConfigValueStockType = "StockType";
        public const string ADConfigValueContactType = "ContactType";
        public const string ADConfigValueSellOrderItemType = "SellOrderItemType";
        public const string ADConfigValueShipmentType = "ShipmentType";
        public const string ADConfigValueReceiptType = "ReceiptType";
        public const string ADConfigValuePOSType = "POSType";
        public const string ADConfigValuePOSStatus = "POSStatus";
        public const string ADConfigValueTransferType = "TransferType";
        public const string cstContactTypeInvoice = "Invoice";
        public const string cstContactTypeProposal = "Proposal";
        public const string cstContactTypeSaleOrder = "SaleOrder";
        public const string cstContactTypePurchaseOrder = "PurchaseOrder";
        public const string cstContactTypeDelivery = "Delivery";
        public const string cstContactTypeReceipt = "Receipt";
        public const string cstContactTypeSaleReturn = "SaleReturn";
        public const string cstContactTypeCreditNote = "CreditNote";
        public const string cstContactTypeInvoiceCopy = "InvoiceCopy";
        public const string cstContactTypeProposalCopy = "ProposalCopy";
        public const string cstContactTypeSaleOrderCopy = "SaleOrderCopy";
        public const string cstContactTypeDeliveryCopy = "DeliveryCopy";
        public const string cstContactTypeReceiptCopy = "ReceiptCopy";
        public const string cstContactTypeSaleReturnCopy = "SaleReturnCopy";
        public const string cstContactTypeCreditNoteCopy = "CreditNoteCopy";
        public const string cstHistoryActionCreate = "Create";
        public const string cstHistoryActionChange = "Change";
        public const string cstHistoryActionGenerate = "Generate";
        public const string cstProposalTypeManual = "Manual";
        public const string cstProposalStatusNew = "New";
        public const string cstProposalStatusIncomplete = "Incomplete";
        public const string cstProposalStatusComplete = "Complete";
        public const string cstProposalRelateManual = "Manual";
        public const string cstProposalRelateSellOrder = "SellOrder";
        public const string cstCommissionTypeManual = "Manual";
        public const string cstCommissionTypeFromSellOrder = "FromSellOrder";
        public const string cstCommissionStatusNew = "New";
        public const string cstCommissionStatusIncomplete = "Incomplete";
        public const string cstCommissionStatusComplete = "Complete";
        public const string cstCommissionRelateManual = "Manual";
        public const string cstCommissionRelateSellOrder = "SellOrder";
        public const string cstCommissionRelateShipment = "Shipment";
        public const string cstSellReturnTypeManual = "Manual";
        public const string cstSellReturnTypeFromInvoice = "FromInvoice";
        public const string cstSellReturnTypeFromCreditNote = "FromCreditNote";
        public const string cstSellReturnStatusNew = "New";
        public const string cstSellReturnStatusIncomplete = "Incomplete";
        public const string cstSellReturnStatusComplete = "Complete";
        public const string cstSellReturnRelateManual = "Manual";
        public const string cstSellReturnRelateInvoice = "Invoice";
        public const string cstSellReturnRelateCreditNote = "CreditNote";
        public const string cstSellReturnRelateReceipt = "Receipt";
        public const string cstCreditNoteTypeManual = "Manual";
        public const string cstCreditNoteTypeFromSellReturn = "FromSellReturn";
        public const string cstCreditNoteTypeFromInvoice = "FromInvoice";
        public const string cstCreditNoteTypeFromInvoiceAffectStock = "FromInvoiceAffectStock";
        public const string cstCreditNoteStatusNew = "New";
        public const string cstCreditNoteStatusIncomplete = "Incomplete";
        public const string cstCreditNoteStatusComplete = "Complete";
        public const string cstCreditNoteRelateManual = "Manual";
        public const string cstCreditNoteRelateReceipt = "Receipt";
        public const string cstCreditNoteRelateInvoice = "Invoice";
        public const string cstTransactionTypeProposal = "Proposal";
        public const string cstTransactionTypeSellOrder = "SellOrder";
        public const string cstTransactionTypeCommission = "Commission";
        public const string cstTransactionTypeShipment = "Shipment";
        public const string cstTransactionTypeInvoice = "Invoice";
        public const string cstTransactionTypePurchaseOrder = "PurchaseOrder";
        public const string cstTransactionTypeReceipt = "Receipt";
        public const string cstTransactionTypeSellReturn = "SellReturn";
        public const string cstTransactionTypeCreditNote = "CreditNote";
        public const string cstTransactionTypeTransfer = "Transfer";
        public const string cstTransactionTypeTransferStockIn = "TransferStockIn";
        public const string cstTransactionTypeTransferStockOut = "TransferStockOut";
        public const string cstTransactionTypeZerlegung = "Zerlegung";
        public const string cstTransactionTypeRezeptur = "Rezeptur";
        public const string cstStatusActiv = "StatusActiv";
        public const string cstStatusInActiv = "StatusInActiv";
        public const string cstItemTypeProduct = "Product";
        public const string cstItemTypeText = "Text";
        public static DataSet glbdsConfigValues = new DataSet();
        public static readonly string ADConfigValueTable = "ADConfigValues";

        public static string GetTextFromKey(string strKey)
        {
            IEnumerator enumerator = glbdsConfigValues.Tables.GetEnumerator();
            while (enumerator.MoveNext())
            {
                foreach (DataRow row in ((DataTable)enumerator.Current).Rows)
                {
                    if (row["Key"].ToString() == strKey)
                    {
                        return row["Text"].ToString();
                    }
                }
            }
            return string.Empty;
        }

        public static string GetTextFromKey(string strKey, string strConfigValueTableName)
        {
            foreach (DataRow row in glbdsConfigValues.Tables[strConfigValueTableName].Rows)
            {
                if (row["Key"].ToString() == strKey)
                {
                    return row["Text"].ToString();
                }
            }
            return string.Empty;
        }

        public static DataTable InitConfigValueTable(string strADConfigValueGroup)
        {
            return glbdsConfigValues.Tables[strADConfigValueGroup];
        }

        public static DataTable InitConfigValueTableStructure(string strConfigKey)
        {
            DataColumn column = new DataColumn();
            DataColumn[] columnArray = new DataColumn[1];
            column.ColumnName = "Key";
            column.DataType = typeof(string);
            DataTable table1 = new DataTable(strConfigKey);
            table1.Columns.Add(column);
            columnArray[0] = column;
            DataColumn column2 = new DataColumn
            {
                ColumnName = "Value",
                DataType = typeof(string)
            };
            table1.Columns.Add(column2);
            DataColumn column3 = new DataColumn
            {
                ColumnName = "Text",
                DataType = typeof(string)
            };
            table1.Columns.Add(column3);
            table1.PrimaryKey = columnArray;
            return table1;
        }

        public static void InitGlobalConfigValueTables()
        {
            ADConfigValueUtility.glbdsConfigValues.Tables.Clear();
            ADConfigValueUtility.glbdsConfigValues.Clear();
            using (DataSet ds = GMCUtil.LoadCacheXML("ConfigValues"))
            {
                Parallel.ForEach<string>((from x in ds.Tables[0].AsEnumerable()
                                          group x by x.Field<string>("ADConfigKeyGroup") into g
                                          select g.Key).ToList<string>(), delegate (string strADConfigValueGroup) {
                                              if (!string.IsNullOrEmpty(strADConfigValueGroup))
                                              {
                                                  try
                                                  {
                                                      DataTable tblStruct = InitConfigValueTableStructure(strADConfigValueGroup);
                                                      DataTable table = ds.Tables[0].AsEnumerable().Where<DataRow>(x => x.Field<string>("ADConfigKeyGroup").Equals(strADConfigValueGroup)).OrderBy<DataRow, int>(delegate (DataRow x) {
                                                          if (x["ADConfigValueSortOrder"] != DBNull.Value)
                                                          {
                                                              return x.Field<int>("ADConfigValueSortOrder");
                                                          }
                                                          return 0;
                                                      }).Select<DataRow, DataRow>(delegate (DataRow x) {
                                                          DataRow row1 = tblStruct.NewRow();
                                                          row1["Key"] = x.Field<string>("ADConfigKey");
                                                          row1["Value"] = x.Field<string>("ADConfigKeyValue");
                                                          row1["Text"] = GMCWebApp.GetControlText(x.Field<string>("ADConfigText"));
                                                          return row1;
                                                      }).CopyToDataTable<DataRow>();
                                                      table.TableName = strADConfigValueGroup;
                                                      table.PrimaryKey = new DataColumn[] { table.Columns["Key"] };
                                                      DataTable table2 = table.Copy();
                                                      table2.TableName = strADConfigValueGroup + "Search";
                                                      object[] values = new object[] { "", "", "" };
                                                      table2.Rows.Add(values);
                                                      DataSet glbdsConfigValues = ADConfigValueUtility.glbdsConfigValues;
                                                      lock (glbdsConfigValues)
                                                      {
                                                          ADConfigValueUtility.glbdsConfigValues.Tables.Add(table);
                                                          ADConfigValueUtility.glbdsConfigValues.Tables.Add(table2);
                                                      }
                                                  }
                                                  catch (Exception exception)
                                                  {
                                                      XtraMessageBox.Show("ADConfigValuesUtility" + exception.Message);
                                                      //.LogNewMessage("ADConfigValuesUtility", GMCWebApp.CurrentUser, "InitGlobalConfigValueTables", string.Format("{0}: {1} - Stack {2} - Source {3}", new object[] { strADConfigValueGroup, exception.Message, exception.StackTrace, exception.Source }), "FAIL", false);
                                                  }
                                              }
                                          });
                //GMCLogging.ShowRecentMessages();
            }
        }

        public static void UpdateValueToADConfigValueTable(string strKey, string strText)
        {
            try
            {
                GMCDbUtil.ExecuteQuery(string.Format("UPDATE [ADConfigValues] SET [ADConfigText]='{0}' WHERE [ADConfigKey]='{1}'", strText, strKey));
            }
            catch (Exception)
            {
                XtraMessageBox.Show("#Message# Exception");
            }
        }
    }
}
