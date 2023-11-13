using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("ApiConfigurationPick")]
[Index("PackagingLocation", Name = "IDX_ApiConfigurationPick_PackagingLocation")]
[Index("PickLocation", Name = "IDX_ApiConfigurationPick_PickLocation")]
public partial class ApiConfigurationPick
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(50)]
    public string PickLocation { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PackagingLocation { get; set; }

    [StringLength(100)]
    public string BaseURL { get; set; }

    [StringLength(100)]
    public string ApiURL { get; set; }

    [StringLength(100)]
    public string BoxDetailsURL { get; set; }

    [StringLength(100)]
    public string ReturnBoxDetailsURL { get; set; }

    [StringLength(200)]
    public string PrepaidTransactionSyncURL { get; set; }

    [StringLength(100)]
    public string DriverCommisionURL { get; set; }

    [StringLength(200)]
    public string FinanceReturnPacketDetails { get; set; }

    [StringLength(200)]
    public string CelebrityOrderDetails { get; set; }

    [StringLength(100)]
    public string OrderDataAnalysisURL { get; set; }

    [StringLength(255)]
    public string BoxShipDetails { get; set; }

    [StringLength(255)]
    public string BoxDeliverDetails { get; set; }
}
