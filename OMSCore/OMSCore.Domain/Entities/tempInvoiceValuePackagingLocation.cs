using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("tempInvoiceValuePackagingLocation")]
public partial class tempInvoiceValuePackagingLocation
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int id { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PackagingLocation { get; set; }

    [Precision(10, 3)]
    public decimal? InvoiceValue { get; set; }

    [Precision(10, 3)]
    public decimal? BoutiqaatCredit { get; set; }
}
