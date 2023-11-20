using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("GateEntryHeader")]
[Index("InsertedBy", Name = "IDX_GateEntryHeader_InsertedBy")]
[Index("DocumentNumber", Name = "IX_GateEntryHeader_DocumentNumber")]
public partial class GateEntryHeader
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int ID { get; set; }

    [StringLength(50)]
    public string DocumentNumber { get; set; }

    public DateOnly? DateCreated { get; set; }

    [Column(TypeName = "time")]
    public TimeOnly? TimeCreated { get; set; }

    [StringLength(50)]
    public string InsertedBy { get; set; }

    [StringLength(50)]
    public string ShippingAgentCode { get; set; }

    [Column(TypeName = "int(11)")]
    public int? Status { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? ReadyForArchive { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [StringLength(100)]
    public string UpdatedBy { get; set; }
}
