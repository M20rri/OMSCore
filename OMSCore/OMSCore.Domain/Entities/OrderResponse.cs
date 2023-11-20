using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("OrderResponse")]
public partial class OrderResponse
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [Column(TypeName = "json")]
    public string Response { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [Column(TypeName = "int(11)")]
    public int? InsertedBy { get; set; }

    [StringLength(50)]
    public string OrderNo { get; set; }

    [Column(TypeName = "json")]
    public string Request { get; set; }
}
