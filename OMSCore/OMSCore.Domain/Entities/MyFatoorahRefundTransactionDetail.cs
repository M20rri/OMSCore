using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Index("WebOrderNo", "TicketId", Name = "IX_MyFRT_WebOrdTicket")]
public partial class MyFatoorahRefundTransactionDetail
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [StringLength(50)]
    public string ReferenceOrderNo { get; set; }

    [Required]
    [StringLength(50)]
    public string TicketId { get; set; }

    [Precision(10, 3)]
    public decimal RefundAmountFCY { get; set; }

    [Precision(10, 3)]
    public decimal? RefundAmountLCY { get; set; }

    [Precision(25, 20)]
    public decimal? CurrencyFactor { get; set; }

    [StringLength(50)]
    public string TransactionNo { get; set; }

    public bool? IsSuccess { get; set; }

    [StringLength(50)]
    public string RefundStatus { get; set; }

    [StringLength(255)]
    public string Message { get; set; }

    [StringLength(255)]
    public string ValidationErrors { get; set; }

    [StringLength(50)]
    public string RefundReference { get; set; }

    [Precision(10, 3)]
    public decimal RefundedAmount { get; set; }

    [StringLength(255)]
    public string Comment { get; set; }

    [StringLength(50)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }
}
