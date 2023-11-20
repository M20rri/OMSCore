using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("SharingInvoiceSetup")]
public partial class SharingInvoiceSetup
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int ID { get; set; }

    [StringLength(50)]
    public string DSPCode { get; set; }

    [StringLength(50)]
    public string Country { get; set; }

    [Column(TypeName = "enum('Item Value + Shipping + COD Fees + Vat + Custom','Item Value + Shipping + COD Fees + Vat','Item Value + Shipping + COD Fees','Item Value + Shipping','Item Value')")]
    public string ConfigurationSetup { get; set; }

    [Column(TypeName = "int(11)")]
    public int? Amount { get; set; }

    [Column(TypeName = "int(11)")]
    public int? IsActive { get; set; }

    [Column(TypeName = "int(11)")]
    public int? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedOn { get; set; }

    [Column(TypeName = "int(11)")]
    public int? UpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }
}
