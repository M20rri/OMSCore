using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Index("WebOrderNo", "TicketId", Name = "IX_OffLineRefundTransactionDetails_WebOrdTicket")]
public partial class OffLineRefundTransactionDetail
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(50)]
    public string RefOrderNo { get; set; }

    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [Required]
    [StringLength(50)]
    public string TicketId { get; set; }

    [Required]
    [StringLength(500)]
    public string TransactionId { get; set; }

    [StringLength(50)]
    public string TicketPriorityId { get; set; }

    [StringLength(50)]
    public string NextStatus { get; set; }

    public bool? IsEditable { get; set; }

    [Precision(10, 3)]
    public decimal? TotalRefund { get; set; }

    [Precision(10, 3)]
    public decimal? TotalRefundInKWD { get; set; }

    [Precision(10, 3)]
    public decimal? TransactionAmount { get; set; }

    public DateOnly? TransactionDate { get; set; }

    [Required]
    [StringLength(50)]
    public string CurrencyCode { get; set; }

    [StringLength(50)]
    public string UserAssign { get; set; }

    [Precision(10, 3)]
    public decimal? TaxAmount { get; set; }

    [Precision(10, 3)]
    public decimal? ShippingAmount { get; set; }

    [Precision(10, 3)]
    public decimal? DiscountAmount { get; set; }

    [StringLength(200)]
    public string Comments { get; set; }

    [Required]
    [StringLength(500)]
    public string TamaraCaptureId { get; set; }

    [StringLength(500)]
    public string RefundReference { get; set; }

    [StringLength(50)]
    public string PaymentGateWay { get; set; }

    public bool? RetryCount { get; set; }

    public bool? IsSuccess { get; set; }

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

    [Column(TypeName = "int(11)")]
    public int? RefundGatewayId { get; set; }
}
