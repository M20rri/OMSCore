using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("BoxShelvingMapping")]
[Index("AWBNo", "Status", Name = "IDX_BoxShelvingMapping")]
public partial class BoxShelvingMapping
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int BoxShelvingMappingId { get; set; }

    [Column(TypeName = "int(11)")]
    public int ShelvingId { get; set; }

    [StringLength(20)]
    public string AWBNo { get; set; }

    [Column(TypeName = "enum('Open','Shipped','Closed')")]
    public string Status { get; set; }

    [Column(TypeName = "int(11)")]
    public int? AttemptCount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(100)]
    public string InsertedBy { get; set; }

    [StringLength(100)]
    public string UpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(500)]
    public string TicketId { get; set; }

    [Column(TypeName = "enum('Cancel','Schedule','Reschedule','Delivered','Return To shelf','Lost By driver','Customer Denied','No Action','Packet With Driver','Shipped')")]
    public string Reason { get; set; }
}
