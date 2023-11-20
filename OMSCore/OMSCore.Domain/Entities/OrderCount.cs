using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Keyless]
[Table("OrderCount")]
[Index("ReferenceOrderNo", "TotalITemCount", Name = "IDX_OrderCount")]
[Index("WebOrderNo", Name = "IDX_OrderCount_WebOrderNo")]
[Index("WebOrderNo", "PackagingLocation", Name = "IDX_OrderCount_WebOrderNo_PackagingLocation")]
public partial class OrderCount
{
    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [StringLength(50)]
    public string ReferenceOrderNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int? OrderItemCount { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PackagingLocation { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [StringLength(100)]
    public string UpdateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(100)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? ReadyForArchive { get; set; }

    [StringLength(45)]
    public string CustomerId { get; set; }

    [StringLength(45)]
    public string ContactNo { get; set; }

    [Column(TypeName = "bit(1)")]
    public ulong? Merged { get; set; }

    [Column(TypeName = "int(11)")]
    public int TotalITemCount { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? SortingBinType { get; set; }
}
