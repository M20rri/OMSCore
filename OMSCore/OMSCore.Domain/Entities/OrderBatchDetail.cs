using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[PrimaryKey("ItemId", "BatchId")]
[Index("SentforPick", Name = "IDX_OrderBatchDetails_SentforPick")]
[Index("BatchId", Name = "IX_OrderBatchDetails_BatchId")]
[Index("WebOrderNo", "ItemId", Name = "WebOrderNo_ItemId")]
[Index("ItemNo", Name = "idx_OrderBatchDetails_ItemNo")]
public partial class OrderBatchDetail
{
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

    [Column(TypeName = "enum('NORMAL','EXPRESS','SURFACE','EXCHANGE','PRIORITY','SPECIALDELIVERY','GIFT','GiftCard','PREORDER','VAS')")]
    public string OrderType { get; set; }

    [StringLength(20)]
    public string DeliveryType { get; set; }

    [StringLength(50)]
    public string PickLocation { get; set; }

    [Column(TypeName = "int(11)")]
    public int? VendorID { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? SentforPick { get; set; }

    [Column(TypeName = "int(11)")]
    public int? TotalItemCount { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsSurface { get; set; }

    public bool? IsFOC { get; set; }

    [StringLength(100)]
    public string OrderCategory { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PackagingLocation { get; set; }

    [StringLength(20)]
    public string ItemNo { get; set; }

    [StringLength(500)]
    public string Error { get; set; }

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

    [StringLength(20)]
    public string BatchCondition { get; set; }

    [StringLength(20)]
    public string SortingZone { get; set; }
}
