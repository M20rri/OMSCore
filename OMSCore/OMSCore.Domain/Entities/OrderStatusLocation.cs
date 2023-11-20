using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("OrderStatusLocation")]
[Index("StatusId", Name = "IDX_OrderStatusLocation_StatusId")]
[Index("WebOrderNo", Name = "IDX_OrderStatusLocation_WebOrderNo")]
[Index("WebOrderNo", "PackagingLocation", Name = "IDX_OrderStatusLocation_WebOrderNo_PackagingLocation")]
[Index("WebOrderNo", "PackagingLocation", "StatusId", Name = "IDX_OrderStatusLocation_WebOrderNo_PackagingLocation_StatusId")]
public partial class OrderStatusLocation
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PackagingLocation { get; set; }

    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int? StatusId { get; set; }

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
