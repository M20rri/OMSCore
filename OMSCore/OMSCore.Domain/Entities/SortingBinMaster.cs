using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[PrimaryKey("PackagingLocation", "BinCode")]
[Table("SortingBinMaster")]
[Index("BinCode", Name = "IDX_SortingBinMaster_BinCode")]
[Index("IsUsed", "IsHold", "PackagingLocation", "MinItem", "MaxItem", "SortingBinType", "Priority", "LastUsedDateTime", "BinCode", Name = "SortingBinMaster")]
[Index("IsUsed", "IsHold", "PackagingLocation", "MinItem", "MaxItem", "SortingBinType", "BinCode", Name = "SortingBinMaster_2")]
public partial class SortingBinMaster
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int PackagingLocation { get; set; }

    [Key]
    [StringLength(100)]
    public string BinCode { get; set; }

    [Column(TypeName = "int(11)")]
    public int? MinItem { get; set; }

    [Column(TypeName = "int(11)")]
    public int? MaxItem { get; set; }

    [Column(TypeName = "int(11)")]
    public int? IsUsed { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsHold { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte IsDeleted { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUsedDateTime { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? Priority { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? SortingBinType { get; set; }

    [StringLength(10)]
    public string ZoneCode { get; set; }
}
