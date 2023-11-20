using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Keyless]
[Index("CustomerId", Name = "IDX_OrderPaymentDetails_CustomerId")]
public partial class OrderPaymentDetail
{
    [StringLength(30)]
    public string CustomerId { get; set; }

    [StringLength(50)]
    public string DocumentNo { get; set; }

    [StringLength(45)]
    public string PaymentMethod { get; set; }

    [StringLength(45)]
    public string IsGift { get; set; }

    [StringLength(45)]
    public string ParentId { get; set; }

    [StringLength(45)]
    public string ShipAddId { get; set; }

    [StringLength(45)]
    public string BillAddId { get; set; }

    [StringLength(100)]
    public string OrderNo { get; set; }

    [StringLength(100)]
    public string EmailID { get; set; }
}
