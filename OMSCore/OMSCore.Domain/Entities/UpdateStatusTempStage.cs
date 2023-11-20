using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("UpdateStatusTempStage")]
[Index("Id", Name = "IDX_UpdateStatusTempStage_Id")]
[Index("ProcessName", Name = "IDX_UpdateStatusTempStage_ProcessName")]
[Index("Updated", Name = "IDX_UpdateStatusTempStage_Updated")]
public partial class UpdateStatusTempStage
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(45)]
    public string WebOrderNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int ItemId { get; set; }

    [StringLength(100)]
    public string ProcessName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(45)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? Updated { get; set; }

    [StringLength(20)]
    public string ItemNo { get; set; }
}
