using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("BatchCalendarArchive")]
[Index("Id", Name = "IDX_BatchCalendar_Id")]
public partial class BatchCalendarArchive
{
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? BatchDateTime { get; set; }

    [Column(TypeName = "enum('Automatic','Manual')")]
    public string BatchType { get; set; }

    [Column(TypeName = "enum('NORMAL','EXPRESS','SURFACE','EXCHANGE','PRIORITY','SPECIALDELIVERY','GIFT','GiftCard','PREORDER','VAS')")]
    public string OrderType { get; set; }

    [Column(TypeName = "enum('','3Hr','6Hr','9Hr','12Hr','SameDay','NextDay','ExactDate')")]
    public string DeliveryType { get; set; }

    [Column(TypeName = "int(11)")]
    public int? OrderCount { get; set; }

    [Column(TypeName = "int(11)")]
    public int? UserId { get; set; }

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

    [Column(TypeName = "tinyint(4)")]
    public sbyte? Created { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PackagingLocation { get; set; }

    [StringLength(100)]
    public string DeletedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DeletedOn { get; set; }

    [Key]
    [Column(TypeName = "int(11)")]
    public int AutoId { get; set; }

    [StringLength(45)]
    public string OrderCategory { get; set; }
}
