using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("ReturnFraudAWB")]
[Index("RAWBNo", Name = "IDX_ReturnFraudAWB_RAWBNo")]
public partial class ReturnFraudAWB
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(50)]
    public string RAWBNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(100)]
    public string InsertedBy { get; set; }

    [StringLength(100)]
    public string UserName { get; set; }

    [StringLength(50)]
    public string QCStatus { get; set; }
}
