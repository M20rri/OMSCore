using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("PackingMapping")]
[Index("DSPCode", "PaymentMethodCode", "InvoiceValue", "Country", "OrderCategory", "IsFragile", "IsDanger", "Priority", Name = "IDX_PackingMapping")]
public partial class PackingMapping
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint PackingMappingId { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PackagingLocation { get; set; }

    [StringLength(50)]
    public string DSPCode { get; set; }

    [Column(TypeName = "int(11)")]
    public int? Country { get; set; }

    [StringLength(50)]
    public string PaymentMethodCode { get; set; }

    [Column(TypeName = "mediumint(20)")]
    public int InvoiceValue { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsFragile { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsDanger { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsElectronic { get; set; }

    [Column(TypeName = "int(11)")]
    public int? Priority { get; set; }

    [StringLength(50)]
    public string OrderCategory { get; set; }

    [StringLength(50)]
    public string PackingLocation { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsActive { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [Column(TypeName = "int(11)")]
    public int? InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [Column(TypeName = "int(11)")]
    public int? UpdatedBy { get; set; }
}
