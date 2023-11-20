using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("DSPAWBMapping")]
[Index("DSPCode", "PaymentMethodCode", "AWBNo", "IsUsed", Name = "IDX_DSPAWBMapping")]
[Index("DSPCode", "PaymentMethodCode", "IsUsed", Name = "IDX_DSPAWBMapping_2")]
public partial class DSPAWBMapping
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int DSPAWBMappingId { get; set; }

    [StringLength(50)]
    public string DSPCode { get; set; }

    [StringLength(50)]
    public string PaymentMethodCode { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsUsed { get; set; }

    [StringLength(20)]
    public string AWBNo { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? ReadyForArchive { get; set; }

    [StringLength(100)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(100)]
    public string UpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }
}
