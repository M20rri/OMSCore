using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("ProductNotReturnThreshold")]
[Index("Country", "Currency", "ThresholdAmount", Name = "UK_ProductNotReturnThreshold", IsUnique = true)]
public partial class ProductNotReturnThreshold
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(50)]
    public string Country { get; set; }

    [StringLength(50)]
    public string Currency { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ThresholdAmount { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsActive { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(50)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [StringLength(50)]
    public string UpdatedBy { get; set; }
}
