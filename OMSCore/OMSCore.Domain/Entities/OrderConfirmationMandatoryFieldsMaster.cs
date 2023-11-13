using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("OrderConfirmationMandatoryFieldsMaster")]
public partial class OrderConfirmationMandatoryFieldsMaster
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(100)]
    public string Country { get; set; }

    [Required]
    [StringLength(50)]
    public string PaymentType { get; set; }

    [Required]
    [StringLength(255)]
    public string FieldName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime InsertedOn { get; set; }

    [Required]
    [StringLength(50)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime UpdatedOn { get; set; }

    [StringLength(50)]
    public string UpdatedBy { get; set; }
}
