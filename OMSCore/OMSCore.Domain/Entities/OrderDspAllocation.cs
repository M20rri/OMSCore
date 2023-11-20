using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("OrderDspAllocation")]
[Index("WebOrderNo", "IsAWBGenerated", Name = "IDX_OrderDspAllocation_WebOrderNo_IsAWBGenerated")]
[Index("WebOrderNo", "IsBoxPosted", Name = "IDX_OrderDspAllocation_WebOrderNo_IsBoxPosted")]
[Index("WebOrderNo", "IsReadyForAWBGeneration", Name = "IDX_OrderDspAllocation_WebOrderNo_IsReadyForAWBGeneration")]
[Index("WebOrderNo", "ProcessStatus", Name = "IDX_OrderDspAllocation_WebOrderNo_ProcessStatus")]
[Index("WebOrderNo", "PackagingLocation", Name = "UNQ_OrderDspAllocation_WebOrderNo_PackagingLocation", IsUnique = true)]
public partial class OrderDspAllocation
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PackagingLocation { get; set; }

    [StringLength(50)]
    public string DSPCode { get; set; }

    [StringLength(20)]
    public string AWBNo { get; set; }

    [StringLength(50)]
    public string FMDSPCode { get; set; }

    [StringLength(20)]
    public string FMAWBNo { get; set; }

    [StringLength(100)]
    public string ProcessStatus { get; set; }

    [Column(TypeName = "int(11)")]
    public int? DSPRetryCount { get; set; }

    [StringLength(500)]
    public string ErrorMessage { get; set; }

    [StringLength(500)]
    public string DSPErrorMessage { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsReadyForAWBGeneration { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsAWBGenerated { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsBoxPosted { get; set; }

    [StringLength(500)]
    public string ShipmentURL { get; set; }

    [Column(TypeName = "int(11)")]
    public int? AWBRetryCount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(100)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [StringLength(100)]
    public string UpdatedBy { get; set; }

    [StringLength(100)]
    public string Source { get; set; }
}
