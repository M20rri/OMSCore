using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("PostedManifestHeader")]
[Index("LocationCode", Name = "IDX_PostedManifestHeader_LocationCode")]
[Index("ManifestNo", Name = "IDX_PostedManifestHeader_ManifestNo")]
[Index("ManifestNo", "Returned", Name = "idx_PostedManifestHeader_ManifestNo_Returned")]
public partial class PostedManifestHeader
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int ID { get; set; }

    [StringLength(50)]
    public string ManifestNo { get; set; }

    [StringLength(50)]
    public string ShippingAgentCode { get; set; }

    [StringLength(50)]
    public string FMShippingAgentCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ManifestDate { get; set; }

    [StringLength(20)]
    public string LocationCode { get; set; }

    [StringLength(50)]
    public string ShippingAgentName { get; set; }

    [StringLength(50)]
    public string FMShippingAgentName { get; set; }

    [StringLength(45)]
    public string ModeofTransport { get; set; }

    [StringLength(45)]
    public string VehicleNo { get; set; }

    [StringLength(45)]
    public string DriverName { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? ReadyForArchive { get; set; }

    [StringLength(100)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [StringLength(100)]
    public string UpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? Integrated { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? IntegratedOn { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsFragile { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsDanger { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsElectronic { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? ArchiveNo { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? Returned { get; set; }

    [StringLength(50)]
    public string InvoiceExpression { get; set; }

    [StringLength(50)]
    public string InvoiceLimit { get; set; }
}
