using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Keyless]
[Table("temp_WebOrderNo")]
public partial class temp_WebOrderNo
{
    [StringLength(100)]
    public string WebOrderNo { get; set; }
}
