using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Keyless]
public partial class ofs_sales_return_invoice
{
    [Required]
    [StringLength(3)]
    public string txn_type { get; set; }

    public DateOnly? vdate { get; set; }

    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [Precision(53, 3)]
    public decimal? Item_price { get; set; }

    [Precision(54, 3)]
    public decimal? Total_Charges_Income { get; set; }

    [Precision(54, 3)]
    public decimal? Total_Taxs { get; set; }

    [StringLength(50)]
    public string Ticket_no { get; set; }
}
