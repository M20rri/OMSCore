using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Keyless]
[Table("TempFastTrackAllocatedOrder")]
public partial class TempFastTrackAllocatedOrder
{
    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ItemId { get; set; }

    [StringLength(20)]
    public string ItemNo { get; set; }

    [StringLength(50)]
    public string ReferenceOrderNo { get; set; }

    [StringLength(100)]
    public string BundleID { get; set; }

    [StringLength(100)]
    public string BundleSeqID { get; set; }

    [Column("NOW()", TypeName = "datetime")]
    public DateTime NOW__ { get; set; }
}
