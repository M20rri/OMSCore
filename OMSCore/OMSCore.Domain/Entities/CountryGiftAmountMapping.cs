using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("CountryGiftAmountMapping")]
public partial class CountryGiftAmountMapping
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(10)]
    public string CurrencyCode { get; set; }

    [Precision(10, 3)]
    public decimal? Amount { get; set; }
}
