using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Index("Deleted", Name = "IDX_HoldOrders_Deleted")]
[Index("InsertedOn", Name = "IDX_HoldOrders_InsertedOn")]
[Index("ItemId", Name = "IDX_HoldOrders_ItemId")]
[Index("User", Name = "IDX_HoldOrders_User")]
[Index("WebOrderNo", Name = "IDX_HoldOrders_WebOrderNo")]
public partial class HoldOrder
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ItemId { get; set; }

    [StringLength(500)]
    public string Reason { get; set; }

    [StringLength(250)]
    public string Notes { get; set; }

    [Column(TypeName = "int(11)")]
    public int? User { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? Deleted { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DeletedOn { get; set; }

    [Column(TypeName = "int(11)")]
    public int? OperationType { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? ReadyForArchive { get; set; }

    [StringLength(100)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [StringLength(100)]
    public string UpdatedBy { get; set; }
}
