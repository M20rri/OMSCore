using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Keyless]
public partial class CountryShippingCharge
{
    [StringLength(100)]
    public string Country { get; set; }

    [Precision(10, 3)]
    public decimal? ShippingCharges { get; set; }
}
