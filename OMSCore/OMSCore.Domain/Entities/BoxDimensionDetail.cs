using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Index("AWBNo", Name = "IDX_BoxDimensionDetails_AWBNo")]
[Index("BoxId", Name = "IDX_BoxDimensionDetails_BoxId")]
public partial class BoxDimensionDetail
{
    [StringLength(20)]
    public string AWBNo { get; set; }

    [Key]
    [StringLength(50)]
    public string BoxId { get; set; }

    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [StringLength(50)]
    public string PackagingItem { get; set; }

    [Precision(10, 2)]
    public decimal? Length { get; set; }

    [Precision(10, 2)]
    public decimal? Breadth { get; set; }

    [Precision(10, 2)]
    public decimal? Height { get; set; }

    [Precision(10, 2)]
    public decimal? Weight { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? Active { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? ReadyForArchive { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(100)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [StringLength(100)]
    public string UpdatedBy { get; set; }

    [StringLength(45)]
    public string DimensionUnit { get; set; }

    [StringLength(45)]
    public string WeightUnit { get; set; }
}
