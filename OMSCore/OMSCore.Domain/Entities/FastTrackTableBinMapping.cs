using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("FastTrackTableBinMapping")]
[Index("BinCode", Name = "unq_FastTrackTableBinMapping_BinCode", IsUnique = true)]
[Index("TableId", Name = "unq_FastTrackTableBinMapping_TableId", IsUnique = true)]
public partial class FastTrackTableBinMapping
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [Column(TypeName = "int(11)")]
    public int? TableId { get; set; }

    [StringLength(50)]
    public string BinCode { get; set; }

    [StringLength(50)]
    public string ZoneCode { get; set; }

    [StringLength(50)]
    public string LocationCode { get; set; }

    [Column(TypeName = "int(11)")]
    public int? InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [Column(TypeName = "int(11)")]
    public int? UpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PickLocation { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PackagingLocation { get; set; }
}
