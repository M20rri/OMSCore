using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("ReturnQCHeader")]
[Index("InsertedBy", Name = "IDX_ReturnQCHeader_InsertedBy")]
[Index("DocumentNumber", Name = "idx_ReturnQCHeader_DocumentNumber")]
public partial class ReturnQCHeader
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(45)]
    public string DocumentNumber { get; set; }

    [StringLength(45)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime InsertedOn { get; set; }

    [StringLength(45)]
    public string UpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime UpdatedOn { get; set; }

    [StringLength(45)]
    public string PassBin { get; set; }

    [StringLength(45)]
    public string FailBin { get; set; }

    [StringLength(45)]
    public string RefurnishBin { get; set; }

    [StringLength(45)]
    public string ExpiredBin { get; set; }
}
