using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Index("ReferenceOrderNo", "PackagingLocation", Name = "IDX_SortingBinDetails")]
[Index("BinCode", Name = "IDX_SortingBinDetails_BinCode")]
[Index("ItemId", Name = "IDX_SortingBinDetails_ItemId")]
[Index("WebOrderNo", Name = "IDX_SortingBinDetails_WebOrderNo")]
[Index("BatchId", "ItemId", Name = "UK_SortingBinDetails", IsUnique = true)]
[Index("InsertedOn", Name = "idx_SortingBinDetails_InsertedOn")]
public partial class SortingBinDetail
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PackagingLocation { get; set; }

    [StringLength(100)]
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

    [StringLength(100)]
    public string LotNo { get; set; }

    [StringLength(100)]
    public string OrderType { get; set; }

    [StringLength(50)]
    public string ReferenceOrderNo { get; set; }

    [StringLength(20)]
    public string SerialNo { get; set; }

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

    [Column(TypeName = "int(11)")]
    public int? ProcessedCount { get; set; }
}
