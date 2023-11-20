using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("HolidayMaster")]
public partial class HolidayMaster
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    public DateOnly? Date { get; set; }

    [StringLength(50)]
    public string Day { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? Active { get; set; }

    [StringLength(50)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(50)]
    public string UpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }
}
