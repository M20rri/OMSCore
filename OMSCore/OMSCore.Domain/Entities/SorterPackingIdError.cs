using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("SorterPackingIdError")]
public partial class SorterPackingIdError
{
    [StringLength(50)]
    public string ManifestNumber { get; set; }

    [Key]
    [StringLength(20)]
    public string AWBNo { get; set; }

    [StringLength(30)]
    public string SealNo { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? Scaned { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DocumentDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PacketScanedDate { get; set; }

    [StringLength(100)]
    public string UserID { get; set; }

    [StringLength(100)]
    public string ErrorDetails { get; set; }
}
