using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[PrimaryKey("BoxId", "InvoiceNo")]
[Index("WebOrderNo", "ReferenceOrderNo", Name = "IDX_BoxWaiverDetails")]
public partial class BoxWaiverDetail
{
    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [StringLength(50)]
    public string ReferenceOrderNo { get; set; }

    [Key]
    [StringLength(50)]
    public string BoxId { get; set; }

    [Key]
    [StringLength(50)]
    public string InvoiceNo { get; set; }

    [Precision(10, 3)]
    public decimal? WaiverOffAmount { get; set; }
}
