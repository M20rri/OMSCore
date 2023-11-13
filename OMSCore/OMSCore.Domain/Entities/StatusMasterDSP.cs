using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("StatusMasterDSP")]
[Index("Code", Name = "idx_StatusMasterDSP_Code")]
[Index("DSPCode", Name = "idx_StatusMasterDSP_DSPCode")]
[Index("Description", Name = "idx_StatusMasterDSP_Description")]
[Index("Type", Name = "idx_StatusMasterDSP_Type")]
public partial class StatusMasterDSP
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [Column(TypeName = "enum('Delivered','Returned')")]
    public string Type { get; set; }

    [StringLength(50)]
    public string DSPCode { get; set; }

    public string Code { get; set; }

    public string Description { get; set; }
}
