using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Index("CurrencyCode1", Name = "IDX_CurrencyCode")]
public partial class CurrencyCode
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int ID { get; set; }

    [Column("CurrencyCode")]
    [StringLength(20)]
    public string CurrencyCode1 { get; set; }

    [StringLength(60)]
    public string CurrencyDescription { get; set; }

    [Precision(38, 20)]
    public decimal ExchangeRateAmount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime StartingDate { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ErrorOccured { get; set; }

    [StringLength(1000)]
    public string ErrorMessage { get; set; }

    [Precision(10, 3)]
    public decimal? DifferenceAllowed { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PackagingLocation { get; set; }
}
