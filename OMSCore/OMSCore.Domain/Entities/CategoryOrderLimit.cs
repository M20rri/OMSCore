using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("CategoryOrderLimit")]
public partial class CategoryOrderLimit
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int ID { get; set; }

    [Precision(10, 3)]
    public decimal? MininumPrice { get; set; }

    [Precision(10, 3)]
    public decimal? MaximumPrice { get; set; }

    [Precision(10, 3)]
    public decimal? ShippingCharge { get; set; }

    [StringLength(100)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(100)]
    public string UpdateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [Precision(10, 3)]
    public decimal? VAT { get; set; }

    [StringLength(100)]
    public string CountryCode { get; set; }

    [StringLength(50)]
    public string OrderCategory { get; set; }

    [Precision(10, 3)]
    public decimal? OrderLimit { get; set; }
}
