using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

public partial class OrderMandatoryField
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(100)]
    public string Country { get; set; }

    [Column(TypeName = "enum('COD','PREPAID','EXCHANGE')")]
    public string PaymentMethodCode { get; set; }

    [Precision(10, 3)]
    public decimal? ToAmount { get; set; }

    [Precision(10, 3)]
    public decimal? FromAmount { get; set; }

    [StringLength(255)]
    public string FieldName { get; set; }

    [StringLength(255)]
    public string Comments { get; set; }

    public bool? Active { get; set; }

    [StringLength(100)]
    public string TableName { get; set; }

    [Column(TypeName = "int(11)")]
    public int? length { get; set; }
}
