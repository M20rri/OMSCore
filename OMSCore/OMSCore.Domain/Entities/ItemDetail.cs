using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("ItemDetail")]
[Index("ItemNo", "IsFastTrack", Name = "IDX_ItemDetail")]
[Index("ImageUpdateRequired", Name = "IDX_ItemDetail_ImageUpdateRequired")]
[Index("Brand", Name = "ItemDetail_Brand_IDX")]
[Index("ImageUpdateRetryCount", Name = "idx_ItemDetail_ImageUpdateRetryCount")]
[Index("ItemNo", Name = "idx_ItemDetail_ItemNo")]
public partial class ItemDetail
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(20)]
    public string ItemNo { get; set; }

    [StringLength(250)]
    public string Description { get; set; }

    [StringLength(250)]
    public string Description2 { get; set; }

    [StringLength(250)]
    public string ItemCategoryCode { get; set; }

    [StringLength(250)]
    public string ProductGroupCode { get; set; }

    [StringLength(250)]
    public string Category3 { get; set; }

    [StringLength(250)]
    public string Category4 { get; set; }

    [StringLength(250)]
    public string Brand { get; set; }

    [StringLength(50)]
    public string MagentoSyncId { get; set; }

    [Column(TypeName = "int(11)")]
    public int InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [Column(TypeName = "int(11)")]
    public int? UpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [StringLength(300)]
    public string ImageUrl { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsDanger { get; set; }

    [StringLength(250)]
    public string ArabicDescription { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsFragile { get; set; }

    [Column(TypeName = "enum('Small','Medium','Large')")]
    public string SortingBinType { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsFastTrack { get; set; }

    [StringLength(50)]
    public string HSNCode { get; set; }

    [StringLength(100)]
    public string ShipmentDeclaration { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsElectronic { get; set; }

    [Column(TypeName = "blob")]
    public byte[] ImageBase64 { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? ImageUpdateRequired { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? ImageUpdateRetryCount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ImageUpdatedOn { get; set; }

    [Precision(10, 3)]
    public decimal? Length { get; set; }

    [Precision(10, 3)]
    public decimal? Width { get; set; }

    [Precision(10, 3)]
    public decimal? Height { get; set; }

    [Precision(10, 3)]
    public decimal? Weight { get; set; }
}
