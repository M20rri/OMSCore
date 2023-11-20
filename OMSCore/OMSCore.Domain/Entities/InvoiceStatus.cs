using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("InvoiceStatus")]
[Index("BoxId", Name = "IDX_InvoiceStatus_BoxId")]
[Index("BoxId", "WebOrderNo", Name = "IDX_InvoiceStatus_BoxId_WebOrderNo")]
[Index("InsertedOn", Name = "IDX_InvoiceStatus_InsertedOn")]
[Index("InvoiceNo", Name = "IDX_InvoiceStatus_InvoiceNo")]
public partial class InvoiceStatus
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(50)]
    public string BoxId { get; set; }

    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [StringLength(50)]
    public string InvoiceNo { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsInvAwsPacked { get; set; }

    [StringLength(100)]
    public string IsInvAwsPackedPath { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsInvAwsPackedRetry { get; set; }

    [StringLength(100)]
    public string IsInvAwsPackedError { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsInvAwsShipped { get; set; }

    [StringLength(100)]
    public string IsInvAwsShippedPath { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsInvAwsShippedRetry { get; set; }

    [StringLength(100)]
    public string IsInvAwsShippedError { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsInvAwsDelivered { get; set; }

    [StringLength(100)]
    public string IsInvAwsDeliveredPath { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsInvAwsDeliveredRetry { get; set; }

    [StringLength(100)]
    public string IsInvAwsDeliveredError { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsInvSyncDSP { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? IsInvSyncDSPDateTime { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsInvSyncDSPRetry { get; set; }

    [StringLength(100)]
    public string IsInvSyncDSPError { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(50)]
    public string InsertedBy { get; set; }
}
