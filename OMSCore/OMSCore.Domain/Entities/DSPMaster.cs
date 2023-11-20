using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("DSPMaster")]
[Index("DSPCode", "Active", Name = "IDX_DSPMaster")]
[Index("Code", Name = "IDX_DSPMaster_Code")]
[Index("Name", Name = "IX_DSPMaster_Name")]
public partial class DSPMaster
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PackagingLocation { get; set; }

    public string Code { get; set; }

    [StringLength(50)]
    public string Name { get; set; }

    [StringLength(50)]
    public string DSPCode { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? ForwardDSP { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? ReturnDSP { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? Active { get; set; }

    [StringLength(45)]
    public string ModeOfTransport { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ShipmentCopy { get; set; }

    [Column(TypeName = "int(11)")]
    public int? InvoiceCopy { get; set; }

    [StringLength(100)]
    public string PrinterName { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? ElectronicsPartial { get; set; }

    [Column(TypeName = "time")]
    public TimeOnly? EndCutOffTime { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? AllocationPriorPack { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(50)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [StringLength(50)]
    public string UpdatedBy { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }
}
