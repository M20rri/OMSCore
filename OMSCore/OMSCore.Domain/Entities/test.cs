﻿using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Keyless]
[Table("test")]
public partial class test
{
    [Column("order no")]
    public double? order_no { get; set; }
}
