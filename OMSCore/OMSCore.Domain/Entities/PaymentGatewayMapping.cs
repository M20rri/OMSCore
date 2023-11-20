using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("PaymentGatewayMapping")]
public partial class PaymentGatewayMapping
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(45)]
    public string Name { get; set; }

    [Column(TypeName = "int(11)")]
    public int? OFSGatewayId { get; set; }

    [StringLength(45)]
    public string OFSGatewayName { get; set; }

    [Column(TypeName = "int(11)")]
    public int? InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }
}
