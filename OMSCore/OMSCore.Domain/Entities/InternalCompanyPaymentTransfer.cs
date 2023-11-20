using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("InternalCompanyPaymentTransfer")]
public partial class InternalCompanyPaymentTransfer
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(50)]
    public string BoxId { get; set; }

    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PaymentFrom { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PaymentTo { get; set; }

    [Precision(10, 3)]
    public decimal? Amount { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsSyncFrom { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SyncDateTimeFrom { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? RetryFrom { get; set; }

    [StringLength(500)]
    public string ErrorFrom { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsSyncTo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SyncDateTimeTo { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? RetryTo { get; set; }

    [StringLength(500)]
    public string ErrorTo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [Column(TypeName = "int(11)")]
    public int? InsertedBy { get; set; }
}
