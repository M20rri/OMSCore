using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Index("Type", "IsActive", "IsDefault", "CountryCode", Name = "IX_SMSTemplates_Type")]
public partial class SMSTemplate
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(100)]
    public string CountryCode { get; set; }

    [StringLength(1000)]
    public string Template { get; set; }

    [StringLength(45)]
    public string Insertedby { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Insertedon { get; set; }

    [StringLength(45)]
    public string Updatedby { get; set; }

    [StringLength(45)]
    public string Updatedon { get; set; }

    public bool? IsActive { get; set; }

    [StringLength(45)]
    public string Language { get; set; }

    public bool? IsDefault { get; set; }

    [StringLength(45)]
    public string Type { get; set; }

    [StringLength(45)]
    public string IsDirect { get; set; }

    [Column(TypeName = "text")]
    public string EmailHeader { get; set; }

    [Column(TypeName = "text")]
    public string EmailFooter { get; set; }

    [Column(TypeName = "text")]
    public string EmailTemplate { get; set; }

    [StringLength(1000)]
    public string Subject { get; set; }

    public bool? IsActiveAutomatic { get; set; }
}
