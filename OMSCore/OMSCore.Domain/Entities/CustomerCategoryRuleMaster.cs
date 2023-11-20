using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("CustomerCategoryRuleMaster")]
[Index("Category", "IsActive", Name = "IX_CustomerCategoryRuleMaster")]
[Index("IsActive", Name = "IX_CustomerCategoryRuleMaster_IsActive")]
public partial class CustomerCategoryRuleMaster
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(50)]
    public string Category { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndDate { get; set; }

    [Column(TypeName = "int(11)")]
    public int? SNo { get; set; }

    [StringLength(255)]
    public string Description { get; set; }

    [StringLength(50)]
    public string ConditionOption { get; set; }

    [Column(TypeName = "int(11)")]
    public int? Value { get; set; }

    [Column(TypeName = "enum('Less Than','Less Than Equal To','Greater Than','Greater Than Equal To','Equal To')")]
    public string ValueOption { get; set; }

    [Column(TypeName = "enum('NetValue','OrderCount','ReturnPercentage')")]
    public string ValueType { get; set; }

    [Column(TypeName = "enum('HOUR','DAY','MONTH','YEAR','LIFETIME')")]
    public string TimeSlot { get; set; }

    [Column(TypeName = "int(11)")]
    public int? TimeSlotValue { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsActive { get; set; }

    [Column(TypeName = "int(11)")]
    public int? InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [Column(TypeName = "int(11)")]
    public int? UpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }
}
