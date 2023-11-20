using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("GiftCardRedeemRequestLog")]
public partial class GiftCardRedeemRequestLog
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(100)]
    public string WebOrderNo { get; set; }

    [StringLength(255)]
    public string Response { get; set; }

    [Column(TypeName = "text")]
    public string Request { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(255)]
    public string InsertedBy { get; set; }
}
