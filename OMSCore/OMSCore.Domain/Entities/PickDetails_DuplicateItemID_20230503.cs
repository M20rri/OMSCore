using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Keyless]
[Table("PickDetails_DuplicateItemID_20230503")]
public partial class PickDetails_DuplicateItemID_20230503
{
    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int ItemId { get; set; }

    [Column(TypeName = "int(11)")]
    public int BatchId { get; set; }

    [StringLength(50)]
    public string ItemNo { get; set; }

    [StringLength(100)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [StringLength(100)]
    public string UpdatedBy { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PackagingLocation { get; set; }

    [StringLength(1000)]
    public string BinCode { get; set; }

    [Column(TypeName = "int(11)")]
    public int? OrderAllocationUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? OrderAllocationDate { get; set; }

    [StringLength(20)]
    public string Lot { get; set; }

    [StringLength(20)]
    public string SerialNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int? IsSurface { get; set; }

    [StringLength(50)]
    public string ReferenceOrderNo { get; set; }

    [Column(TypeName = "enum('NORMAL','EXPRESS','SURFACE','EXCHANGE','PRIORITY','SPECIALDELIVERY','GIFT','GiftCard','PREORDER','VAS')")]
    public string OrderType { get; set; }

    [StringLength(1000)]
    public string PickLocation { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? ReadyForArchive { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [Column(TypeName = "int(11)")]
    public int? SortingSequenceNo { get; set; }

    [StringLength(100)]
    public string VendorItemCode { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsPrinted { get; set; }

    [StringLength(100)]
    public string BarCode { get; set; }

    [StringLength(250)]
    public string ErrorMessage { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? Sync { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SyncDateTime { get; set; }

    [Column(TypeName = "int(11)")]
    public int? RetryCount { get; set; }

    [StringLength(50)]
    public string PickBin { get; set; }

    [StringLength(50)]
    public string PickZone { get; set; }

    [StringLength(50)]
    public string PickUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PickTime { get; set; }
}
