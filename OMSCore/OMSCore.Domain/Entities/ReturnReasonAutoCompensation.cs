using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("ReturnReasonAutoCompensation")]
[Index("TicketType", "Reason", "PaymentMethodCode", "AutoCompensate", Name = "IDX_ReturnReasonAutoCompensation")]
public partial class ReturnReasonAutoCompensation
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(100)]
    public string Reason { get; set; }

    [StringLength(50)]
    public string PaymentMethodCode { get; set; }

    [StringLength(100)]
    public string TicketType { get; set; }

    public bool? AutoCompensate { get; set; }

    [Column(TypeName = "int(11)")]
    public int? CompensationReasonId { get; set; }

    public bool? ReadyForArchive { get; set; }

    [StringLength(255)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdateOn { get; set; }

    [StringLength(255)]
    public string UpdatedBy { get; set; }
}
