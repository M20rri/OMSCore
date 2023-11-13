using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Keyless]
[Table("SortingBinDetailsArchive")]
[Index("ReferenceOrderNo", "PackagingLocation", Name = "IDX_SortingBinDetailsArchive")]
[Index("BinCode", Name = "IDX_SortingBinDetailsArchive_BinCode")]
[Index("Id", Name = "IDX_SortingBinDetailsArchive_Id")]
[Index("ItemId", Name = "IDX_SortingBinDetailsArchive_ItemId")]
[Index("WebOrderNo", Name = "IDX_SortingBinDetailsArchive_WebOrderNo")]
[Index("IsSync", "RetryCount", "Id", "InsertedBySystem", "InsertedBy", Name = "IX_SortingBinDetailsArchive")]
[Index("BatchId", "ItemId", Name = "UK_SortingBinDetailsArchive", IsUnique = true)]
[Index("InsertedOn", Name = "idx_SortingBinDetailsArchive_InsertedOn")]
[Index("SyncDatetime", "IsSync", Name = "idx_comb")]
public partial class SortingBinDetailsArchive
{
    [Column(TypeName = "int(11)")]
    public int? Id { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PackagingLocation { get; set; }

    [StringLength(1000)]
    public string BinCode { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ItemId { get; set; }

    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int? BatchId { get; set; }

    [Column(TypeName = "int(11)")]
    public int? UserId { get; set; }

    [StringLength(50)]
    public string ItemNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int? IsSurface { get; set; }

    [Column(TypeName = "int(11)")]
    public int? SortingSequenceNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int? TotalItemCount { get; set; }

    [StringLength(1000)]
    public string LotNo { get; set; }

    [StringLength(1000)]
    public string OrderType { get; set; }

    [StringLength(50)]
    public string ReferenceOrderNo { get; set; }

    [StringLength(20)]
    public string SerialNo { get; set; }

    public bool? ReadyForArchive { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(100)]
    public string InsertedBy { get; set; }

    [StringLength(100)]
    public string InsertedBySystem { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ProcessedCount { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsSync { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? RetryCount { get; set; }

    [StringLength(250)]
    public string ErrorMessage { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SyncDatetime { get; set; }
}
