using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Keyless]
[Table("BoxHeaderTemp")]
[Index("BoxID", Name = "IDX_BoxHeaderTemp_BoxID")]
[Index("UserId", Name = "IDX_BoxHeaderTemp_UserId")]
[Index("UserId", "PackagingLocation", Name = "UNQ_BoxHeaderTemp_UserId_PackagingLocation", IsUnique = true)]
public partial class BoxHeaderTemp
{
    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [StringLength(20)]
    public string ItemNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    public bool? IsSurface { get; set; }

    [StringLength(50)]
    public string BoxID { get; set; }

    [StringLength(50)]
    public string SKU { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PackagingLocation { get; set; }

    [Column(TypeName = "int(11)")]
    public int? UserId { get; set; }

    public bool? IsFragile { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsDanger { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsElectronic { get; set; }

    [Column(TypeName = "enum('NORMAL','EXPRESS','SURFACE','EXCHANGE','PRIORITY','SPECIALDELIVERY','GIFT','GiftCard','PREORDER','VAS')")]
    public string OrderType { get; set; }

    [StringLength(45)]
    public string ReferanceOrderNo { get; set; }

    [StringLength(45)]
    public string Company { get; set; }

    public bool? IsBoxLimitOver { get; set; }

    [Column(TypeName = "int(11)")]
    public int? TableId { get; set; }
}
