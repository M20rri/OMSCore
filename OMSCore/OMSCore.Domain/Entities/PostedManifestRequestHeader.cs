using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("PostedManifestRequestHeader")]
public partial class PostedManifestRequestHeader
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int RequestId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? fromDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? toDate { get; set; }

    [StringLength(45)]
    public string DSPCode { get; set; }

    [StringLength(45)]
    public string PCLocation { get; set; }

    [StringLength(45)]
    public string UserLocation { get; set; }

    [StringLength(45)]
    public string UserId { get; set; }

    [StringLength(45)]
    public string Status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsActive { get; set; }
}
