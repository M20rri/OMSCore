using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

public partial class ItemUrlDetail
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(20)]
    public string ItemNo { get; set; }

    [StringLength(300)]
    public string ImageURL { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsProcessed { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ProcessedOn { get; set; }

    [StringLength(500)]
    public string ErrorMessage { get; set; }
}
