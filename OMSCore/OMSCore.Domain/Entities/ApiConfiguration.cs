using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("ApiConfiguration")]
[Index("ServiceName", "ID", Name = "IDX_ApiConfiguration_ServiceName")]
public partial class ApiConfiguration
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int ID { get; set; }

    [StringLength(250)]
    public string URL { get; set; }

    [StringLength(250)]
    public string UserID { get; set; }

    [StringLength(1000)]
    public string AccessKey { get; set; }

    [StringLength(250)]
    public string ServerUserName { get; set; }

    [StringLength(250)]
    public string ServerPassword { get; set; }

    [StringLength(250)]
    public string RetailerPartnerID { get; set; }

    [StringLength(250)]
    public string RetailerPartnerName { get; set; }

    [StringLength(50)]
    public string SellerId { get; set; }

    [StringLength(50)]
    public string ServiceName { get; set; }

    [Column(TypeName = "int(11)")]
    public int? MaxThreadPool { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ChunkCount { get; set; }

    [StringLength(40)]
    public string IPAddress { get; set; }

    [StringLength(100)]
    public string InstallationName { get; set; }

    [StringLength(100)]
    public string DisplayName { get; set; }

    [StringLength(100)]
    public string StatusProcedure { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ThresholdValue1 { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ThresholdValue2 { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? Active { get; set; }

    [StringLength(250)]
    public string TokenURL { get; set; }
}
