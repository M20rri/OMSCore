using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("DropDownOption")]
public partial class DropDownOption
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    public string OptionText { get; set; }

    [Column(TypeName = "int(11)")]
    public int ReportId { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? OptionValue { get; set; }
}
