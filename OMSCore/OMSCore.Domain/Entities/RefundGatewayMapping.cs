using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("RefundGatewayMapping")]
[Index("Gateway", "CountryId", "Active", "IsAuto", Name = "IX_RefundGatewayMapping")]
public partial class RefundGatewayMapping
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(100)]
    public string Gateway { get; set; }

    [Column(TypeName = "int(11)")]
    public int? CountryId { get; set; }

    [StringLength(100)]
    public string RefundGateway { get; set; }

    [Column(TypeName = "int(11)")]
    public int? RefundGatewayId { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? Active { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsAuto { get; set; }

    [Column(TypeName = "int(11)")]
    public int? InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [Column(TypeName = "int(11)")]
    public int? UpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [Column(TypeName = "int(11)")]
    public int? RefundAPIId { get; set; }
}
