using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("StoreCreditRequestResponseLog")]
[Index("CustomerId", Name = "idx_StoreCreditRequestResponseLog_CustomerId")]
[Index("TicketId", Name = "idx_StoreCreditRequestResponseLog_TicketId")]
public partial class StoreCreditRequestResponseLog
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(30)]
    public string Type { get; set; }

    [StringLength(30)]
    public string CustomerId { get; set; }

    [StringLength(50)]
    public string TicketId { get; set; }

    [Precision(10, 3)]
    public decimal? BalanceAmount { get; set; }

    [StringLength(20)]
    public string NotifyCustomer { get; set; }

    [StringLength(20)]
    public string Store { get; set; }

    [StringLength(500)]
    public string Request { get; set; }

    [StringLength(500)]
    public string Response { get; set; }

    [StringLength(20)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsSync { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? RetryCounter { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SyncedOn { get; set; }

    [StringLength(500)]
    public string ErrorMessage { get; set; }
}
