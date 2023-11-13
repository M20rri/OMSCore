using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("ReasonMaster")]
[Index("ReasonType", Name = "IDX_ReasonMaster_ReasonType")]
public partial class ReasonMaster
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(100)]
    public string Description { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsRepick { get; set; }

    [Column(TypeName = "int(11)")]
    public int? MaxRepickCount { get; set; }

    [StringLength(50)]
    public string ReasonType { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? SMSRequired { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? ReleaseRequired { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsActive { get; set; }

    [Precision(18, 3)]
    public decimal? CompensationValue { get; set; }

    [Precision(18, 3)]
    public decimal? CompensationValueSA { get; set; }
}
