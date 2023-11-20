using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("CustomerTypeMaster")]
[Index("Name", Name = "IDX_CustomerTypeMaster_Name")]
public partial class CustomerTypeMaster
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(45)]
    public string Name { get; set; }

    [StringLength(45)]
    public string Description { get; set; }

    [StringLength(100)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(100)]
    public string UpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [Column(TypeName = "int(11)")]
    public int? CategoryPriority { get; set; }

    [Column(TypeName = "int(11)")]
    public int? IsVIP { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? BatchPriority { get; set; }
}
