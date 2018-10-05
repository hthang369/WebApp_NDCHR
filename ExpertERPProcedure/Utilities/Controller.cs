using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using ExpertWebLib;
using ExpertERP.BusinessEntities;

namespace ExpertERP
{
    public class Controller
    {
        public static ARInvoicesController InvoiceCtrl = new ARInvoicesController();

        public static ARInvoiceItemsController InvoiceItemCtrl = new ARInvoiceItemsController();
        public static APPInvoiceItemsController PInvoiceItemCtrl = new APPInvoiceItemsController();
        public static APPInvoicesController PInvoiceCtrl = new APPInvoicesController();
        public static APPInvoiceItemReceiptItemsController InvoiceInItemReceiptItemCtrl = new APPInvoiceItemReceiptItemsController();

        public static ARSOsController SOCtrl = new ARSOsController();
        public static ARSOItemsController SOItemCtrl = new ARSOItemsController();

        public static ICShipmentsController ShipmentCtrl = new ICShipmentsController();
        public static ICShipmentItemsController ShipmentItemCtrl = new ICShipmentItemsController();
        public static ICShipmentSOsController ShipmentSOCtrl = new ICShipmentSOsController();
        public static ICShipmentItemSOItemsController ShipmentItemSOItemCtrl = new ICShipmentItemSOItemsController();

        public static ARCreditNoteItemInvoiceItemsController CreditNoteItemInvoiceItemCtrl = new ARCreditNoteItemInvoiceItemsController();
        public static ARCreditNoteItemsController CreditNoteItemCtrl = new ARCreditNoteItemsController();
        public static ARCreditNoteInvoicesController CreditNoteInvoiceCtrl = new ARCreditNoteInvoicesController();
        public static APPOsController POCtrl = new APPOsController();
        public static APPOItemsController POItemCtrl = new APPOItemsController();
        public static ICReceiptPOsController ReceiptPOCtrl = new ICReceiptPOsController();
        public static ARCreditNotesController CreditNoteCtrl = new ARCreditNotesController();
        public static APCreditNotesController APCreditNoteCtrl = new APCreditNotesController();

        public static ICReceiptItemsController ReceiptItemCtrl = new ICReceiptItemsController();
        public static ICReceiptItemPurchaseOrderItemsController ReceiptItemPurchaseOrderItemCtrl = new ICReceiptItemPurchaseOrderItemsController();

        public static ICValsController ValuationCtrl = new ICValsController();
        public static ICStockTypesController StockTypeCtrl = new ICStockTypesController();

        public static ICTransactionsController TransactionCtrl = new ICTransactionsController();
        public static ICTransactionItemsController TransactionItemCtrl = new ICTransactionItemsController();

        public static GLVouchersController VoucherCtrl = new GLVouchersController();
        public static GLVoucherTransactionItemsController VoucherTransactionItemCtrl = new GLVoucherTransactionItemsController();
        public static GLVoucherItemsController VoucherItemCtrl = new GLVoucherItemsController();
        public static GENumberingsController NumberingCtrl = new GENumberingsController();

        public static ICROsController ROCtrl = new ICROsController();
        public static HRContractsController HRContractCtrl = new HRContractsController();
        public static HREmployeesController EmployeeCtrl = new HREmployeesController();
        public static HREmployeeContractsController EmployeeContractCtrl = new HREmployeeContractsController();
        public static HREmployeeContractAllowancesController EmployeeContractAllowanceCtrl = new HREmployeeContractAllowancesController();
        public static HREmployeeAllowancesController EmployeeAllowanceCtrl = new HREmployeeAllowancesController();
        public static HRAllowanceRatesController AllowanceRateCtrl = new HRAllowanceRatesController();
        public static HREmployeeInsurancesController EmployeeInsuranceCtrl = new HREmployeeInsurancesController();
        public static HREmployeeTimeCardsController EmployeeTimeCardCtrl = new HREmployeeTimeCardsController();
        public static HREmployeeOffWorksController EmployeeOffWorkCtrl = new HREmployeeOffWorksController();
        public static HREmployeeOvertimesController EmployeeOvertimeCtrl = new HREmployeeOvertimesController();
        public static HRBonusAllowancesController BonusAllowanceCtrl = new HRBonusAllowancesController();
        public static HRBonusAllowanceItemsController BonusAllowanceItemCtrl = new HRBonusAllowanceItemsController();
        public static HREmployeeLRegsController EmployeeLRegCtrl = new HREmployeeLRegsController();
        public static HREmpActivitysController EmpActivityCtrl = new HREmpActivitysController();
        public static HREmployeeRelativesController EmployeeRelativeCtrl = new HREmployeeRelativesController();
        public static HRPayrollTypesController PayrollTypeCtrl = new HRPayrollTypesController();
        public static HRDepartmentsController DepartmentCtrl = new HRDepartmentsController();
        public static HRSectionsController SectionCtrl = new HRSectionsController();
        public static HRPositionsController PositionCtrl = new HRPositionsController();
        public static HRSalaryLevelsController SalaryLevelCtrl = new HRSalaryLevelsController();
        public static HRShiftsController ShiftCtrl = new HRShiftsController();
        public static HREmployeeLeaveTypesController EmployeeLeaveTypeCtrl = new HREmployeeLeaveTypesController();
        public static HREmployeeLeaveTypeDtlsController EmployeeLeaveTypeDtlCtrl = new HREmployeeLeaveTypeDtlsController();
        public static HRInsurancesController InsuranceCtrl = new HRInsurancesController();
        public static HRSeniorityCfgsController SeniorityCfgCtrl = new HRSeniorityCfgsController();
        public static HRInTaxRatesController InTaxRateCtrl = new HRInTaxRatesController();
        public static HRDiligentCfgsController DiligentCfgCtrl = new HRDiligentCfgsController();
        public static HRAdvanceCfgsController AdvanceCfgCtrl = new HRAdvanceCfgsController();
        public static HRPerformancesController PerformanceCtrl = new HRPerformancesController();
        public static HROvertimeRatesController OvertimeRateCtrl = new HROvertimeRatesController();
        public static HROvertimeRateDtlsController OvertimeRateDtlCtrl = new HROvertimeRateDtlsController();
        public static HRHolidaysController HolidayCtrl = new HRHolidaysController();
        public static HRHolidayConfigsController HolidayConfigCtrl = new HRHolidayConfigsController();

