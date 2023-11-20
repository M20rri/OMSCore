using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("ShipmentMatrix")]
[Index("PackagingLocation", Name = "IDX_ShipmentMatrix_PackagingLocation")]
public partial class ShipmentMatrix
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(50)]
    public string PickLocation { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PackagingLocation { get; set; }

    [StringLength(500)]
    public string ApiforPick { get; set; }

    [StringLength(500)]
    public string ApiforBox { get; set; }

    [StringLength(50)]
    public string SortingBinMin { get; set; }

    [StringLength(50)]
    public string SortingBinMax { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PickState { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? SoftDSPAllocation { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? DefaultPickLoaction { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? ReadyForArchive { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? Active { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(100)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [StringLength(100)]
    public string UpdatedBy { get; set; }
}
