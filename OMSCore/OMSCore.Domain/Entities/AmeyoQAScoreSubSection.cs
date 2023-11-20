using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

[Table("AmeyoQAScoreSubSection")]
public partial class AmeyoQAScoreSubSection
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int SRNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int? Id { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ScoreHeadId { get; set; }

    [Column(TypeName = "int(11)")]
    public int? SectionSrNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int? SectionId { get; set; }

    [Required]
    [StringLength(500)]
    public string NameEn { get; set; }

    [StringLength(500)]
    public string NameAr { get; set; }

    [StringLength(50)]
    public string HierarchyId { get; set; }

    [Column(TypeName = "int(11)")]
    public int? Points { get; set; }

    [Column(TypeName = "int(11)")]
    public int? AchievedPoint { get; set; }

    [StringLength(10)]
    public string AchievedValue { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsCritical { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(100)]
    public string Comments { get; set; }
}
