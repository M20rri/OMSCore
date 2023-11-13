using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OMSCore.Domain.Entities;

[Table("AmeyoQAEvaluationType")]
public partial class AmeyoQAEvaluationType
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(100)]
    public string EvaluationType { get; set; }
}
