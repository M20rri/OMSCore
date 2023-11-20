using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("OrderConfirmRuleMaster")]
[Index("IsActive", Name = "IX_OrderConfirmRuleMaster")]
public partial class OrderConfirmRuleMaster
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [Column(TypeName = "enum('Normal','Special')")]
    public string RuleType { get; set; }

    [StringLength(100)]
    public string Country { get; set; }

    [StringLength(500)]
    public string PaymentMethod { get; set; }

    [StringLength(500)]
    public string OrderCategory { get; set; }

    [StringLength(500)]
    public string CustomerType { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PackagingLocation { get; set; }

    public DateOnly? ToDate { get; set; }

    public DateOnly? FromDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(45)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [StringLength(45)]
    public string UpdatedBy { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? ReadyForArchive { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsActive { get; set; }

    [Column(TypeName = "int(11)")]
    public int? RuleFor { get; set; }

    [Precision(10, 3)]
    public decimal? OrderValue { get; set; }

    [StringLength(50)]
    public string Expression { get; set; }

    [StringLength(10)]
    public string NoOfCivilIDDigits { get; set; }

    [StringLength(500)]
    public string CivilIDStartsWith { get; set; }

    [StringLength(10)]
    public string NoOfPhoneDigits { get; set; }

    [StringLength(500)]
    public string PhoneNoStartsWith { get; set; }

    [StringLength(500)]
    public string PaymentGateway { get; set; }
}
