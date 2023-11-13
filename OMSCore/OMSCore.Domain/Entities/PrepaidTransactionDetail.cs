using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

public partial class PrepaidTransactionDetail
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [StringLength(100)]
    public string TransactionId { get; set; }

    [Precision(10, 2)]
    public decimal? BoutiqaatCredit { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsSynced { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(100)]
    public string InsertedBy { get; set; }

    [StringLength(100)]
    public string UpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [Precision(10, 2)]
    public decimal? InvoiceValue { get; set; }

    [StringLength(45)]
    public string PaymentMethod { get; set; }

    [Column(TypeName = "int(11)")]
    public int? RetryCounter { get; set; }

    [StringLength(200)]
    public string ErrorMessage { get; set; }

    [StringLength(30)]
    public string CustomerId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? OrderDate { get; set; }

    [StringLength(20)]
    public string CurrencyCode { get; set; }

    [Precision(25, 20)]
    public decimal CurrencyFactor { get; set; }
}
