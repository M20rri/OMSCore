using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("ReturnReasonMaster")]
public partial class ReturnReasonMaster
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PackagingLocation { get; set; }

    [StringLength(45)]
    public string Code { get; set; }

    [StringLength(45)]
    public string Description { get; set; }

    [Column(TypeName = "enum('','Item','Item+Charges','Item+Charges+Custom','Item+Charges+Custom+Tax','Item+Custom','Item+Tax','Item+Charges+Tax')")]
    public string NDR { get; set; }

    [Column(TypeName = "enum('','Item','Item+Charges','Item+Charges+Custom','Item+Charges+Custom+Tax','Item+Custom','Item+Tax','Item+Custom+Tax','Item+Charges+Tax')")]
    public string CIR { get; set; }

    [Column(TypeName = "enum('','Item','Item+Charges','Item+Charges+Custom','Item+Charges+Custom+Tax','Item+Custom','Item+Tax','Item+Custom+Tax','Item+Charges+Tax')")]
    public string CIRPartial { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte AuthorizationRequired { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? Destination { get; set; }

    [StringLength(20)]
    public string ReturnType { get; set; }

    [StringLength(45)]
    public string PaymentType { get; set; }

    [StringLength(200)]
    public string CIRNDROption { get; set; }

    [StringLength(200)]
    public string CIRPartialOption { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsActive { get; set; }
}
