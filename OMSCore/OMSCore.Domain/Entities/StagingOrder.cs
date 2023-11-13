using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("StagingOrder")]
[Index("CustomerId", "OrderType", Name = "IDX_StagingOrder_CustomerId_OrderType")]
public partial class StagingOrder
{
    [StringLength(30)]
    public string CustomerId { get; set; }

    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(45)]
    public string DocumentNo { get; set; }

    [StringLength(100)]
    public string SKU { get; set; }

    [StringLength(100)]
    public string Description { get; set; }

    [StringLength(100)]
    public string ProductType { get; set; }

    [StringLength(45)]
    public string CategoryName { get; set; }

    [StringLength(45)]
    public string Price { get; set; }

    [StringLength(45)]
    public string Brand { get; set; }

    [StringLength(45)]
    public string Quantity { get; set; }

    [StringLength(45)]
    public string Amount { get; set; }

    [StringLength(100)]
    public string WebOrderNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int? Count { get; set; }

    [StringLength(45)]
    public string FOC { get; set; }

    [StringLength(255)]
    public string SKUId { get; set; }

    [StringLength(100)]
    public string DiscountPercentage { get; set; }

    [StringLength(100)]
    public string DiscountAmount { get; set; }

    [StringLength(100)]
    public string OrderType { get; set; }

    [StringLength(255)]
    public string ReadyForArchive { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(100)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [StringLength(100)]
    public string UpdatedBy { get; set; }

    [StringLength(10)]
    public string CelebrityId { get; set; }

    [StringLength(200)]
    public string CelebrityName { get; set; }

    [StringLength(50)]
    public string TicketId { get; set; }

    [Column(TypeName = "mediumtext")]
    public string ChildSkuList { get; set; }

    [Column(TypeName = "mediumtext")]
    public string ChildSkuQtyList { get; set; }

    [Column(TypeName = "int(11)")]
    public int? GridId { get; set; }

    [Column(TypeName = "mediumtext")]
    public string ChildProductEnitityIdList { get; set; }

    [Column(TypeName = "mediumtext")]
    public string ChildSKUPriceList { get; set; }

    [Column(TypeName = "mediumtext")]
    public string ChildSKUFinalPriceList { get; set; }

    [Column(TypeName = "text")]
    public string ChildSKUNameList { get; set; }

    public bool? IsGWP { get; set; }

    [StringLength(50)]
    public string OriginalPrice { get; set; }
}
