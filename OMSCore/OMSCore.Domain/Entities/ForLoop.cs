using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("ForLoop")]
public partial class ForLoop
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int i { get; set; }
}
