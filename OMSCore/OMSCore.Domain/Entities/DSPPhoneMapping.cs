using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("DSPPhoneMapping")]
[Index("Country", Name = "IDX_DSPPhoneMapping_Country")]
[Index("DSPCode", "Country", Name = "IX_DSPPhoneMapping_DSPCode_Country")]
public partial class DSPPhoneMapping
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int ID { get; set; }

    [Column(TypeName = "int(11)")]
    public int? DSPCode { get; set; }

    [Column(TypeName = "int(11)")]
    public int? Country { get; set; }

    [StringLength(255)]
    public string PhoneNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int? IsActive { get; set; }

    [Column(TypeName = "int(11)")]
    public int? InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [Column(TypeName = "int(11)")]
    public int? UpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }
}
