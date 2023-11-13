using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OMSCore.Domain.Entities;

[Table("CancelResponse")]
public partial class CancelResponse
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(100)]
    public string TicketId { get; set; }

    [Column("CancelResponse", TypeName = "json")]
    public string CancelResponse1 { get; set; }

    [Column(TypeName = "json")]
    public string Request { get; set; }

    [StringLength(100)]
    public string Type { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }
}
