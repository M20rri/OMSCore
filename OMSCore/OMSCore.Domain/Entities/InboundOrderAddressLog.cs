using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("InboundOrderAddressLog")]
public partial class InboundOrderAddressLog
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [StringLength(30)]
    public string CustomerId { get; set; }

    [Column(TypeName = "enum('Bill','Ship')")]
    public string AddressDetailType { get; set; }

    [StringLength(400)]
    public string Notes { get; set; }

    [StringLength(100)]
    public string FirstName { get; set; }

    [StringLength(100)]
    public string MiddleName { get; set; }

    [StringLength(50)]
    public string City { get; set; }

    [StringLength(100)]
    public string PhoneNo { get; set; }

    [StringLength(100)]
    public string AlternatePhoneNo { get; set; }

    [StringLength(20)]
    public string PostCode { get; set; }

    [StringLength(20)]
    public string AddressType { get; set; }

    [StringLength(30)]
    public string State { get; set; }

    [StringLength(100)]
    public string Country { get; set; }

    [StringLength(100)]
    public string EmailId { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? ReadyForArchive { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? OrderDate { get; set; }

    [StringLength(100)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [StringLength(100)]
    public string UpdatedBy { get; set; }

    [StringLength(100)]
    public string Street { get; set; }

    [StringLength(255)]
    public string Region { get; set; }

    [StringLength(100)]
    public string LastName { get; set; }

    [StringLength(255)]
    public string Company { get; set; }

    [StringLength(100)]
    public string FloorNo { get; set; }

    [StringLength(100)]
    public string FlatNo { get; set; }

    [StringLength(100)]
    public string AddressBlock { get; set; }

    [StringLength(250)]
    public string Avenue { get; set; }

    [StringLength(100)]
    public string PACINo { get; set; }

    [StringLength(100)]
    public string Villa { get; set; }

    [StringLength(50)]
    public string TelephoneCode { get; set; }

    [StringLength(50)]
    public string LandLine { get; set; }

    [Column(TypeName = "int(11)")]
    public int? AddressId { get; set; }

    [Column(TypeName = "int(3)")]
    public int? UpdateAddress { get; set; }

    [StringLength(100)]
    public string Latitude { get; set; }

    [StringLength(100)]
    public string Longitude { get; set; }

    [StringLength(50)]
    public string LocationUpdatedBy { get; set; }
}
