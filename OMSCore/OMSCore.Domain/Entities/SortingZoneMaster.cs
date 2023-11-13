using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("SortingZoneMaster")]
[Index("PackagingLocation", "ZoneCode", Name = "unq_SortingZoneMaster_PackagingLocation_ZoneCode", IsUnique = true)]
public partial class SortingZoneMaster
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PackagingLocation { get; set; }

    [StringLength(20)]
    public string ZoneCode { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsActive { get; set; }
}
