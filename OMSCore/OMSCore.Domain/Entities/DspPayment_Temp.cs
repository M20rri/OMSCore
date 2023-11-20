using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("DspPayment_Temp")]
public partial class DspPayment_Temp
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

    [Column(TypeName = "datetime")]
    public DateTime InvoiceDate { get; set; }

    [StringLength(20)]
    public string AWBNo { get; set; }

    [StringLength(100)]
    public string Country { get; set; }

    [StringLength(10)]
    public string Status { get; set; }

    [StringLength(100)]
    public string PaymentMethod { get; set; }

    [StringLength(50)]
    public string DSPCode { get; set; }

    [StringLength(50)]
    public string CurrencyCode { get; set; }

    [Precision(32, 3)]
    public decimal CurrencyFactor { get; set; }

    [Precision(32, 3)]
    public decimal LocalCurrencyAmount { get; set; }

    [Precision(32, 3)]
    public decimal ForeignCurrencyAmount { get; set; }

    [Precision(32, 3)]
    public decimal USDAmount { get; set; }

    [StringLength(50)]
    public string BoxSize { get; set; }

    [StringLength(50)]
    public string BoxWeight { get; set; }

    [StringLength(20)]
    public string CSVAWBNo { get; set; }

    [StringLength(50)]
    public string CSVCurrency { get; set; }

    [Precision(32, 3)]
    public decimal? CSVAmount { get; set; }

    [StringLength(100)]
    public string CSVTransactionId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CSVTransactionDate { get; set; }

    [StringLength(100)]
    public string CSVBankId { get; set; }

    [Precision(32, 3)]
    public decimal? DifferenceAmount { get; set; }

    [Precision(32, 3)]
    public decimal? DifferenceAllowed { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? Matched { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? Include { get; set; }

    [StringLength(250)]
    public string Comments { get; set; }

    [StringLength(250)]
    public string Message { get; set; }

    [Column(TypeName = "int(11)")]
    public int InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }
}
