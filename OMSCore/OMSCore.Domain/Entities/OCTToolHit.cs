using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Index("WebOrderNo", Name = "IX_OCTToolHits")]
[Index("StatusFromWMS", Name = "IX_OCTToolHits_StatusFromWMS")]
public partial class OCTToolHit
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [StringLength(100)]
    public string StatusFromWMS { get; set; }

    [StringLength(100)]
    public string OrderStatus { get; set; }

    [StringLength(500)]
    public string MESSAGE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(100)]
    public string InsertedBy { get; set; }

    public bool? IsRefunded { get; set; }

    [Column(TypeName = "json")]
    public string APIRequest { get; set; }

    [Column(TypeName = "json")]
    public string APIResponse { get; set; }

    [Precision(10, 3)]
    public decimal? MagentoStoreCredit { get; set; }

    public bool? RetryCount { get; set; }
}
