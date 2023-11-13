using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Index("DeliveredDate", Name = "ofs_sales_invoices_DeliveredDate_IDX")]
[Index("InvoiceDate", Name = "ofs_sales_invoices_InvoiceDate_IDX")]
[Index("InvoiceNo", Name = "ofs_sales_invoices_InvoiceNo_IDX")]
[Index("PackagingLocation", Name = "ofs_sales_invoices_PackagingLocation_IDX")]
public partial class ofs_sales_invoice
{
    [Key]
    [StringLength(50)]
    public string InvoiceNo { get; set; }

    public DateOnly? InvoiceDate { get; set; }

    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [StringLength(20)]
    public string AWBNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PackagingLocation { get; set; }

    [StringLength(50)]
    public string BoxId { get; set; }

    [StringLength(50)]
    public string DSPCode { get; set; }

    [StringLength(50)]
    public string PaymentMethodCode { get; set; }

    public DateOnly? DeliveredDate { get; set; }

    [Precision(32, 3)]
    public decimal? Item_value { get; set; }

    [Precision(32, 3)]
    public decimal? CODCharges { get; set; }

    [Precision(32, 3)]
    public decimal? ShippingCharges { get; set; }

    [Precision(32, 3)]
    public decimal? CustomDuty { get; set; }

    [Precision(32, 3)]
    public decimal? TaxAmount { get; set; }

    [Precision(32, 3)]
    public decimal? InvoiceValue { get; set; }

    [Precision(32, 3)]
    public decimal? CollectableAmount { get; set; }

    [StringLength(20)]
    public string CurrencyCode { get; set; }

    [Precision(25, 20)]
    public decimal? CurrencyFactor { get; set; }

    [Precision(53, 3)]
    public decimal? Item_value_LCY { get; set; }

    [Precision(53, 3)]
    public decimal? CODCharges_LCY { get; set; }

    [Precision(53, 3)]
    public decimal? ShippingCharges_LCY { get; set; }

    [Precision(53, 3)]
    public decimal? CustomDuty_LCY { get; set; }

    [Precision(53, 3)]
    public decimal? TaxAmount_LCY { get; set; }

    [Precision(53, 3)]
    public decimal? InvoiceValue_LCY { get; set; }

    [Precision(53, 3)]
    public decimal? CollectableAmount_LCY { get; set; }
}
