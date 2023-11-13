using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("ItemLotInfo")]
[Index("ItemNo", "LotNo", Name = "IDX_ItemLotInfo_ItemNo_LotNo")]
public partial class ItemLotInfo
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(20)]
    public string ItemNo { get; set; }

    [StringLength(250)]
    public string Description { get; set; }

    [StringLength(100)]
    public string TrackingType { get; set; }

    [StringLength(100)]
    public string EanBarcode { get; set; }

    [StringLength(100)]
    public string UOM { get; set; }

    [StringLength(100)]
    public string SerialNo { get; set; }

    [StringLength(100)]
    public string LotNo { get; set; }

    [StringLength(100)]
    public string Barcode { get; set; }

    [StringLength(100)]
    public string QualityStatus { get; set; }

    public DateOnly? ExpiryDate { get; set; }

    [StringLength(100)]
    public string PurchaseContractType { get; set; }

    public DateOnly? CreatedDate { get; set; }

    [StringLength(100)]
    public string InventoryType { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(20)]
    public string InsertedBy { get; set; }
}
