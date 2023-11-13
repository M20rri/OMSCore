using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("ReturnTicket")]
[Index("TicketID", "ReturnDSPCode", Name = "IDX_ReturnTicket")]
[Index("RAWBNo", "AWBNo", "WebOrderNo", "ItemID", Name = "IDX_ReturnTicket_3")]
[Index("ItemID", Name = "IDX_ReturnTicket_ItemID")]
[Index("ReceivedAtRPC", "TicketStatus", "InsertedOn", Name = "IDX_ReturnTicket_ReceivedAtRPC_TicketStatus_InsertedOn")]
[Index("TicketID", Name = "IDX_ReturnTicket_TicketID")]
[Index("AWBNo", "WebOrderNo", Name = "IX_ReturnTicket_AWBNO")]
public partial class ReturnTicket
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(50)]
    public string TicketID { get; set; }

    [Column(TypeName = "int(11)")]
    public int ItemID { get; set; }

    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [StringLength(20)]
    public string AWBNo { get; set; }

    [StringLength(50)]
    public string ForwardDSPCode { get; set; }

    [StringLength(50)]
    public string RAWBNo { get; set; }

    [StringLength(50)]
    public string ReturnDSPCode { get; set; }

    [StringLength(50)]
    public string ReturnType { get; set; }

    [StringLength(500)]
    public string ReturnReasonPrimary { get; set; }

    [StringLength(500)]
    public string SecondaryReturnReason { get; set; }

    [StringLength(1000)]
    public string AgentComment { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? ReceivedAtRPC { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpectedReceivedDate { get; set; }

    [StringLength(100)]
    public string RPCLocation { get; set; }

    [StringLength(100)]
    public string ReturnReasonCode { get; set; }

    [StringLength(50)]
    public string QCPriority { get; set; }

    [StringLength(50)]
    public string TicketStatus { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? ReadyForArchive { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(100)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [StringLength(100)]
    public string UpdatedBy { get; set; }

    [StringLength(20)]
    public string ItemNo { get; set; }
}
