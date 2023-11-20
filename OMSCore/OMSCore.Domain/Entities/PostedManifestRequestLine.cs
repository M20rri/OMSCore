using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Keyless]
[Table("PostedManifestRequestLine")]
public partial class PostedManifestRequestLine
{
    [StringLength(45)]
    public string RequestId { get; set; }

    [StringLength(100)]
    public string PostedInvoiceNo { get; set; }

    [StringLength(45)]
    public string BillToName { get; set; }

    [StringLength(45)]
    public string ShipToName { get; set; }

    [StringLength(45)]
    public string Address1 { get; set; }

    [StringLength(45)]
    public string Address2 { get; set; }

    [StringLength(45)]
    public string City { get; set; }

    [StringLength(20)]
    public string AWBNo { get; set; }

    [StringLength(45)]
    public string PostCode { get; set; }

    [StringLength(45)]
    public string WebOrderNo { get; set; }

    [StringLength(45)]
    public string PaymentMethodCode { get; set; }

    [StringLength(45)]
    public string CODCharges { get; set; }

    [StringLength(45)]
    public string Description { get; set; }

    [StringLength(45)]
    public string PaidAmount { get; set; }

    [StringLength(45)]
    public string ManifestNo { get; set; }

    [StringLength(45)]
    public string ManifestDateTime { get; set; }

    [StringLength(45)]
    public string Weight { get; set; }

    [StringLength(45)]
    public string Height { get; set; }

    [StringLength(45)]
    public string Length { get; set; }

    [StringLength(45)]
    public string Breadth { get; set; }

    [StringLength(45)]
    public string PackagingItem { get; set; }

    [StringLength(45)]
    public string CollectableAmount { get; set; }
}
