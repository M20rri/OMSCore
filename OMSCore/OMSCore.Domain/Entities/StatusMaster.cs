using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("StatusMaster")]
[Index("ID", Name = "IDX_StatusMaster_ID")]
[Index("StatusName", Name = "IDX_StatusMaster_StatusName")]
[Index("IsAssignable", Name = "IX_StatusMaster_IsAssignable")]
public partial class StatusMaster
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int ID { get; set; }

    [StringLength(50)]
    public string StatusName { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? ReadyForArchive { get; set; }

    [StringLength(100)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(100)]
    public string UpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [Column(TypeName = "int(4)")]
    public int? IsCancelable { get; set; }

    [Column(TypeName = "int(4)")]
    public int? IsHoldable { get; set; }

    [Column(TypeName = "int(4)")]
    public int? IsAddressChange { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ProcessSequence { get; set; }

    [Column(TypeName = "int(11)")]
    public int? NextProcess { get; set; }

    public bool? ApplicableForRule { get; set; }

    [Column(TypeName = "int(4)")]
    public int? IsExchangeable { get; set; }

    [Column(TypeName = "int(4)")]
    public int? IsWaiverOffAble { get; set; }

    public bool? IsBulkStatusUpdate { get; set; }

    public bool? IsOrderEditable { get; set; }

    [Column(TypeName = "bit(1)")]
    public ulong? SMSRequired { get; set; }

    [Column(TypeName = "int(11)")]
    public int? IsReturnable { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? GWPAdded { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? CRM { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? OFS { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsAssignable { get; set; }

    [Column(TypeName = "int(11)")]
    public int? OrderStatusId { get; set; }

    [Column(TypeName = "bit(1)")]
    public ulong? IsCallable { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsCRMSchedule { get; set; }
}
