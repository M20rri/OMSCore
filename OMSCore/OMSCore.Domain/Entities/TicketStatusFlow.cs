using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("TicketStatusFlow")]
[Index("TicketType", "NextStatus", "CurrentStatus", "RefundRequired", Name = "IDX_TicketStatusFlow")]
public partial class TicketStatusFlow
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [Column(TypeName = "int(11)")]
    public int? TicketType { get; set; }

    [Column(TypeName = "int(11)")]
    public int? CurrentStatus { get; set; }

    [Column(TypeName = "int(11)")]
    public int? NextStatus { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? RefundRequired { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ReadyForArchive { get; set; }

    [StringLength(45)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(45)]
    public string UpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }
}
