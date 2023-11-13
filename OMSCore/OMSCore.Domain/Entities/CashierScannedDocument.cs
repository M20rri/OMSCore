using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Index("CashierDocumentNo", Name = "IDX_CashierDocumentNo")]
public partial class CashierScannedDocument
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(100)]
    public string CashierDocumentNo { get; set; }

    [StringLength(255)]
    public string FileName { get; set; }

    [StringLength(500)]
    public string ScannedDocURL { get; set; }

    [StringLength(255)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }
}
