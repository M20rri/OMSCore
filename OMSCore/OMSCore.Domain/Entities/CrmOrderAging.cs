using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("CrmOrderAging")]
[Index("ApplicableForAging", Name = "IDX_CrmOrderAging_ApplicableForAging")]
[Index("WebOrderNo", Name = "IDX_CrmOrderAging_WebOrderNo")]
public partial class CrmOrderAging
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int? Age { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ApplicableForAging { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(255)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [StringLength(255)]
    public string UpdatedBy { get; set; }
}
