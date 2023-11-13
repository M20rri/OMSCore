using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Keyless]
[Table("UpdateorderStatus")]
public partial class UpdateorderStatus
{
    [StringLength(50)]
    public string order_number { get; set; }

    [Column(TypeName = "int(11)")]
    public int? Status { get; set; }
}
