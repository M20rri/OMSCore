using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("QcFailEntry")]
public partial class QcFailEntry
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [Column(TypeName = "bigint(20)")]
    public long? WebOrderNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ItemId { get; set; }

    [Column(TypeName = "int(11)")]
    public int? BatchId { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ItemNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ReasonCode { get; set; }

    [Column(TypeName = "int(11)")]
    public int? IsRepick { get; set; }

    [Column(TypeName = "int(11)")]
    public int? MaxRepickCount { get; set; }

    [StringLength(1000)]
    public string InsertedOn { get; set; }

    [StringLength(1000)]
    public string Lot { get; set; }

    [StringLength(1000)]
    public string PickLocation { get; set; }

    [Column(TypeName = "int(11)")]
    public int? Quantity { get; set; }
}
