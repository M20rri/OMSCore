using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("PostedManifestLine")]
[Index("AWBNo", Name = "IDX_PostedManifestLine_AWBNo")]
[Index("BoxId", Name = "IDX_PostedManifestLine_BoxId")]
[Index("FMAWBNo", Name = "IDX_PostedManifestLine_FMAWBNo")]
[Index("ManifestNo", Name = "IDX_PostedManifestLine_ManifestNo")]
[Index("Issync_PYtech", "PyTechSyncRetryCount", Name = "IDX_PostedManifestLine_ManifestNo_issync_PYtech_PytechRetryCount")]
public partial class PostedManifestLine
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int ID { get; set; }

    [StringLength(50)]
    public string ManifestNo { get; set; }

    [StringLength(20)]
    public string AWBNo { get; set; }

    [StringLength(20)]
    public string FMAWBNo { get; set; }

    [StringLength(30)]
    public string SealNo { get; set; }

    [StringLength(50)]
    public string BoxId { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? Scaned { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DocumentDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PacketScanedDate { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? ReadyForArchive { get; set; }

    [StringLength(100)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [StringLength(100)]
    public string UpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? Integrated { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? IntegratedOn { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? Issync_PYtech { get; set; }

    [StringLength(100)]
    public string ErrorMessage_PYTech { get; set; }

    [Column(TypeName = "enum('DSP','RETURN')")]
    public string HandoverStatus { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? ArchiveNo { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? ReScan { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PyTechSyncRetryCount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PyTechSyncOn { get; set; }
}
