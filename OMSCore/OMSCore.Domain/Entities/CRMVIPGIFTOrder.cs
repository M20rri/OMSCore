using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Index("IsOrderSuccess", "Country", "DocumentNo", "CustomerId", Name = "IDX_CRMVIPGIFTOrders")]
[Index("DocumentNo", "Country", "CustomerId", "OrderStatus", Name = "IDX_CRMVIPGIFTOrders_2")]
[Index("DocumentNo", "CustomerId", Name = "IDX_CRMVIPGIFTOrders_3")]
public partial class CRMVIPGIFTOrder
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int ID { get; set; }

    [StringLength(50)]
    public string HeaderId { get; set; }

    [StringLength(50)]
    public string DocumentNo { get; set; }

    [StringLength(50)]
    public string EmailId { get; set; }

    [Column(TypeName = "int(11)")]
    public int? CustomerId { get; set; }

    [StringLength(100)]
    public string CustomerName { get; set; }

    [StringLength(50)]
    public string PhoneNo { get; set; }

    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [StringLength(50)]
    public string OrderType { get; set; }

    [StringLength(50)]
    public string SKU { get; set; }

    [StringLength(50)]
    public string SKUId { get; set; }

    [StringLength(500)]
    public string SKUDESC { get; set; }

    [Column(TypeName = "int(11)")]
    public int? Qty { get; set; }

    [Precision(10, 3)]
    public decimal? Price { get; set; }

    [Precision(11, 3)]
    public decimal? OriginalPrice { get; set; }

    [Column(TypeName = "int(11)")]
    public int? IsPass { get; set; }

    [StringLength(20)]
    public string AwbNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ShippingAddressId { get; set; }

    [Column(TypeName = "int(11)")]
    public int? BillingAddressId { get; set; }

    [StringLength(255)]
    public string AddressText { get; set; }

    [StringLength(100)]
    public string Country { get; set; }

    [StringLength(50)]
    public string Currency { get; set; }

    [StringLength(50)]
    public string PaymentMethod { get; set; }

    [StringLength(50)]
    public string ShippingMethod { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(50)]
    public string InsertedBy { get; set; }

    [Precision(10, 3)]
    public decimal? CODCharges { get; set; }

    [Precision(10, 3)]
    public decimal? ShippingCharges { get; set; }

    [Precision(10, 3)]
    public decimal? Vat { get; set; }

    [Precision(10, 3)]
    public decimal? CustomDuty { get; set; }

    [Precision(10, 3)]
    public decimal? SubTotal { get; set; }

    [Precision(10, 3)]
    public decimal? NetValue { get; set; }

    [Column(TypeName = "int(11)")]
    public int? IsLimitApplied { get; set; }

    [StringLength(500)]
    public string OrderStatus { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? OrderDate { get; set; }

    [Column(TypeName = "int(11)")]
    public int? IsOrderSuccess { get; set; }
}
