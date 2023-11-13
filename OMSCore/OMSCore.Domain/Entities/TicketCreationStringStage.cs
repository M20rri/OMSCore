using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("TicketCreationStringStage")]
[Index("SLT_Id", "Id", "AWBNo", Name = "IX_TicketCreationStringStage")]
public partial class TicketCreationStringStage
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [Column(TypeName = "int(11)")]
    public int? SLT_Id { get; set; }

    [Column(TypeName = "int(11)")]
    public int? BoxShelvingMappingId { get; set; }

    [Column(TypeName = "json")]
    public string TicketString { get; set; }

    [StringLength(20)]
    public string AWBNo { get; set; }

    [StringLength(20)]
    public string WebOrderNo { get; set; }

    [StringLength(50)]
    public string TicketId { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsProcessed { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [Column(TypeName = "int(11)")]
    public int? InsertedBy { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PytechRecordId { get; set; }

    [StringLength(50)]
    public string Ticket_ID { get; set; }
}
