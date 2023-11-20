using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("InboundOrderApiLog")]
[Index("Processed", Name = "IDX_InboundOrderApiLog_Processed")]
[Index("AppOrderNo", Name = "IX_InboundOrderApiLog_AppOrderNo")]
[Index("WebOrderNo", Name = "IX_InboundOrderApiLog_WebOrderNo")]
public partial class InboundOrderApiLog
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [Column(TypeName = "json")]
    public string OrderJson { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? Processed { get; set; }

    [Column(TypeName = "int(11)")]
    public int? RetryCount { get; set; }

    [StringLength(500)]
    public string ErrorMessage { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? ReadyForArchive { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(30)]
    public string TimeStamp { get; set; }

    [StringLength(100)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [StringLength(100)]
    public string UpdatedBy { get; set; }

    [StringLength(100)]
    public string WebOrderNo { get; set; }

    [StringLength(50)]
    public string AppOrderNo { get; set; }
}
