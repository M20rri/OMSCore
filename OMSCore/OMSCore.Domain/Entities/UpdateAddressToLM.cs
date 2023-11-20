using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("UpdateAddressToLMS")]
public partial class UpdateAddressToLM
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [StringLength(50)]
    public string BoxId { get; set; }

    [StringLength(20)]
    public string AWBNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(100)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsSynced { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? RetryCount { get; set; }

    [StringLength(500)]
    public string ErrorMessage { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }
}
