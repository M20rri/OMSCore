using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("TicketRefundHeaderLog")]
public partial class TicketRefundHeaderLog
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(100)]
    public string TicketId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime TicketDate { get; set; }

    [Precision(10, 2)]
    public decimal ItemValue { get; set; }

    [Precision(10, 2)]
    public decimal CustomDuty { get; set; }

    [Precision(10, 2)]
    public decimal Tax { get; set; }

    [Precision(10, 2)]
    public decimal? CodCharges { get; set; }

    [Precision(10, 2)]
    public decimal? ShippingCharges { get; set; }

    [Precision(10, 2)]
    public decimal? GiftCharges { get; set; }

    [Precision(10, 2)]
    public decimal? CustomizationCharges { get; set; }

    [Precision(10, 2)]
    public decimal? OrderProcessCharges { get; set; }

    [Precision(10, 2)]
    public decimal TotalAmountRefunded { get; set; }

    [StringLength(45)]
    public string WebOrderNo { get; set; }

    [StringLength(45)]
    public string RefundedAmount { get; set; }

    [StringLength(100)]
    public string AccountNumber { get; set; }

    [StringLength(45)]
    public string SwiftCode { get; set; }

    [StringLength(45)]
    public string BankName { get; set; }

    [StringLength(45)]
    public string IFSCCode { get; set; }

    [StringLength(45)]
    public string RefundType { get; set; }

    [StringLength(45)]
    public string TransactionId { get; set; }

    [StringLength(45)]
    public string AuthorizationNo { get; set; }

    [StringLength(50)]
    public string CurrencyCode { get; set; }

    [Precision(25, 20)]
    public decimal? CurrencyFactor { get; set; }

    public bool? RefundRequired { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TransactionDate { get; set; }

    [StringLength(255)]
    public string IsMandatetory1 { get; set; }

    [StringLength(255)]
    public string IsMandatetory2 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InstanceOfDate { get; set; }

    [Column(TypeName = "int(11)")]
    public int VersionNo { get; set; }
}
