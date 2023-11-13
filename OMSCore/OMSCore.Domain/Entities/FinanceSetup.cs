using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("FinanceSetup")]
public partial class FinanceSetup
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StartPreviousFY { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndPreviousFY { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StartPreviousFQ { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndPreviousFQ { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StartCurrentFQ { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndCurrentFQ { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StartCurrentFY { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndCurrentFY { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EdiyaStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EdiyaEndDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [Column(TypeName = "int(11)")]
    public int? InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [Column(TypeName = "int(11)")]
    public int? UpdatedBy { get; set; }
}
