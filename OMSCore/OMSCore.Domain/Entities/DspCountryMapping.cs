using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("DspCountryMapping")]
[Index("PackagingLocation", "DSPCode", "FMDSPCode", "CountryCode", Name = "unq_DspCountryMapping_PkgLoc_DSPCode_FMDSP_Country", IsUnique = true)]
public partial class DspCountryMapping
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PackagingLocation { get; set; }

    [StringLength(50)]
    public string DSPCode { get; set; }

    [StringLength(50)]
    public string FMDSPCode { get; set; }

    [StringLength(100)]
    public string CountryCode { get; set; }

    [StringLength(100)]
    public string CountryName { get; set; }

    [Column(TypeName = "int(11)")]
    public int? HiPackageAmount { get; set; }

    [StringLength(20)]
    public string CurrencyCode { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? ElectronicsPartial { get; set; }

    public bool? SendShipmentAmountUSD { get; set; }

    public bool? PrintInvoiceAmountUSD { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [Column(TypeName = "int(11)")]
    public int? InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [Column(TypeName = "int(11)")]
    public int? UpdatedBy { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? Active { get; set; }

    [Precision(10, 3)]
    public decimal? MinWeight { get; set; }

    [Precision(10, 3)]
    public decimal? MaxWeight { get; set; }
}
