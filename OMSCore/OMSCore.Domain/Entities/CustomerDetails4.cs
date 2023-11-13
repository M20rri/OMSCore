using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("CustomerDetails4")]
[Index("CustomerId", Name = "IDX_CustomerDetails_CustomerId")]
[Index("CustomerType", Name = "IDX_CustomerDetails_CustomerType")]
[Index("CustomerId", "RANK", "CustomerType", "OrderValue", Name = "IX_CustomerDetails")]
public partial class CustomerDetails4
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(30)]
    public string CustomerId { get; set; }

    [StringLength(50)]
    public string CustomerType { get; set; }

    [Column(TypeName = "int(11)")]
    public int? OrderCount { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ItemCount { get; set; }

    [Precision(10, 3)]
    public decimal? OrderValue { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ReturnOrderCount { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ReturnItemCount { get; set; }

    [Precision(10, 3)]
    public decimal? ReturnValue { get; set; }

    [Column(TypeName = "int(11)")]
    public int? CancelOrderCount { get; set; }

    [Column(TypeName = "int(11)")]
    public int? CancelItemCount { get; set; }

    [Precision(10, 3)]
    public decimal? CancelValue { get; set; }

    [Column(TypeName = "int(11)")]
    public int? OrderModifyCount { get; set; }

    [Column(TypeName = "int(11)")]
    public int? OrderModifyLineCount { get; set; }

    [Precision(10, 3)]
    public decimal? OrderModifyValue { get; set; }

    [Column(TypeName = "int(11)")]
    public int? AddressChangeCount { get; set; }

    [StringLength(100)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(100)]
    public string UpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [Column(TypeName = "int(11)")]
    public int? CIReturnOrderCount { get; set; }

    [Column(TypeName = "int(11)")]
    public int? CIReturnItemCount { get; set; }

    [Precision(10, 3)]
    public decimal? CIReturnValue { get; set; }

    [Column(TypeName = "int(11)")]
    public int? NDReturnOrderCount { get; set; }

    [Column(TypeName = "int(11)")]
    public int? NDReturnItemCount { get; set; }

    [Precision(10, 3)]
    public decimal? NDReturnValue { get; set; }

    [Column(TypeName = "int(11)")]
    public int? CompensationOrderCount { get; set; }

    [Column(TypeName = "int(11)")]
    public int? CompensationItemCount { get; set; }

    [Precision(10, 3)]
    public decimal? CompensationValue { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ExchangeOrderCount { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ExchangeItemCount { get; set; }

    [Precision(10, 3)]
    public decimal? ExchangeValue { get; set; }

    [Column(TypeName = "int(11)")]
    public int? DeliveredOrderCount { get; set; }

    [Precision(10, 2)]
    public decimal? ReturnPercentage { get; set; }

    [Column(TypeName = "int(11)")]
    public int? RANK { get; set; }

    [StringLength(100)]
    public string EmailId { get; set; }

    public bool? IsSyncToMagento { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? MagentoSyncDateTime { get; set; }

    [StringLength(1000)]
    public string MagentoErrorMessage { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CategoryChangeDate { get; set; }
}
