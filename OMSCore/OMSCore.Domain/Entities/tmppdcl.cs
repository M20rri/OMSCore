using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Keyless]
[Table("tmppdcl")]
[Index("AWBNo", Name = "idx_AWBNo")]
[Index("CashierDocumentNo", Name = "idx_CashierDocumentNo")]
public partial class tmppdcl
{
    [StringLength(20)]
    public string AWBNo { get; set; }

    [StringLength(100)]
    public string CashierDocumentNo { get; set; }

    [StringLength(255)]
    public string DriverID { get; set; }

    public DateOnly? InsertedOn { get; set; }
}
