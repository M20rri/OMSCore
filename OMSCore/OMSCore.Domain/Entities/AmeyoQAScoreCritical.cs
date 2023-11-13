using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OMSCore.Domain.Entities;

[Table("AmeyoQAScoreCritical")]
public partial class AmeyoQAScoreCritical
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int SRNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int? Id { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ScoreHeadId { get; set; }

    [Column(TypeName = "int(11)")]
    public int? SectionId { get; set; }

    [Column(TypeName = "int(11)")]
    public int? SectionSRNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int? SubSectionSRNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int? SubSectionId { get; set; }

    [Required]
    [StringLength(500)]
    public string NameEn { get; set; }

    [StringLength(500)]
    public string NameAr { get; set; }

    [StringLength(25)]
    public string HierarchyId { get; set; }

    [StringLength(20)]
    public string AchievedValue { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(500)]
    public string Comments { get; set; }
}
