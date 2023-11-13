using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("NumberSeriesMaster")]
[Index("NumberSeriesPrefix", Name = "unq_NumberSeriesMaster_NumberSeriesPrefix", IsUnique = true)]
public partial class NumberSeriesMaster
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(50)]
    public string EntryType { get; set; }

    [StringLength(50)]
    public string NumberSeriesPrefix { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FromDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ToDate { get; set; }

    [Column(TypeName = "int(20) unsigned")]
    public uint? LastNumberUsed { get; set; }

    [Column(TypeName = "int(20)")]
    public int? NextDayCount { get; set; }

    [StringLength(50)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? ReadyForArchive { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [StringLength(50)]
    public string UpdatedBy { get; set; }

    [Column(TypeName = "int(20)")]
    public int? RemainingCount { get; set; }

    [Column(TypeName = "int(8) unsigned zerofill")]
    public uint NumberSeriesStartingNumber { get; set; }
}
