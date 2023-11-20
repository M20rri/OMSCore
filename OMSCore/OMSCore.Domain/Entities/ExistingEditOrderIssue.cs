using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("ExistingEditOrderIssue")]
[Index("Country", "WebOrderNo", Name = "idx_ExistingEditOrderIssue_WebOrderNo")]
public partial class ExistingEditOrderIssue
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(100)]
    public string Country { get; set; }

    [Precision(10, 3)]
    public decimal? ShippingCharges { get; set; }

    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? OrderDateTime { get; set; }

    [Precision(10, 3)]
    public decimal? MagentoShippingCharges { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? Sent { get; set; }

    [StringLength(500)]
    public string ErrorMessage { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }
}
