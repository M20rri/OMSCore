using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("CRMOrderStatus")]
[Index("OrderStatus", Name = "IDX_CRMOrderStatus_OrderStatus")]
[Index("WebOrderNo", Name = "IDX_CRMOrderStatus_WebOrderNo")]
[Index("WebOrderNo", "OrderStatus", Name = "IDX_CRMOrderStatus_WebOrderNo_OrderStatus")]
public partial class CRMOrderStatus
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int? OrderStatus { get; set; }

    [StringLength(100)]
    public string StatusName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(150)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [StringLength(150)]
    public string UpdatedBy { get; set; }
}
