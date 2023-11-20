using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("ProcessLedger")]
public partial class ProcessLedger
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ProcessId { get; set; }

    [StringLength(50)]
    public string ProcessName { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ItemId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(100)]
    public string InsertedBy { get; set; }

    [StringLength(100)]
    public string Source { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? ProcessStatus { get; set; }
}
