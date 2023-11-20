using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Keyless]
[Table("OrderBoxWeightSizeMaster")]
public partial class OrderBoxWeightSizeMaster
{
    [Column(TypeName = "int(11)")]
    public int? OrderSize { get; set; }

    [Precision(10, 3)]
    public decimal? BoxWeight { get; set; }

    [Precision(10, 3)]
    public decimal? BoxSize { get; set; }
}
