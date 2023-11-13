using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Keyless]
[Table("tempItemDetail")]
public partial class tempItemDetail
{
    [StringLength(20)]
    public string ItemNo { get; set; }

    [StringLength(250)]
    public string Description { get; set; }

    [StringLength(250)]
    public string ArabicDescription { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsDanger { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsFragile { get; set; }
}
