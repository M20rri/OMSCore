using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

/// <summary>
/// 		
/// </summary>
[Table("TicketMaster")]
[Index("IsLMSSyncRequired", Name = "IXD_TicketMaster_IsLMSSyncRequired")]
[Index("Id", "Type", Name = "IX_TicketMaster")]
public partial class TicketMaster
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(100)]
    public string Type { get; set; }

    [Column(TypeName = "int(11)")]
    public int? Priority { get; set; }

    [Column(TypeName = "int(11)")]
    public int? DepartmentId { get; set; }

    [Column(TypeName = "int(11)")]
    public int? SubDepartmentId { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? SingleStep { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? Active { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? SelfAssigned { get; set; }

    [StringLength(45)]
    public string DefaultStatus { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsBulkUploaded { get; set; }

    public bool? RefundRequired { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsGeneral { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsDateRequired { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsAmountRequired { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsAssignable { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsImageUpload { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsPrintRequired { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsLMSSyncRequired { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsShotClose { get; set; }

    public bool? ApprovalRequired { get; set; }
}
