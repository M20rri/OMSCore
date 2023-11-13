using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Index("ReturnCreated", "RetryCount", Name = "IX_AutoGateEntryLineDetails")]
[Index("PostedGateEntryLineId", Name = "IX_AutoGateEntryLineDetails_PostedGateEntryLineId")]
[Index("TicketStatusId", Name = "IX_AutoGateEntryLineDetails_TicketStatusId")]
[Index("WebOrderNo", "AWBNo", Name = "IX_AutoGateEntryLineDetails_WebOrderNo_AWBNo")]
[Index("AWBNo", Name = "idx_autoGEawbNo")]
public partial class AutoGateEntryLineDetail
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [StringLength(20)]
    public string AWBNo { get; set; }

    [StringLength(50)]
    public string TicketId { get; set; }

    [StringLength(50)]
    public string TempTicketId { get; set; }

    [StringLength(50)]
    public string TempRAWBNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PostedGateEntryLineId { get; set; }

    [Column(TypeName = "int(11)")]
    public int? TicketStatusId { get; set; }

    public bool? ReturnCreated { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(255)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedOn { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; }

    [StringLength(500)]
    public string ErrorMessage { get; set; }

    [Column(TypeName = "int(11)")]
    public int? RetryCount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }
}
