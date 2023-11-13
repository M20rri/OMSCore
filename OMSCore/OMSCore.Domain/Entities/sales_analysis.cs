using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[PrimaryKey("SKU", "orderdate")]
[Table("sales_analysis")]
public partial class sales_analysis
{
    [Key]
    public string SKU { get; set; }

    [Key]
    public DateOnly orderdate { get; set; }

    [Column(TypeName = "int(11)")]
    public int? qty_placed { get; set; }

    [Column(TypeName = "int(11)")]
    public int? cancelled_qty { get; set; }

    [Column(TypeName = "int(11)")]
    public int? Return_qty { get; set; }

    [Column(TypeName = "int(11)")]
    public int? Net_Sales_Qty { get; set; }

    [Precision(10, 3)]
    public decimal? total_retail_price { get; set; }

    [Precision(10, 3)]
    public decimal? net_price { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PackagingLocation { get; set; }
}
