using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

public partial class DashboardProcessDataLimitDetail
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(45)]
    public string ProcessData { get; set; }

    [Column(TypeName = "int(11)")]
    public int? CountLimit { get; set; }

    [StringLength(1000)]
    public string DisplayText { get; set; }

    [StringLength(1000)]
    public string Section { get; set; }
}
