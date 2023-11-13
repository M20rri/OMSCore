using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("TicketLine")]
[Index("ItemId", "TicketId", "TicketStatus", Name = "IX_TicketLine")]
[Index("TicketId", "WebOrderNo", Name = "IX_TicketLine_2")]
[Index("ItemId", Name = "IX_TicketLine_ItemId")]
[Index("TicketId", Name = "IX_TicketLine_TicketId")]
[Index("WebOrderNo", Name = "IX_TicketLine_WebOrderNo")]
public partial class TicketLine
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(50)]
    public string TicketId { get; set; }

    [Column(TypeName = "int(11)")]
    public int? TicketStatus { get; set; }

    [StringLength(45)]
    public string NewTicketId { get; set; }

    [Column(TypeName = "int(11)")]
    public int? NewTicketType { get; set; }

    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ItemId { get; set; }

    [StringLength(20)]
    public string ItemNo { get; set; }

    [StringLength(500)]
    public string Description { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? ReadyForArchive { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(50)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [StringLength(50)]
    public string UpdatedBy { get; set; }

    [StringLength(500)]
    public string ReturnReason { get; set; }
}
