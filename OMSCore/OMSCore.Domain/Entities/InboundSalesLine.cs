using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("InboundSalesLine")]
[Index("WebOrderNo", "ItemId", Name = "IDX_InboundSalesLine")]
[Index("WebOrderNo", "IsProcessed", Name = "IDX_InboundSalesLine_2")]
[Index("InsertedOn", Name = "IDX_InboundSalesLine_InsertedOn")]
[Index("IsProcessed", Name = "IDX_InboundSalesLine_IsProcessed")]
[Index("WebOrderNo", Name = "INDEX_InboundSalesLine_WeborderNo")]
[Index("IsGWP", Name = "IX_InboundSalesLine_IsGWP")]
public partial class InboundSalesLine
{
    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [Key]
    [Column(TypeName = "int(11)")]
    public int ItemId { get; set; }

    [StringLength(100)]
    public string CouponCode { get; set; }

    [StringLength(150)]
    public string CouponType { get; set; }

    [StringLength(100)]
    public string CampaignId { get; set; }

    [StringLength(45)]
    public string ProductId { get; set; }

    [StringLength(1000)]
    public string Description { get; set; }

    [StringLength(255)]
    public string SKU { get; set; }

    [Column(TypeName = "tinyint(3)")]
    public sbyte? Quantity { get; set; }

    [StringLength(100)]
    public string BundleID { get; set; }

    [Column(TypeName = "int(11)")]
    public int? BundleQuantity { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpectedDispatchDate { get; set; }

    [StringLength(20)]
    public string ItemNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int? VendorID { get; set; }

    [Column(TypeName = "enum('','ExactDate','Faster','SameDay','NextDay','tablerate_bestway','flatrate_flatrate')")]
    public string DeliveryType { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SpecialDeliveryDate { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsFragile { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsPrecious { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsSurface { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsCustomized { get; set; }

    [StringLength(50)]
    public string PickLocation { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PackagingLocation { get; set; }

    [StringLength(45)]
    public string DspCode { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsProcessed { get; set; }

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

    [StringLength(255)]
    public string LeafCategory { get; set; }

    public bool IsFOC { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsDanger { get; set; }

    [StringLength(1000)]
    public string ArabicDescription { get; set; }

    [StringLength(100)]
    public string BundleSeqID { get; set; }

    [StringLength(1000)]
    public string BundleDescription { get; set; }

    [Column(TypeName = "int(11)")]
    public int? RowId { get; set; }

    [StringLength(45)]
    public string BundleProductId { get; set; }

    public bool? IsGWP { get; set; }

    [StringLength(50)]
    public string OfferType { get; set; }

    [StringLength(10)]
    public string PromoGroup { get; set; }

    [StringLength(100)]
    public string PromoDesc { get; set; }

    [StringLength(10)]
    public string PromoRuleId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PromoStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PromoEndDate { get; set; }
}
