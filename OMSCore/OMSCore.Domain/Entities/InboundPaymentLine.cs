using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("InboundPaymentLine")]
[Index("WebOrderNo", "ItemId", Name = "IDX_InboundPaymentLine")]
[Index("WebOrderNo", "IsHeader", Name = "IDX_InboundPaymentLine2")]
[Index("IsHeader", "CelebrityOrderSync", "AgentCode", "RetryCounter", Name = "IDX_InboundPaymentLine_3")]
[Index("ItemId", Name = "IDX_InboundPaymentLine_ItemId")]
[Index("WebOrderNo", Name = "INDEX_InboundPaymentLine_WeborderNo")]
[Index("PackagingLocation", Name = "idx_InboundPaymentLine_PackagingLocation")]
public partial class InboundPaymentLine
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsHeader { get; set; }

    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ItemId { get; set; }

    [StringLength(45)]
    public string PaymentGateway { get; set; }

    [StringLength(50)]
    public string PaymentMethodCode { get; set; }

    [Precision(10, 3)]
    public decimal? CODCharges { get; set; }

    [Precision(10, 3)]
    public decimal? ShippingCharges { get; set; }

    [Precision(10, 3)]
    public decimal? GiftCharges { get; set; }

    [Precision(10, 3)]
    public decimal? Amount { get; set; }

    [Precision(10, 3)]
    public decimal? Tax { get; set; }

    [Precision(10, 3)]
    public decimal? AmountInclTax { get; set; }

    [Precision(10, 3)]
    public decimal? Discount { get; set; }

    [StringLength(100)]
    public string CouponCode { get; set; }

    [Precision(10, 3)]
    public decimal? CouponAmount { get; set; }

    [Precision(10, 3)]
    public decimal? CustomizedCharges { get; set; }

    [Precision(10, 3)]
    public decimal? BoutiqaatCredit { get; set; }

    [Precision(10, 3)]
    public decimal? OtherCharges { get; set; }

    [StringLength(100)]
    public string AgentCode { get; set; }

    [Precision(10, 3)]
    public decimal AgentCommission { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? OrderChargesProcessed { get; set; }

    [Precision(10, 3)]
    public decimal MrpPrice { get; set; }

    [Precision(10, 3)]
    public decimal UnitPrice { get; set; }

    [Precision(10, 3)]
    public decimal UnitPriceIncludingTax { get; set; }

    [Precision(10, 3)]
    public decimal? OriginalPriceIncludingTax { get; set; }

    [StringLength(100)]
    public string WalletName { get; set; }

    [Precision(10, 3)]
    public decimal WalletAmount { get; set; }

    [StringLength(100)]
    public string TransactionId { get; set; }

    [Column(TypeName = "int(11)")]
    public int? TaxPercentage { get; set; }

    [StringLength(20)]
    public string CurrencyCode { get; set; }

    [Precision(25, 20)]
    public decimal? CurrencyFactor { get; set; }

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

    [Column(TypeName = "tinyint(4)")]
    public sbyte? CelebrityOrderSync { get; set; }

    [Column(TypeName = "int(11)")]
    public int? RetryCounter { get; set; }

    [StringLength(1000)]
    public string ErrorMessage { get; set; }

    [Precision(10, 3)]
    public decimal? CustomDuty { get; set; }

    [StringLength(255)]
    public string AuthorizationId { get; set; }

    public bool? IsRecalculated { get; set; }

    [Precision(10, 3)]
    public decimal? RecalculatedAmount { get; set; }

    [Precision(10, 3)]
    public decimal? RoundingDifference { get; set; }

    [Precision(10, 3)]
    public decimal? CustomDutyPercentage { get; set; }

    [Precision(10, 3)]
    public decimal? CustomThresholdLimit { get; set; }

    [Precision(10, 3)]
    public decimal? DiscountItemPrice { get; set; }

    [Precision(10, 3)]
    public decimal? DiscountItemPercent { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? GiftCardExpiryDate { get; set; }

    [StringLength(300)]
    public string AgentName { get; set; }

    [Precision(10, 3)]
    public decimal? PromoItemDiscountAmount { get; set; }

    [Precision(10, 3)]
    public decimal? PromoItemDiscountPercentage { get; set; }

    [Precision(10, 3)]
    public decimal? ItemDiscount { get; set; }

    [Precision(10, 3)]
    public decimal? SpecialPrice { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PackagingLocation { get; set; }

    [Precision(25, 20)]
    public decimal? OldCurrencyFactor { get; set; }
}
