using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Keyless]
[Table("tempTicketDetailAWB")]
public partial class tempTicketDetailAWB
{
    [StringLength(20)]
    public string AWBNo { get; set; }

    [StringLength(50)]
    public string TicketId { get; set; }

    [Column(TypeName = "int(11)")]
    public int? TicketType { get; set; }

    [StringLength(45)]
    public string Name { get; set; }

    [StringLength(100)]
    public string Type { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }
}
