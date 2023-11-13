using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Index("WebOrderNo", "CustomerPhone", "RecipientPhone", "CustomerEmail", "GiftCardStatus", "OrderDateTime", Name = "IDX_GiftCardOrderDetails")]
[Index("WebOrderNo", "CustomerPhone", Name = "IX_GiftCardOrderDetails")]
public partial class GiftCardOrderDetail
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int ID { get; set; }

    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ItemId { get; set; }

    [StringLength(100)]
    public string SKU { get; set; }

    [Precision(10, 3)]
    public decimal? UnitPrice { get; set; }

    [StringLength(30)]
    public string CustomerId { get; set; }

    [StringLength(30)]
    public string RecipientCustomerId { get; set; }

    [StringLength(50)]
    public string CardNo { get; set; }

    [Precision(10, 3)]
    public decimal? CardAmount { get; set; }

    [StringLength(30)]
    public string CardCurrency { get; set; }

    [Precision(25, 20)]
    public decimal? OriginalCurrencyFactor { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RedemptionDate { get; set; }

    [Column(TypeName = "enum('Redeemed','Not Redeemed')")]
    public string GiftCardStatus { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(45)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [StringLength(45)]
    public string UpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? OrderDateTime { get; set; }

    [StringLength(200)]
    public string RecipientName { get; set; }

    [StringLength(100)]
    public string RecipientPhone { get; set; }

    [StringLength(100)]
    public string Plateform { get; set; }

    [StringLength(50)]
    public string AppOrderNo { get; set; }

    [StringLength(100)]
    public string RecipientEmail { get; set; }

    [StringLength(200)]
    public string CustomerName { get; set; }

    [StringLength(100)]
    public string CustomerPhone { get; set; }

    [StringLength(200)]
    public string CustomerEmail { get; set; }

    [StringLength(45)]
    public string Country { get; set; }
}
