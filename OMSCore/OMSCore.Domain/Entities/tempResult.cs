using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Keyless]
[Table("tempResult")]
public partial class tempResult
{
    [StringLength(50)]
    public string KeyData { get; set; }

    [StringLength(100)]
    public string ValueData { get; set; }

    [StringLength(100)]
    public string ConditionData { get; set; }
}
