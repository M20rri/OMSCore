using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("DepartmentHead")]
public partial class DepartmentHead
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [Column(TypeName = "int(11)")]
    public int? DeptId { get; set; }

    [Column(TypeName = "int(11)")]
    public int? SubDeptId { get; set; }

    [Column(TypeName = "int(11)")]
    public int? UserId { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? Active { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ReadyForArchive { get; set; }

    [Column(TypeName = "int(11)")]
    public int? InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [Column(TypeName = "int(11)")]
    public int? UpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }
}
