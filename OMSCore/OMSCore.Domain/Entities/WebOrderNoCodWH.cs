using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Keyless]
[Table("WebOrderNoCodWH")]
public partial class WebOrderNoCodWH
{
    [StringLength(50)]
    public string WebOrderNo { get; set; }
}
