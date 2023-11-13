using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("Setup")]
public partial class Setup
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int ID { get; set; }

    [Column(TypeName = "int(11)")]
    public int? OrderStatusID { get; set; }

    [Precision(10, 3)]
    public decimal? CcCommisionPercentage { get; set; }

    [Column(TypeName = "int(11)")]
    public int? InboundSalesHeaderId { get; set; }

    [Column(TypeName = "int(11)")]
    public int? HoldId { get; set; }

    [Column(TypeName = "int(11)")]
    public int? CancelId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? HoldDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CustomerProfileDateTime { get; set; }

    [Column(TypeName = "int(11)")]
    public int? CustomerProfileInboundSalesHeaderId { get; set; }

    [Column(TypeName = "int(11)")]
    public int? CustomerProfileBoxStatusId { get; set; }

    [Column(TypeName = "int(11)")]
    public int? CustomerProfileTicketHeaderId { get; set; }

    [Column(TypeName = "enum('Percentage','Amount')")]
    public string AutoCompensationBasis { get; set; }

    [Column(TypeName = "int(11)")]
    public int? CompensationValue { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastAgeingUsed { get; set; }
}
