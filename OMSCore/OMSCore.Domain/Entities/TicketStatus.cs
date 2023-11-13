using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("TicketStatus")]
[Index("WebOrderId", "AWBNo", Name = "IX_TicketStatus")]
[Index("AWBNo", Name = "idx_TSawbNo")]
public partial class TicketStatus
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int ID { get; set; }

    [StringLength(50)]
    public string TicketId { get; set; }

    [StringLength(50)]
    public string WebOrderId { get; set; }

    [StringLength(20)]
    public string AWBNo { get; set; }

    [StringLength(50)]
    public string ItemID { get; set; }

    [StringLength(50)]
    public string Status { get; set; }

    [StringLength(50)]
    public string QCStatus { get; set; }

    [StringLength(50)]
    public string QCDoneBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? QCDateTime { get; set; }

    [StringLength(50)]
    public string DocumentNumber { get; set; }

    [StringLength(100)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [StringLength(100)]
    public string UpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }
}
