using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("StatusProcessMapping")]
[Index("ProcessName", "IsActive", Name = "IDX_StatusProcessMapping")]
public partial class StatusProcessMapping
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(100)]
    public string ProcessName { get; set; }

    [Column(TypeName = "int(11)")]
    public int AppliedStatus { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(45)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsActive { get; set; }

    [StringLength(100)]
    public string Country { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsPrepaid { get; set; }
}
