using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("CompanyMaster")]
public partial class CompanyMaster
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(50)]
    public string Name { get; set; }

    [StringLength(255)]
    public string CompanyAddress { get; set; }

    [StringLength(255)]
    public string APIURL { get; set; }

    [StringLength(255)]
    public string APIUserName { get; set; }

    [StringLength(255)]
    public string APIPassword { get; set; }

    public bool? Active { get; set; }

    [StringLength(255)]
    public string MagentoToken { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TokenDate { get; set; }

    [StringLength(255)]
    public string ReadAPIURL { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? AddressRevampActive { get; set; }

    [StringLength(255)]
    public string UnifiedAPIURL { get; set; }

    [StringLength(255)]
    public string UnifiedAPIToken { get; set; }

    [StringLength(500)]
    public string ElasticSearch { get; set; }

    [StringLength(255)]
    public string CRSAPIURL { get; set; }

    [StringLength(255)]
    public string AddressAPIURL { get; set; }

    [StringLength(100)]
    public string BaseURLOFS { get; set; }

    [StringLength(100)]
    public string BaseURLCRM { get; set; }

    [StringLength(100)]
    public string TaxPayerName { get; set; }

    [StringLength(250)]
    public string TaxPayerAddress { get; set; }

    [StringLength(100)]
    public string VATRegNo { get; set; }

    [StringLength(100)]
    public string EffectiveRegDate { get; set; }

    [StringLength(250)]
    public string TaxPayerAddressEN { get; set; }

    [StringLength(250)]
    public string TaxPayerAddressAR { get; set; }

    [Precision(5, 2)]
    public decimal? ColloectionPercentage { get; set; }

    [Precision(5, 2)]
    public decimal? ColloectionVATPercentage { get; set; }

    [Column(TypeName = "int(11)")]
    public int? CountryId { get; set; }

    [Column(TypeName = "enum('Fixed','Variable')")]
    public string CollectionType { get; set; }

    [Precision(10, 3)]
    public decimal? OrderHeaderLineAllowedDiff { get; set; }

    [StringLength(10)]
    public string CurrencyCode { get; set; }
}
