using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Index("InsertedOn", Name = "IDX_CRMOrders_InsertedOn")]
[Index("OrderDateTime", Name = "IDX_CRMOrders_OrderDateTime")]
[Index("OrderType", Name = "IDX_CRMOrders_OrderType")]
[Index("ReferenceOrderNo", Name = "IDX_CRMOrders_ReferenceOrderNo")]
[Index("WebOrderNo", Name = "IDX_CRMOrders_WebOrderNo")]
[Index("CustomerId", Name = "IX_CRMOrders_CustomerId")]
[Index("OrderStatus", "IsRuleRun", Name = "IX_CRMOrders_OrderStatus")]
[Index("WebOrderNo", "CustomerEmail", "CustomerId", "CustomerPhone", Name = "UK_CRMOrders", IsUnique = true)]
[Index("AppOrderNo", Name = "idx_AppOrderNo")]
[Index("WebOrderNo", "ReferenceOrderNo", Name = "idx_comb")]
public partial class CRMOrder
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int ID { get; set; }

    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int? OrderStatus { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? OrderDateTime { get; set; }

    [Column(TypeName = "enum('COD','PREPAID','EXCHANGE')")]
    public string PaymentMethod { get; set; }

    [StringLength(45)]
    public string UserAssign { get; set; }

    [StringLength(50)]
    public string OrderCategory { get; set; }

    [StringLength(100)]
    public string FirstName { get; set; }

    [StringLength(100)]
    public string MiddleName { get; set; }

    [StringLength(100)]
    public string LastName { get; set; }

    [StringLength(30)]
    public string CustomerId { get; set; }

    [StringLength(100)]
    public string CustomerEmail { get; set; }

    [StringLength(100)]
    public string CustomerPhone { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PackagingLocation { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(45)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [StringLength(45)]
    public string UpdatedBy { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? ReadyForArchive { get; set; }

    [StringLength(100)]
    public string Country { get; set; }

    [StringLength(50)]
    public string OrderSource { get; set; }

    [Precision(10, 2)]
    public decimal? OrderAmount { get; set; }

    [StringLength(45)]
    public string Currency { get; set; }

    [Column(TypeName = "enum('NORMAL','EXPRESS','SURFACE','EXCHANGE','PRIORITY','SPECIALDELIVERY','GIFT','GiftCard','PREORDER','VAS')")]
    public string OrderType { get; set; }

    [StringLength(50)]
    public string ReferenceOrderNo { get; set; }

    [StringLength(50)]
    public string AppOrderNo { get; set; }

    [StringLength(50)]
    public string Company { get; set; }

    [Column(TypeName = "int(11)")]
    public int? IsRuleRun { get; set; }

    [Column(TypeName = "int(11)")]
    public int? AssigndByUserId { get; set; }

    [StringLength(20)]
    public string StoreId { get; set; }

    public bool? IsAmeyoSync { get; set; }

    [StringLength(500)]
    public string SyncMessage { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SyncUpdatedOn { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SyncDateTime { get; set; }

    [StringLength(50)]
    public string CustomerType { get; set; }
}
