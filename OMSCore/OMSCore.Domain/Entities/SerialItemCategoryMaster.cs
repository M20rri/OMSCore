using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("SerialItemCategoryMaster")]
public partial class SerialItemCategoryMaster
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(255)]
    public string CategoryName { get; set; }

    [StringLength(255)]
    public string SeriesPrefix { get; set; }

    public bool? IsActive { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(255)]
    public string InsertedBy { get; set; }
}
