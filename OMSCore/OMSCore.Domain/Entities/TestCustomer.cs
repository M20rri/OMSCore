using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("TestCustomer")]
[Index("CustomerId", "Active", Name = "IDX_TestCustomer")]
public partial class TestCustomer
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(30)]
    public string CustomerId { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? Active { get; set; }
}
