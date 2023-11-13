using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Keyless]
[Table("tempAWBGE")]
public partial class tempAWBGE
{
    [StringLength(50)]
    public string AWBNo { get; set; }
}
