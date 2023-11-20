using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("TicketLineLog")]
public partial class TicketLineLog
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

    [StringLength(1000)]
    public string Description { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? ReadyForArchive { get; set; }

    [StringLength(500)]
    public string ReturnReason { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InstanceOfDate { get; set; }

    [Column(TypeName = "int(11)")]
    public int VersionNo { get; set; }
}
