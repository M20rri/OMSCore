using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("TableMaster")]
[Index("Id", "IsFastTrack", Name = "IX_TableMaster")]
[Index("IsFastTrack", Name = "IX_TableMaster_IsFastTrack")]
public partial class TableMaster
{
    [StringLength(50)]
    public string Description { get; set; }

    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PackagingLocation { get; set; }

    [StringLength(100)]
    public string InvoicePrinter { get; set; }

    [StringLength(100)]
    public string ShipmentLabelPrinter { get; set; }

    [StringLength(45)]
    public string PackagingNo { get; set; }

    [Column(TypeName = "enum('Forward','Return')")]
    public string Process { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsFastTrack { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? FastTrackLimit { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? Priority { get; set; }
}
