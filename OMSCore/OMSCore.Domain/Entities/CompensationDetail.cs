using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("CompensationDetail")]
[Index("WebOrderNo", "ReasonId", Name = "IX_CompensationDetail")]
[Index("TicketId", Name = "IX_CompensationDetail_TicketId")]
public partial class CompensationDetail
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(20)]
    public string TicketId { get; set; }

    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [StringLength(50)]
    public string ReasonText { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ReasonId { get; set; }

    [Precision(8, 2)]
    public decimal? Amount { get; set; }

    public bool? IsBulk { get; set; }

    [Column(TypeName = "int(11)")]
    public int? InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(3)]
    public string GoodWill { get; set; }
}
