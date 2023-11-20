using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("ItemSortingBinZoneMapping")]
[Index("ItemNo", Name = "IDX_ItemSortingBinZoneMapping_ItemNo")]
[Index("ZoneCode", Name = "IDX_ItemSortingBinZoneMapping_ZoneCode")]
[Index("PackagingLocation", "ItemNo", Name = "UNQ_ItemSortingBinZoneMapping_PackagingLocation_ItemNo", IsUnique = true)]
public partial class ItemSortingBinZoneMapping
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PackagingLocation { get; set; }

    [StringLength(20)]
    public string ItemNo { get; set; }

    [StringLength(10)]
    public string ZoneCode { get; set; }
}
