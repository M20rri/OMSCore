using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("DriverCashTemp")]
[Index("CashierDocumentNo", "Status", "DriverID", Name = "IDX_DriverCashTemp")]
[Index("DriverID", Name = "IDX_DriverCashTemp_DriverID")]
[Index("Status", Name = "IDX_DriverCashTemp_Status")]
public partial class DriverCashTemp
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int ID { get; set; }

    [StringLength(100)]
    public string CashierDocumentNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int? DriverID { get; set; }

    [StringLength(20)]
    public string AWBNo { get; set; }

    [StringLength(255)]
    public string OrderPaymentMethod { get; set; }

    [Column(TypeName = "int(11)")]
    public int? GatewayId { get; set; }

    [Precision(10, 3)]
    public decimal? PaidAmount { get; set; }

    [StringLength(255)]
    public string TransactionID { get; set; }

    [StringLength(255)]
    public string AuthorizeNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(255)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [StringLength(255)]
    public string UpdatedBy { get; set; }

    [StringLength(500)]
    public string TransactionURL { get; set; }

    [StringLength(500)]
    public string TransactionFileName { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ShelvingLedgerId { get; set; }

    public string Status { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ShelvingId { get; set; }

    [Column(TypeName = "int(11)")]
    public int? DeviceId { get; set; }

    [StringLength(50)]
    public string RunSheetNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PytechDriverId { get; set; }
}
