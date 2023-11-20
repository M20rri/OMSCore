using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("NumberSeriesEntry")]
[Index("EntryType", "Used", Name = "IDX_NumberSeriesEntry")]
[Index("SeriesCode", Name = "IDX_NumberSeriesEntry_SeriesCode")]
[Index("Used", "NumberSeriesMasterId", Name = "IDX_NumberSeriesEntry_Used_NumberSeriesMasterId")]
public partial class NumberSeriesEntry
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [Column(TypeName = "int(11)")]
    public int? NumberSeriesMasterId { get; set; }

    [StringLength(50)]
    public string EntryType { get; set; }

    [StringLength(50)]
    public string SeriesCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FromDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ToDate { get; set; }

    [Column(TypeName = "int(8) unsigned zerofill")]
    public uint? LastNumberUsed { get; set; }

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

    [Column(TypeName = "tinyint(2)")]
    public sbyte? Used { get; set; }
}
