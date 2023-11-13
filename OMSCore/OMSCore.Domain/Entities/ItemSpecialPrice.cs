using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Keyless]
[Table("ItemSpecialPrice")]
[Index("ItemNo", Name = "idx_ItemSpecialPrice_ItemNo")]
public partial class ItemSpecialPrice
{
    [StringLength(50)]
    public string ItemNo { get; set; }

    [Precision(10, 2)]
    public decimal? SpecialPrice { get; set; }

    [Precision(10, 2)]
    public decimal? NormalPrice { get; set; }
}
