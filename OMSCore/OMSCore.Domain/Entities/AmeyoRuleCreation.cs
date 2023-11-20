using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("AmeyoRuleCreation")]
public partial class AmeyoRuleCreation
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [Column(TypeName = "text")]
    public string CustomerType { get; set; }

    [Column(TypeName = "text")]
    public string PaymentMethodCode { get; set; }

    [Column(TypeName = "text")]
    public string Country { get; set; }

    [Column(TypeName = "int(11)")]
    public int OrderStatus { get; set; }

    [Column(TypeName = "text")]
    public string OrderType { get; set; }

    public DateOnly FromDate { get; set; }

    public DateOnly ToDate { get; set; }

    [Required]
    [StringLength(50)]
    public string Expression { get; set; }

    [Precision(10, 3)]
    public decimal Value { get; set; }

    public bool Active { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime InsertedOn { get; set; }

    [StringLength(100)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [StringLength(100)]
    public string UpdatedBy { get; set; }
}
