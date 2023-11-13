using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("ShelvingLedger")]
[Index("DriverId", "ShelvingId", "AWBNo", Name = "IDX_ShelvingLedger")]
[Index("DriverId", "IsActive", Name = "IDX_ShelvingLedger2")]
[Index("AWBNo", Name = "IDX_ShelvingLedger_AWBNo")]
[Index("AWBNo", "IsActive", Name = "idx_ShelvingLedger_AWBNoIsActive")]
public partial class ShelvingLedger
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int ShelvingLedgerId { get; set; }

    [Column(TypeName = "int(11)")]
    public int? BoxShelvingMappingId { get; set; }

    [Column(TypeName = "int(11)")]
    public int? DriverId { get; set; }

    [StringLength(20)]
    public string AWBNo { get; set; }

    [Column(TypeName = "enum('Cancel','Schedule','Reschedule','Delivered','Return To shelf','Lost By driver','Customer Denied','No Action','Packet With Driver','Shipped')")]
    public string Status { get; set; }

    [StringLength(100)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(100)]
    public string UpdateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [StringLength(45)]
    public string ShelvingId { get; set; }

    public bool? IsActive { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte IsCommissionCalculated { get; set; }

    [Column(TypeName = "int(11)")]
    public int? DeliveryTimeSlotId { get; set; }

    [StringLength(100)]
    public string RunsheetNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PYTechRecordId { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PytechDriverId { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PytechShelvingId { get; set; }
}
