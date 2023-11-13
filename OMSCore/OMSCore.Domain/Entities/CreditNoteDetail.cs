using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[PrimaryKey("Id", "TicketId")]
public partial class CreditNoteDetail
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [Key]
    [StringLength(100)]
    public string TicketId { get; set; }

    [Column(TypeName = "int(11)")]
    public int ItemId { get; set; }

    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [StringLength(20)]
    public string AWBNo { get; set; }

    [StringLength(50)]
    public string ForwardDSPCode { get; set; }

    [StringLength(100)]
    public string PNRReasonCode { get; set; }

    [StringLength(20)]
    public string CNNumber { get; set; }

    public DateOnly? CNReceivingDate { get; set; }

    [StringLength(100)]
    public string CNReceivedBy { get; set; }

    public DateOnly? InsertedOn { get; set; }

    [StringLength(100)]
    public string InsertedBy { get; set; }
}
