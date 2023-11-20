using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("DriverCommissionLedger")]
public partial class DriverCommissionLedger
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(45)]
    public string DriverCode { get; set; }

    [Column(TypeName = "int(11)")]
    public int? CalculatedDeliveryBase { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DeliveryBaseDate { get; set; }

    [Column(TypeName = "int(11)")]
    public int? DeliverBaseValue { get; set; }

    [Precision(8, 3)]
    public decimal? CommissionValue { get; set; }

    [Precision(8, 3)]
    public decimal? TotalCommissionValue { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? Sync { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SyncDate { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PackagingLocation { get; set; }

    [Column(TypeName = "int(5)")]
    public int RetryCount { get; set; }

    [StringLength(45)]
    public string Acknowledgement { get; set; }
}
