using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Keyless]
[Table("BoutiqaatCreditLedgerReport")]
public partial class BoutiqaatCreditLedgerReport
{
    [Column(TypeName = "int(11)")]
    public int? Id { get; set; }

    [StringLength(45)]
    public string CustomerId { get; set; }

    [StringLength(45)]
    public string TicketId { get; set; }

    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [StringLength(50)]
    public string ReferenceOrderNo { get; set; }

    [Precision(10, 3)]
    public decimal BoutiqaatCreditAmount { get; set; }

    [Precision(10, 3)]
    public decimal? BoutiqaatCreditAmountLCY { get; set; }

    [Column(TypeName = "enum('REFUND','EXCHANGE','CONSUME','EXTRA','OTHERS','WAIVEROFF','WRITEOFF','REVERSEBC','GIFT','Gift Card Redeem')")]
    public string BoutiqaatCreditType { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? SyncRequired { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? Synced { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(100)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [StringLength(100)]
    public string UpdatedBy { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? ReadyForArchive { get; set; }

    [StringLength(255)]
    public string Comment { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ApproverId { get; set; }

    [StringLength(500)]
    public string ErrorMessage { get; set; }

    [Column(TypeName = "int(11)")]
    public int? RowId { get; set; }

    [StringLength(50)]
    public string CountryCode { get; set; }
}
