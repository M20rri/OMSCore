using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("BatchCalendar")]
[Index("BatchId", "Created", Name = "IDX_BatchCalendar")]
[Index("Created", "PackagingLocation", "BatchDateTime", Name = "IDX_BatchCalendar_2")]
[Index("Id", Name = "IDX_BatchCalendar_Id")]
public partial class BatchCalendar
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime BatchDateTime { get; set; }

    [Column(TypeName = "enum('Automatic','Manual')")]
    public string BatchType { get; set; }

    [StringLength(1000)]
    public string OrderType { get; set; }

    [Column(TypeName = "enum('','3Hr','6Hr','9Hr','12Hr','SameDay','NextDay','ExactDate')")]
    public string DeliveryType { get; set; }

    [Column(TypeName = "int(11)")]
    public int? OrderCount { get; set; }

    [Column(TypeName = "int(11)")]
    public int? BatchItemCount { get; set; }

    [StringLength(20)]
    public string UserId { get; set; }

    [Column(TypeName = "int(11)")]
    public int? BatchId { get; set; }

    [Column(TypeName = "time")]
    public TimeOnly? BatchTimeInterval { get; set; }

    [Column(TypeName = "int(11)")]
    public int? BatchOrderCount { get; set; }

    [Column(TypeName = "int(11)")]
    public int? BatchLineCount { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PendingOrderCount { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PendingLineCount { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PendingBatchOrderCount { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PendingBatchLineCount { get; set; }

    [Column(TypeName = "int(11)")]
    public int? Created { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PackagingLocation { get; set; }

    [StringLength(100)]
    public string CountryCode { get; set; }

    [StringLength(100)]
    public string RegionCode { get; set; }

    [StringLength(1000)]
    public string OrderCategory { get; set; }

    [StringLength(100)]
    public string DSPCode { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? ReadyForArchive { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(100)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [StringLength(100)]
    public string UpdatedBy { get; set; }

    [Column(TypeName = "int(11)")]
    public int? OrderItemCount { get; set; }

    public DateOnly? PreOrderDate { get; set; }
}
