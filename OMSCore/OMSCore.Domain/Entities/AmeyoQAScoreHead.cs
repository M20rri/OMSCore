using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OMSCore.Domain.Entities;

[Table("AmeyoQAScoreHead")]
public partial class AmeyoQAScoreHead
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(50)]
    public string ReferenceId { get; set; }

    [StringLength(50)]
    public string CSAgentId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DOI { get; set; }

    [StringLength(50)]
    public string InteractionType { get; set; }

    [StringLength(50)]
    public string PhoneNo { get; set; }

    [StringLength(10)]
    public string CallDuration { get; set; }

    [Column(TypeName = "int(11)")]
    public int? TotalScore { get; set; }

    [Column(TypeName = "int(11)")]
    public int? TargetedPoint { get; set; }

    [Column(TypeName = "int(11)")]
    public int? InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(100)]
    public string EvaluationType { get; set; }

    [StringLength(100)]
    public string TicketType { get; set; }
}
