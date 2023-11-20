using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

[Table("AmeyoQASection")]
public partial class AmeyoQASection
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [Required]
    [StringLength(500)]
    public string NameEn { get; set; }

    [StringLength(500)]
    public string NameAr { get; set; }

    public bool? IsActive { get; set; }

    [Column(TypeName = "int(11)")]
    public int? UpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [StringLength(100)]
    public string InteractionType { get; set; }

    [StringLength(100)]
    public string EvaluationType { get; set; }
}
