using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("OrderCategory")]
[Index("CategoryName", Name = "IX_OrderCategory")]
public partial class OrderCategory
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(50)]
    public string CategoryName { get; set; }

    public bool? IsActive { get; set; }

    [StringLength(100)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(100)]
    public string UpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdateOn { get; set; }

    public bool? RefundRequired { get; set; }
}
