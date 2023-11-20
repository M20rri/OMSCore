using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("MyFatoorahTransactionDetailsLOG")]
public partial class MyFatoorahTransactionDetailsLOG
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [StringLength(50)]
    public string ChildOrderNo { get; set; }

    [StringLength(50)]
    public string TicketId { get; set; }

    [StringLength(20)]
    public string InvoiceId { get; set; }

    [StringLength(255)]
    public string InvoiceURL { get; set; }

    [StringLength(20)]
    public string InvoiceStatus { get; set; }

    [StringLength(20)]
    public string InvoiceReference { get; set; }

    [StringLength(50)]
    public string TransactionDate { get; set; }

    [StringLength(50)]
    public string PaymentGateway { get; set; }

    [StringLength(50)]
    public string ReferenceId { get; set; }

    [StringLength(50)]
    public string TrackId { get; set; }

    [StringLength(50)]
    public string TransactionId { get; set; }

    [StringLength(50)]
    public string PaymentId { get; set; }

    [StringLength(50)]
    public string AuthorizationId { get; set; }

    [StringLength(20)]
    public string TransationValue { get; set; }

    [StringLength(20)]
    public string CustomerServiceCharge { get; set; }

    [StringLength(20)]
    public string TotalValue { get; set; }

    [StringLength(10)]
    public string PaidCurrency { get; set; }

    [StringLength(20)]
    public string PaidCurrencyValue { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsProcessed { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ProcessedDateTime { get; set; }

    [Precision(10, 3)]
    public decimal? WebOrderAmount { get; set; }

    [Precision(10, 3)]
    public decimal? ChildOrderAmount { get; set; }

    [StringLength(255)]
    public string ErrorMessage { get; set; }

    [StringLength(50)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(50)]
    public string UpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [Precision(10, 3)]
    public decimal? RecalculatedAmount { get; set; }

    [StringLength(50)]
    public string CurrencyCode { get; set; }

    [Precision(10, 3)]
    public decimal? CustomDuty { get; set; }

    [Precision(10, 3)]
    public decimal? Tax { get; set; }

    [Precision(10, 3)]
    public decimal? ShippingCharges { get; set; }

    [Precision(10, 3)]
    public decimal? CODCharges { get; set; }

    [StringLength(50)]
    public string SecondaryPaymentGateway { get; set; }
}
