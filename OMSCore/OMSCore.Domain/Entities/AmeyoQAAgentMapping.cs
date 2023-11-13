using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OMSCore.Domain.Entities;

[Table("AmeyoQAAgentMapping")]
public partial class AmeyoQAAgentMapping
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [Column(TypeName = "int(11)")]
    public int? TeamLeadId { get; set; }

    [Column(TypeName = "int(11)")]
    public int? AgentId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [Column(TypeName = "int(11)")]
    public int? UpdatedBy { get; set; }
}
