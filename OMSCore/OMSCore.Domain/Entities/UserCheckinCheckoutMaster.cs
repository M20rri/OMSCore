using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("UserCheckinCheckoutMaster")]
public partial class UserCheckinCheckoutMaster
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(255)]
    public string UserId { get; set; }

    [StringLength(255)]
    public string Username { get; set; }

    [StringLength(255)]
    public string Type { get; set; }

    public bool? Inbound { get; set; }

    public bool? Outbound { get; set; }

    public bool? Active { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedOn { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PackagingLocation { get; set; }
}
