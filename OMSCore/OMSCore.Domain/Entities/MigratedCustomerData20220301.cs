using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Keyless]
[Table("MigratedCustomerData20220301")]
public partial class MigratedCustomerData20220301
{
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [Column(TypeName = "enum('Payment','Cancel','Sale','BCredit','Waiveoff','Refund','BCPayment','BC to Payment Gateway','Gift','Gift Card Sale','Gift Card Redeem','Exchange Refund','Exchange Cancel','Collection Invoice','Collection Credit Memo','DSP Collection')")]
    public string EntryType { get; set; }

    [StringLength(30)]
    public string CustomerId { get; set; }

    [StringLength(100)]
    public string Country { get; set; }

    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsMWH { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PackagingLocation { get; set; }

    [Column(TypeName = "enum('Company','InterCompany')")]
    public string TransactionType { get; set; }

    [StringLength(50)]
    public string CurrencyCode { get; set; }

    [Precision(25, 20)]
    public decimal? CurrencyFactor { get; set; }

    [Precision(25, 20)]
    public decimal? OldCurrencyFactor { get; set; }
}
