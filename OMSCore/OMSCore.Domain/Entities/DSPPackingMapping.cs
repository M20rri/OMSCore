using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("DSPPackingMapping")]
[Index("PackingLocation", "Country", "DSPCode", "PaymentMethod", "PackageValue", "Priority", "OrderCategory", "ProductTypeCode", Name = "IDX_DSPPackingMapping")]
public partial class DSPPackingMapping
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(50)]
    public string DSPCode { get; set; }

    [StringLength(10)]
    public string Country { get; set; }

    [StringLength(20)]
    public string PaymentMethod { get; set; }

    [StringLength(50)]
    public string OrderCategory { get; set; }

    [Column(TypeName = "mediumint(20)")]
    public int PackageValue { get; set; }

    [StringLength(10)]
    public string ProductTypeCode { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? Priority { get; set; }

    [StringLength(50)]
    public string PackingLocation { get; set; }

    public bool? IsActive { get; set; }

    [StringLength(100)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(100)]
    public string UpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }
}
