using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Keyless]
[Table("OrderPaymentEntryReport")]
public partial class OrderPaymentEntryReport
{
    [Column(TypeName = "int(11)")]
    public int? Id { get; set; }

    [Column(TypeName = "enum('Payment','Cancel','Sale','BCredit','Waiveoff','Refund','BCPayment','BC to Payment Gateway','Gift','Gift Card Sale','Gift Card Redeem','Exchange Refund','Exchange Cancel','Collection Invoice','Collection Credit Memo','DSP Collection')")]
    public string EntryType { get; set; }

    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [StringLength(50)]
    public string ReferenceOrderNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PackagingLocation { get; set; }

    [StringLength(30)]
    public string CustomerId { get; set; }

    [Precision(10, 3)]
    public decimal? OrderAmount { get; set; }

    [Precision(10, 3)]
    public decimal? OrderAmountLCY { get; set; }

    [StringLength(100)]
    public string Country { get; set; }

    [StringLength(20)]
    public string AWBNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? OrderDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PostingDate { get; set; }

    [Column(TypeName = "enum('G/L Account','Customer','Vendor','Bank Account','Fixed Asset','IC Partner')")]
    public string PaymentGatewayType { get; set; }

    [StringLength(30)]
    public string PaymentGateway { get; set; }

    [StringLength(100)]
    public string TransactionId { get; set; }

    [Precision(10, 3)]
    public decimal? BQWaiveoffAmount { get; set; }

    [StringLength(50)]
    public string PaymentMethodCode { get; set; }

    [StringLength(50)]
    public string CurrencyCode { get; set; }

    [Precision(25, 20)]
    public decimal? CurrencyFactor { get; set; }

    public bool? IsSync { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SyncDateTime { get; set; }

    [StringLength(255)]
    public string ErrorMessage { get; set; }

    public bool? ReadyForArchive { get; set; }

    [StringLength(50)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(50)]
    public string UpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [Precision(10, 3)]
    public decimal? Discount { get; set; }

    [Column(TypeName = "int(11)")]
    public int? RetryCount { get; set; }

    [Column(TypeName = "enum('','Compensation','Refund','Exchange','Cancel')")]
    public string TicketType { get; set; }

    [Column(TypeName = "enum('NDR','CIR')")]
    public string ReturnType { get; set; }

    public bool? BeforeChangePaymentMethod { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? ReadyForSync { get; set; }

    [Column(TypeName = "int(11)")]
    public int? LockedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LockedDateTime { get; set; }

    [StringLength(50)]
    public string TicketId { get; set; }

    [Column(TypeName = "int(11)")]
    public int? RowId { get; set; }
}
