using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[PrimaryKey("Id", "PaymentMethod")]
[Table("PaymentMaster")]
public partial class PaymentMaster
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [Key]
    public string PaymentMethod { get; set; }

    public bool? IsActive { get; set; }
}
