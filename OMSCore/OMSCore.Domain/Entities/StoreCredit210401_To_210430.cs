using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("StoreCredit210401_To_210430")]
public partial class StoreCredit210401_To_210430
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [Column(TypeName = "int(11)")]
    public int? History_id { get; set; }

    [Column(TypeName = "int(11)")]
    public int? Balance_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Updated_at { get; set; }

    [Column(TypeName = "int(11)")]
    public int? Actions { get; set; }

    [Precision(10, 3)]
    public decimal? Balance_amount { get; set; }

    [Precision(10, 3)]
    public decimal? Balance_delta { get; set; }

    [StringLength(1000)]
    public string Additional_info { get; set; }

    [Column(TypeName = "int(11)")]
    public int? IsCustomerNotified { get; set; }

    [StringLength(100)]
    public string Ticket { get; set; }

    [Column(TypeName = "int(11)")]
    public int? Customerid { get; set; }

    [Column(TypeName = "int(11)")]
    public int? Websiteid { get; set; }

    [Precision(10, 3)]
    public decimal? Amount { get; set; }

    [StringLength(10)]
    public string Base_currency_code { get; set; }

    [StringLength(100)]
    public string WebOrderNo { get; set; }

    [StringLength(100)]
    public string ReferenceOrderNo { get; set; }

    [StringLength(100)]
    public string TicketType { get; set; }
}
