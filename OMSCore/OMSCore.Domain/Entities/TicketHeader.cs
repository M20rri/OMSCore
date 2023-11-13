using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("TicketHeader")]
[Index("TicketId", "TicketType", "TicketStatus", "TicketPriority", "RefundRequired", "UserAssign", "ShortClose", Name = "IDX_TicketHeader")]
[Index("InsertedBy", Name = "IDX_TicketHeader_InsertedBy")]
[Index("NewWebOrderNo", Name = "IDX_TicketHeader_NewWebOrderNo")]
[Index("WebOrderNo", Name = "IDX_TicketHeader_WebOrderNo")]
[Index("IsLMSSync", Name = "IXD_TicketHeader_IsLMSSync")]
[Index("InsertedOn", Name = "IX_TicketHeader")]
[Index("ShortClose", Name = "IX_TicketHeader_ShortClose")]
[Index("AWBNo", "TicketType", Name = "idx_TicketHeader_AWBNoTicketType")]
public partial class TicketHeader
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte RefundRequired { get; set; }

    [StringLength(50)]
    public string TicketId { get; set; }

    [Column(TypeName = "int(11)")]
    public int? TicketType { get; set; }

    [StringLength(50)]
    public string ReferenceTicketId { get; set; }

    [StringLength(50)]
    public string ReferenceTicketType { get; set; }

    [StringLength(50)]
    public string NewTicketId { get; set; }

    [StringLength(50)]
    public string NewTicketType { get; set; }

    [Column(TypeName = "int(11)")]
    public int? TicketStatus { get; set; }

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
    public int? TicketPriority { get; set; }

    [Column(TypeName = "int(11)")]
    public int? AppoverUserId { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PackagingLocation { get; set; }

    [StringLength(10)]
    public string Company { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? ReadyForArchive { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(50)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [StringLength(45)]
    public string UpdatedBy { get; set; }

    [Column(TypeName = "int(11)")]
    public int? SentForApprovalByUserId { get; set; }

    [StringLength(20)]
    public string AWBNo { get; set; }

    public bool? ShortClose { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsFraud { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? ProductNotReturn { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsLMSSync { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? IsLMSSyncDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ApprovedDate { get; set; }

    [Column(TypeName = "int(11)")]
    public int? Archive { get; set; }

    [StringLength(20)]
    public string TicketSource { get; set; }

    [Column(TypeName = "int(11)")]
    public int? RetryCount { get; set; }

    [StringLength(500)]
    public string LMSResponseMessage { get; set; }

    [StringLength(100)]
    public string Reason { get; set; }

    [Column(TypeName = "int(11)")]
    public int? CompanyId { get; set; }

    public bool? IsCreditMemoCreated { get; set; }
}
