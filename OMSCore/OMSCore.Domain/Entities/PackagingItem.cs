using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("PackagingItem")]
[Index("PackagingNo", Name = "IDX_PackagingItem_PackagingNo")]
public partial class PackagingItem
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int PackagingId { get; set; }

    [StringLength(45)]
    public string PackagingNo { get; set; }

    [StringLength(45)]
    public string Description { get; set; }

    [Precision(10, 3)]
    public decimal? Length { get; set; }

    [Precision(10, 3)]
    public decimal? Breadth { get; set; }

    [Precision(10, 3)]
    public decimal? Height { get; set; }

    [StringLength(20)]
    public string UnitOfMeasure { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? Undefined { get; set; }

    [Precision(10, 3)]
    public decimal? VolumatricWeight { get; set; }

    [Precision(38, 0)]
    public decimal? DividedBy { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? DefaultPackingItem { get; set; }

    [StringLength(45)]
    public string DimensionUnit { get; set; }

    [StringLength(45)]
    public string WeightUnit { get; set; }
}
