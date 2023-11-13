using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("ProductTypeMaster")]
[Index("Code", Name = "IX_ProductTypeMaster")]
public partial class ProductTypeMaster
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(10)]
    public string Code { get; set; }

    [StringLength(100)]
    public string Description { get; set; }

    public bool? IsFragile { get; set; }

    public bool? IsDanger { get; set; }

    public bool? IsActive { get; set; }

    [StringLength(100)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(100)]
    public string UpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }
}
