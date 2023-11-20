using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("DriverDeliveryStage")]
[Index("AWB", "GatewayID", Name = "IDX_DriverDeliveryStage_AWB_GatewayID")]
public partial class DriverDeliveryStage
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    public string AWB { get; set; }

    [StringLength(255)]
    public string DriverID { get; set; }

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

    [StringLength(255)]
    public string InsertedBy { get; set; }

    public bool IsTallied { get; set; }

    [StringLength(500)]
    public string TransactionURL { get; set; }

    public bool IsDelivered { get; set; }

    [StringLength(255)]
    public string CashierDocumentNo { get; set; }

    [StringLength(255)]
    public string Status { get; set; }

    [StringLength(50)]
    public string RunSheetNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PytechDriverId { get; set; }

    [Column(TypeName = "int(11)")]
    public int? DeviceId { get; set; }

    [StringLength(50)]
    public string DeliveredDateTime { get; set; }

    [Column(TypeName = "int(11)")]
    public int? LMSRecordId { get; set; }
}
