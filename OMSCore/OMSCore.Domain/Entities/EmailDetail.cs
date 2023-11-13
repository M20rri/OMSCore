using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("EmailDetail")]
public partial class EmailDetail
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(1000)]
    public string Subject { get; set; }

    [Column(TypeName = "text")]
    public string EmailBody { get; set; }

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

    [StringLength(45)]
    public string Response { get; set; }

    [Column(TypeName = "int(11)")]
    public int? RetryCount { get; set; }

    [StringLength(500)]
    public string Source { get; set; }

    [Column(TypeName = "int(11)")]
    public int? TemplateID { get; set; }

    [StringLength(100)]
    public string EmailId { get; set; }
}
