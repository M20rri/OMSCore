using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

/// <summary>
/// 	
/// </summary>
[Keyless]
[Table("DeliveryTypeMaster")]
public partial class DeliveryTypeMaster
{
    [Column(TypeName = "int(11)")]
    public int? Id { get; set; }

    [StringLength(100)]
    public string DeliveryType { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? Active { get; set; }
}
