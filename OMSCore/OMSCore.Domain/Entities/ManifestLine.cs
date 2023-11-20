using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("ManifestLine")]
[Index("AWBNo", Name = "IDX_AWBNo")]
[Index("BoxId", Name = "IDX_ManifestLine_BoxId")]
[Index("FMAWBNo", Name = "IDX_ManifestLine_FMAWBNo")]
[Index("ManifestNo", "AWBNo", "UserID", Name = "IDX_perf_ManiFestLine")]
public partial class ManifestLine
{
    [StringLength(50)]
    public string ManifestNo { get; set; }

    [Key]
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

    [StringLength(100)]
    public string UserID { get; set; }
}
