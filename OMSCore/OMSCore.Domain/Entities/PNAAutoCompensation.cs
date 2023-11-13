using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("PNAAutoCompensation")]
[Index("WebOrderNo", Name = "IX_PNAAutoCompensation")]
public partial class PNAAutoCompensation
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [StringLength(50)]
    public string TicketId { get; set; }

    public bool? IsRefund { get; set; }

    [StringLength(5000)]
    public string ErrorMessage { get; set; }
}
