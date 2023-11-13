using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Keyless]
[Table("Salasadspcity_TempTable")]
public partial class Salasadspcity_TempTable
{
    [StringLength(50)]
    public string City { get; set; }

    [StringLength(50)]
    public string Country { get; set; }
}
