using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OMSCore.Domain.Entities;

[Table("AmeyoQAScoreSection")]
public partial class AmeyoQAScoreSection
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int SRNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int? Id { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ScoreHeadId { get; set; }

    [Required]
    [StringLength(500)]
    public string NameEn { get; set; }

    [StringLength(500)]
    public string NameAr { get; set; }

    [StringLength(50)]
    public string HierarchyId { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? TargetedPoint { get; set; }

    [Column(TypeName = "int(11)")]
    public int? AchievedPoint { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }
}
