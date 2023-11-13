using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("WaiverOff")]
public partial class WaiverOff
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(45)]
    public string TicketId { get; set; }

    [StringLength(45)]
    public string WebOrderNo { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? ShipmentCharges { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? CODCharges { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? GiftCharges { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? CustomDuty { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(100)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [StringLength(100)]
    public string UpdatedBy { get; set; }
}
