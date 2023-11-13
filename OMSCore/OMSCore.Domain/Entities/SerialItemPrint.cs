using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("SerialItemPrint")]
public partial class SerialItemPrint
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(255)]
    public string OldItemNo { get; set; }

    [StringLength(255)]
    public string NewItemNo { get; set; }

    [StringLength(255)]
    public string SerialNo { get; set; }

    [StringLength(255)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [Column(TypeName = "int(11)")]
    public int SerialItemMasterId { get; set; }

    [Column(TypeName = "bigint(20)")]
    public long? LastUsedNo { get; set; }

    [StringLength(255)]
    public string BinCode { get; set; }

    public bool IsActive { get; set; }

    [StringLength(255)]
    public string UpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedNo { get; set; }
}
