using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("CountryMaster")]
[Index("Description", Name = "IDX_CountryMaster_Description")]
[Index("Id", Name = "IDX_CountryMaster_Id")]
[Index("Name", Name = "IDX_CountryMaster_Name")]
public partial class CountryMaster
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(100)]
    public string Name { get; set; }

    [Column(TypeName = "int(11)")]
    public int? RegionId { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? Active { get; set; }

    [StringLength(100)]
    public string Description { get; set; }

    [StringLength(20)]
    public string CurrencyCode { get; set; }

    [StringLength(100)]
    public string Currency { get; set; }

    [StringLength(100)]
    public string CurrencySubdivision { get; set; }

    [StringLength(10)]
    public string PhoneCode { get; set; }

    [Precision(10, 3)]
    public decimal? RightOff { get; set; }

    [Column(TypeName = "enum('ROUND','ROUNDUP','ROUNDDOWN')")]
    public string RoundingType { get; set; }

    [StringLength(10)]
    public string RoundingPrecision { get; set; }

    [StringLength(100)]
    public string AmeyoCountryCode { get; set; }

    [StringLength(3)]
    public string ISOCode { get; set; }

    [StringLength(3)]
    public string OrderSeries { get; set; }

    [StringLength(3)]
    public string OrderSeriesLen { get; set; }

    [Column(TypeName = "int(11)")]
    public int? GiftOrderThreshold { get; set; }

    [Precision(10, 3)]
    public decimal? ExchangeThreshold { get; set; }

    [Column(TypeName = "int(11)")]
    public int? SurpriseGiftThreshold { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? PartialPackingAllowed { get; set; }

    [Column(TypeName = "int(11)")]
    public int? SCCountryId { get; set; }
}
