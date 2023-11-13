using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Keyless]
[Table("OrderDetailReco_20230504")]
[Index("ItemIDOD", Name = "idx_OrderDetailReco_20230504_ItemId")]
public partial class OrderDetailReco_20230504
{
    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ItemIDOD { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ItemIdISL { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ITemIdPD { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ItemIdPP { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ItemIdBL { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }
}
