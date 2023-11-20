using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("ReturnCategory")]
public partial class ReturnCategory
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [Column("ReturnCategory")]
    [StringLength(100)]
    public string ReturnCategory1 { get; set; }

    [StringLength(100)]
    public string ReturnSubCategory { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? Active { get; set; }
}
