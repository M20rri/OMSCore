using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Keyless]
[Table("ProcessLedger_WebOrderNo_ItemId")]
[Index("ItemId", Name = "idx_ProcessLedger_WebOrderNo_ItemId_ItemId")]
[Index("WebOrderNo", Name = "idx_ProcessLedger_WebOrderNo_ItemId_WebOrderNo")]
public partial class ProcessLedger_WebOrderNo_ItemId
{
    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ItemId { get; set; }
}
