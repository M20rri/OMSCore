using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("AmeyoQASubSection")]
[Index("SectionId", Name = "AmeyoQASubSection_FK")]
public partial class AmeyoQASubSection
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(500)]
    public string NameEn { get; set; }

    [StringLength(500)]
    public string NameAr { get; set; }

    [Column(TypeName = "int(11)")]
    public int SectionId { get; set; }

    public bool IsCritical { get; set; }

    public bool? IsActive { get; set; }

    [Column(TypeName = "int(11)")]
    public int? Points { get; set; }

    [Column(TypeName = "int(11)")]
    public int? UpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }
}
