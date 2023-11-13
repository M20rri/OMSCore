using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Keyless]
[Table("PNADetailLedger")]
[Index("ItemID", Name = "IDX_ItemId")]
[Index("ReferenceOrderNo", Name = "IDX_ReferenceOrderNo")]
public partial class PNADetailLedger
{
    [Column(TypeName = "bigint(20)")]
    public long? EntryNo { get; set; }

    [Column(TypeName = "bigint(20)")]
    public long? SyncId { get; set; }

    [Column(TypeName = "bigint(20)")]
    public long? ItemID { get; set; }

    [StringLength(255)]
    public string UserID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(250)]
    public string PNADateTime { get; set; }

    [StringLength(50)]
    public string ItemNo { get; set; }

    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [StringLength(50)]
    public string ReferenceOrderNo { get; set; }

    [Column(TypeName = "int(5)")]
    public int? BatchID { get; set; }

    public bool? SyncToWMS { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SyncDateTime { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? ReTryCount { get; set; }

    [StringLength(255)]
    public string ErrorMsg { get; set; }

    [StringLength(255)]
    public string Count { get; set; }
}
