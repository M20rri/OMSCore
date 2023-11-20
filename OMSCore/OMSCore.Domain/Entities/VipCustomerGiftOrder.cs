using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Index("RuleId", Name = "IX_RuleId")]
public partial class VipCustomerGiftOrder
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(50)]
    public string CustomerId { get; set; }

    [Column(TypeName = "int(11)")]
    public int? RuleId { get; set; }

    [Column(TypeName = "json")]
    public string UnifiedApiRequest { get; set; }

    [Column(TypeName = "json")]
    public string UnifiedApiResponse { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(100)]
    public string EmailId { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsOrderPlaced { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? GiftDate { get; set; }

    [StringLength(50)]
    public string AppOrderNo { get; set; }
}
