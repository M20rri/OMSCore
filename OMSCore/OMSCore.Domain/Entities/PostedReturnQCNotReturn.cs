using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("PostedReturnQCNotReturn")]
public partial class PostedReturnQCNotReturn
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(50)]
    public string ItemNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ItemId { get; set; }

    [StringLength(50)]
    public string WebOrder { get; set; }

    [StringLength(50)]
    public string AWBNo { get; set; }

    [StringLength(50)]
    public string TicketNo { get; set; }

    [StringLength(50)]
    public string ForwardDSPCode { get; set; }

    [StringLength(50)]
    public string ReturnDSPCode { get; set; }

    [StringLength(50)]
    public string QCDocumentNo { get; set; }

    [StringLength(50)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReceivedDate { get; set; }

    [Column(TypeName = "int(11)")]
    public int? IsReceived { get; set; }

    [StringLength(50)]
    public string ReturnQCUser { get; set; }

    [Column(TypeName = "int(11)")]
    public int? IsClosedByFinance { get; set; }

    [Column(TypeName = "int(11)")]
    public int? FinanceUserId { get; set; }

    [StringLength(100)]
    public string CreditNoteNo { get; set; }
}
