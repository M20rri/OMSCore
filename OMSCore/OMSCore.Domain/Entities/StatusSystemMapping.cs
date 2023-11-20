using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("StatusSystemMapping")]
[Index("Id", "StatusId", "PackagingLocation", Name = "IDX_StatusSystemMapping")]
[Index("Id", "StatusId", Name = "IDX_StatusSystemMapping_Id")]
[Index("StatusId", Name = "IDX_StatusSystemMapping_StatusId")]
[Index("StatusId", "IsActive", Name = "IX_StatusSystemMapping")]
public partial class StatusSystemMapping
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [Column(TypeName = "int(11)")]
    public int? StatusId { get; set; }

    [StringLength(45)]
    public string DestinationSystem { get; set; }

    [StringLength(500)]
    public string URL { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsActive { get; set; }

    [StringLength(50)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(50)]
    public string UpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PackagingLocation { get; set; }

    [Column(TypeName = "int(11)")]
    public int? MaxThreadPool { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ChunkCount { get; set; }

    [StringLength(250)]
    public string TokenValue { get; set; }
}
