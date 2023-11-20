using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("FastTrackAllocatedOrder")]
[Index("ItemId", Name = "IX_FastTrackAllocatedOrder_ItemId")]
[Index("TableId", Name = "IX_FastTrackAllocatedOrder_TableId")]
[Index("WebOrderNo", Name = "IX_FastTrackAllocatedOrder_WebOrderNo")]
public partial class FastTrackAllocatedOrder
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ItemId { get; set; }

    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [StringLength(20)]
    public string ItemNo { get; set; }

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

    [StringLength(50)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [StringLength(50)]
    public string UpdatedBy { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PickLocation { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PackagingLocation { get; set; }
}
