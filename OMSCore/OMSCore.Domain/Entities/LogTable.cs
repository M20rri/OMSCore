using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("LogTable")]
public partial class LogTable
{
    [Column(TypeName = "datetime")]
    public DateTime? RUNTIME { get; set; }

    [Column("Proc Name")]
    [StringLength(100)]
    public string Proc_Name { get; set; }

    [Column("Entry Type")]
    [StringLength(45)]
    public string Entry_Type { get; set; }

    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(20)]
    public string TimeStamp { get; set; }
}
