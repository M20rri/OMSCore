using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("BoxLine")]
[Index("ReferenceOrderNo", "ReturnCreated", Name = "IDX_BoxLine")]
[Index("ReferenceOrderNo", "BoxId", Name = "IDX_BoxLine2")]
[Index("BoxId", Name = "IDX_BoxLineBoxId")]
[Index("AWBNo", Name = "IDX_BoxLine_AWBNo")]
[Index("ItemId", Name = "IDX_BoxLine_ItemId", IsUnique = true)]
[Index("SentforPosting", Name = "IDX_BoxLine_SentforPosting")]
[Index("WebOrderNo", "ItemId", Name = "INDEX_BoxLine_WeborderNoItemId")]
[Index("InvoiceNo", Name = "idx_BoxLine_InvoiceNo")]
public partial class BoxLine
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(50)]
    public string BoxId { get; set; }

    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ItemId { get; set; }

    [Column(TypeName = "int(11)")]
    public int? BatchID { get; set; }

    [StringLength(20)]
    public string ItemNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [Column(TypeName = "int(11)")]
    public int? IsSurface { get; set; }

    [Column(TypeName = "int(11)")]
    public int? IsFragile { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PackId { get; set; }

    [Column(TypeName = "int(11)")]
    public int? IsExchange { get; set; }

    [Column(TypeName = "int(11)")]
    public int? Frequency { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? Priority { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsPrecious { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsGiftWrap { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? BoxCreationDateTime { get; set; }

    [StringLength(50)]
    public string ForwardDspCode { get; set; }

    [StringLength(20)]
    public string AWBNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int? UserId { get; set; }

    [StringLength(50)]
    public string InvoiceNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InvoiceDate { get; set; }

    [Column(TypeName = "int(11)")]
    public int? SentforPosting { get; set; }

    [StringLength(50)]
    public string PickLocation { get; set; }

    [StringLength(50)]
    public string Lot { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SentOn { get; set; }

    [StringLength(1000)]
    public string Error { get; set; }

    [Column(TypeName = "int(11)")]
    public int? TableId { get; set; }

    [StringLength(1000)]
    public string RoutingCode { get; set; }

    [StringLength(50)]
    public string ReferenceOrderNo { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? ReturnCreated { get; set; }

    [StringLength(50)]
    public string SerialNo { get; set; }

    [StringLength(255)]
    public string SKU { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsPdfUploaded { get; set; }

    [StringLength(100)]
    public string BarCode { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsUID { get; set; }
}
