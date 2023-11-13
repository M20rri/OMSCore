using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("MigratedCustomerKWTOKSA")]
[Index("CustomerId", Name = "CustomerId", IsUnique = true)]
public partial class MigratedCustomerKWTOKSA
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [Required]
    [StringLength(30)]
    public string CustomerId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime InsertedOn { get; set; }

    [Column(TypeName = "int(11)")]
    public int InsertedBy { get; set; }

    public bool? IsMigrated { get; set; }
}
