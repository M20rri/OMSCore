using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("LiabitlityTransfer")]
[Index("AWBNo", Name = "IDX_LiabitlityTransfer_AWBNo")]
[Index("BoxId", Name = "IDX_LiabitlityTransfer_BoxId")]
public partial class LiabitlityTransfer
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [StringLength(50)]
    public string ReferenceOrderNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int CountryId { get; set; }

    [StringLength(50)]
    public string BoxId { get; set; }

    [StringLength(20)]
    public string AWBNo { get; set; }

    [Precision(15, 3)]
    public decimal? AmountFCY { get; set; }

    [Precision(10, 3)]
    public decimal? AmountLCY { get; set; }

    [Precision(15, 3)]
    public decimal? AmountUSD { get; set; }

    [StringLength(20)]
    public string CurrencyCode { get; set; }

    [Precision(25, 20)]
    public decimal? CurrencyFactor { get; set; }

    [Column(TypeName = "enum('G/L Account','Customer','Vendor','Bank Account','Fixed Asset','IC Partner','DSP Partner')")]
    public string FromAccountType { get; set; }

    [StringLength(20)]
    public string FromAccountNo { get; set; }

    [Column(TypeName = "enum('G/L Account','Customer','Vendor','Bank Account','Fixed Asset','IC Partner','DSP Partner')")]
    public string ToAccountType { get; set; }

    [StringLength(20)]
    public string ToAccountNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PostingDate { get; set; }

    [StringLength(255)]
    public string TransactionNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TransactionDate { get; set; }

    public bool IsSync { get; set; }

    [StringLength(500)]
    public string ErrorMessage { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(255)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "int(11)")]
    public int? RetryCount { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PackagingLocation { get; set; }

    [StringLength(100)]
    public string UpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ReadyForArchive { get; set; }

    [Column(TypeName = "int(11)")]
    public int? DeviceId { get; set; }
}
