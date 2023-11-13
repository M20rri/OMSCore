using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[PrimaryKey("Id", "Active")]
[Table("CityMaster")]
[Index("Country", "Name", Name = "IX_CityMaster", IsUnique = true)]
[Index("Name", "Active", Name = "IX_CityMaster_2")]
[Index("Active", Name = "IX_CityMaster_Active")]
public partial class CityMaster
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(50)]
    public string Name { get; set; }

    [StringLength(100)]
    public string ArabicName { get; set; }

    [StringLength(100)]
    public string Country { get; set; }

    [Key]
    public bool Active { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ZoneId { get; set; }

    [StringLength(10)]
    public string SubZone { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsSyncLMS { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? RetryCount { get; set; }

    [StringLength(500)]
    public string ErrorMessage { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [Column(TypeName = "int(11)")]
    public int? InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [Column(TypeName = "int(11)")]
    public int? UpdatedBy { get; set; }
}
