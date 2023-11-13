using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("FastTrackReleaseInventory")]
[Index("IsSync", Name = "IX_FastTrackReleaseInventory_IsSync")]
[Index("ItemId", Name = "IX_FastTrackReleaseInventory_ItemId")]
[Index("WebOrderNo", Name = "IX_FastTrackReleaseInventory_WebOrderNo")]
public partial class FastTrackReleaseInventory
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(50)]
    public string BoxId { get; set; }

    [Column(TypeName = "int(11)")]
    public int? BatchId { get; set; }

    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ItemId { get; set; }

    [StringLength(20)]
    public string ItemNo { get; set; }

    [StringLength(50)]
    public string LotNo { get; set; }

    [StringLength(50)]
    public string SerialNo { get; set; }

    [StringLength(100)]
    public string BarCode { get; set; }

    [Column(TypeName = "int(11)")]
    public int? TableId { get; set; }

    [StringLength(50)]
    public string BinCode { get; set; }

    [StringLength(50)]
    public string ZoneCode { get; set; }

    [StringLength(50)]
    public string LocationCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [Column(TypeName = "int(11)")]
    public int? InsetedBy { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsSync { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? RetryCount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SyncDateTime { get; set; }

    [StringLength(500)]
    public string SyncErrorMessage { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PickLocation { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PackagingLocation { get; set; }
}
