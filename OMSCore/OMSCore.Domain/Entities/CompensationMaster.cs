using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("CompensationMaster")]
public partial class CompensationMaster
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int ID { get; set; }

    [Precision(10, 3)]
    public decimal? FromOrderValue { get; set; }

    [Precision(10, 3)]
    public decimal? ToOrderValue { get; set; }

    [Precision(10, 3)]
    public decimal? MaxCompensationAmount { get; set; }

    public bool? Status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(100)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [StringLength(100)]
    public string UpdatedBy { get; set; }

    [StringLength(20)]
    public string Currency { get; set; }
}
