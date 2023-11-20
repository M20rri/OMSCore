using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("InboundSalesHeader")]
[Index("WebOrderNo", "Confirm", Name = "IDX_InboundSalesHeader_2")]
[Index("Confirm", Name = "IDX_InboundSalesHeader_Confirm")]
[Index("CustomerId", Name = "IDX_InboundSalesHeader_CustomerId")]
[Index("InsertedOn", Name = "IDX_InboundSalesHeader_InsertedOn")]
[Index("OrderJSONId", Name = "IDX_InboundSalesHeader_OrderJSONId")]
[Index("ReferenceOrderNo", "OrderCategory", Name = "IX_InboundSalesHeader")]
[Index("IsSync", "RetryCount", Name = "IX_InboundSalesHeader_2")]
[Index("AppOrderNo", Name = "IX_InboundSalesHeader_AppOrderNo")]
[Index("IsOrderAnalysis", Name = "IX_InboundSalesHeader_IsOrderAnalysis")]
[Index("WebOrderNo", "ReferenceOrderNo", "PaymentMethodCode", "CustomerId", "Confirm", Name = "WebOrderNo_ReferenceOrderNo")]
[Index("WebOrderNo", Name = "WebOrderNo_UNIQUE", IsUnique = true)]
public partial class InboundSalesHeader
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [Column(TypeName = "int(11)")]
    public int OrderJSONId { get; set; }

    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [StringLength(30)]
    public string CustomerId { get; set; }

    [StringLength(50)]
    public string PaymentMethodCode { get; set; }

    [StringLength(45)]
    public string PaymentGateway { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? OrderDateTime { get; set; }

    [Column(TypeName = "enum('NORMAL','EXPRESS','SURFACE','EXCHANGE','PRIORITY','SPECIALDELIVERY','GIFT','GiftCard','PREORDER','VAS')")]
    public string OrderType { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? Frequency { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? Priority { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsExchange { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsGiftWrap { get; set; }

    [StringLength(100)]
    public string Country { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? ReadyForArchive { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(100)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [StringLength(100)]
    public string UpdatedBy { get; set; }

    [StringLength(50)]
    public string OrderCategory { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? Confirm { get; set; }

    [StringLength(50)]
    public string ReferenceOrderNo { get; set; }

    [StringLength(50)]
    public string AppOrderNo { get; set; }

    [StringLength(50)]
    public string OrderSource { get; set; }

    [StringLength(45)]
    public string Company { get; set; }

    [StringLength(100)]
    public string ErrorMessage { get; set; }

    [Column(TypeName = "int(11)")]
    public int? IsSync { get; set; }

    [Column(TypeName = "int(11)")]
    public int? RetryCount { get; set; }

    public bool? IsOrderAnalysis { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? OrderConfirmSyncOn { get; set; }

    [StringLength(20)]
    public string StoreId { get; set; }

    [Column(TypeName = "enum('Normal','Edit','CancellationConfirm')")]
    public string ConfirmationType { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsStockReserved { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? FulfillmentCenter { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsMWH { get; set; }

    public bool? IsCollectionInvoiceCreated { get; set; }

    [StringLength(10)]
    public string CustomerCountry { get; set; }

    [Column(TypeName = "int(11)")]
    public int? IsCodFree { get; set; }
}
