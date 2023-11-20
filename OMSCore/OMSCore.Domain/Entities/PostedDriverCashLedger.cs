using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("PostedDriverCashLedger")]
[Index("AWBNo", Name = "IDX_PostedDriverCashLedger_AWBNo")]
[Index("GatewayID", Name = "IDX_PostedDriverCashLedger_GatewayID")]
[Index("CashierDocumentNo", Name = "IX_PostedDriverCashLedger_CashierDocumentNo")]
[Index("InsertedBy", "InsertedOn", "BankHandover", "GatewayID", "DeviceId", Name = "Ix_PostedDriverCashLedger")]
[Index("AWBNo", "GatewayID", Name = "idx_PostedDriverCashLedger_AWBNo_GatewayID")]
public partial class PostedDriverCashLedger
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(100)]
    public string CashierDocumentNo { get; set; }

    [StringLength(255)]
    public string DriverID { get; set; }

    [StringLength(20)]
    public string AWBNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int? GatewayID { get; set; }

    [StringLength(100)]
    public string OrderPaymentMethod { get; set; }

    [Precision(8, 2)]
    public decimal? PaidAmount { get; set; }

    [StringLength(255)]
    public string TransactionID { get; set; }

    [StringLength(255)]
    public string AutorizeNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime InsertedOn { get; set; }

    [Column(TypeName = "int(11)")]
    public int? InsertedBy { get; set; }

    [StringLength(500)]
    public string TransactionURL { get; set; }

    [StringLength(300)]
    public string TransactionFileName { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ShelvingLedgerId { get; set; }

    [StringLength(255)]
    public string Status { get; set; }

    [StringLength(255)]
    public string ShelvingId { get; set; }

    public bool? BankHandover { get; set; }

    public bool? IsSync { get; set; }

    [Column(TypeName = "int(11)")]
    public int? DeviceId { get; set; }
}
