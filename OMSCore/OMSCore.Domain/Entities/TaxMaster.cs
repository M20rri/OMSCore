using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("TaxMaster")]
[Index("FromDate", "ToDate", "FromCountry", "ToCountry", "FromAmount", "ToAmount", "IsActive", Name = "IDX_TaxMaster")]
public partial class TaxMaster
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    public DateOnly? FromDate { get; set; }

    public DateOnly? ToDate { get; set; }

    [Column(TypeName = "int(11)")]
    public int? FromCountry { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ToCountry { get; set; }

    [Precision(10, 2)]
    public decimal? FromAmount { get; set; }

    [Precision(10, 2)]
    public decimal? ToAmount { get; set; }

    [Column(TypeName = "enum('','Item','Item+Charges','Item+Charges+Custom','Item+Custom')")]
    public string TaxCalculationBase { get; set; }

    [Precision(10, 2)]
    public decimal? TaxPercentage { get; set; }

    [Column(TypeName = "enum('','Item','Item+Charges')")]
    public string CustomDutyBase { get; set; }

    [Precision(10, 2)]
    public decimal? CustomDutyPercentage { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte IsActive { get; set; }
}
