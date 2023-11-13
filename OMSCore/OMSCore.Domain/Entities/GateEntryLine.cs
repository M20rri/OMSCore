using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("GateEntryLine")]
[Index("WebOrderNo", "AWBNo", "RAWBNo", Name = "IX_GateEntryLine_1")]
[Index("DocumentNumber", Name = "IX_GateEntryLine_DocumentNumber")]
public partial class GateEntryLine
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int ID { get; set; }

    [StringLength(50)]
    public string DocumentNumber { get; set; }

    [StringLength(50)]
    public string RAWBNo { get; set; }

    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int? Status { get; set; }

    [StringLength(50)]
    public string ReturnType { get; set; }

    public DateOnly? DateCreated { get; set; }

    [Column(TypeName = "time")]
    public TimeOnly? TimeCreated { get; set; }

    [StringLength(50)]
    public string UserCreated { get; set; }

    [StringLength(50)]
    public string ReturnDSPCode { get; set; }

    [StringLength(20)]
    public string AWBNo { get; set; }

    [StringLength(50)]
    public string Remarks { get; set; }

    [StringLength(50)]
    public string QCDoneBy { get; set; }

    [StringLength(50)]
    public string QCTime { get; set; }

    public DateOnly? QCDate { get; set; }

    [StringLength(50)]
    public string CustomerID { get; set; }

    [StringLength(50)]
    public string ForwardDSPCode { get; set; }

    [StringLength(50)]
    public string PCCode { get; set; }

    [StringLength(50)]
    public string QCPriority { get; set; }

    [StringLength(50)]
    public string TicketID { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? ReadyForArchive { get; set; }

    [StringLength(100)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [StringLength(100)]
    public string UpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(50)]
    public string ItemID { get; set; }
}
