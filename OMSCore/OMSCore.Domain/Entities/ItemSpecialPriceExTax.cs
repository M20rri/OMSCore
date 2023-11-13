using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Keyless]
[Table("ItemSpecialPriceExTax")]
[Index("ItemNo", Name = "idx_ItemSpecialPriceExTax_ItemNo")]
public partial class ItemSpecialPriceExTax
{
    [StringLength(50)]
    public string ItemNo { get; set; }

    public double? SpecialPrice { get; set; }

    public double? NormalPrice { get; set; }
}
