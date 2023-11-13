using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Index("ReferenceOrderNo", "BoxId", Name = "IDX_OrderTaxDetails")]
[Index("WebOrderNo", "ItemId", Name = "INDEX_OrderTaxDetails_WeborderNoItemId")]
[Index("WebOrderNo", "ItemId", "ReferenceOrderNo", Name = "INDEX_WebOrderNoItemIdReference")]
[Index("BoxId", Name = "IX_OrderTaxDetails_BoxId")]
public partial class OrderTaxDetail
{
    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [StringLength(50)]
    public string ReferenceOrderNo { get; set; }

    [StringLength(50)]
    public string BoxId { get; set; }

    [Key]
    [Column(TypeName = "int(11)")]
    public int ItemId { get; set; }

    [Precision(10, 3)]
    public decimal? ItemValue { get; set; }

    [Precision(10, 3)]
    public decimal? CODCharges { get; set; }

    [Precision(10, 3)]
    public decimal? ShippingCharges { get; set; }

    [Precision(10, 3)]
    public decimal? GiftCharges { get; set; }

    [Precision(10, 3)]
    public decimal? CustomizationCharges { get; set; }

    [Precision(10, 3)]
    public decimal? OrderProcessCharges { get; set; }

    [Precision(10, 3)]
    public decimal? CustomDuty { get; set; }

    [Column(TypeName = "int(11)")]
    public int? TaxMasterId { get; set; }

    [Precision(10, 3)]
    public decimal? TaxAmount { get; set; }

    [Precision(10, 3)]
    public decimal? TaxPercentage { get; set; }

    [Precision(10, 3)]
    public decimal? CutomDutyPercentage { get; set; }

    [Precision(10, 3)]
    public decimal? InvoiceValue { get; set; }

    [Precision(10, 3)]
    public decimal? CollectableAmount { get; set; }

    [Precision(10, 3)]
    public decimal? TaxBaseAmount { get; set; }

    [Precision(10, 3)]
    public decimal? DiscountAmount { get; set; }

    [Precision(10, 3)]
    public decimal? CouponAmount { get; set; }

    [StringLength(50)]
    public string InvoiceNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PackagingLocation { get; set; }

    [StringLength(20)]
    public string CurrencyCode { get; set; }

    [Precision(25, 20)]
    public decimal? CurrencyFactor { get; set; }

    [StringLength(500)]
    public string ErrorMessage { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? ReadyForArchive { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(50)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [StringLength(50)]
    public string UpdatedBy { get; set; }

    [Column(TypeName = "int(11)")]
    public int? RetryCount { get; set; }

    [Precision(10, 3)]
    public decimal CustomDuty_USD { get; set; }

    [Precision(10, 3)]
    public decimal CollectableAmount_USD { get; set; }

    [Precision(10, 3)]
    public decimal InvoiceValue_USD { get; set; }

    [Precision(10, 3)]
    public decimal? OtherCharges { get; set; }

    [Precision(10, 3)]
    public decimal? UnitPrice { get; set; }

    [Precision(25, 20)]
    public decimal? USDCurrencyFactor { get; set; }

    [StringLength(255)]
    public string ItemValueIncCharges { get; set; }

    [Precision(10, 3)]
    public decimal? BoutiqaatCredit { get; set; }

    [Precision(10, 3)]
    public decimal? DiscountItemPrice { get; set; }

    [Precision(10, 3)]
    public decimal? DiscountItemPercent { get; set; }

    [Precision(10, 3)]
    public decimal? MrpPrice { get; set; }

    [Precision(10, 3)]
    public decimal? UnitPriceIncludingTax { get; set; }

    [Precision(10, 3)]
    public decimal? OriginalPriceIncludingTax { get; set; }
}
