using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("CustomerDetailsLog")]
[Index("CustomerId", Name = "IDX_CustomerDetailsLog_CustomerId")]
[Index("FromCategory", Name = "IDX_CustomerDetailsLog_FromCategory")]
[Index("ToCategory", Name = "IDX_CustomerDetailsLog_ToCategory")]
public partial class CustomerDetailsLog
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(30)]
    public string CustomerId { get; set; }

    [StringLength(50)]
    public string FromCategory { get; set; }

    [StringLength(50)]
    public string ToCategory { get; set; }

    [Precision(10, 3)]
    public decimal? Value1 { get; set; }

    [StringLength(500)]
    public string Description1 { get; set; }

    [Precision(10, 3)]
    public decimal? Value2 { get; set; }

    [StringLength(500)]
    public string Description2 { get; set; }

    [Precision(10, 3)]
    public decimal? Value3 { get; set; }

    [StringLength(500)]
    public string Description3 { get; set; }

    [Precision(10, 3)]
    public decimal? Value4 { get; set; }

    [StringLength(500)]
    public string Description4 { get; set; }

    [Precision(10, 3)]
    public decimal? Value5 { get; set; }

    [StringLength(500)]
    public string Description5 { get; set; }

    [Precision(10, 3)]
    public decimal? Value6 { get; set; }

    [StringLength(500)]
    public string Description6 { get; set; }

    [Precision(10, 3)]
    public decimal? Value7 { get; set; }

    [StringLength(500)]
    public string Description7 { get; set; }

    [Precision(10, 3)]
    public decimal? Value8 { get; set; }

    [StringLength(500)]
    public string Description8 { get; set; }

    [Precision(10, 3)]
    public decimal? Value9 { get; set; }

    [StringLength(500)]
    public string Description9 { get; set; }

    [Precision(10, 3)]
    public decimal? Value10 { get; set; }

    [StringLength(500)]
    public string Description10 { get; set; }

    [Column(TypeName = "int(11)")]
    public int? CustomerRank { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CategoryChangeDate { get; set; }

    public bool? IsSync { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SyncDateTime { get; set; }

    [StringLength(1000)]
    public string SyncMessage { get; set; }
}
