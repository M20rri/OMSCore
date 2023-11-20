using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("CurrencyDenomination")]
public partial class CurrencyDenomination
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(20)]
    public string Code { get; set; }

    [Precision(10, 3)]
    public decimal? Value { get; set; }

    [StringLength(255)]
    public string Symbol { get; set; }

    public bool? IsActive { get; set; }

    [StringLength(20)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }
}
