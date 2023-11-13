using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("SerialItemMaster")]
[Index("OldItemNo", Name = "UK_SerialItemMaster_OldItemNo", IsUnique = true)]
public partial class SerialItemMaster
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    public string OldItemNo { get; set; }

    [StringLength(255)]
    public string ENNo { get; set; }

    [StringLength(255)]
    public string CategoryId { get; set; }

    [StringLength(255)]
    public string Size { get; set; }

    [StringLength(255)]
    public string Color { get; set; }

    [StringLength(1000)]
    public string Description { get; set; }

    [StringLength(255)]
    public string BinNo { get; set; }

    [StringLength(255)]
    public string NewItemNo { get; set; }

    [StringLength(255)]
    public string SKU { get; set; }

    [StringLength(255)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }
}
