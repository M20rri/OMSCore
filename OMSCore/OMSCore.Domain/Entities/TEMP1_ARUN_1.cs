using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Keyless]
[Table("TEMP1_ARUN_1")]
[Index("IsMatching", Name = "IDX_TEMP1_ARUN_IsMatching")]
[Index("WebOrderNo", Name = "IDX_TEMP1_ARUN_WEBNO")]
[Index("ItemNo", Name = "IDX_TEMP1_ARUN_itemNO")]
public partial class TEMP1_ARUN_1
{
    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [StringLength(50)]
    public string ItemNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int? IsMatching { get; set; }
}
