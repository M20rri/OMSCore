﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("RegisteredPickDataApiLog")]
public partial class RegisteredPickDataApiLog
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [Column(TypeName = "int(11)")]
    public int? XmlId { get; set; }

    [Column(TypeName = "json")]
    public string Json { get; set; }

    [StringLength(1000)]
    public string XML { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? ReadyForArchive { get; set; }

    [StringLength(50)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [StringLength(50)]
    public string UpdatedBy { get; set; }
}
