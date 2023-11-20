using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Keyless]
[Table("TEMP1_ARUN")]
public partial class TEMP1_ARUN
{
    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [StringLength(50)]
    public string ItemNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int? IsMatching { get; set; }
}
