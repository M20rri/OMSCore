using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Keyless]
[Table("ProcessLedgerDetailHeader")]
[Index("WebOrderNo", Name = "idx_ProcessLedgerDetailHeader_WebOrderNo")]
public partial class ProcessLedgerDetailHeader
{
    [Column(TypeName = "int(11)")]
    public int? Id { get; set; }

    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? ProcessStatus { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ProcessedOn { get; set; }

    [StringLength(100)]
    public string ProcessedBy { get; set; }
}
