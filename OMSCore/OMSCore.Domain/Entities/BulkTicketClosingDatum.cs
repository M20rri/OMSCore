using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OMSCore.Domain.Entities;

public partial class BulkTicketClosingDatum
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(50)]
    public string TicketId { get; set; }

    [StringLength(50)]
    public string TransactionAmount { get; set; }

    public DateOnly? TransactionDate { get; set; }

    [StringLength(50)]
    public string TransactionId { get; set; }

    [StringLength(50)]
    public string AuthorizationCode { get; set; }

    [StringLength(50)]
    public string Comment { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsRefunded { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(100)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [StringLength(100)]
    public string UpdatedBy { get; set; }
}
