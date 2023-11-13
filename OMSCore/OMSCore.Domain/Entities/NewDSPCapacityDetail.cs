using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Index("CountryCode", "DSPCode", "PaymentMethod", "FromDate", "ToDate", "Capacity", "IsDeleted", Name = "IDX_NewDSPCapacityDetails")]
public partial class NewDSPCapacityDetail
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint DSPCapacityDetailId { get; set; }

    [StringLength(50)]
    public string DSPCode { get; set; }

    public DateOnly? FromDate { get; set; }

    public DateOnly? ToDate { get; set; }

    [Column(TypeName = "time")]
    public TimeOnly? FromTime { get; set; }

    [Column(TypeName = "time")]
    public TimeOnly? ToTime { get; set; }

    [Column(TypeName = "mediumint(10) unsigned")]
    public uint Capacity { get; set; }

    [Column(TypeName = "int(11)")]
    public int? CountryCode { get; set; }

    [StringLength(50)]
    public string Type { get; set; }

    [StringLength(50)]
    public string PaymentMethod { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte IsDeleted { get; set; }

    [StringLength(100)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(100)]
    public string UpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }
}
