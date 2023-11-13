using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OMSCore.Domain.Entities;

[Table("ChangeCustomerCategoryCalender")]
public partial class ChangeCustomerCategoryCalender
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    public string CustomerType { get; set; }

    [Required]
    [StringLength(50)]
    public string OperationType { get; set; }

    public DateOnly FromDate { get; set; }

    [Required]
    [StringLength(50)]
    public string UserId { get; set; }

    public DateOnly? ToDate { get; set; }

    [StringLength(255)]
    public string DateInterval { get; set; }
}
