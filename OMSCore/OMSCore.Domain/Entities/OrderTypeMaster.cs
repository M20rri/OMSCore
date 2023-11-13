using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("OrderTypeMaster")]
[Index("OrderType", Name = "IX_OrderTypeMaster")]
public partial class OrderTypeMaster
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(100)]
    public string OrderType { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? Active { get; set; }

    public bool? OperationAllowed { get; set; }

    public bool? RefundRequired { get; set; }
}
