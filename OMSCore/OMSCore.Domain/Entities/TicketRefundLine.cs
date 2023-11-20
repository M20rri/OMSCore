using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("TicketRefundLine")]
[Index("ItemId", Name = "IDX_TicketRefundLine")]
[Index("TicketId", Name = "IDX_TicketRefundLine_TicketId")]
public partial class TicketRefundLine
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(50)]
    public string TicketId { get; set; }

    [Precision(10, 3)]
    public decimal? CodCharges { get; set; }

    [Precision(10, 3)]
    public decimal? ShippingCharges { get; set; }

    [Precision(10, 3)]
    public decimal? GiftCharges { get; set; }

    [Precision(10, 3)]
    public decimal? CustomizationCharges { get; set; }

    [Precision(10, 3)]
    public decimal? OrderProcessCharges { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ItemId { get; set; }

    [Precision(10, 3)]
    public decimal? ItemValue { get; set; }

    [Precision(10, 3)]
    public decimal? CustomDuty { get; set; }

    [Precision(10, 3)]
    public decimal? Tax { get; set; }

    [StringLength(45)]
    public string WebOrderNo { get; set; }

    [StringLength(100)]
    public string ReturnReason { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(50)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [StringLength(50)]
    public string UpdatedBy { get; set; }

    [StringLength(100)]
    public string PNRReturnReason { get; set; }
}
