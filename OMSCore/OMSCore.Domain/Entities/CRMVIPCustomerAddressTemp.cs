using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("CRMVIPCustomerAddressTemp")]
[Index("DocumentNo", "EmailID", Name = "CRMVIPCustomerAddressTemp_DocumentNo_IDX", IsUnique = true)]
public partial class CRMVIPCustomerAddressTemp
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(50)]
    public string DocumentNo { get; set; }

    [StringLength(50)]
    public string CustomerID { get; set; }

    [StringLength(50)]
    public string AddressID { get; set; }

    [StringLength(50)]
    public string CustomerName { get; set; }

    [StringLength(50)]
    public string EmailID { get; set; }

    [StringLength(100)]
    public string PhoneNo { get; set; }

    [StringLength(1000)]
    public string ContactAddress { get; set; }

    [StringLength(50)]
    public string CurrencyCode { get; set; }

    [StringLength(100)]
    public string Country { get; set; }

    [StringLength(100)]
    public string UserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DocumentDate { get; set; }

    [StringLength(100)]
    public string FileId { get; set; }
}
