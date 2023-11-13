using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("ShelvingMaster")]
[Index("ShelvingId", Name = "IDX_ShelvingMaster_ShelvingId")]
[Index("ShelvingCode", Name = "IX_ShelvingMaster")]
public partial class ShelvingMaster
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int ShelvingId { get; set; }

    [StringLength(45)]
    public string ShelvingCode { get; set; }

    [StringLength(45)]
    public string Areas { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(100)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [StringLength(100)]
    public string UpdatedBy { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? ReadyForArchive { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsActive { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PytechId { get; set; }

    [StringLength(100)]
    public string ArabicArea { get; set; }
}
