using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("OrderStatusLine")]
[Index("ItemId", Name = "idx_OrderStatusLine_ItemId")]
[Index("ItemId", "StatusId", Name = "idx_OrderStatusLine_ItemId_StatusId")]
[Index("WebOrderNo", Name = "idx_OrderStatusLine_WebOrderNo")]
[Index("WebOrderNo", "ItemId", Name = "idx_OrderStatusLine_WebOrderNo_ItemId")]
public partial class OrderStatusLine
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ItemId { get; set; }

    [Column(TypeName = "int(11)")]
    public int? StatusId { get; set; }

    [StringLength(50)]
    public string StatusName { get; set; }

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

    [StringLength(100)]
    public string Source { get; set; }
}
