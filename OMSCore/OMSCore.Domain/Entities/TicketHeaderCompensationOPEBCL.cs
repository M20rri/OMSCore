using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("TicketHeaderCompensationOPEBCL")]
public partial class TicketHeaderCompensationOPEBCL
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(50)]
    public string TicketId { get; set; }

    [Column(TypeName = "int(11)")]
    public int? TicketType { get; set; }

    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [StringLength(10)]
    public string Company { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PackagingLocation { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? FulfillmentCenter { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsCreated { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedOn { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? RowCountOPE { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? RowCountBCL { get; set; }
}
