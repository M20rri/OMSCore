using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("CallStatusLog")]
[Index("CallType", "InsertedOn", Name = "IX_CallStatusLog")]
[Index("InsertedOn", Name = "IX_CallStatusLog_3")]
[Index("CustomerId", Name = "IX_CallStatusLog_CustomerId")]
[Index("WebOrderno", Name = "IX_CallStatusLog_WebOrderno")]
public partial class CallStatusLog
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(45)]
    public string CallType { get; set; }

    [StringLength(45)]
    public string Reason { get; set; }

    [StringLength(30)]
    public string CustomerId { get; set; }

    [StringLength(50)]
    public string WebOrderno { get; set; }

    [StringLength(1000)]
    public string Comment { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsArabic { get; set; }

    [StringLength(100)]
    public string MainCode { get; set; }

    [StringLength(100)]
    public string TicketSubCategory1 { get; set; }

    [StringLength(100)]
    public string TicketSubCategory2 { get; set; }

    [StringLength(100)]
    public string TicketSubCategory3 { get; set; }

    [StringLength(45)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime InsertedOn { get; set; }
}
