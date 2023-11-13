using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("DeliveryTimeSlotMaster")]
public partial class DeliveryTimeSlotMaster
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(200)]
    public string Description { get; set; }

    [Column(TypeName = "time")]
    public TimeOnly? FromTime { get; set; }

    [Column(TypeName = "time")]
    public TimeOnly? ToTime { get; set; }

    [Column(TypeName = "int(11)")]
    public int? InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [Column(TypeName = "int(11)")]
    public int? UpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [Column(TypeName = "int(11)")]
    public int? IsActive { get; set; }

    [StringLength(100)]
    public string Remarks { get; set; }
}
