using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OMSCore.Domain.Entities;

[Table("AmeyoQAInteractionType")]
public partial class AmeyoQAInteractionType
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string InteractionType { get; set; }
}
