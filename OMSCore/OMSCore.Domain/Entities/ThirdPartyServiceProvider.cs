using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

public partial class ThirdPartyServiceProvider
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(45)]
    public string Name { get; set; }

    [StringLength(255)]
    public string APIURL { get; set; }

    [StringLength(255)]
    public string APIUserName { get; set; }

    [StringLength(255)]
    public string APIPassword { get; set; }

    public bool? Active { get; set; }

    [StringLength(1000)]
    public string Token { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TokenDate { get; set; }

    [StringLength(255)]
    public string ReadAPIURL { get; set; }

    [Column(TypeName = "int(11)")]
    public int? MyFatoorahInvoiceExpiryDays { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsRefund { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsFrontEndAccount { get; set; }

    [StringLength(20)]
    public string GatewayMethod { get; set; }

    [Column(TypeName = "int(11)")]
    public int? CompanyId { get; set; }
}
