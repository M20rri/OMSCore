using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Keyless]
[Table("BoxHeader")]
[Index("AWBNo", "WebOrderNo", Name = "IDX_BoxHeader")]
[Index("PaymentMethod", "InsertedOn", Name = "IDX_BoxHeader2")]
[Index("BoxId", Name = "IDX_BoxHeaderBoxId")]
[Index("AWBNo", Name = "IDX_BoxHeader_AWBNo")]
[Index("InsertedOn", Name = "IDX_BoxHeader_InsertedOn")]
[Index("ManifestCreated", Name = "IDX_BoxHeader_ManifestCreated")]
[Index("WebOrderNo", Name = "IDX_BoxHeader_WebOrderNo")]
[Index("AWBNo", "ForwardDSPCode", "PackagingLocation", Name = "IDX_CancelOrdersData_AWBNoForwardDSPCodePackagingLocation")]
[Index("InsertedOn", "PaymentMethod", "ForwardDSPCode", Name = "IX_BoxHeader_3")]
[Index("InvoiceNo", Name = "IX_BoxHeader_InvoiceNo")]
[Index("ManifestNo", Name = "IX_BoxHeader_ManifestNo")]
[Index("ReferenceOrderNo", Name = "IX_BoxHeader_ReferenceOrderNo")]
public partial class BoxHeader
{
    [StringLength(50)]
    public string BoxId { get; set; }

    [StringLength(50)]
    public string ForwardDSPCode { get; set; }

    [StringLength(20)]
    public string AWBNo { get; set; }

    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [StringLength(50)]
    public string ReferenceOrderNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PackagingLocation { get; set; }

    [Precision(10, 2)]
    public decimal? PacketAmount { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? CheckServiceability { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? Cancel { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? AddressChange { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? ApplicableForManifest { get; set; }

    [Column(TypeName = "enum('Air','Surface','Mixed')")]
    public string ModeOfTransport { get; set; }

    [StringLength(50)]
    public string ManifestNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ManifestedDateTime { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? Hold { get; set; }

    [StringLength(500)]
    public string HoldReason { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? HoldDateTime { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? Return { get; set; }

    [StringLength(50)]
    public string ReturnManifestNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReturnManifestDateTime { get; set; }

    [StringLength(100)]
    public string HoldUserId { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? ManifestCreated { get; set; }

    [StringLength(50)]
    public string PaymentMethod { get; set; }

    [StringLength(50)]
    public string SecuritySealNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int? RetryCounter { get; set; }

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

    [StringLength(50)]
    public string InvoiceNo { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? ReAttemptFlag { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? Delivered { get; set; }

    [StringLength(500)]
    public string ShipmentURL { get; set; }

    [StringLength(255)]
    public string Company { get; set; }

    public bool Payment { get; set; }

    [StringLength(100)]
    public string Country { get; set; }

    [StringLength(100)]
    public string DSPAllocationType { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? ReAttemptCount { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsFragile { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsDanger { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsElectronic { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? BoxCount { get; set; }
}
