using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("Refundcreatedforcompany")]
public partial class Refundcreatedforcompany
{
    [Column("Transaction Type")]
    [StringLength(50)]
    public string Transaction_Type { get; set; }

    [Required]
    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [StringLength(50)]
    public string TicketID { get; set; }

    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [Column(TypeName = "int(11)")]
    public int? Company { get; set; }

    [StringLength(20)]
    public string PackingLocation { get; set; }

    [Column(TypeName = "int(11)")]
    public int? refundGatewayId { get; set; }
}
