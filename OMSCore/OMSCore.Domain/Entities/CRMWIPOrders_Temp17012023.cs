using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Keyless]
[Table("CRMWIPOrders_Temp17012023")]
public partial class CRMWIPOrders_Temp17012023
{
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(100)]
    public string CustomerId { get; set; }

    [StringLength(100)]
    public string SKU { get; set; }

    [StringLength(100)]
    public string Description { get; set; }

    [StringLength(100)]
    public string ProductType { get; set; }

    [StringLength(100)]
    public string CategoryName { get; set; }

    [StringLength(100)]
    public string Price { get; set; }

    [StringLength(100)]
    public string Brand { get; set; }

    [StringLength(100)]
    public string Count { get; set; }

    [StringLength(100)]
    public string Amount { get; set; }

    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [StringLength(50)]
    public string ReferenceOrderNo { get; set; }

    [StringLength(45)]
    public string PaymentMethod { get; set; }

    [StringLength(45)]
    public string FOC { get; set; }

    [StringLength(100)]
    public string ReferenceId { get; set; }

    [StringLength(100)]
    public string AuthenticationId { get; set; }

    [StringLength(100)]
    public string SKUId { get; set; }

    [StringLength(100)]
    public string TicketId { get; set; }

    [StringLength(100)]
    public string TicketType { get; set; }

    public bool? ReadyForArchive { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(100)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [StringLength(255)]
    public string UpdatedBy { get; set; }

    [Column(TypeName = "int(11)")]
    public int? OrderCategory { get; set; }

    [StringLength(100)]
    public string DocumentNo { get; set; }

    [StringLength(10)]
    public string CelebrityId { get; set; }

    [StringLength(200)]
    public string CelebrityName { get; set; }

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

    [StringLength(50)]
    public string AppOrderNo { get; set; }

    [StringLength(50)]
    public string OriginalOrderNo { get; set; }

    [StringLength(45)]
    public string OriginalPaymentGateway { get; set; }
}
