using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OMSCore.Domain.Entities;

[Table("CashierToCashierHandoverLedger")]
public partial class CashierToCashierHandoverLedger
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(100)]
    public string DocumentNo { get; set; }

    [StringLength(100)]
    public string AssignedUser { get; set; }

    [StringLength(100)]
    public string AssignedByUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    public bool? ReadyForArchive { get; set; }
}
