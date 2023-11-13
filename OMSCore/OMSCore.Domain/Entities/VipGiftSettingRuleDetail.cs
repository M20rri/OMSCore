using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Index("CustomerCategory", "IsRuleRun", "GiftDate", "Active", "StartingRank", "EndingRank", Name = "IX_VipGiftSettingRuleDetails")]
public partial class VipGiftSettingRuleDetail
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [Column(TypeName = "int(11)")]
    public int? CustomerCategory { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? GiftDate { get; set; }

    [StringLength(50)]
    public string RuleType { get; set; }

    [Column(TypeName = "int(11)")]
    public int? StartingRank { get; set; }

    [Column(TypeName = "int(11)")]
    public int? EndingRank { get; set; }

    [Column(TypeName = "int(11)")]
    public int? SKUReservedQuantity { get; set; }

    public bool? Active { get; set; }

    [Column(TypeName = "int(11)")]
    public int? InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [Column(TypeName = "int(11)")]
    public int? UpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    public bool? IsRuleRun { get; set; }
}
