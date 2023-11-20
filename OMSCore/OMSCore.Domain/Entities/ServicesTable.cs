using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("ServicesTable")]
public partial class ServicesTable
{
    [StringLength(250)]
    public string OFSServicesName { get; set; }

    [StringLength(250)]
    public string NAVServicesName { get; set; }

    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }
}
