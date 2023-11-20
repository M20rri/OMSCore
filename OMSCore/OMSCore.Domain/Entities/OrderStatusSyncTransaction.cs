using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("OrderStatusSyncTransaction")]
[Index("StatusId", "DestinationSystem", "IsSynced", "RetryCounter", Name = "IDX_OrderStatusSyncTransaction")]
[Index("WebOrderNo", Name = "IX_OrderStatusSyncTransaction_WebOrderNo")]
public partial class OrderStatusSyncTransaction
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int ItemId { get; set; }

    [StringLength(45)]
    public string DestinationSystem { get; set; }

    [Column(TypeName = "int(11)")]
    public int? StatusId { get; set; }

    [Column(TypeName = "int(11)")]
    public int? RetryCounter { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsSynced { get; set; }

    [StringLength(200)]
    public string ErrorMessage { get; set; }

    [StringLength(100)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(100)]
    public string UpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PackagingLocation { get; set; }

    [StringLength(50)]
    public string ItemNo { get; set; }
}
