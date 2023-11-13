using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Keyless]
[Table("tbl_InvoiceCountryToDownload")]
public partial class tbl_InvoiceCountryToDownload
{
    [StringLength(50)]
    public string InvoiceNo { get; set; }

    [StringLength(20)]
    public string WebOrderNo { get; set; }

    [StringLength(20)]
    public string AWBNo { get; set; }

    [StringLength(20)]
    public string Country { get; set; }

    [StringLength(20)]
    public string DeliveredDateTime { get; set; }
}
