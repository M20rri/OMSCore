using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Index("ReferenceId", "InsertedBy", "Id", Name = "IDX_AmeyoImageDetails")]
public partial class AmeyoQAImageDetail
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(50)]
    public string ReferenceId { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ItemId { get; set; }

    [StringLength(300)]
    public string ImageUrl { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsDeleted { get; set; }

    [StringLength(45)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(45)]
    public string DeletedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DeletedOn { get; set; }

    [StringLength(45)]
    public string Source { get; set; }

    [StringLength(500)]
    public string AWSFULLFilePath { get; set; }
}
