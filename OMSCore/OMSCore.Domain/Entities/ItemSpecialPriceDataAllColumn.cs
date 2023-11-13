using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Keyless]
[Table("ItemSpecialPriceDataAllColumn")]
[Index("ItemNo", Name = "idx_ItemSpecialPriceDataAllColumn_ItemNo")]
public partial class ItemSpecialPriceDataAllColumn
{
    [StringLength(50)]
    public string ItemNo { get; set; }

    public double? NormalPrice { get; set; }

    public double? TotalDiscount { get; set; }

    public double? SpecialPrice { get; set; }

    public double? VAT { get; set; }

    public double? SpecialPriceExclVAT { get; set; }
}
