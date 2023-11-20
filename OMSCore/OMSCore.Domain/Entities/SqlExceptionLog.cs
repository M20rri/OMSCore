using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("SqlExceptionLog")]
public partial class SqlExceptionLog
{
    [Key]
    [Column(TypeName = "int(11) unsigned")]
    public uint Id { get; set; }

    [StringLength(500)]
    public string SPName { get; set; }

    [StringLength(8000)]
    public string ErrorMessage { get; set; }

    [StringLength(8000)]
    public string Parameters { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(255)]
    public string InsertedBy { get; set; }
}
