using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("StoreCreditSEP2023")]
[Index("ReferenceOrderNo", Name = "StoreCreditSEP2023_ReferenceOrderNo_IDX")]
[Index("TicketType", Name = "StoreCreditSEP2023_TicketType_IDX")]
[Index("WebOrderNo", Name = "StoreCreditSEP2023_WebOrderNo_IDX")]
[Index("customer_id", Name = "StoreCreditSEP2023_customer_id_IDX")]
public partial class StoreCreditSEP2023
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [Column(TypeName = "int(11)")]
    public int? history_id { get; set; }

    [Column(TypeName = "int(11)")]
    public int? balance_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? entry_at_utc { get; set; }

    [StringLength(100)]
    public string ticket_id { get; set; }

    [StringLength(1000)]
    public string additional_info { get; set; }

    [StringLength(100)]
    public string noted_order_no { get; set; }

    [Column(TypeName = "int(11)")]
    public int? customer_id { get; set; }

    [Precision(10, 3)]
    public decimal? balance_delta { get; set; }

    [Column(TypeName = "int(11)")]
    public int? action { get; set; }

    [StringLength(200)]
    public string entry_type { get; set; }

    [StringLength(100)]
    public string order_no { get; set; }

    [Column(TypeName = "int(11)")]
    public int? is_new_checkout { get; set; }

    [Precision(10, 3)]
    public decimal? order_store_credit_kwd { get; set; }

    [StringLength(100)]
    public string order_is_sc_reverted { get; set; }

    [StringLength(100)]
    public string order_store_credit_pay_status { get; set; }

    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [StringLength(100)]
    public string ReferenceOrderNo { get; set; }

    [StringLength(100)]
    public string TicketType { get; set; }

    [StringLength(10)]
    public string TestCustomer { get; set; }
}
