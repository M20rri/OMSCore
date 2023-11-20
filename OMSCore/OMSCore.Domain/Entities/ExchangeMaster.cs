using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("ExchangeMaster")]
public partial class ExchangeMaster
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(255)]
    public string TicketType { get; set; }

    [StringLength(255)]
    public string ReturnType { get; set; }

    public bool? Charges { get; set; }

    public bool? CustomDuty { get; set; }

    public bool? Tax { get; set; }
}
