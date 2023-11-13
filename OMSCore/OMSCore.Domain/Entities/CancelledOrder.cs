using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Index("Sync", "RetryCount", "InsertedOn", "ItemNo", Name = "IDX_CancelledOrders_Sync_RetryCount")]
[Index("ItemId", Name = "INDEX_ItemID")]
[Index("CancelType", "IsSyncForNAV", "RetryCountForNAV", Name = "IX_CancelledOrders_IsSyncForNAV_CancelType")]
public partial class CancelledOrder
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ItemId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CancelledDate { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? ReadyForArchive { get; set; }

    [StringLength(100)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [StringLength(100)]
    public string UpdatedBy { get; set; }

    [StringLength(50)]
    public string Reason { get; set; }

    [StringLength(250)]
    public string Notes { get; set; }

    [StringLength(20)]
    public string SourceSystem { get; set; }

    [StringLength(50)]
    public string ItemNo { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? Sync { get; set; }

    [StringLength(250)]
    public string ErrorMessage { get; set; }

    [Column(TypeName = "int(11)")]
    public int? RetryCount { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsSyncForWMS { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SyncDatetimeForWMS { get; set; }

    [Column(TypeName = "int(11)")]
    public int? RetryCountForWMS { get; set; }

    [StringLength(500)]
    public string ErrorMessageForWMS { get; set; }

    [Column(TypeName = "enum('After Batch','Before Batch')")]
    public string CancelType { get; set; }

    public bool? IsSyncForNAV { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SyncDatetimeForNAV { get; set; }

    [Column(TypeName = "int(11)")]
    public int? RetryCountForNAV { get; set; }

    [StringLength(1000)]
    public string ErrorMessageForNAV { get; set; }

    [StringLength(50)]
    public string WebOrderNo { get; set; }
}
