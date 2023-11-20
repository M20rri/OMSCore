using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("PostedDriverCashHeader")]
[Index("DocumentNo", Name = "IDX_PostedDriverCashHeader_DocumentNo")]
[Index("BankId", "BankReceiptNo", "HandOverDocumentNo", "InsertedBy", Name = "IX_PostedDriverCashHeader")]
[Index("HandOverDocumentNo", "DocumentNo", "BankId", Name = "IX_PostedDriverCashHeader_2")]
[Index("UpdatedBy", Name = "PostedDriverCashHeader_UpdatedBy")]
public partial class PostedDriverCashHeader
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

    [StringLength(100)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    public string UpdatedBy { get; set; }

    [StringLength(10)]
    public string BankId { get; set; }

    [StringLength(100)]
    public string BankReceiptNo { get; set; }

    [StringLength(100)]
    public string HandOverDocumentNo { get; set; }
}
