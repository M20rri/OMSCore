using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("RoleMaster")]
public partial class RoleMaster
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(50)]
    public string RoleName { get; set; }

    [StringLength(500)]
    public string Description { get; set; }

    [Column(TypeName = "int(11)")]
    public int? UpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [StringLength(50)]
    public string ApplicableFor { get; set; }

    [Column(TypeName = "int(11)")]
    public int? InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }
}
