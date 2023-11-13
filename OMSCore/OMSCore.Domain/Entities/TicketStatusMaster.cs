using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("TicketStatusMaster")]
[Index("Id", "Active", "Name", Name = "IDX_TicketStatusMaster")]
public partial class TicketStatusMaster
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(45)]
    public string Name { get; set; }

    [Column(TypeName = "int(11)")]
    public int? Active { get; set; }

    public bool? IsCommentsMandatory { get; set; }

    public bool? IsDepartmentMandatory { get; set; }

    public bool? IsSubDepartmentMandatory { get; set; }

    public bool? IsUserMandatory { get; set; }

    public bool? IsByPassQC { get; set; }

    public bool? TriggerRefundValidation { get; set; }

    [Column(TypeName = "int(11)")]
    public int? IsRescheduleDateMandatory { get; set; }
}
