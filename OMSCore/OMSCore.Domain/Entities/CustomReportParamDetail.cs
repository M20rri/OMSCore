using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[PrimaryKey("ReportId", "ParamId")]
public partial class CustomReportParamDetail
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int ReportId { get; set; }

    [Key]
    [Column(TypeName = "int(11)")]
    public int ParamId { get; set; }

    [StringLength(255)]
    public string ParamName { get; set; }

    [StringLength(255)]
    public string Label { get; set; }

    [StringLength(255)]
    public string ParamDataType { get; set; }

    [StringLength(255)]
    public string FieldType { get; set; }

    [StringLength(255)]
    public string Validation { get; set; }

    [StringLength(255)]
    public string FieldSource { get; set; }

    public bool? Mandatory { get; set; }

    [StringLength(255)]
    public string Sequence { get; set; }

    public bool? IsDateTimePicker { get; set; }

    public bool? IsDropDown { get; set; }

    [StringLength(100)]
    public string DropdownID { get; set; }

    [StringLength(100)]
    public string DropdownValue { get; set; }

    [StringLength(500)]
    public string Condition { get; set; }
}
