using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("ProcessStatusMapping")]
public partial class ProcessStatusMapping
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ProcessId { get; set; }

    [Column(TypeName = "int(11)")]
    public int? StatusId { get; set; }

    [StringLength(100)]
    public string Country { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsPrepaid { get; set; }

    [StringLength(15)]
    public string DSPCode { get; set; }

    [StringLength(10)]
    public string ReturnType { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsActive { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(100)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [StringLength(100)]
    public string UpdatedBy { get; set; }
}
