using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("TEMPTAX")]
[Index("fromCountry", Name = "IX_TEMPTAX")]
public partial class TEMPTAX
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(100)]
    public string fromCountry { get; set; }

    [StringLength(100)]
    public string toCountry { get; set; }

    [StringLength(100)]
    public string ItemValueIncCharges { get; set; }

    [StringLength(100)]
    public string BoxId { get; set; }

    [Column(TypeName = "json")]
    public string JSONField { get; set; }

    [Column(TypeName = "mediumtext")]
    public string Request { get; set; }
}
