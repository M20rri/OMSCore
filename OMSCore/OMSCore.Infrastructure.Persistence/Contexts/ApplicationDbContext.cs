using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using OMSCore.Application.Interfaces;
using OMSCore.Domain.Common;
using OMSCore.Domain.Entities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace OMSCore.Infrastructure.Persistence.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        private readonly ILoggerFactory _loggerFactory;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options,
            ILoggerFactory loggerFactory
            ) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            _loggerFactory = loggerFactory;
        }

        #region DbSets

        public virtual DbSet<AmeyoQAAgentMapping> AmeyoQAAgentMappings { get; set; }

        public virtual DbSet<AmeyoQACriticalSection> AmeyoQACriticalSections { get; set; }

        public virtual DbSet<AmeyoQAEvaluationType> AmeyoQAEvaluationTypes { get; set; }

        public virtual DbSet<AmeyoQAImageDetail> AmeyoQAImageDetails { get; set; }

        public virtual DbSet<AmeyoQAInteractionType> AmeyoQAInteractionTypes { get; set; }

        public virtual DbSet<AmeyoQAScoreCritical> AmeyoQAScoreCriticals { get; set; }

        public virtual DbSet<AmeyoQAScoreHead> AmeyoQAScoreHeads { get; set; }

        public virtual DbSet<AmeyoQAScoreSection> AmeyoQAScoreSections { get; set; }

        public virtual DbSet<AmeyoQAScoreSubSection> AmeyoQAScoreSubSections { get; set; }

        public virtual DbSet<AmeyoQASection> AmeyoQASections { get; set; }

        public virtual DbSet<AmeyoQASubSection> AmeyoQASubSections { get; set; }

        public virtual DbSet<AmeyoQATeamLead> AmeyoQATeamLeads { get; set; }

        public virtual DbSet<AmeyoRuleCreation> AmeyoRuleCreations { get; set; }

        public virtual DbSet<AnalysisRow> AnalysisRows { get; set; }

        public virtual DbSet<ApiConfiguration> ApiConfigurations { get; set; }

        public virtual DbSet<ApiConfigurationPick> ApiConfigurationPicks { get; set; }

        public virtual DbSet<ApproverEntryLog> ApproverEntryLogs { get; set; }

        public virtual DbSet<AutoCompensation> AutoCompensations { get; set; }

        public virtual DbSet<AutoGateEntryLineDetail> AutoGateEntryLineDetails { get; set; }

        public virtual DbSet<AutoRefundEntry> AutoRefundEntries { get; set; }

        public virtual DbSet<BankMaster> BankMasters { get; set; }

        public virtual DbSet<BatchCalendar> BatchCalendars { get; set; }

        public virtual DbSet<BatchCalendarArchive> BatchCalendarArchives { get; set; }

        public virtual DbSet<BoutiqaatCreditLedger> BoutiqaatCreditLedgers { get; set; }

        public virtual DbSet<BoutiqaatCreditLedgerReport> BoutiqaatCreditLedgerReports { get; set; }

        public virtual DbSet<BoxDimensionDetail> BoxDimensionDetails { get; set; }

        public virtual DbSet<BoxHeader> BoxHeaders { get; set; }

        public virtual DbSet<BoxHeaderTemp> BoxHeaderTemps { get; set; }

        public virtual DbSet<BoxInsuranceDetail> BoxInsuranceDetails { get; set; }

        public virtual DbSet<BoxLimitMapping> BoxLimitMappings { get; set; }

        public virtual DbSet<BoxLine> BoxLines { get; set; }

        public virtual DbSet<BoxLineTemp> BoxLineTemps { get; set; }

        public virtual DbSet<BoxPackingmaterialDetail> BoxPackingmaterialDetails { get; set; }

        public virtual DbSet<BoxShelvingMapping> BoxShelvingMappings { get; set; }

        public virtual DbSet<BoxStatus> BoxStatuses { get; set; }

        public virtual DbSet<BoxTaxDetail> BoxTaxDetails { get; set; }

        public virtual DbSet<BoxWaiverDetail> BoxWaiverDetails { get; set; }

        public virtual DbSet<BulkTicketClosingDatum> BulkTicketClosingData { get; set; }

        public virtual DbSet<CRMLineStatus> CRMLineStatuses { get; set; }

        public virtual DbSet<CRMOrder> CRMOrders { get; set; }

        public virtual DbSet<CRMOrderStatus> CRMOrderStatuses { get; set; }

        public virtual DbSet<CRMVIPCustomerAddressTemp> CRMVIPCustomerAddressTemps { get; set; }

        public virtual DbSet<CRMVIPGIFTOrder> CRMVIPGIFTOrders { get; set; }

        public virtual DbSet<CRMWIPOrder> CRMWIPOrders { get; set; }

        public virtual DbSet<CRMWIPOrders_Temp17012023> CRMWIPOrders_Temp17012023s { get; set; }

        public virtual DbSet<CallStatusLog> CallStatusLogs { get; set; }

        public virtual DbSet<CallTypeMaster> CallTypeMasters { get; set; }

        public virtual DbSet<CancelResponse> CancelResponses { get; set; }

        public virtual DbSet<CancelRetrunItemDetail> CancelRetrunItemDetails { get; set; }

        public virtual DbSet<CancelledOrder> CancelledOrders { get; set; }

        public virtual DbSet<CashierScannedDocument> CashierScannedDocuments { get; set; }

        public virtual DbSet<CashierToCashierHandoverLedger> CashierToCashierHandoverLedgers { get; set; }

        public virtual DbSet<CategoryOrderLimit> CategoryOrderLimits { get; set; }

        public virtual DbSet<ChangeCustomerCategoryCalender> ChangeCustomerCategoryCalenders { get; set; }

        public virtual DbSet<CityMaster> CityMasters { get; set; }

        public virtual DbSet<CompanyMaster> CompanyMasters { get; set; }

        public virtual DbSet<CompensationDetail> CompensationDetails { get; set; }

        public virtual DbSet<CompensationMaster> CompensationMasters { get; set; }

        public virtual DbSet<CountryGiftAmountMapping> CountryGiftAmountMappings { get; set; }

        public virtual DbSet<CountryMaster> CountryMasters { get; set; }

        public virtual DbSet<CountryShippingCharge> CountryShippingCharges { get; set; }

        public virtual DbSet<CreditNoteDetail> CreditNoteDetails { get; set; }

        public virtual DbSet<CrmOrderAging> CrmOrderAgings { get; set; }

        public virtual DbSet<CurrencyCode> CurrencyCodes { get; set; }

        public virtual DbSet<CurrencyCodesApiLog> CurrencyCodesApiLogs { get; set; }

        public virtual DbSet<CurrencyDenomination> CurrencyDenominations { get; set; }

        public virtual DbSet<CustomReportHeader> CustomReportHeaders { get; set; }

        public virtual DbSet<CustomReportParamDetail> CustomReportParamDetails { get; set; }

        public virtual DbSet<CustomReportPermission> CustomReportPermissions { get; set; }

        public virtual DbSet<CustomerCategoryRuleMaster> CustomerCategoryRuleMasters { get; set; }

        public virtual DbSet<CustomerDetail> CustomerDetails { get; set; }

        public virtual DbSet<CustomerDetails4> CustomerDetails4s { get; set; }

        public virtual DbSet<CustomerDetailsLog> CustomerDetailsLogs { get; set; }

        public virtual DbSet<CustomerTypeMaster> CustomerTypeMasters { get; set; }

        public virtual DbSet<DSPAPIMaster> DSPAPIMasters { get; set; }

        public virtual DbSet<DSPAWBMapping> DSPAWBMappings { get; set; }

        public virtual DbSet<DSPCapacityDetail> DSPCapacityDetails { get; set; }

        public virtual DbSet<DSPCutoffDetail> DSPCutoffDetails { get; set; }

        public virtual DbSet<DSPMaster> DSPMasters { get; set; }

        public virtual DbSet<DSPPackageInsurance> DSPPackageInsurances { get; set; }

        public virtual DbSet<DSPPackingMapping> DSPPackingMappings { get; set; }

        public virtual DbSet<DSPPhoneMapping> DSPPhoneMappings { get; set; }

        public virtual DbSet<DSPStatusDetail> DSPStatusDetails { get; set; }

        public virtual DbSet<DSPStatusDetailsDelivered> DSPStatusDetailsDelivereds { get; set; }

        public virtual DbSet<DSPStatusDetailsReturned> DSPStatusDetailsReturneds { get; set; }

        public virtual DbSet<DashBoardDetail> DashBoardDetails { get; set; }

        public virtual DbSet<DashboardProcessDataLimitDetail> DashboardProcessDataLimitDetails { get; set; }

        public virtual DbSet<DelinkShelfOnAWB> DelinkShelfOnAWBs { get; set; }

        public virtual DbSet<DeliveryTimeSlotMaster> DeliveryTimeSlotMasters { get; set; }

        public virtual DbSet<DeliveryTypeMaster> DeliveryTypeMasters { get; set; }

        public virtual DbSet<DepartmentHead> DepartmentHeads { get; set; }

        public virtual DbSet<DepartmentMaster> DepartmentMasters { get; set; }

        public virtual DbSet<DeviceMaster> DeviceMasters { get; set; }

        public virtual DbSet<DigitMasterForAutoConfirm> DigitMasterForAutoConfirms { get; set; }

        public virtual DbSet<DigitsMaster> DigitsMasters { get; set; }

        public virtual DbSet<DriverBoxAllocationTemp> DriverBoxAllocationTemps { get; set; }

        public virtual DbSet<DriverCashHeader> DriverCashHeaders { get; set; }

        public virtual DbSet<DriverCashTemp> DriverCashTemps { get; set; }

        public virtual DbSet<DriverCommissionLedger> DriverCommissionLedgers { get; set; }

        public virtual DbSet<DriverCommissionMaster> DriverCommissionMasters { get; set; }

        public virtual DbSet<DriverDeliveryStage> DriverDeliveryStages { get; set; }

        public virtual DbSet<DriverMaster> DriverMasters { get; set; }

        public virtual DbSet<DropDownOption> DropDownOptions { get; set; }

        public virtual DbSet<DspCityMapping> DspCityMappings { get; set; }

        public virtual DbSet<DspCountryMapping> DspCountryMappings { get; set; }

        public virtual DbSet<DspPayment> DspPayments { get; set; }

        public virtual DbSet<DspPayment_Temp> DspPayment_Temps { get; set; }

        public virtual DbSet<DspReconciliation_Temp> DspReconciliation_Temps { get; set; }

        public virtual DbSet<Elite_City_temp1> Elite_City_temp1s { get; set; }

        public virtual DbSet<EmailDetail> EmailDetails { get; set; }

        public virtual DbSet<ExchangeMaster> ExchangeMasters { get; set; }

        public virtual DbSet<ExistingEditOrderIssue> ExistingEditOrderIssues { get; set; }

        public virtual DbSet<FastTrackAllocatedOrder> FastTrackAllocatedOrders { get; set; }

        public virtual DbSet<FastTrackItemBinInventory> FastTrackItemBinInventories { get; set; }

        public virtual DbSet<FastTrackItemMapping> FastTrackItemMappings { get; set; }

        public virtual DbSet<FastTrackReleaseInventory> FastTrackReleaseInventories { get; set; }

        public virtual DbSet<FastTrackTableBinMapping> FastTrackTableBinMappings { get; set; }

        public virtual DbSet<FilterExpressionMapping> FilterExpressionMappings { get; set; }

        public virtual DbSet<FinanceSetup> FinanceSetups { get; set; }

        public virtual DbSet<ForLoop> ForLoops { get; set; }

        public virtual DbSet<Forward_Analysis_Header> Forward_Analysis_Headers { get; set; }

        public virtual DbSet<Forward_Analysis_Line> Forward_Analysis_Lines { get; set; }

        public virtual DbSet<GateEntryHeader> GateEntryHeaders { get; set; }

        public virtual DbSet<GateEntryLine> GateEntryLines { get; set; }

        public virtual DbSet<GiftCardOrderDetail> GiftCardOrderDetails { get; set; }

        public virtual DbSet<GiftCardRedeemRequestLog> GiftCardRedeemRequestLogs { get; set; }

        public virtual DbSet<HoldOrder> HoldOrders { get; set; }

        public virtual DbSet<HolidayMaster> HolidayMasters { get; set; }

        public virtual DbSet<InboundMessage> InboundMessages { get; set; }

        public virtual DbSet<InboundOrderAddress> InboundOrderAddresses { get; set; }

        public virtual DbSet<InboundOrderAddressLog> InboundOrderAddressLogs { get; set; }

        public virtual DbSet<InboundOrderApiLog> InboundOrderApiLogs { get; set; }

        public virtual DbSet<InboundPaymentLine> InboundPaymentLines { get; set; }

        public virtual DbSet<InboundPaymentLineLog> InboundPaymentLineLogs { get; set; }

        public virtual DbSet<InboundSalesHeader> InboundSalesHeaders { get; set; }

        public virtual DbSet<InboundSalesLine> InboundSalesLines { get; set; }

        public virtual DbSet<InternalCompanyPaymentTransfer> InternalCompanyPaymentTransfers { get; set; }

        public virtual DbSet<InvoiceStatus> InvoiceStatuses { get; set; }

        public virtual DbSet<ItemDetail> ItemDetails { get; set; }

        public virtual DbSet<ItemDetailFastTrackHistory> ItemDetailFastTrackHistories { get; set; }

        public virtual DbSet<ItemDetailWeight> ItemDetailWeights { get; set; }

        public virtual DbSet<ItemLotInfo> ItemLotInfos { get; set; }

        public virtual DbSet<ItemSortingBinZoneMapping> ItemSortingBinZoneMappings { get; set; }

        public virtual DbSet<ItemSpecialPrice> ItemSpecialPrices { get; set; }

        public virtual DbSet<ItemSpecialPriceDataAllColumn> ItemSpecialPriceDataAllColumns { get; set; }

        public virtual DbSet<ItemSpecialPriceDatum> ItemSpecialPriceData { get; set; }

        public virtual DbSet<ItemSpecialPriceExTax> ItemSpecialPriceExTaxes { get; set; }

        public virtual DbSet<ItemUrlDetail> ItemUrlDetails { get; set; }

        public virtual DbSet<LiabitlityTransfer> LiabitlityTransfers { get; set; }

        public virtual DbSet<LocationMaster> LocationMasters { get; set; }

        public virtual DbSet<LogDetail> LogDetails { get; set; }

        public virtual DbSet<LogDetailsError> LogDetailsErrors { get; set; }

        public virtual DbSet<LogTable> LogTables { get; set; }

        public virtual DbSet<LogisticsCapacity> LogisticsCapacities { get; set; }

        public virtual DbSet<LogisticsCapacityDetail> LogisticsCapacityDetails { get; set; }

        public virtual DbSet<LostAWBbyaramex> LostAWBbyaramexes { get; set; }

        public virtual DbSet<MagentoDataForInboundOrderAddress> MagentoDataForInboundOrderAddresses { get; set; }

        public virtual DbSet<MagentoOrderRequestResponse> MagentoOrderRequestResponses { get; set; }

        public virtual DbSet<MagentoToken> MagentoTokens { get; set; }

        public virtual DbSet<ManifestHeader> ManifestHeaders { get; set; }

        public virtual DbSet<ManifestLine> ManifestLines { get; set; }

        public virtual DbSet<MasterDeliveryStatus> MasterDeliveryStatuses { get; set; }

        public virtual DbSet<MigratedCustomerData20220301> MigratedCustomerData20220301s { get; set; }

        public virtual DbSet<MigratedCustomerKWTOKSA> MigratedCustomerKWTOKSAs { get; set; }

        public virtual DbSet<MissingOPE20230824> MissingOPE20230824s { get; set; }

        public virtual DbSet<MissingOpeOrder> MissingOpeOrders { get; set; }

        public virtual DbSet<MyFatoorahRefundTransactionDetail> MyFatoorahRefundTransactionDetails { get; set; }

        public virtual DbSet<MyFatoorahTransactionDetail> MyFatoorahTransactionDetails { get; set; }

        public virtual DbSet<MyFatoorahTransactionDetailsLOG> MyFatoorahTransactionDetailsLOGs { get; set; }

        public virtual DbSet<NPSConfirmedOrder> NPSConfirmedOrders { get; set; }

        public virtual DbSet<NewDSPCapacityDetail> NewDSPCapacityDetails { get; set; }

        public virtual DbSet<NotificationMasterMyFatoorah> NotificationMasterMyFatoorahs { get; set; }

        public virtual DbSet<NumberSeriesEntry> NumberSeriesEntries { get; set; }

        public virtual DbSet<NumberSeriesLocationMapping> NumberSeriesLocationMappings { get; set; }

        public virtual DbSet<NumberSeriesMaster> NumberSeriesMasters { get; set; }

        public virtual DbSet<OCTReturnRequired> OCTReturnRequireds { get; set; }

        public virtual DbSet<OCTToolHit> OCTToolHits { get; set; }

        public virtual DbSet<OffLineRefundTransactionDetail> OffLineRefundTransactionDetails { get; set; }

        public virtual DbSet<OrderBatchDetail> OrderBatchDetails { get; set; }

        public virtual DbSet<OrderBoxWeightSizeMaster> OrderBoxWeightSizeMasters { get; set; }

        public virtual DbSet<OrderCategory> OrderCategories { get; set; }

        public virtual DbSet<OrderConfirmRuleMaster> OrderConfirmRuleMasters { get; set; }

        public virtual DbSet<OrderConfirmationMandatoryFieldsMaster> OrderConfirmationMandatoryFieldsMasters { get; set; }

        public virtual DbSet<OrderCount> OrderCounts { get; set; }

        public virtual DbSet<OrderDataAnalysis> OrderDataAnalyses { get; set; }

        public virtual DbSet<OrderDetail> OrderDetails { get; set; }

        public virtual DbSet<OrderDetailPriority> OrderDetailPriorities { get; set; }

        public virtual DbSet<OrderDetailReco_20230504> OrderDetailReco_20230504s { get; set; }

        public virtual DbSet<OrderDetail_DuplicateItemID_20230503> OrderDetail_DuplicateItemID_20230503s { get; set; }

        public virtual DbSet<OrderDspAllocation> OrderDspAllocations { get; set; }

        public virtual DbSet<OrderMandatoryField> OrderMandatoryFields { get; set; }

        public virtual DbSet<OrderPaymentDetail> OrderPaymentDetails { get; set; }

        public virtual DbSet<OrderPaymentEntry> OrderPaymentEntries { get; set; }

        public virtual DbSet<OrderPaymentEntryReport> OrderPaymentEntryReports { get; set; }

        public virtual DbSet<OrderPaymentEntryTemp_31012023> OrderPaymentEntryTemp_31012023s { get; set; }

        public virtual DbSet<OrderResponse> OrderResponses { get; set; }

        public virtual DbSet<OrderSourceMaster> OrderSourceMasters { get; set; }

        public virtual DbSet<OrderStatus> OrderStatuses { get; set; }

        public virtual DbSet<OrderStatusHeader> OrderStatusHeaders { get; set; }

        public virtual DbSet<OrderStatusLine> OrderStatusLines { get; set; }

        public virtual DbSet<OrderStatusLocation> OrderStatusLocations { get; set; }

        public virtual DbSet<OrderStatusMaster> OrderStatusMasters { get; set; }

        public virtual DbSet<OrderStatusSyncTransaction> OrderStatusSyncTransactions { get; set; }

        public virtual DbSet<OrderStatus_Test> OrderStatus_Tests { get; set; }

        public virtual DbSet<OrderTaxCalculation> OrderTaxCalculations { get; set; }

        public virtual DbSet<OrderTaxDetail> OrderTaxDetails { get; set; }

        public virtual DbSet<OrderTypeMaster> OrderTypeMasters { get; set; }

        public virtual DbSet<PNAAutoCompensation> PNAAutoCompensations { get; set; }

        public virtual DbSet<PNADetailLedger> PNADetailLedgers { get; set; }

        public virtual DbSet<PNRReasonMaster> PNRReasonMasters { get; set; }

        public virtual DbSet<PackagingItem> PackagingItems { get; set; }

        public virtual DbSet<PackingMapping> PackingMappings { get; set; }

        public virtual DbSet<PageMaster> PageMasters { get; set; }

        public virtual DbSet<PaymentGatewayMapping> PaymentGatewayMappings { get; set; }

        public virtual DbSet<PaymentGatewayMaster> PaymentGatewayMasters { get; set; }

        public virtual DbSet<PaymentGateway_error_updated> PaymentGateway_error_updateds { get; set; }

        public virtual DbSet<PaymentGatewayerror_updated> PaymentGatewayerror_updateds { get; set; }

        public virtual DbSet<PaymentMaster> PaymentMasters { get; set; }

        public virtual DbSet<PendingPackaging> PendingPackagings { get; set; }

        public virtual DbSet<Pending_shipment_with_Aramex> Pending_shipment_with_Aramexes { get; set; }

        public virtual DbSet<PickDetail> PickDetails { get; set; }

        public virtual DbSet<PickDetails_DuplicateItemID_20230503> PickDetails_DuplicateItemID_20230503s { get; set; }

        public virtual DbSet<PostGateEntryHeader> PostGateEntryHeaders { get; set; }

        public virtual DbSet<PostGateEntryLine> PostGateEntryLines { get; set; }

        public virtual DbSet<PostGateEntryLine_LostAramex_Backup20230103> PostGateEntryLine_LostAramex_Backup20230103s { get; set; }

        public virtual DbSet<PostedDriverCashHeader> PostedDriverCashHeaders { get; set; }

        public virtual DbSet<PostedDriverCashLedger> PostedDriverCashLedgers { get; set; }

        public virtual DbSet<PostedManifestHeader> PostedManifestHeaders { get; set; }

        public virtual DbSet<PostedManifestLine> PostedManifestLines { get; set; }

        public virtual DbSet<PostedManifestRequestHeader> PostedManifestRequestHeaders { get; set; }

        public virtual DbSet<PostedManifestRequestLine> PostedManifestRequestLines { get; set; }

        public virtual DbSet<PostedReturnQC> PostedReturnQCs { get; set; }

        public virtual DbSet<PostedReturnQCHeader> PostedReturnQCHeaders { get; set; }

        public virtual DbSet<PostedReturnQCHeaderRemark> PostedReturnQCHeaderRemarks { get; set; }

        public virtual DbSet<PostedReturnQCHeader_2Ticket> PostedReturnQCHeader_2Tickets { get; set; }

        public virtual DbSet<PostedReturnQCHeader_BackupThreeTicketsPNR> PostedReturnQCHeader_BackupThreeTicketsPNRs { get; set; }

        public virtual DbSet<PostedReturnQCNotReturn> PostedReturnQCNotReturns { get; set; }

        public virtual DbSet<PostedReturnQC_2Ticket> PostedReturnQC_2Tickets { get; set; }

        public virtual DbSet<PostedReturnQC_BackupThreeTicketsPNR> PostedReturnQC_BackupThreeTicketsPNRs { get; set; }

        public virtual DbSet<PreOrderDateMaster> PreOrderDateMasters { get; set; }

        public virtual DbSet<PrePostedReturnQC> PrePostedReturnQCs { get; set; }

        public virtual DbSet<PrePostedReturnQCHeader> PrePostedReturnQCHeaders { get; set; }

        public virtual DbSet<PrepaidTransactionDetail> PrepaidTransactionDetails { get; set; }

        public virtual DbSet<PrinterMaster> PrinterMasters { get; set; }

        public virtual DbSet<PriorityMaster> PriorityMasters { get; set; }

        public virtual DbSet<ProcessLedger> ProcessLedgers { get; set; }

        public virtual DbSet<ProcessLedgerDetail> ProcessLedgerDetails { get; set; }

        public virtual DbSet<ProcessLedgerDetailHeader> ProcessLedgerDetailHeaders { get; set; }

        public virtual DbSet<ProcessLedgerDetailManualForceDB_20231024> ProcessLedgerDetailManualForceDB_20231024s { get; set; }

        public virtual DbSet<ProcessLedgerHeader> ProcessLedgerHeaders { get; set; }

        public virtual DbSet<ProcessLedger_WebOrderNo_ItemId> ProcessLedger_WebOrderNo_ItemIds { get; set; }

        public virtual DbSet<ProcessMaster> ProcessMasters { get; set; }

        public virtual DbSet<ProcessStatusMapping> ProcessStatusMappings { get; set; }

        public virtual DbSet<ProcessValidationMapping> ProcessValidationMappings { get; set; }

        public virtual DbSet<ProductNotReturnThreshold> ProductNotReturnThresholds { get; set; }

        public virtual DbSet<ProductTypeMaster> ProductTypeMasters { get; set; }

        public virtual DbSet<QcFailEntry> QcFailEntries { get; set; }

        public virtual DbSet<ReScheduleDetail> ReScheduleDetails { get; set; }

        public virtual DbSet<ReasonMaster> ReasonMasters { get; set; }

        public virtual DbSet<RefundGatewayMapping> RefundGatewayMappings { get; set; }

        public virtual DbSet<RefundTransactionRequestResponse> RefundTransactionRequestResponses { get; set; }

        public virtual DbSet<Refundcreatedforcompany> Refundcreatedforcompanies { get; set; }

        public virtual DbSet<RegionMaster> RegionMasters { get; set; }

        public virtual DbSet<RegisteredPickDataApiLog> RegisteredPickDataApiLogs { get; set; }

        public virtual DbSet<ReturnCategory> ReturnCategories { get; set; }

        public virtual DbSet<ReturnFraudAWB> ReturnFraudAWBs { get; set; }

        public virtual DbSet<ReturnQC> ReturnQCs { get; set; }

        public virtual DbSet<ReturnQCHeader> ReturnQCHeaders { get; set; }

        public virtual DbSet<ReturnReasonAutoCompensation> ReturnReasonAutoCompensations { get; set; }

        public virtual DbSet<ReturnReasonMaster> ReturnReasonMasters { get; set; }

        public virtual DbSet<ReturnTicket> ReturnTickets { get; set; }

        public virtual DbSet<RoleMaster> RoleMasters { get; set; }

        public virtual DbSet<RolePageMapping> RolePageMappings { get; set; }

        public virtual DbSet<SMSConfiguration> SMSConfigurations { get; set; }

        public virtual DbSet<SMSDetail> SMSDetails { get; set; }

        public virtual DbSet<SMSLanguageMaster> SMSLanguageMasters { get; set; }

        public virtual DbSet<SMSProvider> SMSProviders { get; set; }

        public virtual DbSet<SMSTagMaster> SMSTagMasters { get; set; }

        public virtual DbSet<SMSTemplate> SMSTemplates { get; set; }

        public virtual DbSet<SMSType> SMSTypes { get; set; }

        public virtual DbSet<Salasadspcity_TempTable> Salasadspcity_TempTables { get; set; }

        public virtual DbSet<SerialItemCategoryMaster> SerialItemCategoryMasters { get; set; }

        public virtual DbSet<SerialItemMaster> SerialItemMasters { get; set; }

        public virtual DbSet<SerialItemPrint> SerialItemPrints { get; set; }

        public virtual DbSet<ServicesTable> ServicesTables { get; set; }

        public virtual DbSet<Setup> Setups { get; set; }

        public virtual DbSet<SharingInvoiceSetup> SharingInvoiceSetups { get; set; }

        public virtual DbSet<ShelvingLedger> ShelvingLedgers { get; set; }

        public virtual DbSet<ShelvingLedgerTemp> ShelvingLedgerTemps { get; set; }

        public virtual DbSet<ShelvingMaster> ShelvingMasters { get; set; }

        public virtual DbSet<ShipmentMatrix> ShipmentMatrices { get; set; }

        public virtual DbSet<SorterPackingIdError> SorterPackingIdErrors { get; set; }

        public virtual DbSet<SortingBinAssignment> SortingBinAssignments { get; set; }

        public virtual DbSet<SortingBinDetail> SortingBinDetails { get; set; }

        public virtual DbSet<SortingBinDetailsArchive> SortingBinDetailsArchives { get; set; }

        public virtual DbSet<SortingBinMaster> SortingBinMasters { get; set; }

        public virtual DbSet<SortingZoneMaster> SortingZoneMasters { get; set; }

        public virtual DbSet<SqlExceptionLog> SqlExceptionLogs { get; set; }

        public virtual DbSet<StagingOrder> StagingOrders { get; set; }

        public virtual DbSet<StatusMaster> StatusMasters { get; set; }

        public virtual DbSet<StatusMasterDSP> StatusMasterDSPs { get; set; }

        public virtual DbSet<StatusProcessMapping> StatusProcessMappings { get; set; }

        public virtual DbSet<StatusSystemMapping> StatusSystemMappings { get; set; }

        public virtual DbSet<StockReleaseInformation> StockReleaseInformations { get; set; }

        public virtual DbSet<StoreCredit201201_To_210131> StoreCredit201201_To_210131s { get; set; }

        public virtual DbSet<StoreCredit210201_To_210228> StoreCredit210201_To_210228s { get; set; }

        public virtual DbSet<StoreCredit210301_To_210331> StoreCredit210301_To_210331s { get; set; }

        public virtual DbSet<StoreCredit210401_To_210430> StoreCredit210401_To_210430s { get; set; }

        public virtual DbSet<StoreCredit210501_To_210531> StoreCredit210501_To_210531s { get; set; }

        public virtual DbSet<StoreCredit210601_To_210630> StoreCredit210601_To_210630s { get; set; }

        public virtual DbSet<StoreCredit210701_To_210831> StoreCredit210701_To_210831s { get; set; }

        public virtual DbSet<StoreCredit210901_To_210930> StoreCredit210901_To_210930s { get; set; }

        public virtual DbSet<StoreCredit211001_To_211030> StoreCredit211001_To_211030s { get; set; }

        public virtual DbSet<StoreCredit211101_To_211130> StoreCredit211101_To_211130s { get; set; }

        public virtual DbSet<StoreCredit211201_To_211231> StoreCredit211201_To_211231s { get; set; }

        public virtual DbSet<StoreCreditAPR2022> StoreCreditAPR2022s { get; set; }

        public virtual DbSet<StoreCreditAUG2022> StoreCreditAUG2022s { get; set; }

        public virtual DbSet<StoreCreditDEC2022> StoreCreditDEC2022s { get; set; }

        public virtual DbSet<StoreCreditFEB2022> StoreCreditFEB2022s { get; set; }

        public virtual DbSet<StoreCreditFEB2023> StoreCreditFEB2023s { get; set; }

        public virtual DbSet<StoreCreditJAN2022> StoreCreditJAN2022s { get; set; }

        public virtual DbSet<StoreCreditJAN2023> StoreCreditJAN2023s { get; set; }

        public virtual DbSet<StoreCreditJUL2022> StoreCreditJUL2022s { get; set; }

        public virtual DbSet<StoreCreditJULAUG2023> StoreCreditJULAUG2023s { get; set; }

        public virtual DbSet<StoreCreditJUN2022> StoreCreditJUN2022s { get; set; }

        public virtual DbSet<StoreCreditJUN2023> StoreCreditJUN2023s { get; set; }

        public virtual DbSet<StoreCreditMAR2022> StoreCreditMAR2022s { get; set; }

        public virtual DbSet<StoreCreditMAR2023> StoreCreditMAR2023s { get; set; }

        public virtual DbSet<StoreCreditMAY2022> StoreCreditMAY2022s { get; set; }

        public virtual DbSet<StoreCreditMAY2023> StoreCreditMAY2023s { get; set; }

        public virtual DbSet<StoreCreditNAV2022> StoreCreditNAV2022s { get; set; }

        public virtual DbSet<StoreCreditOCT2022> StoreCreditOCT2022s { get; set; }

        public virtual DbSet<StoreCreditOCT2023> StoreCreditOCT2023s { get; set; }

        public virtual DbSet<StoreCreditRequestResponseLog> StoreCreditRequestResponseLogs { get; set; }

        public virtual DbSet<StoreCreditSEP2022> StoreCreditSEP2022s { get; set; }

        public virtual DbSet<StoreCreditSEP2023> StoreCreditSEP2023s { get; set; }

        public virtual DbSet<SubDepartmentMaster> SubDepartmentMasters { get; set; }

        public virtual DbSet<TEMP1_ARUN> TEMP1_ARUNs { get; set; }

        public virtual DbSet<TEMP1_ARUN_1> TEMP1_ARUN_1s { get; set; }

        public virtual DbSet<TEMP1_ARUN_2> TEMP1_ARUN_2s { get; set; }

        public virtual DbSet<TEMP1_ARUN_WORKING> TEMP1_ARUN_WORKINGs { get; set; }

        public virtual DbSet<TEMPInvoice> TEMPInvoices { get; set; }

        public virtual DbSet<TEMPTAX> TEMPTAXes { get; set; }

        public virtual DbSet<TMPCustomerDetail> TMPCustomerDetails { get; set; }

        public virtual DbSet<TMPInboundPaymentLine> TMPInboundPaymentLines { get; set; }

        public virtual DbSet<TableMaster> TableMasters { get; set; }

        public virtual DbSet<TaxMaster> TaxMasters { get; set; }

        public virtual DbSet<TempFastTrackAllocatedOrder> TempFastTrackAllocatedOrders { get; set; }

        public virtual DbSet<TempItemInventoryDetail> TempItemInventoryDetails { get; set; }

        public virtual DbSet<TestCustomer> TestCustomers { get; set; }

        public virtual DbSet<ThirdPartyServiceProvider> ThirdPartyServiceProviders { get; set; }

        public virtual DbSet<TicketCreationStringStage> TicketCreationStringStages { get; set; }

        public virtual DbSet<TicketHeader> TicketHeaders { get; set; }

        public virtual DbSet<TicketHeaderCompensationOPEBCL> TicketHeaderCompensationOPEBCLs { get; set; }

        public virtual DbSet<TicketHeaderLog> TicketHeaderLogs { get; set; }

        public virtual DbSet<TicketImageDetail> TicketImageDetails { get; set; }

        public virtual DbSet<TicketLine> TicketLines { get; set; }

        public virtual DbSet<TicketLineLog> TicketLineLogs { get; set; }

        public virtual DbSet<TicketMaster> TicketMasters { get; set; }

        public virtual DbSet<TicketReasonCodeLM> TicketReasonCodeLMs { get; set; }

        public virtual DbSet<TicketRefundHeader> TicketRefundHeaders { get; set; }

        public virtual DbSet<TicketRefundHeaderLog> TicketRefundHeaderLogs { get; set; }

        public virtual DbSet<TicketRefundLine> TicketRefundLines { get; set; }

        public virtual DbSet<TicketRefundLineLog> TicketRefundLineLogs { get; set; }

        public virtual DbSet<TicketRefundTransactionDateDetailLog> TicketRefundTransactionDateDetailLogs { get; set; }

        public virtual DbSet<TicketRemark> TicketRemarks { get; set; }

        public virtual DbSet<TicketStatus> TicketStatuses { get; set; }

        public virtual DbSet<TicketStatusFlow> TicketStatusFlows { get; set; }

        public virtual DbSet<TicketStatusMaster> TicketStatusMasters { get; set; }

        public virtual DbSet<URLShortnerProvider> URLShortnerProviders { get; set; }

        public virtual DbSet<UpdateAddressToLM> UpdateAddressToLMs { get; set; }

        public virtual DbSet<UpdateStatusTempStage> UpdateStatusTempStages { get; set; }

        public virtual DbSet<UpdateorderStatus> UpdateorderStatuses { get; set; }

        public virtual DbSet<UserCheckinCheckoutMaster> UserCheckinCheckoutMasters { get; set; }

        public virtual DbSet<UserCompanyMapping> UserCompanyMappings { get; set; }

        public virtual DbSet<UserCompanyMappingLog> UserCompanyMappingLogs { get; set; }

        public virtual DbSet<UserMaster> UserMasters { get; set; }

        public virtual DbSet<UserRoleMapping> UserRoleMappings { get; set; }

        public virtual DbSet<UserRoleMappingLog> UserRoleMappingLogs { get; set; }

        public virtual DbSet<UserTableMapping> UserTableMappings { get; set; }

        public virtual DbSet<UserValidationMapping> UserValidationMappings { get; set; }

        public virtual DbSet<ValidationMaster> ValidationMasters { get; set; }

        public virtual DbSet<VipCustomerGiftOrder> VipCustomerGiftOrders { get; set; }

        public virtual DbSet<VipGiftSettingRuleDetail> VipGiftSettingRuleDetails { get; set; }

        public virtual DbSet<VipGiftSettingRuleSkuDetail> VipGiftSettingRuleSkuDetails { get; set; }

        public virtual DbSet<WaiverOff> WaiverOffs { get; set; }

        public virtual DbSet<WebOrderNoCodNotCancel> WebOrderNoCodNotCancels { get; set; }

        public virtual DbSet<WebOrderNoCodWH> WebOrderNoCodWHs { get; set; }

        public virtual DbSet<ZoneMaster> ZoneMasters { get; set; }

        public virtual DbSet<electronics_from_purchase_20211216> electronics_from_purchase_20211216s { get; set; }

        public virtual DbSet<ofs_sales_invoice> ofs_sales_invoices { get; set; }

        public virtual DbSet<ofs_sales_return_invoice> ofs_sales_return_invoices { get; set; }

        public virtual DbSet<sales_analysis> sales_analyses { get; set; }

        public virtual DbSet<tbl_InvoiceCountryToDownload> tbl_InvoiceCountryToDownloads { get; set; }

        public virtual DbSet<tempAWBGE> tempAWBGEs { get; set; }

        public virtual DbSet<tempInvoiceValuePackagingLocation> tempInvoiceValuePackagingLocations { get; set; }

        public virtual DbSet<tempItemDangerShippingDeclaration> tempItemDangerShippingDeclarations { get; set; }

        public virtual DbSet<tempItemDescription> tempItemDescriptions { get; set; }

        public virtual DbSet<tempItemDetail> tempItemDetails { get; set; }

        public virtual DbSet<tempOrder> tempOrders { get; set; }

        public virtual DbSet<tempPostedGateEntry1> tempPostedGateEntry1s { get; set; }

        public virtual DbSet<tempResult> tempResults { get; set; }

        public virtual DbSet<tempTicketDetailAWB> tempTicketDetailAWBs { get; set; }

        public virtual DbSet<tempTicketHeaderCompensationOPEBCL> tempTicketHeaderCompensationOPEBCLs { get; set; }

        public virtual DbSet<temp_ELITE_City> temp_ELITE_Cities { get; set; }

        public virtual DbSet<temp_WebOrderNo> temp_WebOrderNos { get; set; }

        public virtual DbSet<test> tests { get; set; }

        public virtual DbSet<tmpPostdescriptionchangeorder> tmpPostdescriptionchangeorders { get; set; }

        public virtual DbSet<tmppdcl> tmppdcls { get; set; }
        #endregion

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableBaseEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.Created = DateTime.UtcNow;
                        break;

                    case EntityState.Modified:
                        entry.Entity.LastModified = DateTime.UtcNow;
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
            .UseCollation("utf8_general_ci")
            .HasCharSet("utf8");

            modelBuilder.Entity<AmeyoQAAgentMapping>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.AgentId).HasDefaultValueSql("'0'");
                entity.Property(e => e.TeamLeadId).HasDefaultValueSql("'0'");
                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<AmeyoQACriticalSection>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<AmeyoQAEvaluationType>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<AmeyoQAImageDetail>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<AmeyoQAInteractionType>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<AmeyoQAScoreCritical>(entity =>
            {
                entity.HasKey(e => e.SRNo).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.SectionId).HasDefaultValueSql("'0'");
                entity.Property(e => e.SectionSRNo).HasDefaultValueSql("'0'");
                entity.Property(e => e.SubSectionSRNo).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<AmeyoQAScoreHead>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<AmeyoQAScoreSection>(entity =>
            {
                entity.HasKey(e => e.SRNo).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.TargetedPoint).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<AmeyoQAScoreSubSection>(entity =>
            {
                entity.HasKey(e => e.SRNo).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<AmeyoQASection>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<AmeyoQASubSection>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<AmeyoQATeamLead>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<AmeyoRuleCreation>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.HasIndex(e => new { e.Country, e.OrderType, e.PaymentMethodCode, e.CustomerType }, "idx_CtOdrTypeStatusPymtCustomerType").HasAnnotation("MySql:FullTextIndex", true);
            });

            modelBuilder.Entity<AnalysisRow>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<ApiConfiguration>(entity =>
            {
                entity.HasKey(e => e.ID).HasName("PRIMARY");

                entity.Property(e => e.ID).ValueGeneratedNever();
            });

            modelBuilder.Entity<ApiConfigurationPick>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<ApproverEntryLog>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<AutoCompensation>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.EntryType).HasDefaultValueSql("'Auto'");
                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.IsClose).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsRefund).HasDefaultValueSql("'0'");
                entity.Property(e => e.Retry).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<AutoGateEntryLineDetail>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<AutoRefundEntry>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.BCLSyncRequired).HasDefaultValueSql("'1'");
                entity.Property(e => e.EntryType).HasDefaultValueSql("'Manual'");
                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.IsClose).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsRefund).HasDefaultValueSql("'0'");
                entity.Property(e => e.Retry).HasDefaultValueSql("'0'");
                entity.Property(e => e.UpdatedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<BankMaster>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<BatchCalendar>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.Created).HasDefaultValueSql("'0'");
                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.ReadyForArchive).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<BatchCalendarArchive>(entity =>
            {
                entity.HasKey(e => e.AutoId).HasName("PRIMARY");

                entity.Property(e => e.DeletedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<BoutiqaatCreditLedger>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.ApproverId).HasDefaultValueSql("'0'");
                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.ReadyForArchive).HasDefaultValueSql("'0'");
                entity.Property(e => e.SyncRequired).HasDefaultValueSql("'0'");
                entity.Property(e => e.Synced).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<BoutiqaatCreditLedgerReport>(entity =>
            {
                entity.Property(e => e.ApproverId).HasDefaultValueSql("'0'");
                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.ReadyForArchive).HasDefaultValueSql("'0'");
                entity.Property(e => e.SyncRequired).HasDefaultValueSql("'0'");
                entity.Property(e => e.Synced).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<BoxDimensionDetail>(entity =>
            {
                entity.HasKey(e => e.BoxId).HasName("PRIMARY");

                entity.Property(e => e.Active).HasDefaultValueSql("'1'");
                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.ReadyForArchive).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<BoxHeader>(entity =>
            {
                entity.Property(e => e.BoxCount).HasDefaultValueSql("'1'");
                entity.Property(e => e.Delivered).HasDefaultValueSql("'0'");
                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.ReAttemptCount).HasDefaultValueSql("'0'");
                entity.Property(e => e.ReAttemptFlag).HasDefaultValueSql("'1'");
                entity.Property(e => e.ReadyForArchive).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<BoxHeaderTemp>(entity =>
            {
                entity.Property(e => e.IsBoxLimitOver).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsDanger).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsElectronic).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<BoxInsuranceDetail>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<BoxLimitMapping>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.Active).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<BoxLine>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.ReturnCreated).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<BoxPackingmaterialDetail>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.ReadyForArchive).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<BoxShelvingMapping>(entity =>
            {
                entity.HasKey(e => e.BoxShelvingMappingId).HasName("PRIMARY");

                entity.Property(e => e.AttemptCount).HasDefaultValueSql("'0'");
                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.IsDeleted).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<BoxStatus>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.BoxRetryCount).HasDefaultValueSql("'0'");
                entity.Property(e => e.DeliveredRetryCount).HasDefaultValueSql("'0'");
                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.IsBoxSync).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsCollectionInvoiceCreated).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsDelivered).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsDeliveredSync).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsInvAwsDelivered).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsInvAwsDeliveredRetry).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsInvAwsPacked).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsInvAwsPackedRetry).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsInvAwsShipped).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsInvAwsShippedRetry).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsInvSyncDSP).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsInvSyncDSPRetry).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsNPSSync).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsPaymentCollected).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsPaymentCollectedSync).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsReturned).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsShip).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsShipSync).HasDefaultValueSql("'0'");
                entity.Property(e => e.NPSRetryCount).HasDefaultValueSql("'0'");
                entity.Property(e => e.PaymentRetryCount).HasDefaultValueSql("'0'");
                entity.Property(e => e.ReadyForArchive).HasDefaultValueSql("'0'");
                entity.Property(e => e.ReturnBeforeDelivery).HasDefaultValueSql("'0'");
                entity.Property(e => e.ShipRetryCount).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<BoxTaxDetail>(entity =>
            {
                entity.HasKey(e => e.ItemId).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.ReadyForArchive).HasDefaultValueSql("'0'");
                entity.Property(e => e.RetryCount).HasDefaultValueSql("'0'");
                entity.Property(e => e.WaiverOff).HasDefaultValueSql("'0.000'");
            });

            modelBuilder.Entity<BoxWaiverDetail>(entity =>
            {
                entity.HasKey(e => new { e.BoxId, e.InvoiceNo })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
            });

            modelBuilder.Entity<BulkTicketClosingDatum>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<CRMLineStatus>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<CRMOrder>(entity =>
            {
                entity.HasKey(e => e.ID).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.IsAmeyoSync).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsRuleRun).HasDefaultValueSql("'0'");
                entity.Property(e => e.ReadyForArchive).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<CRMOrderStatus>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<CRMVIPCustomerAddressTemp>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<CRMVIPGIFTOrder>(entity =>
            {
                entity.HasKey(e => e.ID).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.IsLimitApplied).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsOrderSuccess).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsPass).HasDefaultValueSql("'0'");
                entity.Property(e => e.OriginalPrice).HasDefaultValueSql("'0.000'");
            });

            modelBuilder.Entity<CRMWIPOrder>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.ReadyForArchive).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<CRMWIPOrders_Temp17012023>(entity =>
            {
                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.ReadyForArchive).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<CallStatusLog>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<CallTypeMaster>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<CancelResponse>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<CancelRetrunItemDetail>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<CancelledOrder>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.CancelType).HasDefaultValueSql("'Before Batch'");
                entity.Property(e => e.CancelledDate).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.ErrorMessageForWMS).HasDefaultValueSql("''");
                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.IsSyncForNAV).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsSyncForWMS).HasDefaultValueSql("'0'");
                entity.Property(e => e.ReadyForArchive).HasDefaultValueSql("'0'");
                entity.Property(e => e.RetryCount).HasDefaultValueSql("'0'");
                entity.Property(e => e.RetryCountForNAV).HasDefaultValueSql("'0'");
                entity.Property(e => e.RetryCountForWMS).HasDefaultValueSql("'0'");
                entity.Property(e => e.Sync).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<CashierScannedDocument>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<CashierToCashierHandoverLedger>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.ReadyForArchive).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<CategoryOrderLimit>(entity =>
            {
                entity.HasKey(e => e.ID).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.OrderLimit).HasDefaultValueSql("'1000.000'");
                entity.Property(e => e.UpdatedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<ChangeCustomerCategoryCalender>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<CityMaster>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Active })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<CompanyMaster>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.Active).HasDefaultValueSql("'1'");
                entity.Property(e => e.AddressRevampActive).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<CompensationDetail>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<CompensationMaster>(entity =>
            {
                entity.HasKey(e => e.ID).HasName("PRIMARY");
            });

            modelBuilder.Entity<CountryGiftAmountMapping>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<CountryMaster>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.Id).ValueGeneratedNever();
                entity.Property(e => e.Active).HasDefaultValueSql("'1'");
                entity.Property(e => e.GiftOrderThreshold).HasDefaultValueSql("'99999'");
            });

            modelBuilder.Entity<CreditNoteDetail>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.TicketId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<CrmOrderAging>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<CurrencyCode>(entity =>
            {
                entity.HasKey(e => e.ID).HasName("PRIMARY");

                entity.Property(e => e.ErrorOccured).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<CurrencyCodesApiLog>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.ReadyForArchive).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<CurrencyDenomination>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<CustomReportHeader>(entity =>
            {
                entity.HasKey(e => e.ReportId).HasName("PRIMARY");

                entity.Property(e => e.Active).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<CustomReportParamDetail>(entity =>
            {
                entity.HasKey(e => new { e.ReportId, e.ParamId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
            });

            modelBuilder.Entity<CustomReportPermission>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.Active).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<CustomerCategoryRuleMaster>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<CustomerDetail>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.AddressChangeCount).HasDefaultValueSql("'0'");
                entity.Property(e => e.CancelItemCount).HasDefaultValueSql("'0'");
                entity.Property(e => e.CancelOrderCount).HasDefaultValueSql("'0'");
                entity.Property(e => e.CancelValue).HasDefaultValueSql("'0.000'");
                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.ItemCount).HasDefaultValueSql("'0'");
                entity.Property(e => e.OrderCount).HasDefaultValueSql("'0'");
                entity.Property(e => e.OrderModifyCount).HasDefaultValueSql("'0'");
                entity.Property(e => e.OrderModifyLineCount).HasDefaultValueSql("'0'");
                entity.Property(e => e.OrderModifyValue).HasDefaultValueSql("'0.000'");
                entity.Property(e => e.OrderValue).HasDefaultValueSql("'0.000'");
                entity.Property(e => e.ReturnItemCount).HasDefaultValueSql("'0'");
                entity.Property(e => e.ReturnOrderCount).HasDefaultValueSql("'0'");
                entity.Property(e => e.ReturnValue).HasDefaultValueSql("'0.000'");
            });

            modelBuilder.Entity<CustomerDetails4>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.AddressChangeCount).HasDefaultValueSql("'0'");
                entity.Property(e => e.CancelItemCount).HasDefaultValueSql("'0'");
                entity.Property(e => e.CancelOrderCount).HasDefaultValueSql("'0'");
                entity.Property(e => e.CancelValue).HasDefaultValueSql("'0.000'");
                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.ItemCount).HasDefaultValueSql("'0'");
                entity.Property(e => e.OrderCount).HasDefaultValueSql("'0'");
                entity.Property(e => e.OrderModifyCount).HasDefaultValueSql("'0'");
                entity.Property(e => e.OrderModifyLineCount).HasDefaultValueSql("'0'");
                entity.Property(e => e.OrderModifyValue).HasDefaultValueSql("'0.000'");
                entity.Property(e => e.OrderValue).HasDefaultValueSql("'0.000'");
                entity.Property(e => e.ReturnItemCount).HasDefaultValueSql("'0'");
                entity.Property(e => e.ReturnOrderCount).HasDefaultValueSql("'0'");
                entity.Property(e => e.ReturnValue).HasDefaultValueSql("'0.000'");
            });

            modelBuilder.Entity<CustomerDetailsLog>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.IsSync).HasDefaultValueSql("'0'");
                entity.Property(e => e.Value1).HasDefaultValueSql("'0.000'");
                entity.Property(e => e.Value10).HasDefaultValueSql("'0.000'");
                entity.Property(e => e.Value2).HasDefaultValueSql("'0.000'");
                entity.Property(e => e.Value3).HasDefaultValueSql("'0.000'");
                entity.Property(e => e.Value4).HasDefaultValueSql("'0.000'");
                entity.Property(e => e.Value5).HasDefaultValueSql("'0.000'");
                entity.Property(e => e.Value6).HasDefaultValueSql("'0.000'");
                entity.Property(e => e.Value7).HasDefaultValueSql("'0.000'");
                entity.Property(e => e.Value8).HasDefaultValueSql("'0.000'");
                entity.Property(e => e.Value9).HasDefaultValueSql("'0.000'");
            });

            modelBuilder.Entity<CustomerTypeMaster>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.CategoryPriority).HasDefaultValueSql("'0'");
                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.IsVIP).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<DSPAPIMaster>(entity =>
            {
                entity.HasKey(e => e.DSPMappingId).HasName("PRIMARY");

                entity.Property(e => e.DSPMappingId).ValueGeneratedNever();
            });

            modelBuilder.Entity<DSPAWBMapping>(entity =>
            {
                entity.HasKey(e => e.DSPAWBMappingId).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.IsUsed).HasDefaultValueSql("'0'");
                entity.Property(e => e.ReadyForArchive).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<DSPCapacityDetail>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<DSPCutoffDetail>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<DSPMaster>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.Active).HasDefaultValueSql("'1'");
                entity.Property(e => e.ElectronicsPartial).HasDefaultValueSql("'0'");
                entity.Property(e => e.ForwardDSP).HasDefaultValueSql("'1'");
                entity.Property(e => e.ReturnDSP).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<DSPPackageInsurance>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<DSPPackingMapping>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.IsActive).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<DSPPhoneMapping>(entity =>
            {
                entity.HasKey(e => e.ID).HasName("PRIMARY");
            });

            modelBuilder.Entity<DSPStatusDetail>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<DSPStatusDetailsDelivered>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<DSPStatusDetailsReturned>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<DashBoardDetail>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<DashboardProcessDataLimitDetail>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<DelinkShelfOnAWB>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.IsSyncLMS).HasDefaultValueSql("'0'");
                entity.Property(e => e.RetryCounter).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<DeliveryTimeSlotMaster>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.IsActive).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<DeliveryTypeMaster>(entity =>
            {
                entity.ToTable("DeliveryTypeMaster", tb => tb.HasComment("	"));

                entity.Property(e => e.Active).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<DepartmentHead>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.Active).HasDefaultValueSql("'1'");
                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.ReadyForArchive).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<DepartmentMaster>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.Active).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<DeviceMaster>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.IsActive).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<DigitMasterForAutoConfirm>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<DigitsMaster>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<DriverBoxAllocationTemp>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.IsActive).HasDefaultValueSql("'1'");
                entity.Property(e => e.RetryCounter).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<DriverCashHeader>(entity =>
            {
                entity.HasKey(e => e.ID).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<DriverCashTemp>(entity =>
            {
                entity.HasKey(e => e.ID).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<DriverCommissionLedger>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.Sync).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<DriverCommissionMaster>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<DriverDeliveryStage>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<DriverMaster>(entity =>
            {
                entity.HasKey(e => e.DriverId).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.IsDeleted).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsSync_Pytech).HasDefaultValueSql("'0'");
                entity.Property(e => e.ReadyForArchive).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<DropDownOption>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<DspCityMapping>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<DspCountryMapping>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.ElectronicsPartial).HasDefaultValueSql("'0'");
                entity.Property(e => e.MaxWeight).HasDefaultValueSql("'99.000'");
                entity.Property(e => e.MinWeight).HasDefaultValueSql("'0.000'");
            });

            modelBuilder.Entity<DspPayment>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.DifferenceAllowed).HasDefaultValueSql("'0.000'");
                entity.Property(e => e.DifferenceAmount).HasDefaultValueSql("'0.000'");
                entity.Property(e => e.Include).HasDefaultValueSql("'0'");
                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.IsProcessed).HasDefaultValueSql("'0'");
                entity.Property(e => e.Matched).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<DspPayment_Temp>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.DifferenceAllowed).HasDefaultValueSql("'0.000'");
                entity.Property(e => e.DifferenceAmount).HasDefaultValueSql("'0.000'");
                entity.Property(e => e.Include).HasDefaultValueSql("'0'");
                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.Matched).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<DspReconciliation_Temp>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.DifferenceAmount).HasDefaultValueSql("'0.000'");
                entity.Property(e => e.Include).HasDefaultValueSql("'0'");
                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.Matched).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<EmailDetail>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.Insertedon).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.RetryCount).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<ExchangeMaster>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<ExistingEditOrderIssue>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<FastTrackAllocatedOrder>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<FastTrackItemBinInventory>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<FastTrackItemMapping>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<FastTrackReleaseInventory>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<FastTrackTableBinMapping>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<FilterExpressionMapping>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("FilterExpressionMapping", tb => tb.HasComment("Mapping table for filter expression"));

                entity.Property(e => e.IsActive).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<FinanceSetup>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<ForLoop>(entity =>
            {
                entity.HasKey(e => e.i).HasName("PRIMARY");

                entity.Property(e => e.i).ValueGeneratedNever();
            });

            modelBuilder.Entity<GateEntryHeader>(entity =>
            {
                entity.HasKey(e => e.ID).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.ReadyForArchive).HasDefaultValueSql("'0'");
                entity.Property(e => e.Status).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<GateEntryLine>(entity =>
            {
                entity.HasKey(e => e.ID).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.ReadyForArchive).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<GiftCardOrderDetail>(entity =>
            {
                entity.HasKey(e => e.ID).HasName("PRIMARY");

                entity.HasIndex(e => new { e.WebOrderNo, e.CustomerPhone, e.RecipientPhone, e.CustomerEmail }, "IX_GiftCardOrderDetails_EmailPhone").HasAnnotation("MySql:FullTextIndex", true);

                entity.Property(e => e.GiftCardStatus).HasDefaultValueSql("'Not Redeemed'");
            });

            modelBuilder.Entity<GiftCardRedeemRequestLog>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<HoldOrder>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.ReadyForArchive).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<HolidayMaster>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<InboundMessage>(entity =>
            {
                entity.HasKey(e => e.MessageId).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.ItemId).HasDefaultValueSql("'0'");
                entity.Property(e => e.ReadyForArchive).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<InboundOrderAddress>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.ReadyForArchive).HasDefaultValueSql("'0'");
                entity.Property(e => e.UpdateAddress).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<InboundOrderAddressLog>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.ReadyForArchive).HasDefaultValueSql("'0'");
                entity.Property(e => e.UpdateAddress).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<InboundOrderApiLog>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.Processed).HasDefaultValueSql("'0'");
                entity.Property(e => e.ReadyForArchive).HasDefaultValueSql("'0'");
                entity.Property(e => e.RetryCount).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<InboundPaymentLine>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.CelebrityOrderSync).HasDefaultValueSql("'0'");
                entity.Property(e => e.CouponAmount).HasDefaultValueSql("'0.000'");
                entity.Property(e => e.CustomDuty).HasDefaultValueSql("'0.000'");
                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.IsRecalculated).HasDefaultValueSql("'0'");
                entity.Property(e => e.OrderChargesProcessed).HasDefaultValueSql("'0'");
                entity.Property(e => e.ReadyForArchive).HasDefaultValueSql("'0'");
                entity.Property(e => e.RetryCounter).HasDefaultValueSql("'0'");
                entity.Property(e => e.TaxPercentage).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<InboundPaymentLineLog>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.CelebrityOrderSync).HasDefaultValueSql("'0'");
                entity.Property(e => e.CouponAmount).HasDefaultValueSql("'0.000'");
                entity.Property(e => e.CustomDuty).HasDefaultValueSql("'0.000'");
                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.IsRecalculated).HasDefaultValueSql("'0'");
                entity.Property(e => e.OrderChargesProcessed).HasDefaultValueSql("'0'");
                entity.Property(e => e.ReadyForArchive).HasDefaultValueSql("'0'");
                entity.Property(e => e.RetryCounter).HasDefaultValueSql("'0'");
                entity.Property(e => e.TaxPercentage).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<InboundSalesHeader>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.Confirm).HasDefaultValueSql("'0'");
                entity.Property(e => e.ConfirmationType).HasDefaultValueSql("'Normal'");
                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.IsCodFree).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsCollectionInvoiceCreated).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsStockReserved).HasDefaultValueSql("'1'");
                entity.Property(e => e.IsSync).HasDefaultValueSql("'0'");
                entity.Property(e => e.Priority).HasDefaultValueSql("'0'");
                entity.Property(e => e.ReadyForArchive).HasDefaultValueSql("'0'");
                entity.Property(e => e.RetryCount).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<InboundSalesLine>(entity =>
            {
                entity.HasKey(e => e.ItemId).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.IsGWP).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsProcessed).HasDefaultValueSql("'0'");
                entity.Property(e => e.ReadyForArchive).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<InternalCompanyPaymentTransfer>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<InvoiceStatus>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.IsInvAwsDelivered).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsInvAwsDeliveredRetry).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsInvAwsPacked).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsInvAwsPackedRetry).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsInvAwsShipped).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsInvAwsShippedRetry).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsInvSyncDSP).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsInvSyncDSPRetry).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<ItemDetail>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.Height).HasDefaultValueSql("'1.000'");
                entity.Property(e => e.ImageUpdateRequired).HasDefaultValueSql("'0'");
                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.IsElectronic).HasDefaultValueSql("'0'");
                entity.Property(e => e.Length).HasDefaultValueSql("'1.000'");
                entity.Property(e => e.SortingBinType).HasDefaultValueSql("'Small'");
                entity.Property(e => e.Weight).HasDefaultValueSql("'0.500'");
                entity.Property(e => e.Width).HasDefaultValueSql("'1.000'");
            });

            modelBuilder.Entity<ItemDetailFastTrackHistory>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.SortingBinType).HasDefaultValueSql("'Small'");
            });

            modelBuilder.Entity<ItemLotInfo>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<ItemSortingBinZoneMapping>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<ItemUrlDetail>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<LiabitlityTransfer>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.AmountUSD).HasDefaultValueSql("'0.000'");
                entity.Property(e => e.CurrencyFactor).HasDefaultValueSql("'0.00000000000000000000'");
                entity.Property(e => e.DeviceId).HasDefaultValueSql("'0'");
                entity.Property(e => e.ReadyForArchive).HasDefaultValueSql("'0'");
                entity.Property(e => e.RetryCount).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<LocationMaster>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.DirectPrintflag).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsDefaultPacKlocation).HasDefaultValueSql("'0'");
                entity.Property(e => e.LocationType).HasDefaultValueSql("'PICK'");
            });

            modelBuilder.Entity<LogDetail>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<LogDetailsError>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<LogTable>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<LogisticsCapacity>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<LogisticsCapacityDetail>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<LostAWBbyaramex>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<MagentoOrderRequestResponse>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<ManifestHeader>(entity =>
            {
                entity.HasKey(e => e.ManifestNo).HasName("PRIMARY");

                entity.Property(e => e.Returned).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<ManifestLine>(entity =>
            {
                entity.HasKey(e => e.AWBNo).HasName("PRIMARY");
            });

            modelBuilder.Entity<MasterDeliveryStatus>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<MigratedCustomerData20220301>(entity =>
            {
                entity.Property(e => e.TransactionType).HasDefaultValueSql("'Company'");
            });

            modelBuilder.Entity<MigratedCustomerKWTOKSA>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.IsMigrated).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<MissingOPE20230824>(entity =>
            {
                entity.Property(e => e.PayOPE).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<MissingOpeOrder>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.Status).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<MyFatoorahRefundTransactionDetail>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<MyFatoorahTransactionDetail>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.IsProcessed).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<MyFatoorahTransactionDetailsLOG>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.IsProcessed).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<NPSConfirmedOrder>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.IsSync).HasDefaultValueSql("'0'");
                entity.Property(e => e.RetryCounter).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<NewDSPCapacityDetail>(entity =>
            {
                entity.HasKey(e => e.DSPCapacityDetailId).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<NotificationMasterMyFatoorah>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<NumberSeriesEntry>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.UpdatedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.Used).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<NumberSeriesLocationMapping>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<NumberSeriesMaster>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.Id).ValueGeneratedNever();
                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.UpdatedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<OCTReturnRequired>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.IsReturnCreated).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<OCTToolHit>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.IsRefunded).HasDefaultValueSql("'0'");
                entity.Property(e => e.MagentoStoreCredit).HasDefaultValueSql("'0.000'");
                entity.Property(e => e.RetryCount).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<OffLineRefundTransactionDetail>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<OrderBatchDetail>(entity =>
            {
                entity.HasKey(e => new { e.ItemId, e.BatchId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.IsFOC).HasDefaultValueSql("'0'");
                entity.Property(e => e.ReadyForArchive).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<OrderCategory>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.IsActive).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<OrderConfirmRuleMaster>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.RuleFor).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<OrderConfirmationMandatoryFieldsMaster>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.UpdatedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<OrderDataAnalysis>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.Allocated).HasDefaultValueSql("'0'");
                entity.Property(e => e.BatchId).HasDefaultValueSql("'0'");
                entity.Property(e => e.BoutiqaatCredit).HasDefaultValueSql("'0.000'");
                entity.Property(e => e.BoutiqaatCredit_KWD).HasDefaultValueSql("'0.000'");
                entity.Property(e => e.CollectableAmount).HasDefaultValueSql("'0.000'");
                entity.Property(e => e.CollectableAmount_KWD).HasDefaultValueSql("'0.000'");
                entity.Property(e => e.CollectableAmount_USD).HasDefaultValueSql("'0.000'");
                entity.Property(e => e.CustomerId).HasDefaultValueSql("''");
                entity.Property(e => e.ForwardCycleClose).HasDefaultValueSql("'0'");
                entity.Property(e => e.InvoiceAmount).HasDefaultValueSql("'0.000'");
                entity.Property(e => e.InvoiceAmount_KWD).HasDefaultValueSql("'0.000'");
                entity.Property(e => e.InvoiceAmount_USD).HasDefaultValueSql("'0.000'");
                entity.Property(e => e.IsByPassQC).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsCancelled).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsDelivered).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsPNA).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsPaymentReceived).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsReturn).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsShipped).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsSync).HasDefaultValueSql("'0'");
                entity.Property(e => e.Ishold).HasDefaultValueSql("'0'");
                entity.Property(e => e.OrderAmount).HasDefaultValueSql("'0.000'");
                entity.Property(e => e.Picked).HasDefaultValueSql("'0'");
                entity.Property(e => e.ReturnBeforeDelivery).HasDefaultValueSql("'0'");
                entity.Property(e => e.SyncRetryCount).HasDefaultValueSql("'0'");
                entity.Property(e => e.TransctionAmount).HasDefaultValueSql("'0.000'");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.IsFOC).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<OrderDetailPriority>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.ReadyForArchive).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<OrderDetailReco_20230504>(entity =>
            {
                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<OrderDetail_DuplicateItemID_20230503>(entity =>
            {
                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.IsFOC).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<OrderDspAllocation>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.IsAWBGenerated).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsBoxPosted).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsReadyForAWBGeneration).HasDefaultValueSql("'0'");
                entity.Property(e => e.ProcessStatus).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<OrderMandatoryField>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<OrderPaymentEntry>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.BeforeChangePaymentMethod).HasDefaultValueSql("'0'");
                entity.Property(e => e.CollectionChargePercent).HasDefaultValueSql("'0.00000'");
                entity.Property(e => e.CollectionChargesAmt).HasDefaultValueSql("'0.00000'");
                entity.Property(e => e.DestinationCompany).HasDefaultValueSql("'1'");
                entity.Property(e => e.DestinationCompanyISSync).HasDefaultValueSql("'0'");
                entity.Property(e => e.DestinationCompanyRetryCount).HasDefaultValueSql("'0'");
                entity.Property(e => e.FixedCollectionCharge).HasDefaultValueSql("'0.00000'");
                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.InvoiceValue).HasDefaultValueSql("'0.000'");
                entity.Property(e => e.NoOfInterCompany).HasDefaultValueSql("'1'");
                entity.Property(e => e.ReadyForArchive).HasDefaultValueSql("'0'");
                entity.Property(e => e.RetryCount).HasDefaultValueSql("'0'");
                entity.Property(e => e.SourceCompany).HasDefaultValueSql("'1'");
                entity.Property(e => e.SourceCompanyISSync).HasDefaultValueSql("'0'");
                entity.Property(e => e.SourceCompanyRetryCount).HasDefaultValueSql("'0'");
                entity.Property(e => e.TicketType).HasDefaultValueSql("''");
                entity.Property(e => e.TransactionType).HasDefaultValueSql("'Company'");
                entity.Property(e => e.VATCollectionAmt).HasDefaultValueSql("'0.00000'");
                entity.Property(e => e.VatPercent).HasDefaultValueSql("'0.00000'");
            });

            modelBuilder.Entity<OrderPaymentEntryReport>(entity =>
            {
                entity.Property(e => e.BeforeChangePaymentMethod).HasDefaultValueSql("'0'");
                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.ReadyForArchive).HasDefaultValueSql("'0'");
                entity.Property(e => e.RetryCount).HasDefaultValueSql("'0'");
                entity.Property(e => e.TicketType).HasDefaultValueSql("''");
            });

            modelBuilder.Entity<OrderPaymentEntryTemp_31012023>(entity =>
            {
                entity.Property(e => e.BeforeChangePaymentMethod).HasDefaultValueSql("'0'");
                entity.Property(e => e.DestinationCompany).HasDefaultValueSql("'1'");
                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.InvoiceValue).HasDefaultValueSql("'0.000'");
                entity.Property(e => e.NoOfInterCompany).HasDefaultValueSql("'1'");
                entity.Property(e => e.ReadyForArchive).HasDefaultValueSql("'0'");
                entity.Property(e => e.RetryCount).HasDefaultValueSql("'0'");
                entity.Property(e => e.SourceCompany).HasDefaultValueSql("'1'");
                entity.Property(e => e.SourceCompanyISSync).HasDefaultValueSql("'0'");
                entity.Property(e => e.SourceCompanyRetryCount).HasDefaultValueSql("'0'");
                entity.Property(e => e.TicketType).HasDefaultValueSql("''");
                entity.Property(e => e.TransactionType).HasDefaultValueSql("'Company'");
            });

            modelBuilder.Entity<OrderResponse>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<OrderSourceMaster>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.IsActive).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<OrderStatus>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.ReadyForArchive).HasDefaultValueSql("'0'");
                entity.Property(e => e.UpdatedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<OrderStatusHeader>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<OrderStatusLine>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<OrderStatusLocation>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<OrderStatusMaster>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.Id).ValueGeneratedNever();
                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.IsActive).HasDefaultValueSql("'1'");
                entity.Property(e => e.ReadyForArchive).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<OrderStatusSyncTransaction>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.IsSynced).HasDefaultValueSql("'0'");
                entity.Property(e => e.RetryCounter).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<OrderStatus_Test>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.ReadyForArchive).HasDefaultValueSql("'0'");
                entity.Property(e => e.UpdatedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<OrderTaxCalculation>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<OrderTaxDetail>(entity =>
            {
                entity.HasKey(e => e.ItemId).HasName("PRIMARY");

                entity.Property(e => e.ItemId).ValueGeneratedNever();
                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.ReadyForArchive).HasDefaultValueSql("'0'");
                entity.Property(e => e.RetryCount).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<OrderTypeMaster>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.Id).ValueGeneratedNever();
                entity.Property(e => e.Active).HasDefaultValueSql("'1'");
                entity.Property(e => e.RefundRequired).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<PNAAutoCompensation>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.IsRefund).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<PNRReasonMaster>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.FinanceApprovalRequired).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsPNR).HasDefaultValueSql("'1'");
                entity.Property(e => e.IsThreshold).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<PackagingItem>(entity =>
            {
                entity.HasKey(e => e.PackagingId).HasName("PRIMARY");
            });

            modelBuilder.Entity<PackingMapping>(entity =>
            {
                entity.HasKey(e => e.PackingMappingId).HasName("PRIMARY");

                entity.Property(e => e.IsElectronic).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<PageMaster>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<PaymentGatewayMapping>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<PaymentGatewayMaster>(entity =>
            {
                entity.HasKey(e => e.GatewayID).HasName("PRIMARY");

                entity.Property(e => e.CheckExchangeThreshold).HasDefaultValueSql("'0'");
                entity.Property(e => e.CollectionChargePercent).HasDefaultValueSql("'0.00000'");
                entity.Property(e => e.CollectionInvReq).HasDefaultValueSql("'0'");
                entity.Property(e => e.CollectionType).HasDefaultValueSql("'Mixed'");
                entity.Property(e => e.FixedCollectionCharge).HasDefaultValueSql("'0.00000'");
                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.IsAccountNo).HasDefaultValueSql("'1'");
                entity.Property(e => e.IsActive).HasDefaultValueSql("'1'");
                entity.Property(e => e.IsAuthorizeNoMandatory).HasDefaultValueSql("'1'");
                entity.Property(e => e.IsBCToCash).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsBankName).HasDefaultValueSql("'1'");
                entity.Property(e => e.IsCashAccount).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsForward).HasDefaultValueSql("'1'");
                entity.Property(e => e.IsIFSCCode).HasDefaultValueSql("'1'");
                entity.Property(e => e.IsMandatetory1).HasDefaultValueSql("'1'");
                entity.Property(e => e.IsMandatetory2).HasDefaultValueSql("'1'");
                entity.Property(e => e.IsMangement).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsRefundEnable).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsReturn).HasDefaultValueSql("'1'");
                entity.Property(e => e.IsSearchFilter).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsSwiftCode).HasDefaultValueSql("'1'");
                entity.Property(e => e.IsTransactionDate).HasDefaultValueSql("'1'");
                entity.Property(e => e.IsTransactionIDMandatory).HasDefaultValueSql("'1'");
                entity.Property(e => e.VatPercent).HasDefaultValueSql("'0.00000'");
            });

            modelBuilder.Entity<PaymentMaster>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.PaymentMethod })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
                entity.Property(e => e.IsActive).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<PendingPackaging>(entity =>
            {
                entity.HasKey(e => new { e.WebOrderNo, e.BatchId, e.ItemNo, e.SerialNo, e.ItemId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0 });

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.ReadyForArchive).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<PickDetail>(entity =>
            {
                entity.HasKey(e => new { e.ItemId, e.BatchId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.ReadyForArchive).HasDefaultValueSql("'0'");
                entity.Property(e => e.RetryCount).HasDefaultValueSql("'0'");
                entity.Property(e => e.SortingSequenceNo).HasDefaultValueSql("'0'");
                entity.Property(e => e.Sync).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<PickDetails_DuplicateItemID_20230503>(entity =>
            {
                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.ReadyForArchive).HasDefaultValueSql("'0'");
                entity.Property(e => e.RetryCount).HasDefaultValueSql("'0'");
                entity.Property(e => e.SortingSequenceNo).HasDefaultValueSql("'0'");
                entity.Property(e => e.Sync).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<PostGateEntryHeader>(entity =>
            {
                entity.HasKey(e => e.ID).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.ReadyForArchive).HasDefaultValueSql("'0'");
                entity.Property(e => e.Status).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<PostGateEntryLine>(entity =>
            {
                entity.HasKey(e => e.ID).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.ReadyForArchive).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<PostGateEntryLine_LostAramex_Backup20230103>(entity =>
            {
                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.ReadyForArchive).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<PostedDriverCashHeader>(entity =>
            {
                entity.HasKey(e => e.ID).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<PostedDriverCashLedger>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.BankHandover).HasDefaultValueSql("'0'");
                entity.Property(e => e.DeviceId).HasDefaultValueSql("'0'");
                entity.Property(e => e.GatewayID).HasDefaultValueSql("'0'");
                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.IsSync).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<PostedManifestHeader>(entity =>
            {
                entity.HasKey(e => e.ID).HasName("PRIMARY");

                entity.Property(e => e.ArchiveNo).HasDefaultValueSql("'0'");
                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.ReadyForArchive).HasDefaultValueSql("'0'");
                entity.Property(e => e.Returned).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<PostedManifestLine>(entity =>
            {
                entity.HasKey(e => e.ID).HasName("PRIMARY");

                entity.Property(e => e.ArchiveNo).HasDefaultValueSql("'0'");
                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.Issync_PYtech).HasDefaultValueSql("'0'");
                entity.Property(e => e.PyTechSyncRetryCount).HasDefaultValueSql("'0'");
                entity.Property(e => e.ReScan).HasDefaultValueSql("'0'");
                entity.Property(e => e.ReadyForArchive).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<PostedManifestRequestHeader>(entity =>
            {
                entity.HasKey(e => e.RequestId).HasName("PRIMARY");
            });

            modelBuilder.Entity<PostedReturnQC>(entity =>
            {
                entity.HasKey(e => e.ItemId).HasName("PRIMARY");

                entity.Property(e => e.ItemId).ValueGeneratedNever();
                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.IsHeader).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsSync).HasDefaultValueSql("'0'");
                entity.Property(e => e.ProductsNotReturned).HasDefaultValueSql("'0'");
                entity.Property(e => e.RetryCounter).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<PostedReturnQCHeader>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.IsSynced).HasDefaultValueSql("'0'");
                entity.Property(e => e.ProductsNotReturned).HasDefaultValueSql("'0'");
                entity.Property(e => e.RetryCounter).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<PostedReturnQCHeaderRemark>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<PostedReturnQCHeader_2Ticket>(entity =>
            {
                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.IsSynced).HasDefaultValueSql("'0'");
                entity.Property(e => e.ProductsNotReturned).HasDefaultValueSql("'0'");
                entity.Property(e => e.RetryCounter).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<PostedReturnQCHeader_BackupThreeTicketsPNR>(entity =>
            {
                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.IsSynced).HasDefaultValueSql("'0'");
                entity.Property(e => e.ProductsNotReturned).HasDefaultValueSql("'0'");
                entity.Property(e => e.RetryCounter).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<PostedReturnQCNotReturn>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<PostedReturnQC_2Ticket>(entity =>
            {
                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.IsHeader).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsSync).HasDefaultValueSql("'0'");
                entity.Property(e => e.ProductsNotReturned).HasDefaultValueSql("'0'");
                entity.Property(e => e.RetryCounter).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<PostedReturnQC_BackupThreeTicketsPNR>(entity =>
            {
                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.IsHeader).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsSync).HasDefaultValueSql("'0'");
                entity.Property(e => e.ProductsNotReturned).HasDefaultValueSql("'0'");
                entity.Property(e => e.RetryCounter).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<PreOrderDateMaster>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.Active).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<PrePostedReturnQC>(entity =>
            {
                entity.HasKey(e => e.ItemId).HasName("PRIMARY");

                entity.Property(e => e.ItemId).ValueGeneratedNever();
                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.IsHeader).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsProcess).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsSync).HasDefaultValueSql("'0'");
                entity.Property(e => e.ProductsNotReturned).HasDefaultValueSql("'0'");
                entity.Property(e => e.RetryCounter).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<PrePostedReturnQCHeader>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.IsProcess).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsSynced).HasDefaultValueSql("'0'");
                entity.Property(e => e.ProductsNotReturned).HasDefaultValueSql("'0'");
                entity.Property(e => e.RetryCounter).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<PrepaidTransactionDetail>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.IsSynced).HasDefaultValueSql("'0'");
                entity.Property(e => e.RetryCounter).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<PrinterMaster>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<PriorityMaster>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.Active).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<ProcessLedger>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.ProcessStatus).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<ProcessLedgerHeader>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<ProcessMaster>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<ProcessStatusMapping>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<ProcessValidationMapping>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<ProductNotReturnThreshold>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<ProductTypeMaster>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.IsActive).HasDefaultValueSql("'1'");
                entity.Property(e => e.IsDanger).HasDefaultValueSql("'1'");
                entity.Property(e => e.IsFragile).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<QcFailEntry>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.Quantity).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<ReScheduleDetail>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.IsActive).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<ReasonMaster>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.CompensationValueSA).HasDefaultValueSql("'0.000'");
                entity.Property(e => e.IsActive).HasDefaultValueSql("'1'");
                entity.Property(e => e.ReleaseRequired).HasDefaultValueSql("'1'");
                entity.Property(e => e.SMSRequired).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<RefundGatewayMapping>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.IsAuto).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<RefundTransactionRequestResponse>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<Refundcreatedforcompany>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<RegionMaster>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.Id).ValueGeneratedNever();
                entity.Property(e => e.Active).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<RegisteredPickDataApiLog>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.ReadyForArchive).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<ReturnCategory>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.Active).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<ReturnFraudAWB>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<ReturnQC>(entity =>
            {
                entity.HasKey(e => e.ItemId).HasName("PRIMARY");

                entity.Property(e => e.ItemId).ValueGeneratedNever();
                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.IsHeader).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<ReturnQCHeader>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<ReturnReasonAutoCompensation>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<ReturnReasonMaster>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.IsActive).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<ReturnTicket>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.ReadyForArchive).HasDefaultValueSql("'0'");
                entity.Property(e => e.ReceivedAtRPC).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<RoleMaster>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<RolePageMapping>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.UpdatedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<SMSConfiguration>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<SMSDetail>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.Insertedon).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.RetryCount).HasDefaultValueSql("'0'");
                entity.Property(e => e.SmsTriggerFrom).HasDefaultValueSql("'Automatic'");
            });

            modelBuilder.Entity<SMSLanguageMaster>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<SMSProvider>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<SMSTagMaster>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<SMSTemplate>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.Insertedon).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<SMSType>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<SerialItemCategoryMaster>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<SerialItemMaster>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<SerialItemPrint>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<ServicesTable>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<Setup>(entity =>
            {
                entity.HasKey(e => e.ID).HasName("PRIMARY");
            });

            modelBuilder.Entity<SharingInvoiceSetup>(entity =>
            {
                entity.HasKey(e => e.ID).HasName("PRIMARY");
            });

            modelBuilder.Entity<ShelvingLedger>(entity =>
            {
                entity.HasKey(e => e.ShelvingLedgerId).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.IsActive).HasDefaultValueSql("'1'");
                entity.Property(e => e.UpdatedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<ShelvingLedgerTemp>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.IsActive).HasDefaultValueSql("'1'");
                entity.Property(e => e.RetryCounter).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<ShelvingMaster>(entity =>
            {
                entity.HasKey(e => e.ShelvingId).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.IsActive).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<ShipmentMatrix>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.Active).HasDefaultValueSql("'0'");
                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.ReadyForArchive).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<SorterPackingIdError>(entity =>
            {
                entity.HasKey(e => e.AWBNo).HasName("PRIMARY");
            });

            modelBuilder.Entity<SortingBinAssignment>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.RetryCount).HasDefaultValueSql("'0'");
                entity.Property(e => e.Success).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<SortingBinDetail>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.ReadyForArchive).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<SortingBinDetailsArchive>(entity =>
            {
                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.IsSync).HasDefaultValueSql("'0'");
                entity.Property(e => e.ReadyForArchive).HasDefaultValueSql("'0'");
                entity.Property(e => e.RetryCount).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<SortingBinMaster>(entity =>
            {
                entity.HasKey(e => new { e.PackagingLocation, e.BinCode })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.Property(e => e.IsHold).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<SortingZoneMaster>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<SqlExceptionLog>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<StagingOrder>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<StatusMaster>(entity =>
            {
                entity.HasKey(e => e.ID).HasName("PRIMARY");

                entity.Property(e => e.ApplicableForRule).HasDefaultValueSql("'0'");
                entity.Property(e => e.CRM).HasDefaultValueSql("'0'");
                entity.Property(e => e.GWPAdded).HasDefaultValueSql("'0'");
                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.IsAddressChange).HasDefaultValueSql("'1'");
                entity.Property(e => e.IsBulkStatusUpdate).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsCRMSchedule).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsCallable).HasDefaultValueSql("b'0'");
                entity.Property(e => e.IsCancelable).HasDefaultValueSql("'1'");
                entity.Property(e => e.IsExchangeable).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsHoldable).HasDefaultValueSql("'1'");
                entity.Property(e => e.IsOrderEditable).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsWaiverOffAble).HasDefaultValueSql("'0'");
                entity.Property(e => e.OFS).HasDefaultValueSql("'0'");
                entity.Property(e => e.ReadyForArchive).HasDefaultValueSql("'0'");
                entity.Property(e => e.SMSRequired).HasDefaultValueSql("b'0'");
            });

            modelBuilder.Entity<StatusMasterDSP>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<StatusProcessMapping>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.IsActive).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<StatusSystemMapping>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.IsActive).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<StockReleaseInformation>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<StoreCredit201201_To_210131>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<StoreCredit210201_To_210228>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<StoreCredit210301_To_210331>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<StoreCredit210401_To_210430>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<StoreCredit210501_To_210531>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<StoreCredit210601_To_210630>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<StoreCredit210701_To_210831>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<StoreCredit210901_To_210930>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<StoreCredit211001_To_211030>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<StoreCredit211101_To_211130>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<StoreCredit211201_To_211231>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<StoreCreditAPR2022>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<StoreCreditAUG2022>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<StoreCreditDEC2022>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.is_new_checkout).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<StoreCreditFEB2022>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<StoreCreditFEB2023>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<StoreCreditJAN2022>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<StoreCreditJAN2023>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.is_new_checkout).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<StoreCreditJUL2022>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<StoreCreditJULAUG2023>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<StoreCreditJUN2022>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<StoreCreditJUN2023>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<StoreCreditMAR2022>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<StoreCreditMAR2023>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<StoreCreditMAY2022>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<StoreCreditMAY2023>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<StoreCreditNAV2022>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.is_new_checkout).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<StoreCreditOCT2022>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<StoreCreditOCT2023>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<StoreCreditRequestResponseLog>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<StoreCreditSEP2022>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<StoreCreditSEP2023>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<SubDepartmentMaster>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.Active).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<TEMP1_ARUN>(entity =>
            {
                entity.Property(e => e.IsMatching).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<TEMP1_ARUN_1>(entity =>
            {
                entity.Property(e => e.IsMatching).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<TEMP1_ARUN_2>(entity =>
            {
                entity.Property(e => e.IsCancelSync).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsFound).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsPickSync).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<TEMP1_ARUN_WORKING>(entity =>
            {
                entity.Property(e => e.IsCancelSync).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsFound).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsPickSync).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<TEMPTAX>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<TMPCustomerDetail>(entity =>
            {
                entity.Property(e => e.AddressChangeCount).HasDefaultValueSql("'0'");
                entity.Property(e => e.CancelItemCount).HasDefaultValueSql("'0'");
                entity.Property(e => e.CancelOrderCount).HasDefaultValueSql("'0'");
                entity.Property(e => e.CancelValue).HasDefaultValueSql("'0.000'");
                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.ItemCount).HasDefaultValueSql("'0'");
                entity.Property(e => e.OrderCount).HasDefaultValueSql("'0'");
                entity.Property(e => e.OrderModifyCount).HasDefaultValueSql("'0'");
                entity.Property(e => e.OrderModifyLineCount).HasDefaultValueSql("'0'");
                entity.Property(e => e.OrderModifyValue).HasDefaultValueSql("'0.000'");
                entity.Property(e => e.OrderValue).HasDefaultValueSql("'0.000'");
                entity.Property(e => e.ReturnItemCount).HasDefaultValueSql("'0'");
                entity.Property(e => e.ReturnOrderCount).HasDefaultValueSql("'0'");
                entity.Property(e => e.ReturnValue).HasDefaultValueSql("'0.000'");
            });

            modelBuilder.Entity<TMPInboundPaymentLine>(entity =>
            {
                entity.Property(e => e.CelebrityOrderSync).HasDefaultValueSql("'0'");
                entity.Property(e => e.CouponAmount).HasDefaultValueSql("'0.000'");
                entity.Property(e => e.CustomDuty).HasDefaultValueSql("'0.000'");
                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.IsRecalculated).HasDefaultValueSql("'0'");
                entity.Property(e => e.OrderChargesProcessed).HasDefaultValueSql("'0'");
                entity.Property(e => e.ReadyForArchive).HasDefaultValueSql("'0'");
                entity.Property(e => e.RetryCounter).HasDefaultValueSql("'0'");
                entity.Property(e => e.TaxPercentage).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<TableMaster>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<TaxMaster>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<TempFastTrackAllocatedOrder>(entity =>
            {
                entity.Property(e => e.NOW__).HasDefaultValueSql("'0000-00-00 00:00:00'");
            });

            modelBuilder.Entity<TempItemInventoryDetail>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.AvailableQuantity).HasDefaultValueSql("'0'");
                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.TotalQuantity).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<TestCustomer>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<ThirdPartyServiceProvider>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.Id).ValueGeneratedNever();
                entity.Property(e => e.IsFrontEndAccount).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsRefund).HasDefaultValueSql("'0'");
                entity.Property(e => e.MyFatoorahInvoiceExpiryDays).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<TicketCreationStringStage>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.IsProcessed).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<TicketHeader>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.Archive).HasDefaultValueSql("'0'");
                entity.Property(e => e.CompanyId).HasDefaultValueSql("'1'");
                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.IsCreditMemoCreated).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsLMSSync).HasDefaultValueSql("'0'");
                entity.Property(e => e.ReadyForArchive).HasDefaultValueSql("'0'");
                entity.Property(e => e.RetryCount).HasDefaultValueSql("'0'");
                entity.Property(e => e.ShortClose).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<TicketHeaderCompensationOPEBCL>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.IsCreated).HasDefaultValueSql("'0'");
                entity.Property(e => e.RowCountBCL).HasDefaultValueSql("'-1'");
                entity.Property(e => e.RowCountOPE).HasDefaultValueSql("'-1'");
            });

            modelBuilder.Entity<TicketHeaderLog>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.CreationDate).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.ReadyForArchive).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<TicketImageDetail>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<TicketLine>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.ReadyForArchive).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<TicketLineLog>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.CreationDate).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<TicketMaster>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("TicketMaster", tb => tb.HasComment("		"));

                entity.Property(e => e.Active).HasDefaultValueSql("'1'");
                entity.Property(e => e.IsAmountRequired).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsAssignable).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsBulkUploaded).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsDateRequired).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsGeneral).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsLMSSyncRequired).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsShotClose).HasDefaultValueSql("'0'");
                entity.Property(e => e.RefundRequired).HasDefaultValueSql("'0'");
                entity.Property(e => e.SelfAssigned).HasDefaultValueSql("'0'");
                entity.Property(e => e.SingleStep).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<TicketReasonCodeLM>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<TicketRefundHeader>(entity =>
            {
                entity.HasKey(e => e.TicketId).HasName("PRIMARY");

                entity.Property(e => e.AdjustedWaiverOffAmount).HasDefaultValueSql("'0.000'");
                entity.Property(e => e.BeforeChangePaymentMethod).HasDefaultValueSql("'0'");
                entity.Property(e => e.CompanyId).HasDefaultValueSql("'1'");
                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.IsByPassQC).HasDefaultValueSql("'0'");
                entity.Property(e => e.ManualRefund).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<TicketRefundHeaderLog>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.CreationDate).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<TicketRefundLine>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<TicketRefundLineLog>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.CreationDate).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<TicketRemark>(entity =>
            {
                entity.HasKey(e => e.ID).HasName("PRIMARY");
            });

            modelBuilder.Entity<TicketStatus>(entity =>
            {
                entity.HasKey(e => e.ID).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<TicketStatusFlow>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.ReadyForArchive).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<TicketStatusMaster>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.Active).HasDefaultValueSql("'1'");
                entity.Property(e => e.IsByPassQC).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsCommentsMandatory).HasDefaultValueSql("'1'");
                entity.Property(e => e.IsDepartmentMandatory).HasDefaultValueSql("'1'");
                entity.Property(e => e.IsRescheduleDateMandatory).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsSubDepartmentMandatory).HasDefaultValueSql("'1'");
                entity.Property(e => e.IsUserMandatory).HasDefaultValueSql("'1'");
                entity.Property(e => e.TriggerRefundValidation).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<URLShortnerProvider>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<UpdateAddressToLM>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<UpdateStatusTempStage>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.Updated).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<UserCheckinCheckoutMaster>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<UserCompanyMapping>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.Active).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<UserCompanyMappingLog>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<UserMaster>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.Blocked).HasDefaultValueSql("'0'");
                entity.Property(e => e.Company).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsCashier).HasDefaultValueSql("'0'");
                entity.Property(e => e.IsNewPassword).HasDefaultValueSql("'0'");
                entity.Property(e => e.QcAdmin).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<UserRoleMapping>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<UserRoleMappingLog>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<UserTableMapping>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<UserValidationMapping>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<ValidationMaster>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.IsActive).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<VipCustomerGiftOrder>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.IsOrderPlaced).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<VipGiftSettingRuleDetail>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.Active).HasDefaultValueSql("'1'");
                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.IsRuleRun).HasDefaultValueSql("'0'");
                entity.Property(e => e.UpdatedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<VipGiftSettingRuleSkuDetail>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.IsReleased).HasDefaultValueSql("'0'");
                entity.Property(e => e.OrderQuantity).HasDefaultValueSql("'0'");
                entity.Property(e => e.ReleasedQuantity).HasDefaultValueSql("'0'");
                entity.Property(e => e.UpdatedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<WaiverOff>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.Property(e => e.CODCharges).HasDefaultValueSql("'0'");
                entity.Property(e => e.CustomDuty).HasDefaultValueSql("'0'");
                entity.Property(e => e.GiftCharges).HasDefaultValueSql("'0'");
                entity.Property(e => e.ShipmentCharges).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<ZoneMaster>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });

            modelBuilder.Entity<ofs_sales_invoice>(entity =>
            {
                entity.HasKey(e => e.InvoiceNo).HasName("PRIMARY");
            });

            modelBuilder.Entity<ofs_sales_return_invoice>(entity =>
            {
                entity.Property(e => e.txn_type).HasDefaultValueSql("''");
            });

            modelBuilder.Entity<sales_analysis>(entity =>
            {
                entity.HasKey(e => new { e.SKU, e.orderdate })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
            });

            modelBuilder.Entity<tempInvoiceValuePackagingLocation>(entity =>
            {
                entity.HasKey(e => e.id).HasName("PRIMARY");
            });

            modelBuilder.Entity<tempOrder>(entity =>
            {
                entity.HasKey(e => e.ID).HasName("PRIMARY");

                entity.Property(e => e.MESSAGE).HasDefaultValueSql("''");
                entity.Property(e => e.SUCCESS).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<tempPostedGateEntry1>(entity =>
            {
                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.ReadyForArchive).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<tempTicketDetailAWB>(entity =>
            {
                entity.Property(e => e.InsertedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });


            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLoggerFactory(_loggerFactory);
        }
    }
}