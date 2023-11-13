using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("PNRReasonMaster")]
public partial class PNRReasonMaster
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(45)]
    public string PNRReasonCode { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsPNR { get; set; }

    [StringLength(100)]
    public string PNRReasonDescription { get; set; }

    [Column(TypeName = "enum('NDR','CIR','EXCHANGE')")]
    public string PNRReturnType { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? FinanceApprovalRequired { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsThreshold { get; set; }
}
