using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("DSPAPIMaster")]
[Index("DSPCode", "AWBType", "IsActive", "PackagingLocation", Name = "IDX_DSPAPIMaster")]
[Index("AWBType", "DSPCode", Name = "IX_DSPAPIMaster_AWBType_DSPCode")]
public partial class DSPAPIMaster
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int DSPMappingId { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PackagingLocation { get; set; }

    [Column(TypeName = "enum('Manual','API','PreLoaded')")]
    public string AWBType { get; set; }

    [StringLength(50)]
    public string DSPCode { get; set; }

    [StringLength(45)]
    public string DSPName { get; set; }

    [StringLength(200)]
    public string CODAPI { get; set; }

    [StringLength(200)]
    public string PrepaidAPI { get; set; }

    [StringLength(200)]
    public string ExchangeAPI { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte IsActive { get; set; }

    [StringLength(100)]
    public string APIUserName { get; set; }

    [StringLength(100)]
    public string APIPassword { get; set; }

    [StringLength(100)]
    public string AccountNo { get; set; }

    [StringLength(100)]
    public string AccountPin { get; set; }

    [StringLength(100)]
    public string AccountCountry { get; set; }

    [StringLength(100)]
    public string AccountEntity { get; set; }

    [StringLength(255)]
    public string TrackShipmentAPI { get; set; }

    [StringLength(255)]
    public string TrackShipmentURL { get; set; }
}
