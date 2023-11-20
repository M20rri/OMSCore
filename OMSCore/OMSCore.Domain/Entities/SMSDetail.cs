using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("SMSDetail")]
[Index("Sent", "PhoneNo", Name = "IDX_SMSDetail")]
[Index("Sent", "PhoneNo", "RetryCount", "CountryCode", Name = "IX_SMSDetail_2")]
[Index("Insertedon", Name = "IX_SMSDetail_InsertedOn")]
[Index("WebOrderNo", Name = "idx_SMSDetail_WebOrderNo")]
public partial class SMSDetail
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(45)]
    public string PhoneNo { get; set; }

    [StringLength(500)]
    public string Message { get; set; }

    [StringLength(45)]
    public string Insertedby { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Insertedon { get; set; }

    [StringLength(45)]
    public string Updateby { get; set; }

    [StringLength(45)]
    public string Updatedon { get; set; }

    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [StringLength(45)]
    public string CustomerId { get; set; }

    [StringLength(45)]
    public string Sent { get; set; }

    [StringLength(100)]
    public string CountryCode { get; set; }

    [StringLength(8000)]
    public string Response { get; set; }

    [Column(TypeName = "int(11)")]
    public int? RetryCount { get; set; }

    [StringLength(500)]
    public string Source { get; set; }

    [Column(TypeName = "int(11)")]
    public int? TemplateID { get; set; }

    [Column(TypeName = "enum('Automatic','Manual')")]
    public string SmsTriggerFrom { get; set; }
}
