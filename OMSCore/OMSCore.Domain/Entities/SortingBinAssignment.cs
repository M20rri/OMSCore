using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("SortingBinAssignment")]
[Index("Batch_ItemId", Name = "IX_SortingBinAssignment")]
[Index("OrderCount", "Success", Name = "IX_SortingBinAssignment_2")]
public partial class SortingBinAssignment
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(100)]
    public string PackaginLocation { get; set; }

    [StringLength(20)]
    public string WebOrderNo { get; set; }

    [StringLength(20)]
    public string BinCode { get; set; }

    [StringLength(100)]
    public string Batch_ItemId { get; set; }

    [Column(TypeName = "int(11)")]
    public int? UserId { get; set; }

    [Column(TypeName = "int(11)")]
    public int? OrderCount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [Column(TypeName = "int(11)")]
    public int? InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [Column(TypeName = "int(11)")]
    public int? UpdatedBy { get; set; }

    [Column(TypeName = "int(11)")]
    public int? Success { get; set; }

    [StringLength(500)]
    public string Message { get; set; }

    [Column(TypeName = "int(11)")]
    public int? RetryCount { get; set; }

    [StringLength(100)]
    public string BarCode { get; set; }
}
