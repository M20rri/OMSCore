using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("InboundMessage")]
public partial class InboundMessage
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int MessageId { get; set; }

    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ItemId { get; set; }

    [StringLength(500)]
    public string GiftMessage { get; set; }

    [StringLength(500)]
    public string SpecialQCMessage { get; set; }

    [StringLength(50)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? ReadyForArchive { get; set; }
}
