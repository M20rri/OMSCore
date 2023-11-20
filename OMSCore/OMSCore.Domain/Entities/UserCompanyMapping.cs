using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("UserCompanyMapping")]
public partial class UserCompanyMapping
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [Column(TypeName = "int(11)")]
    public int? UserId { get; set; }

    [Column(TypeName = "int(11)")]
    public int? CompanyId { get; set; }

    public bool? Active { get; set; }
}
