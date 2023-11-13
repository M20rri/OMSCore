using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("DriverCashHeader")]
[Index("DocumentNo", "InsertedBy", Name = "IDX_DocumentNo")]
[Index("DriverID", "InsertedBy", "DocumentNo", "IsTallied", Name = "IX_DriverCashHeader")]
public partial class DriverCashHeader
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int ID { get; set; }

    [StringLength(100)]
    public string DocumentNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int? DriverID { get; set; }

    public bool IsTallied { get; set; }

    public bool IsBulkUpload { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime InsertedOn { get; set; }

    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [StringLength(255)]
    public string UpdatedBy { get; set; }
}
