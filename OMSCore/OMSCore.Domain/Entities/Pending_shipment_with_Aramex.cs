using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Keyless]
[Table("Pending_shipment_with_Aramex")]
public partial class Pending_shipment_with_Aramex
{
    [StringLength(50)]
    public string dsp_code { get; set; }

    [StringLength(20)]
    public string awbno { get; set; }

    [StringLength(50)]
    public string order_currency { get; set; }

    [StringLength(50)]
    public string order_status { get; set; }

    [StringLength(50)]
    public string payment_method { get; set; }

    public DateOnly? order_date { get; set; }

    public DateOnly? Shipped_date { get; set; }

    [Column(TypeName = "int(11)")]
    public int? Delivery_Pending_Days { get; set; }

    [StringLength(500)]
    public string StatusDesc { get; set; }

    public bool? IsDelivered { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DeliveredDatetime { get; set; }
}
