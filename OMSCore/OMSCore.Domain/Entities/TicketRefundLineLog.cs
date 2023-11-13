using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("TicketRefundLineLog")]
public partial class TicketRefundLineLog
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(50)]
    public string TicketId { get; set; }

    [Precision(10, 2)]
    public decimal? CodCharges { get; set; }

    [Precision(10, 2)]
    public decimal? ShippingCharges { get; set; }

    [Precision(10, 2)]
    public decimal? GiftCharges { get; set; }

    [Precision(10, 2)]
    public decimal? CustomizationCharges { get; set; }

    [Precision(10, 2)]
    public decimal? OrderProcessCharges { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ItemId { get; set; }

    [Precision(10, 2)]
    public decimal? ItemValue { get; set; }

    [Precision(10, 2)]
    public decimal? CustomDuty { get; set; }

    [Precision(10, 2)]
    public decimal? Tax { get; set; }

    [StringLength(45)]
    public string WebOrderNo { get; set; }

    [StringLength(45)]
    public string ReturnReason { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InstanceOfDate { get; set; }

    [Column(TypeName = "int(11)")]
    public int VersionNo { get; set; }
}
