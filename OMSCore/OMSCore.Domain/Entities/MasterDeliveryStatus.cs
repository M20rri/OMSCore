using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("MasterDeliveryStatus")]
[Index("DSPCode", Name = "MasterDeliveryStatus_DSPCode")]
[Index("Status", Name = "MasterDeliveryStatus_Status")]
public partial class MasterDeliveryStatus
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    public string Status { get; set; }

    [StringLength(50)]
    public string DSPCode { get; set; }
}
