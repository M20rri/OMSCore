using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Index("RuleId", Name = "IX_RuleId")]
public partial class VipGiftSettingRuleSkuDetail
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [Column(TypeName = "int(11)")]
    public int? RuleId { get; set; }

    [StringLength(50)]
    public string SKUId { get; set; }

    [StringLength(50)]
    public string SKU { get; set; }

    [StringLength(255)]
    public string SKUName { get; set; }

    [Column(TypeName = "int(11)")]
    public int? SKUQuantity { get; set; }

    [StringLength(50)]
    public string SKUType { get; set; }

    [Column(TypeName = "int(11)")]
    public int? InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [Column(TypeName = "int(11)")]
    public int? UpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [Column(TypeName = "int(11)")]
    public int? SKUReservedQuantity { get; set; }

    [Column(TypeName = "int(11)")]
    public int? OrderQuantity { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ReleasedQuantity { get; set; }

    public bool? IsReleased { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReleasedDateTime { get; set; }

    [StringLength(255)]
    public string ReleaseMessage { get; set; }
}
