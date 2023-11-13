using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("SMSConfiguration")]
[Index("Country", Name = "IX_SMSConfiguration_Country")]
public partial class SMSConfiguration
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(100)]
    public string Country { get; set; }

    [StringLength(100)]
    public string ProviderName { get; set; }

    public bool? Active { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [Column(TypeName = "int(11)")]
    public int InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime UpdatedOn { get; set; }

    [Column(TypeName = "int(11)")]
    public int UpdatedBy { get; set; }

    [StringLength(100)]
    public string URLShortnerProvider { get; set; }
}
