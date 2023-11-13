using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Index("BoxId", "WebOrderNo", Name = "Idx_BoxInsuranceDetails_BoxId_WeborderNo")]
public partial class BoxInsuranceDetail
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [StringLength(50)]
    public string ReferenceOrderNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? OrderDate { get; set; }

    [Required]
    [StringLength(50)]
    public string BoxId { get; set; }

    [StringLength(50)]
    public string DspPartner { get; set; }

    [StringLength(100)]
    public string FromCountry { get; set; }

    [StringLength(100)]
    public string ToCountry { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FromDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ToDate { get; set; }

    [StringLength(50)]
    public string InsuranceBase { get; set; }

    [StringLength(50)]
    public string InsuranceComponent { get; set; }

    [StringLength(50)]
    public string PercentageFlatValue { get; set; }

    [Precision(10, 3)]
    public decimal? TotalItemValue { get; set; }

    [Precision(10, 3)]
    public decimal? TaxAmount { get; set; }

    [Precision(10, 3)]
    public decimal? CutomDuty { get; set; }

    [Precision(10, 3)]
    public decimal? InsuranceAmount { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PackagingLocation { get; set; }

    [Precision(10, 3)]
    public decimal? NetValue { get; set; }

    [Precision(10, 3)]
    public decimal? USDCurrencyFactor { get; set; }

    [Precision(10, 3)]
    public decimal? CurrencyFactor { get; set; }

    [Precision(10, 3)]
    public decimal? USDTaxAmount { get; set; }

    [Precision(10, 3)]
    public decimal? USDCustomDuty { get; set; }

    [Precision(10, 3)]
    public decimal? USDTotalItemValue { get; set; }

    [Precision(10, 3)]
    public decimal? USDNetValue { get; set; }

    [Precision(10, 3)]
    public decimal? USDInsuranceAmount { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsInsuranceRequired { get; set; }

    [StringLength(100)]
    public string Remarks { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(50)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [StringLength(50)]
    public string UpdatedBy { get; set; }
}
