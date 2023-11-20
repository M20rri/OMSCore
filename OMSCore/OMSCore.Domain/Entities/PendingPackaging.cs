using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[PrimaryKey("WebOrderNo", "BatchId", "ItemNo", "SerialNo", "ItemId")]
[Table("PendingPackaging")]
[Index("WebOrderNo", "ItemId", Name = "IDX_PendingPackaging")]
[Index("BatchId", "ItemId", Name = "IDX_PendingPackaging2")]
[Index("BoxCreated", Name = "IDX_PendingPackaging_BoxCreated")]
[Index("BoxCreated", "ReferenceOrderNo", Name = "IDX_PendingPackaging_BoxCreated_ReferenceOrderNo")]
[Index("BoxID", Name = "IDX_PendingPackaging_BoxID")]
[Index("BarCode", Name = "IX_PendingPackaging_BarCode")]
[Index("InsertedOn", Name = "IX_PendingPackaging_InsertedOn")]
[Index("ItemId", Name = "IX_PendingPackaging_ItemId")]
[Index("PackingBarCode", "BoxID", Name = "IX_PendingPackaging_PackingBarCode_BoxID")]
public partial class PendingPackaging
{
    [Key]
    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [StringLength(50)]
    public string ReferenceOrderNo { get; set; }

    [Key]
    [Column(TypeName = "int(11)")]
    public int ItemId { get; set; }

    [Key]
    [Column(TypeName = "int(11)")]
    public int BatchId { get; set; }

    [Key]
    [StringLength(20)]
    public string ItemNo { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsSurface { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsFragile { get; set; }

    [Column(TypeName = "int(11) unsigned")]
    public uint? BundleId { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsExchange { get; set; }

    public bool? Frequency { get; set; }

    [StringLength(5)]
    public string Priority { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsPrecious { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsGiftWrap { get; set; }

    [StringLength(50)]
    public string BoxID { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? BoxCreated { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? BoxCreationDateTime { get; set; }

    [StringLength(20)]
    public string Lot { get; set; }

    [Key]
    [StringLength(50)]
    public string SerialNo { get; set; }

    [Column(TypeName = "enum('NORMAL','EXPRESS','SURFACE','EXCHANGE','PRIORITY','SPECIALDELIVERY','GIFT','GiftCard','PREORDER','VAS')")]
    public string OrderType { get; set; }

    [StringLength(255)]
    public string SKU { get; set; }

    [Column(TypeName = "int(11)")]
    public int? TotalItemCount { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PackagingLocation { get; set; }

    [StringLength(50)]
    public string PickLocation { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsCustomised { get; set; }

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

    [StringLength(45)]
    public string IsItemScan { get; set; }

    [StringLength(45)]
    public string Company { get; set; }

    [StringLength(100)]
    public string BarCode { get; set; }

    [StringLength(100)]
    public string PackingBarCode { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsUID { get; set; }
}
