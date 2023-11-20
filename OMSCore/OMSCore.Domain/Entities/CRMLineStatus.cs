using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("CRMLineStatus")]
[Index("ItemId", Name = "IDX_CRMLineStatus_ItemId", IsUnique = true)]
[Index("WebOrderNo", Name = "IDX_CRMLineStatus_WebOrderNo")]
[Index("WebOrderNo", "ItemId", "StatusId", Name = "IDX_CRMLineStatus_WebOrderNo_ItemId_StatusId")]
public partial class CRMLineStatus
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ItemId { get; set; }

    [StringLength(20)]
    public string ItemNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int? StatusId { get; set; }

    [StringLength(100)]
    public string StatusName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(150)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [StringLength(150)]
    public string UpdatedBy { get; set; }

    [StringLength(500)]
    public string Source { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PackagingLocation { get; set; }
}
