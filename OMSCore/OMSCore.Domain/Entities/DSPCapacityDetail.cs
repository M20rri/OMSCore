using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Index("DSPCode", Name = "idx_DSPCapacityDetails_DSPCode")]
public partial class DSPCapacityDetail
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(50)]
    public string DSPCode { get; set; }

    [StringLength(10)]
    public string Country { get; set; }

    public DateOnly? Date { get; set; }

    [Column(TypeName = "mediumint(10) unsigned")]
    public uint Capacity { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsDeleted { get; set; }

    [StringLength(100)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(100)]
    public string UpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PackagingLocation { get; set; }
}
