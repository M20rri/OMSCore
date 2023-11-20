using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("BoxStatus")]
[Index("IsDelivered", "IsDeliveredSync", "DeliveredRetryCount", Name = "BoxStatus_3")]
[Index("InsertedOn", Name = "BoxStatus_InsertedOn")]
[Index("AWBNo", Name = "IDX_BoxStatus")]
[Index("ForwardDSPCode", "IsShip", "IsDelivered", Name = "IDX_BoxStatus2")]
[Index("FMAWBNo", Name = "IDX_BoxStatus_FMAWBNo")]
[Index("InvoiceNo", Name = "IDX_BoxStatus_InvoiceNo")]
[Index("WebOrderNo", Name = "IDX_BoxStatus_WebOrderNo")]
[Index("BoxId", "WebOrderNo", Name = "INDEXBoxStatus_BoxIdOrderNo")]
[Index("IsBoxSync", "BoxRetryCount", "AWBNo", Name = "INDEXBoxStatus_IsBoxSyncboxRetryCountAWBNo")]
[Index("IsShip", "IsShipSync", Name = "INDEXBoxStatus_IsShipIsShipSync")]
[Index("ReferenceOrderNo", Name = "IX_BoxStatus_ReferenceOrderNo")]
[Index("IsDelivered", "IsNPSSync", "ReturnBeforeDelivery", Name = "idx_IsDelivered_IsNPSSync_ReturnBeforeDelivery")]
public partial class BoxStatus
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(50)]
    public string BoxId { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PackagingLocation { get; set; }

    public bool? IsCollectionInvoiceCreated { get; set; }

    [StringLength(50)]
    public string ForwardDSPCode { get; set; }

    [StringLength(20)]
    public string AWBNo { get; set; }

    [StringLength(50)]
    public string FMDSPCode { get; set; }

    [StringLength(20)]
    public string FMAWBNo { get; set; }

    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [StringLength(50)]
    public string ReferenceOrderNo { get; set; }

    [StringLength(50)]
    public string InvoiceNo { get; set; }

    public bool? IsBoxSync { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? BoxSyncDate { get; set; }

    [Column(TypeName = "int(11)")]
    public int? BoxRetryCount { get; set; }

    [StringLength(500)]
    public string BoxErrorMessage { get; set; }

    public bool? IsShip { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ShipDateTime { get; set; }

    public bool? IsShipSync { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ShipSyncDate { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ShipRetryCount { get; set; }

    [StringLength(500)]
    public string ShipErrorMessage { get; set; }

    public bool? IsReturned { get; set; }

    public bool? IsDelivered { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DeliveredDateTime { get; set; }

    public bool? IsDeliveredSync { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DeliveredSyncDate { get; set; }

    [Column(TypeName = "int(11)")]
    public int? DeliveredRetryCount { get; set; }

    [StringLength(500)]
    public string DeliveredErrorMessage { get; set; }

    public bool? IsPaymentCollected { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PaymentDateTime { get; set; }

    public bool? IsPaymentCollectedSync { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PaymentCollectedSyncDate { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PaymentRetryCount { get; set; }

    [StringLength(500)]
    public string PaymentErrorMessage { get; set; }

    public bool? IsNPSSync { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? NPSSyncDate { get; set; }

    [Column(TypeName = "int(11)")]
    public int? NPSRetryCount { get; set; }

    [StringLength(500)]
    public string NPSErrorMessage { get; set; }

    public bool? ReadyForArchive { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(50)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? ReturnBeforeDelivery { get; set; }

    public bool? IsUpdateAWB { get; set; }

    [StringLength(100)]
    public string AWBUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AWBUpdatedOn { get; set; }

    [StringLength(100)]
    public string SourceType { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ShipmentStatusSyncOn { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsInvAwsPacked { get; set; }

    [StringLength(100)]
    public string IsInvAwsPackedPath { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsInvAwsPackedRetry { get; set; }

    [StringLength(100)]
    public string IsInvAwsPackedError { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsInvAwsShipped { get; set; }

    [StringLength(100)]
    public string IsInvAwsShippedPath { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsInvAwsShippedRetry { get; set; }

    [StringLength(100)]
    public string IsInvAwsShippedError { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsInvAwsDelivered { get; set; }

    [StringLength(100)]
    public string IsInvAwsDeliveredPath { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsInvAwsDeliveredRetry { get; set; }

    [StringLength(100)]
    public string IsInvAwsDeliveredError { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsInvSyncDSP { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? IsInvSyncDSPDateTime { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsInvSyncDSPRetry { get; set; }

    [StringLength(100)]
    public string IsInvSyncDSPError { get; set; }
}
