using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("TicketRefundHeader")]
[Index("WebOrderNo", "TicketId", Name = "IX_TicketRefundHeader")]
[Index("WebOrderNo", "BeforeChangePaymentMethod", "RefundRequired", Name = "IX_TicketRefundHeader_2")]
public partial class TicketRefundHeader
{
    [Key]
    [StringLength(50)]
    public string TicketId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime TicketDate { get; set; }

    [Precision(10, 3)]
    public decimal? ItemValue { get; set; }

    [Precision(10, 3)]
    public decimal? CustomDuty { get; set; }

    [Precision(10, 3)]
    public decimal? Tax { get; set; }

    [Precision(10, 3)]
    public decimal? CodCharges { get; set; }

    [Precision(10, 3)]
    public decimal? ShippingCharges { get; set; }

    [Precision(10, 3)]
    public decimal? GiftCharges { get; set; }

    [Precision(10, 3)]
    public decimal? CustomizationCharges { get; set; }

    [Precision(10, 3)]
    public decimal? OrderProcessCharges { get; set; }

    [Precision(10, 3)]
    public decimal? TotalAmountRefunded { get; set; }

    [StringLength(50)]
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

    public bool? IsByPassQC { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TransactionDate { get; set; }

    [StringLength(255)]
    public string IsMandatetory1 { get; set; }

    [StringLength(255)]
    public string IsMandatetory2 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(50)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [StringLength(50)]
    public string UpdatedBy { get; set; }

    [Precision(10, 3)]
    public decimal? AdjustedWaiverOffAmount { get; set; }

    public bool? BeforeChangePaymentMethod { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? ManualRefund { get; set; }

    [Column(TypeName = "int(11)")]
    public int? CompanyId { get; set; }
}
