using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("LostAWBbyaramex")]
public partial class LostAWBbyaramex
{
    [StringLength(50)]
    public string AWB { get; set; }

    [StringLength(50)]
    public string WeborderNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int? UserId { get; set; }

    [StringLength(50)]
    public string OrderStatus { get; set; }

    public DateOnly? Details { get; set; }

    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }
}
