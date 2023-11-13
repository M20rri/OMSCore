using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("TicketHeaderLog")]
[Index("TicketId", "TicketStatus", Name = "IX_TicketHeaderLog")]
public partial class TicketHeaderLog
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(50)]
    public string TicketId { get; set; }

    [Column(TypeName = "int(11)")]
    public int? TicketType { get; set; }

    [Column(TypeName = "int(11)")]
    public int? TicketStatus { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte RefundRequired { get; set; }

    [Column(TypeName = "int(11)")]
    public int? TicketPriority { get; set; }

    [StringLength(50)]
    public string ReferenceTicketId { get; set; }

    [StringLength(50)]
    public string ReferenceTicketType { get; set; }

    [StringLength(50)]
    public string NewTicketId { get; set; }

    [StringLength(50)]
    public string NewTicketType { get; set; }

    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [StringLength(50)]
    public string NewWebOrderNo { get; set; }

    [StringLength(10)]
    public string BaseDocumentType { get; set; }

    [StringLength(50)]
    public string DocumentNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int? UserAssign { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AssignedDateTime { get; set; }

    [Column(TypeName = "int(11)")]
    public int? AppoverUserId { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PackagingLocation { get; set; }

    [StringLength(10)]
    public string Company { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? ReadyForArchive { get; set; }

    [Column(TypeName = "int(11)")]
    public int? SentForApprovalByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InstanceOfDate { get; set; }

    [Column(TypeName = "int(11)")]
    public int VersionNo { get; set; }
}
