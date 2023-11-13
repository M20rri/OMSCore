using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("DriverCommissionMaster")]
public partial class DriverCommissionMaster
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    [Column(TypeName = "enum('Normal','Special')")]
    public string Type { get; set; }

    [Precision(8, 3)]
    public decimal CommisionValue { get; set; }

    [Precision(8, 3)]
    public decimal DeliveryBase { get; set; }

    [Column(TypeName = "int(11)")]
    public int PackagingLocation { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte IsActive { get; set; }
}