        public static GLJournalsController JournalCtrl = new GLJournalsController();

        public static ARCustomersController CustomerCtrl = new ARCustomersController();
        public static APSuppliersController SupplierCtrl = new APSuppliersController();
        public static GECurrencysController CurrencyCtrl = new GECurrencysController();
        public static GLCostCentersController CostCenterCtrl = new GLCostCentersController();
        public static GLCostDistsController CostDistCtrl = new GLCostDistsController();
        public static ICAccountSetsController ICAccountSetCtrl = new ICAccountSetsController();
        public static APAccountSetsController APAccountSetCtrl = new APAccountSetsController();
        public static ARAccountSetsController ARAccountSetCtrl = new ARAccountSetsController();
        public static HRAccountSetsController HRAccountSetCtrl = new HRAccountSetsController();
        public static ICProductsController ProductCtrl = new ICProductsController();
        public static GLTranCfgsController TranCfgCtrl = new GLTranCfgsController();
        public static TXTaxCodesController TaxCodeCtrl = new TXTaxCodesController();
        public static FAAssetsController AssetCtrl = new FAAssetsController();
        public static ICDistributionRulesController DistributionRuleCtrl = new ICDistributionRulesController();
        public static ICStocksController StockCtrl = new ICStocksController();
        public static ICReceiptsController ReceiptCtrl = new ICReceiptsController();
        public static ICTransfersController TransferCtrl = new ICTransfersController();
        public static ICTransferItemsController TransferItemCtrl = new ICTransferItemsController();
        public static FAAssetDeprsController AssetDeprCtrl = new FAAssetDeprsController();
        public static FAAssetDeprItemsController AssetDeprItemCtrl = new FAAssetDeprItemsController();
        public static ViewDocumentsController viewDocumentCtrl = new ViewDocumentsController();
        public static PPProductionOrdrsController ProductionOrdrCtrl = new PPProductionOrdrsController();
        public static ICInventoryStatisticsController InventoryStatisticCtrl = new ICInventoryStatisticsController();
        public static PPPhaseCfgsController PhaseCfgCtrl = new PPPhaseCfgsController();
        public static PPWorkCentersController WorkCenterCtrl = new PPWorkCentersController();
        public static APPInvoiceReceiptsController PInvoiceReceiptCtrl = new APPInvoiceReceiptsController();
        public static APPInvoiceItemReceiptItemsController PInvoiceItemReceiptItemCtrl = new APPInvoiceItemReceiptItemsController();
        public static ARInvoiceShipmentsController InvoiceShipmentCtrl = new ARInvoiceShipmentsController();
        public static ARInvoiceItemShipmentItemsController InvoiceItemShipmentItemCtrl = new ARInvoiceItemShipmentItemsController();
        public static PRSlrAdjItemsController SlrAdjItemCtrl = new PRSlrAdjItemsController();
        public static PRSlrAdjsController SlrAdjCtrl = new PRSlrAdjsController();

		public static ADUsersController UserCtrl = new ADUsersController();
        public static GLAccountsController AccountCtrl = new GLAccountsController();
        public static ICProductTypesController ProductTypeCtrl = new ICProductTypesController();
        public static ADApprovalProcsController ADApprovalProcsCtrl = new ADApprovalProcsController();
        public static GLLoanAgreementsController LoanAgreementCtrl = new GLLoanAgreementsController();

        public static ADTransferDocHistorysController TransferDocHistoryCtrl = new ADTransferDocHistorysController();
        public static GLObjectsController ObjectCtrl = new GLObjectsController();
        public static ADTransferDocCfgsController TransferDocCfgCtrl = new ADTransferDocCfgsController();
        public static GETableRelationCfgsController TableRelationCfgCtrl = new GETableRelationCfgsController();
        public static GLSyncCfgsController SyncCtrl = new GLSyncCfgsController();
        public static HRAreasController HRAreaCtrl = new HRAreasController();
    }
}
