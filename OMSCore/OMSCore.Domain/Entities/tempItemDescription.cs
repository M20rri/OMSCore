using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Keyless]
[Table("tempItemDescription")]
[Index("ItemNo", Name = "idx_tempItemDescription_ItemNo")]
public partial class tempItemDescription
{
    [StringLength(20)]
    public string ItemNo { get; set; }

    [StringLength(250)]
    public string Description { get; set; }
}
