using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("DriverBoxAllocationTemp")]
[Index("DriverId", "AWBNo", "IsActive", Name = "IDX_DriverBoxAllocationTemp_DriverId")]
[Index("InsertedBy", Name = "IDX_DriverBoxAllocationTemp_InsertedBy")]
public partial class DriverBoxAllocationTemp
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [Column(TypeName = "int(11)")]
    public int? BoxShelvingMappingId { get; set; }

    [Column(TypeName = "int(11)")]
    public int? DriverId { get; set; }

    [StringLength(20)]
    public string AWBNo { get; set; }

    [Column(TypeName = "enum('Cancel','Schedule','Reschedule','Delivered','Return To shelf','Lost By driver','Customer Denied','No Action','Packet With Driver','Shipped')")]
    public string Status { get; set; }

    [Column(TypeName = "int(11)")]
    public int? InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(45)]
    public string ShelvingId { get; set; }

    public bool? IsActive { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte IsCommissionCalculated { get; set; }

    public bool IsSync { get; set; }

    [StringLength(500)]
    public string Message { get; set; }

    [Column(TypeName = "int(11)")]
    public int? RetryCounter { get; set; }
}
