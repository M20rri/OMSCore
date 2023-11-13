using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("FastTrackItemBinInventory")]
[Index("BinCode", Name = "IX_FastTrackItemBinInventory")]
[Index("ItemNo", "BinCode", Name = "idx_FastTrackItemBinInventory_ItemNo_BinCode", IsUnique = true)]
public partial class FastTrackItemBinInventory
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(20)]
    public string ItemNo { get; set; }

    [StringLength(50)]
    public string BinCode { get; set; }

    [Column(TypeName = "int(11)")]
    public int? Quantity { get; set; }

    [StringLength(50)]
    public string ZoneCode { get; set; }

    [StringLength(50)]
    public string LocationCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PickLocation { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PackagingLocation { get; set; }
}
