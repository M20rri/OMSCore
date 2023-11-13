using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Keyless]
[Table("MagentoToken")]
public partial class MagentoToken
{
    [StringLength(255)]
    public string TokenValue { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TokenDate { get; set; }
}
