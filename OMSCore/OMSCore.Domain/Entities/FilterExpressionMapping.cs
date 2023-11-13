using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

/// <summary>
/// Mapping table for filter expression
/// </summary>
[Table("FilterExpressionMapping")]
[Index("IsActive", Name = "idx_IsActive")]
public partial class FilterExpressionMapping
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(100)]
    public string TableNameToDisplay { get; set; }

    [StringLength(500)]
    public string TableName { get; set; }

    [Required]
    public bool? IsActive { get; set; }

    [StringLength(1000)]
    public string OrderBy_ColumnName { get; set; }

    [StringLength(10000)]
    public string ColumnName { get; set; }

    [StringLength(1000)]
    public string TableQuery { get; set; }
}
