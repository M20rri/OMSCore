using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Keyless]
public partial class tmpPostdescriptionchangeorder
{
    [StringLength(30)]
    public string AwbNo { get; set; }

    [StringLength(30)]
    public string Type { get; set; }

    [StringLength(30)]
    public string WebOrderNo { get; set; }

    [StringLength(30)]
    public string InvoiceNo { get; set; }

    [StringLength(30)]
    public string BoxId { get; set; }
}
