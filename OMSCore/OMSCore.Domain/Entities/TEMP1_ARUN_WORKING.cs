using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Keyless]
[Table("TEMP1_ARUN_WORKING")]
public partial class TEMP1_ARUN_WORKING
{
    [StringLength(50)]
    public string OriginalOrderNo { get; set; }

    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [StringLength(50)]
    public string ItemNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int? IsFound { get; set; }

    [Column(TypeName = "int(11)")]
    public int? IsPickSync { get; set; }

    [StringLength(50)]
    public string PickSyncError { get; set; }

    [Column(TypeName = "int(11)")]
    public int? IsCancelSync { get; set; }

    [StringLength(50)]
    public string CancelSyncError { get; set; }
}
