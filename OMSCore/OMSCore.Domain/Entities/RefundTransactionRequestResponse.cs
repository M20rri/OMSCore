using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("RefundTransactionRequestResponse")]
[Index("WebOrderNo", "TicketId", Name = "IX_RefundTransactionRequestResponse_WebOrdTicket")]
public partial class RefundTransactionRequestResponse
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [Required]
    [StringLength(50)]
    public string TicketId { get; set; }

    [StringLength(8000)]
    public string RequestJSON { get; set; }

    [StringLength(8000)]
    public string ResponseJSON { get; set; }

    [StringLength(50)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }
}
