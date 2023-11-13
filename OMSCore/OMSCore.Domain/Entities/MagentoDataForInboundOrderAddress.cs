using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Keyless]
[Table("MagentoDataForInboundOrderAddress")]
public partial class MagentoDataForInboundOrderAddress
{
    [StringLength(250)]
    public string WebOrderNo { get; set; }

    [StringLength(250)]
    public string CustomerId { get; set; }

    [StringLength(250)]
    public string AddressDetailType { get; set; }

    [StringLength(250)]
    public string Notes { get; set; }

    [StringLength(250)]
    public string FirstName { get; set; }

    [StringLength(250)]
    public string MiddleName { get; set; }

    [StringLength(250)]
    public string Lastname { get; set; }

    [StringLength(250)]
    public string City { get; set; }

    [StringLength(250)]
    public string PhoneNo { get; set; }

    [StringLength(250)]
    public string AlternatePhoneNo { get; set; }

    [StringLength(250)]
    public string PostCode { get; set; }

    [StringLength(250)]
    public string AddressType { get; set; }

    [StringLength(250)]
    public string State { get; set; }

    [StringLength(100)]
    public string Country { get; set; }

    [StringLength(250)]
    public string EmailId { get; set; }

    [StringLength(250)]
    public string ReadyForArchive { get; set; }

    [StringLength(250)]
    public string OrderDate { get; set; }

    [StringLength(250)]
    public string Street { get; set; }

    [StringLength(250)]
    public string Region { get; set; }

    [StringLength(250)]
    public string Company { get; set; }

    [StringLength(250)]
    public string FloorNo { get; set; }

    [StringLength(250)]
    public string FlatNo { get; set; }

    [StringLength(250)]
    public string AddressBlock { get; set; }

    [StringLength(250)]
    public string Avenue { get; set; }

    [StringLength(250)]
    public string PACINo { get; set; }

    [StringLength(250)]
    public string Villa { get; set; }

    [StringLength(250)]
    public string TelephoneCode { get; set; }

    [StringLength(250)]
    public string LandLine { get; set; }

    [StringLength(250)]
    public string AddressId { get; set; }
}
