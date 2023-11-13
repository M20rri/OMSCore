using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Keyless]
public partial class PostedReturnQCHeader_2Ticket
{
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(50)]
    public string RAWBNo { get; set; }

    [StringLength(20)]
    public string AWBNo { get; set; }

    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int? RAWBCount { get; set; }

    [Column(TypeName = "int(11)")]
    public int? AWBCount { get; set; }

    [Column(TypeName = "int(11)")]
    public int? TicketCount { get; set; }

    [Column(TypeName = "int(11)")]
    public int? AuthoriseRequired { get; set; }

    [StringLength(50)]
    public string UserAssign { get; set; }

    [StringLength(50)]
    public string ApproverUser { get; set; }

    [StringLength(50)]
    public string ReturnLocation { get; set; }

    [StringLength(55)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(50)]
    public string UpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [StringLength(45)]
    public string IsApproved { get; set; }

    [Column(TypeName = "enum('Assigned','Pending','Approval Pending','Approved','Reject')")]
    public string Status { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? ProductsNotReturned { get; set; }

    [StringLength(45)]
    public string ReturnType { get; set; }

    [StringLength(45)]
    public string PaymentMode { get; set; }

    [StringLength(50)]
    public string DocumentNo { get; set; }

    [StringLength(100)]
    public string ReturnReasonCode { get; set; }

    [Precision(10, 2)]
    public decimal? ItemValue { get; set; }

    [Precision(10, 2)]
    public decimal? CODCharges { get; set; }

    [Precision(10, 2)]
    public decimal? ShippingCharges { get; set; }

    [Precision(10, 2)]
    public decimal? GiftCharges { get; set; }

    [Precision(10, 2)]
    public decimal? CustomizationCharges { get; set; }

    [Precision(10, 2)]
    public decimal? OrderProcessCharges { get; set; }

    [Precision(10, 2)]
    public decimal? CustomDuty { get; set; }

    [Precision(10, 2)]
    public decimal? TaxAmount { get; set; }

    [StringLength(100)]
    public string TicketId { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? Mismatch { get; set; }

    [Column(TypeName = "int(11)")]
    public int? RetryCounter { get; set; }

    [StringLength(200)]
    public string ErrorMessage { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsSynced { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SyncedOn { get; set; }
}
