using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("OrderTaxCalculation")]
[Index("WebOrderNo", "PackagingLocation", Name = "UNQ_OrderTaxCalculation_WebOrderNo_PackagingLocation", IsUnique = true)]
public partial class OrderTaxCalculation
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PackagingLocation { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? ProcessStatus { get; set; }

    [StringLength(100)]
    public string ErrorMessage { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(100)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [StringLength(100)]
    public string UpdatedBy { get; set; }

    [StringLength(100)]
    public string Source { get; set; }
}
