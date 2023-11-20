using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("OCTReturnRequired")]
[Index("WebOrderNo", "AWBNo", Name = "IX_OCTReturnRequired")]
[Index("IsReturnCreated", Name = "IX_OCTReturnRequired_IsReturnCreated")]
public partial class OCTReturnRequired
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [StringLength(20)]
    public string AWBNo { get; set; }

    public bool? IsReturnCreated { get; set; }

    [StringLength(50)]
    public string TicketId { get; set; }

    [StringLength(500)]
    public string ErrorMessage { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [Column(TypeName = "json")]
    public string ReturnJson { get; set; }
}
