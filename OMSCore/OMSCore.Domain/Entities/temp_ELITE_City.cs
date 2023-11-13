using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Keyless]
[Table("temp_ELITE_City")]
public partial class temp_ELITE_City
{
    [Column(TypeName = "int(11)")]
    public int? Id { get; set; }

    [StringLength(50)]
    public string DSPCode { get; set; }

    [Column(TypeName = "int(11)")]
    public int? CityId { get; set; }

    [StringLength(50)]
    public string CityName { get; set; }

    [Column(TypeName = "int(11)")]
    public int? Active { get; set; }
}
