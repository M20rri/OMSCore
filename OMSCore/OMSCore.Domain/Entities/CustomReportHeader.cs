using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("CustomReportHeader")]
public partial class CustomReportHeader
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int ReportId { get; set; }

    [StringLength(255)]
    public string ReportName { get; set; }

    [StringLength(255)]
    public string SpName { get; set; }

    [Column(TypeName = "enum('NAV','OFS')")]
    public string Applicable { get; set; }

    public bool? Active { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Date { get; set; }
}
