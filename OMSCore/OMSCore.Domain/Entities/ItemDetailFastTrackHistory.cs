using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("ItemDetailFastTrackHistory")]
[Index("IsFastTrack", Name = "ItemDetail_IsFastTrack_IDX")]
[Index("ItemNo", Name = "idx_ItemNo")]
public partial class ItemDetailFastTrackHistory
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
}
