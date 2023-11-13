using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Index("WaybillNumber", Name = "IX_WaybillNumber")]
public partial class DSPStatusDetail
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(255)]
    public string DSPCode { get; set; }

    public string WaybillNumber { get; set; }

    [StringLength(255)]
    public string UpdateCode { get; set; }

    [StringLength(255)]
    public string UpdateDescription { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdateDateTime { get; set; }

    [StringLength(255)]
    public string UpdateLocation { get; set; }

    [StringLength(500)]
    public string Comments { get; set; }

    [StringLength(255)]
    public string ProblemCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(100)]
    public string Country { get; set; }

    [StringLength(100)]
    public string City { get; set; }
}
