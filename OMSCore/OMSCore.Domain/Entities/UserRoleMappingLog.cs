using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("UserRoleMappingLog")]
public partial class UserRoleMappingLog
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [Column(TypeName = "int(11)")]
    public int? UserId { get; set; }

    [Column(TypeName = "int(11)")]
    public int? RoleId { get; set; }

    [StringLength(20)]
    public string ActionType { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ActionDate { get; set; }

    [Column(TypeName = "int(11)")]
    public int? UpdatedBy { get; set; }
}
