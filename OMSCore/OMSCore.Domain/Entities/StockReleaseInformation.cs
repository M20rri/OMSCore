using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("StockReleaseInformation")]
[Index("SyncRequired", "DestinationSystem", Name = "IX_SyncRequired_DestinationSystem")]
[Index("BundleSeqId", Name = "idx_StockReleaseInformation_BundleSeqId")]
public partial class StockReleaseInformation
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ItemId { get; set; }

    [Column(TypeName = "enum('VIPGifting','GWP','FOC','Normal')")]
    public string ItemType { get; set; }

    [Column(TypeName = "enum('Simple','Bundle')")]
    public string SKUType { get; set; }

    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [StringLength(50)]
    public string AppOrderNo { get; set; }

    [StringLength(100)]
    public string BundleId { get; set; }

    [StringLength(100)]
    public string BundleSeqId { get; set; }

    [StringLength(50)]
    public string ItemNo { get; set; }

    [Column(TypeName = "enum('Cancel','Pick')")]
    public string Action { get; set; }

    [Column(TypeName = "enum('CRS','Magento')")]
    public string DestinationSystem { get; set; }

    public bool? IsSync { get; set; }

    public bool? SyncRequired { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SyncDateTime { get; set; }

    [Column(TypeName = "int(11)")]
    public int? RetryCount { get; set; }

    [StringLength(1000)]
    public string ErrorMessage { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }
}
