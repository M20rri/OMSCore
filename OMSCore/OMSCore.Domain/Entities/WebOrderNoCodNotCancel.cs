using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Keyless]
[Table("WebOrderNoCodNotCancel")]
public partial class WebOrderNoCodNotCancel
{
    [StringLength(50)]
    public string WebOrderNo { get; set; }
}
