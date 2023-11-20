using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Keyless]
[Table("electronics_from_purchase_20211216")]
public partial class electronics_from_purchase_20211216
{
    [StringLength(50)]
    public string SKU { get; set; }

    [StringLength(200)]
    public string Product_Name { get; set; }

    [StringLength(50)]
    public string Product_Type { get; set; }

    [StringLength(50)]
    public string type { get; set; }

    [StringLength(50)]
    public string dept { get; set; }

    [StringLength(50)]
    public string Declaration { get; set; }
}
