using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("DSPPackageInsurance")]
public partial class DSPPackageInsurance
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    [StringLength(50)]
    public string DSPPartner { get; set; }

    [StringLength(100)]
    public string OriginCountry { get; set; }

    [StringLength(100)]
    public string DestinationCountry { get; set; }

    [StringLength(50)]
    public string InsuranceBase { get; set; }

    [StringLength(500)]
    public string InsuranceComponent { get; set; }

    [StringLength(50)]
    public string Currency { get; set; }

    [Precision(10, 3)]
    public decimal? TaxPercentage { get; set; }

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
}
