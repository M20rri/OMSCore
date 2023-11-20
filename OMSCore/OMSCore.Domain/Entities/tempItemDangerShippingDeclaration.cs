using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Keyless]
[Table("tempItemDangerShippingDeclaration")]
public partial class tempItemDangerShippingDeclaration
{
    [StringLength(40)]
    public string ItemNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int? IsDanger { get; set; }

    [StringLength(100)]
    public string ShippingDeclaration { get; set; }
}
