using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Keyless]
[Table("ProcessLedgerDetail")]
[Index("ItemId", Name = "idx_ProcessLedgerDetail_ItemId")]
[Index("ProcessId", Name = "idx_ProcessLedgerDetail_ProcessId")]
[Index("WebOrderNo", Name = "idx_ProcessLedgerDetail_WebOrderNo")]
public partial class ProcessLedgerDetail
{
    [Column(TypeName = "int(11)")]
    public int? Id { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ProcessId { get; set; }

    [StringLength(50)]
    public string ProcessName { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ItemId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(100)]
    public string InsertedBy { get; set; }

    [StringLength(100)]
    public string Source { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? ProcessStatus { get; set; }

    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [StringLength(50)]
    public string ItemNo { get; set; }

    [StringLength(100)]
    public string Country { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsPrepaid { get; set; }

    [StringLength(15)]
    public string DSPCode { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsDefaultProcess { get; set; }

    [StringLength(100)]
    public string ProcessStatusMappingId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ProcessedOn { get; set; }

    [StringLength(100)]
    public string ProcessedBy { get; set; }
}
