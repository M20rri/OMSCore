using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("RegionMaster")]
public partial class RegionMaster
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(100)]
    public string RegionName { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? Active { get; set; }
}
