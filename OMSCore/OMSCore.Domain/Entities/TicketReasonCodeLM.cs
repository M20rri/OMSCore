using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("TicketReasonCodeLMS")]
public partial class TicketReasonCodeLM
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(200)]
    public string Name { get; set; }

    [StringLength(10)]
    public string Code { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? Active { get; set; }
}
