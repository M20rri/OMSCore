using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("LocationMaster")]
[Index("Country", "Id", Name = "IDX_LocationMaster_Country")]
[Index("Location", Name = "IDX_LocationMaster_Location")]
public partial class LocationMaster
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(100)]
    public string Location { get; set; }

    [StringLength(1000)]
    public string Description { get; set; }

    [Column(TypeName = "int(11)")]
    public int? Company { get; set; }

    [Column(TypeName = "int(11)")]
    public int? IsActive { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? ItemScanBox { get; set; }

    [StringLength(50)]
    public string PassedBin { get; set; }

    [StringLength(50)]
    public string FailedBin { get; set; }

    [StringLength(100)]
    public string Country { get; set; }

    [Column(TypeName = "int(11)")]
    public int? WarehouseId { get; set; }

    public bool? DirectPrintflag { get; set; }

    [Column(TypeName = "int(11)")]
    public int? TimeZoneOffset { get; set; }

    [Column(TypeName = "int(11)")]
    public int? NumberOfDays { get; set; }

    [StringLength(100)]
    public string Address1 { get; set; }

    [StringLength(100)]
    public string Address2 { get; set; }

    [StringLength(100)]
    public string Address3 { get; set; }

    [StringLength(100)]
    public string City { get; set; }

    [StringLength(100)]
    public string State { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PostCode { get; set; }

    [StringLength(100)]
    public string CompanyName { get; set; }

    [StringLength(30)]
    public string PhoneNumber1 { get; set; }

    [StringLength(30)]
    public string PhoneNumber2 { get; set; }

    [StringLength(45)]
    public string FaxNumber { get; set; }

    [StringLength(30)]
    public string CellPhoneNumber { get; set; }

    [StringLength(100)]
    public string CompanyEmailID { get; set; }

    [StringLength(100)]
    public string Type { get; set; }

    [StringLength(100)]
    public string GLAccountNumber { get; set; }

    [Column(TypeName = "enum('FIFO','SEQUENCE')")]
    public string SortingAlgo { get; set; }

    [StringLength(100)]
    public string ShipBin { get; set; }

    [StringLength(100)]
    public string PassBin { get; set; }

    [StringLength(100)]
    public string FailBin { get; set; }

    [StringLength(100)]
    public string RefurnishBin { get; set; }

    [Column(TypeName = "enum('PICK','PACK')")]
    public string LocationType { get; set; }

    [Column(TypeName = "int(11)")]
    public int? IsPackagingLocation { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PackagingLocation { get; set; }

    public bool? IsDefaultPacKlocation { get; set; }
}
