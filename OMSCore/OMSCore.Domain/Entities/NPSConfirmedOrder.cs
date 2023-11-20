using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("NPSConfirmedOrder")]
[Index("WebOrderNo", Name = "idx_WeOrderNo")]
public partial class NPSConfirmedOrder
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [StringLength(30)]
    public string OrderType { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    public bool? IsSync { get; set; }

    [Column(TypeName = "int(11)")]
    public int? RetryCounter { get; set; }

    [StringLength(500)]
    public string ErrorMessage { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [StringLength(50)]
    public string UpdatedBy { get; set; }
}
