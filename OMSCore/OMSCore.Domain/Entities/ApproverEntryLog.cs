using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OMSCore.Domain.Entities;

[Table("ApproverEntryLog")]
public partial class ApproverEntryLog
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(255)]
    public string WebOrderNo { get; set; }

    [StringLength(255)]
    public string TicketId { get; set; }

    [StringLength(255)]
    public string Type { get; set; }

    [StringLength(255)]
    public string ApproverId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }
}
