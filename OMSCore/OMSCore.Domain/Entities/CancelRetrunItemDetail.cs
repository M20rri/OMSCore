using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Index("ItemId", Name = "IX_CancelRetrunItemDetails")]
public partial class CancelRetrunItemDetail
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [Column(TypeName = "int(11)")]
    public int? BatchId { get; set; }

    [StringLength(255)]
    public string WebOrderNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ItemId { get; set; }

    [StringLength(20)]
    public string ItemNo { get; set; }

    [StringLength(500)]
    public string Description { get; set; }

    [StringLength(255)]
    public string PickBin { get; set; }

    [StringLength(255)]
    public string PickZone { get; set; }

    [StringLength(255)]
    public string Barcode { get; set; }

    [StringLength(500)]
    public string ImgURL { get; set; }

    [StringLength(255)]
    public string DeviceId { get; set; }

    public DateOnly? OrdereCreatedDate { get; set; }

    public DateOnly? CancelledDate { get; set; }

    public DateOnly? ReturnDate { get; set; }

    [Column(TypeName = "int(11)")]
    public int? QTY { get; set; }

    [StringLength(255)]
    public string PickFrom { get; set; }

    public DateOnly? PickedDate { get; set; }

    [Column(TypeName = "int(11)")]
    public int? IsSync { get; set; }

    [Column(TypeName = "int(11)")]
    public int? RetryCounter { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [Column(TypeName = "int(11)")]
    public int? InsertedBy { get; set; }

    [Column(TypeName = "int(11)")]
    public int? UpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [StringLength(50)]
    public string DocumentNo { get; set; }

    [StringLength(50)]
    public string WarehouseNo { get; set; }

    [StringLength(255)]
    public string PutBin { get; set; }

    [StringLength(100)]
    public string PickedFromDate { get; set; }

    [StringLength(100)]
    public string PutawayDate { get; set; }

    [StringLength(100)]
    public string PickedBy { get; set; }

    [StringLength(100)]
    public string PutawayBy { get; set; }

    [Column(TypeName = "enum('Cancel','Return')")]
    public string SourceType { get; set; }
}
