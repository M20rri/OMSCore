using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("OrderStatus")]
[Index("InsertedOn", Name = "IDX_OrderStatus_InsertedOn")]
[Index("ItemId", Name = "IDX_OrderStatus_ItemId")]
[Index("ItemId", "StatusId", Name = "IDX_OrderStatus_ItemId_StatuId")]
[Index("StatusId", Name = "IDX_OrderStatus_StatusId")]
[Index("WebOrderNo", Name = "IDX_OrderStatus_WebOrderNo")]
public partial class OrderStatus
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ItemId { get; set; }

    [StringLength(50)]
    public string ItemNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int? StatusId { get; set; }

    [StringLength(50)]
    public string SKU { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? ReadyForArchive { get; set; }

    [StringLength(100)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(100)]
    public string UpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }
}
