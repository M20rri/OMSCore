using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Index("BoxType", Name = "IDX_BoxPackingmaterialDetails_BoxType")]
[Index("InsertedBy", Name = "IDX_BoxPackingmaterialDetails_InsertedBy")]
[Index("InsertedOn", Name = "IDX_BoxPackingmaterialDetails_InsertedOn")]
public partial class BoxPackingmaterialDetail
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(50)]
    public string BoxId { get; set; }

    [StringLength(20)]
    public string AWBNo { get; set; }

    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [StringLength(50)]
    public string BoxType { get; set; }

    [StringLength(50)]
    public string ForwardDSPCode { get; set; }

    [StringLength(50)]
    public string FMDSPCode { get; set; }

    [StringLength(20)]
    public string FMAWBNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int? InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? ReadyForArchive { get; set; }
}
