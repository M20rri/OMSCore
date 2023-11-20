using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("BoxLimitMapping")]
[Index("DSPCode", "CountryCode", "PaymentMethod", Name = "IX_BoxLimitMapping")]
public partial class BoxLimitMapping
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PackagingLocation { get; set; }

    [StringLength(100)]
    public string CountryCode { get; set; }

    [StringLength(50)]
    public string CurrencyCode { get; set; }

    [StringLength(50)]
    public string PaymentMethod { get; set; }

    [StringLength(50)]
    public string DSPCode { get; set; }

    [Precision(10, 3)]
    public decimal BoxLimit { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? Active { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ActiveDate { get; set; }

    [Column(TypeName = "int(11)")]
    public int InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime InsertedOn { get; set; }

    [Column(TypeName = "int(11)")]
    public int? UpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }
}
