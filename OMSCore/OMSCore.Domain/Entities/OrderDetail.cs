using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("OrderDetail")]
[Index("BatchCreated", "PackagingLocation", "IsCancelled", "IsHold", Name = "IDX_OrderDetail_BatchCreated_PackagingLocation")]
[Index("BatchType", "TableId", Name = "IDX_OrderDetail_BatchType_TableId")]
[Index("ReferenceOrderNo", "WebOrderNo", "ItemId", "BatchCreated", "Country", "IsCancelled", "IsHold", "OrderType", "DeliveryType", "PackagingLocation", "OrderCategory", "InsertedOn", Name = "IDX_OrderDetail_RefOrderNo")]
[Index("ReferenceOrderNo", Name = "IDX_OrderDetail_ReferenceOrderNo")]
[Index("WebOrderNo", Name = "IDX_OrderDetail_WebOrderNo")]
[Index("BatchType", Name = "IX_OrderDetail_BatchType")]
[Index("ItemId", Name = "UK_OrderDetail_ItemId", IsUnique = true)]
[Index("WebOrderNo", "ItemId", Name = "WebOrderNo_ItemId")]
public partial class OrderDetail
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [StringLength(50)]
    public string ReferenceOrderNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ItemId { get; set; }

    [Column(TypeName = "int(5)")]
    public int? BatchID { get; set; }

    [Column(TypeName = "enum('NORMAL','EXPRESS','SURFACE','EXCHANGE','PRIORITY','SPECIALDELIVERY','GIFT','GiftCard','PREORDER','VAS')")]
    public string OrderType { get; set; }

    [Column(TypeName = "enum('','3Hr','6Hr','9Hr','12Hr','SameDay','NextDay','ExactDate')")]
    public string DeliveryType { get; set; }

    [StringLength(50)]
    public string PickLocation { get; set; }

    [Column(TypeName = "int(11)")]
    public int? VendorID { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte IsCancelled { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte IsHold { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte IsGifting { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte IsCustomized { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte BatchCreated { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PromisedDeliveryDate { get; set; }

    [Column(TypeName = "int(1)")]
    public int? RepickCount { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsSurface { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PackagingLocation { get; set; }

    [StringLength(20)]
    public string ItemNo { get; set; }

    [StringLength(100)]
    public string Country { get; set; }

    [StringLength(100)]
    public string OrderCategory { get; set; }

    public bool? IsFOC { get; set; }

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

    [Column(TypeName = "enum('','Regular','FastTrack')")]
    public string BatchType { get; set; }

    [Column(TypeName = "int(11)")]
    public int? TableId { get; set; }
}
