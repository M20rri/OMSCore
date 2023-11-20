﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("MissingOpeOrder")]
public partial class MissingOpeOrder
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(50)]
    public string WeborderNo { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? Status { get; set; }
}
