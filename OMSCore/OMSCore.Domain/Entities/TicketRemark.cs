using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Index("TicketId", Name = "IDX_TicketRemarks_TicketId")]
public partial class TicketRemark
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int ID { get; set; }

    [StringLength(20)]
    public string TicketId { get; set; }

    [StringLength(500)]
    public string Remarks { get; set; }

    [Column(TypeName = "int(11)")]
    public int InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime InsertedOn { get; set; }

    [Column(TypeName = "int(11)")]
    public int TicketSentToId { get; set; }
}
