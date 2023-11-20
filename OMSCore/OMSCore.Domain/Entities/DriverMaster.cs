using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("DriverMaster")]
[Index("DriverId", Name = "IDX_DriverMaster_DriverId")]
public partial class DriverMaster
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int DriverId { get; set; }

    [StringLength(45)]
    public string DriverCode { get; set; }

    [StringLength(200)]
    public string DriverName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(100)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [StringLength(100)]
    public string UpdatedBy { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsDeleted { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? ReadyForArchive { get; set; }

    [Column(TypeName = "int(11)")]
    public int? Location { get; set; }

    [StringLength(20)]
    public string DriverType { get; set; }

    [StringLength(20)]
    public string VendorNo { get; set; }

    [StringLength(100)]
    public string VendorName { get; set; }

    [StringLength(100)]
    public string Device1 { get; set; }

    [StringLength(100)]
    public string Device2 { get; set; }

    [StringLength(45)]
    public string MobileNo { get; set; }

    [StringLength(45)]
    public string EmailId { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsSync_Pytech { get; set; }

    [StringLength(400)]
    public string Reason { get; set; }

    [StringLength(45)]
    public string Department { get; set; }

    [StringLength(50)]
    public string AltMobileNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PYTechId { get; set; }
}
