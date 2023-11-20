using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Keyless]
public partial class TEMPInvoice
{
    [StringLength(100)]
    public string WebOrderNo { get; set; }

    [StringLength(100)]
    public string DSPCode { get; set; }

    [StringLength(20)]
    public string AWBNo { get; set; }

    [StringLength(100)]
    public string InvoiceNo { get; set; }

    [StringLength(100)]
    public string InvoiceDate { get; set; }
}
