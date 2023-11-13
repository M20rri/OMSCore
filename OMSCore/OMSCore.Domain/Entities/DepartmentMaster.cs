using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("DepartmentMaster")]
[Index("Id", Name = "IX_TMPDepartmentMaster")]
public partial class DepartmentMaster
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(100)]
    public string Name { get; set; }

    [Column(TypeName = "int(11)")]
    public int? Active { get; set; }
}
