﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("AutoCompensation")]
[Index("WebOrderNo", Name = "IX_AutoCompensation")]
public partial class AutoCompensation
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [StringLength(50)]
    public string TicketId { get; set; }

    [StringLength(5000)]
    public string ErrorMessage { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(50)]
    public string InsertedBy { get; set; }

    public bool? IsRefund { get; set; }

    public bool? IsClose { get; set; }

    [Column(TypeName = "enum('Auto','Manual')")]
    public string EntryType { get; set; }

    [Column(TypeName = "int(11)")]
    public int? Retry { get; set; }
}
