using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("OrderDataAnalysis")]
[Index("WebOrderNo", "ItemId", Name = "IDX_OrderDataAnalysis")]
[Index("OrderDate", "IsShipped", Name = "IDX_OrderDataAnalysis2")]
[Index("OrderDate", "IsDelivered", Name = "IDX_OrderDataAnalysis3")]
[Index("IsShipped", "IsDelivered", Name = "IDX_OrderDataAnalysis4")]
[Index("IsSync", "SyncRetryCount", Name = "IDX_OrderDataAnalysis5")]
[Index("BatchId", Name = "IDX_OrderDataAnalysis_BatchId")]
[Index("DSPCode", Name = "IDX_OrderDataAnalysis_DSPCode")]
[Index("ForwardCycleClose", Name = "IDX_OrderDataAnalysis_ForwardCycleClose")]
[Index("OrderDate", Name = "IDX_OrderDataAnalysis_OrderDate")]
[Index("WebOrderNo", Name = "IDX_OrderDataAnalysis_OrderNo")]
[Index("Picked", Name = "IDX_OrderDataAnalysis_Picked")]
[Index("ForwardCycleClose", "BatchId", "Picked", "Allocated", "BoxId", "AWBNO", Name = "IX_OrderDataAnalysis")]
[Index("BoxId", Name = "IX_OrderDataAnalysis_BoxId")]
[Index("CustomerId", "IsDelivered", "IsReturn", "OrderDate", Name = "IX_OrderDataAnalysis_IsDelivered_2")]
[Index("IsGateEntry", "ReturnCycleClose", Name = "IX_OrderDataAnalysis_IsGateEntry_ReturnCycleClose")]
[Index("IsPaymentReceived", Name = "IX_OrderDataAnalysis_IsPaymentReceived")]
[Index("ReturnTicket", Name = "IX_OrderDataAnalysis_ReturnTicket")]
[Index("ItemId", Name = "UK_OrderDataAnalysis_ItemId", IsUnique = true)]
[Index("ForwardCycleClose", "Picked", "Allocated", "IsDelivered", Name = "idx_For_picK_all_IsD")]
[Index("AWBNO", Name = "idx_OrderDataAnalysis_AWBNO")]
[Index("CustomerId", Name = "idx_OrderDataAnalysis_CustomerId")]
[Index("PaymentMethodCode", "IsPaymentReceived", "ForwardCycleClose", Name = "idx_Payment_CycleClose")]
[Index("SyncDateTime", "IsSync", Name = "idx_comb")]
[Index("ItemId", "RefundAmount", Name = "idx_id_amount")]
public partial class OrderDataAnalysis
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [StringLength(50)]
    public string ReferenceOrderNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime OrderDate { get; set; }

    [StringLength(100)]
    public string Country { get; set; }

    [Column(TypeName = "enum('NORMAL','EXPRESS','SURFACE','EXCHANGE','PRIORITY','SPECIALDELIVERY','GIFT','GiftCard','PREORDER','VAS')")]
    public string OrderType { get; set; }

    [StringLength(50)]
    public string OrderCategory { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ItemId { get; set; }

    [StringLength(100)]
    public string SKU { get; set; }

    [Column(TypeName = "int(11)")]
    public int? BatchId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? BatchDateTime { get; set; }

    public bool? IsPNA { get; set; }

    public bool? Picked { get; set; }

    [StringLength(100)]
    public string PickedBarCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PickedDateTime { get; set; }

    public bool? Allocated { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AllocatedDateTime { get; set; }

    [StringLength(100)]
    public string AllocatedBy { get; set; }

    [StringLength(50)]
    public string BoxId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? BoxDateTime { get; set; }

    [StringLength(100)]
    public string PackedBy { get; set; }

    [StringLength(50)]
    public string AWBNO { get; set; }

    [StringLength(100)]
    public string DSPCode { get; set; }

    [Precision(10, 3)]
    public decimal? OrderAmount { get; set; }

    [StringLength(100)]
    public string InvoiceNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InvoiceDate { get; set; }

    [Precision(10, 3)]
    public decimal? InvoiceAmount { get; set; }

    [Precision(10, 3)]
    public decimal? InvoiceAmount_USD { get; set; }

    [Precision(10, 3)]
    public decimal? BoutiqaatCredit { get; set; }

    [Precision(10, 3)]
    public decimal? CollectableAmount { get; set; }

    [Precision(10, 3)]
    public decimal? CollectableAmount_USD { get; set; }

    [StringLength(50)]
    public string ManifestNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ManifestDate { get; set; }

    public bool? IsCancelled { get; set; }

    public bool? Ishold { get; set; }

    [StringLength(50)]
    public string PaymentMethodCode { get; set; }

    [StringLength(100)]
    public string PaymentGateway { get; set; }

    [StringLength(100)]
    public string TransactionId { get; set; }

    [Precision(10, 3)]
    public decimal? TransctionAmount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PaymentDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DeliveryDate { get; set; }

    [Precision(10, 3)]
    public decimal? DSPCashReceived { get; set; }

    [Precision(10, 3)]
    public decimal? DSPOnlineReceived { get; set; }

    public bool? ForwardCycleClose { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReturnInitiateDate { get; set; }

    public bool? PNR { get; set; }

    [StringLength(100)]
    public string ReturnType { get; set; }

    [StringLength(100)]
    public string ReturnDSP { get; set; }

    [StringLength(100)]
    public string ReturnTicket { get; set; }

    [StringLength(100)]
    public string ReturnAWBNo { get; set; }

    [Precision(10, 3)]
    public decimal? RefundAmount { get; set; }

    [StringLength(100)]
    public string RefundPaymentMethod { get; set; }

    [StringLength(100)]
    public string ReturnTransactionId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReturnTransactionDate { get; set; }

    [StringLength(100)]
    public string QCStatus { get; set; }

    public bool? ReturnCycleClose { get; set; }

    public bool? ReadyForArchive { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReturnQCDate { get; set; }

    public bool? IsDelivered { get; set; }

    public bool? IsShipped { get; set; }

    public bool? IsPaymentReceived { get; set; }

    [StringLength(100)]
    public string AgentCode { get; set; }

    [Precision(10, 3)]
    public decimal? AgentCommission { get; set; }

    [Precision(10, 3)]
    public decimal? InvoiceAmount_KWD { get; set; }

    [Precision(10, 3)]
    public decimal? BoutiqaatCredit_KWD { get; set; }

    [Precision(10, 3)]
    public decimal? CollectableAmount_KWD { get; set; }

    public bool? IsByPassQC { get; set; }

    public bool? IsSync { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SyncDateTime { get; set; }

    [Column(TypeName = "int(11)")]
    public int? SyncRetryCount { get; set; }

    [StringLength(1000)]
    public string SyncErrorMessage { get; set; }

    public bool? IsGateEntry { get; set; }

    public bool? ReturnBeforeDelivery { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReturnGateEntryDate { get; set; }

    public bool? IsReturn { get; set; }

    [StringLength(30)]
    public string CustomerId { get; set; }

    [Precision(10, 3)]
    public decimal? DiscountItemPrice { get; set; }

    [Precision(10, 3)]
    public decimal? DiscountItemPercent { get; set; }

    [Precision(10, 3)]
    public decimal? MrpPrice { get; set; }
}
