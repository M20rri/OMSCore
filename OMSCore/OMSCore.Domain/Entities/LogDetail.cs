using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Index("InsertedOn", Name = "idx_LogDetails_InsertedOn")]
[Index("ProcName", Name = "idx_LogDetails_ProcName")]
[Index("UniqueId", Name = "idx_LogDetails_UniqueId")]
public partial class LogDetail
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(100)]
    public string ProcName { get; set; }

    [StringLength(100)]
    public string UniqueId { get; set; }

    [StringLength(100)]
    public string EntryType { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(20)]
    public string TimeStamp { get; set; }

    [StringLength(8000)]
    public string InputJson { get; set; }
}
